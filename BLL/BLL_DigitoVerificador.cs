using BE;
using DAL;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_DigitoVerificador
    {
        private Servicio_Calcular servicioCalcular;
        private BLL_BitacoraEvento bllBitacora;
        private DAL_DigitoVerificador dalDigito;
        private DAL_Usuario dalUsuario;
        private DAL_Idioma dalIdioma;
        private DAL_Permiso dalPermiso;
        private DAL_Artista_VM516 dalArtista_VM516;
        private DAL_Especificacion_Obra_VM516 dalObra_VM516;
        private DAL_Reserva_Sala_VM516 dalReserva_VM516;
        private DAL_Sala_VM516 dalSala_VM516;
        private Servicio_VerificadorDigito servicioVerificador;
        public BLL_DigitoVerificador()
        {
            servicioCalcular = new Servicio_Calcular();
            bllBitacora = new BLL_BitacoraEvento();
            dalDigito = new DAL_DigitoVerificador();
            dalUsuario = new DAL_Usuario();
            dalIdioma = new DAL_Idioma();
            servicioVerificador = new Servicio_VerificadorDigito();
            dalPermiso = new DAL_Permiso();
            dalArtista_VM516 = new DAL_Artista_VM516();
            dalObra_VM516 = new DAL_Especificacion_Obra_VM516();
            dalReserva_VM516 = new DAL_Reserva_Sala_VM516();
            dalSala_VM516 = new DAL_Sala_VM516();

        }


        public ExcepcionIntegridad ValidarIntegridad<T>(List<T> listaRegistros, string nombreTabla) where T : IVerificable
        {
            string cadenaAcumuladaParaDVV = "";

            var listaOrdenada = listaRegistros
                .OrderBy(x => x.ObtenerIdentificadorFila())
                .ToList();

            List<string> registrosAlterados = new List<string>();


            foreach (T registro in listaOrdenada)
            {
                string dvhCalculado = servicioCalcular.CalcularDVH(registro);

                string nombreFila = $"{nombreTabla}_{registro.ObtenerIdentificadorFila()}";
                    

                Servicio_DigitoVerificadorVertical registroBD = dalDigito.ObtenerRegistroDigito(nombreFila);
       
                if (registroBD != null &&!servicioVerificador.EsValido(dvhCalculado, registroBD.DVH))
                {
                    registrosAlterados.Add(registro.ObtenerIdentificadorFila());
                }
                cadenaAcumuladaParaDVV += dvhCalculado;
            }

            List<string> registrosGuardados =dalDigito.ObtenerRegistrosDVH(nombreTabla);
                

            List<string> registrosActuales =listaRegistros.Select(x => nombreTabla + "_" + x.ObtenerIdentificadorFila()).ToList();

            List<string> eliminados = registrosGuardados.Where(x => !registrosActuales.Contains(x)).ToList();

            string dvvCalculado =servicioCalcular.CalcularHash(cadenaAcumuladaParaDVV);
                

            Servicio_DigitoVerificadorVertical maestro = dalDigito.ObtenerRegistroDigito(nombreTabla + "_MAESTRO");
               
            bool errorDVV =maestro == null ||!servicioVerificador.EsValido(dvvCalculado, maestro.DVV);
     

            if (registrosAlterados.Count == 0 && eliminados.Count == 0 && !errorDVV)
            {
                return null; 
            }

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Violación de integridad en la tabla '{nombreTabla}'.");

            if (registrosAlterados.Count > 0)
            {
                sb.AppendLine();
                sb.AppendLine("Registros modificados:");
                foreach (string r in registrosAlterados)
                    sb.AppendLine("- " + r);
            }

            if (eliminados.Count > 0)
            {
                sb.AppendLine();
                sb.AppendLine("Registros eliminados:");
                foreach (string r in eliminados)
                    sb.AppendLine("- " + r);
            }

            if (errorDVV)
            {
                sb.AppendLine();
                sb.AppendLine("El DVV de la tabla es incorrecto.");
            }

            string mensaje = sb.ToString();

            bllBitacora.RegistrarBitacora(mensaje,"Sistema","Seguridad",1);

            return new ExcepcionIntegridad(nombreTabla,registrosAlterados,eliminados,errorDVV,mensaje);
    
        }

        public void ValidarTodaLaBase()
        {
            List<ExcepcionIntegridad> errores = new List<ExcepcionIntegridad>();
            // ---------- Idioma ----------
            var errorIdioma = ValidarIntegridad(
                dalIdioma.DameIdiomasBD(),
                "Idioma");

            if (errorIdioma != null)
                errores.Add(errorIdioma);

            // ---------- Permiso ----------
            var errorPermiso = ValidarIntegridad(
                dalPermiso.ListarPermisos(),
                "Permiso");

            if (errorPermiso != null)
                errores.Add(errorPermiso);


            // ---------- Usuario ----------
            var errorUsuario = ValidarIntegridad(
                dalUsuario.ListarUsuarios(),
                "Usuario");

            if (errorUsuario != null)
                errores.Add(errorUsuario);

            // ---------- Rol ----------
            DAL_Rol dalRol = new DAL_Rol();

            BLL_Rol bllRol = new BLL_Rol();

            List<Servicio_Familia> roles = dalRol.ListarRoles();

            List<Servicio_Familia> rolesCompletos = new List<Servicio_Familia>();

            foreach (var rol in roles)
            {
                rolesCompletos.Add(
                    bllRol.ObtenerRolCompleto(rol.IdRol));
            }

            var errorRol = ValidarIntegridad(
                rolesCompletos,
                "Rol");

            //var errorRol = ValidarIntegridad(
            //    dalRol.ListarRoles(),
            //    "Rol");

            if (errorRol != null)
                errores.Add(errorRol);

            // ---------- Familia ----------
            DAL_Familia dalFamilia = new DAL_Familia();

            List<Servicio_Familia> familias = dalFamilia.ListarFamilias();

            List<Servicio_Familia> familiasCompletas = new List<Servicio_Familia>();

            BLL_Familia bllFamilia = new BLL_Familia();

            foreach (var f in familias)
            {
                familiasCompletas.Add(
                    bllFamilia.ObtenerFamiliaCompleta(f.IdRol));
            }

            var errorFamilia = ValidarIntegridad(
                familiasCompletas,
                "Familia");

            //var errorFamilia = ValidarIntegridad(
            //    dalFamilia.ListarFamilias(),
            //    "Familia");

            if (errorFamilia != null)
                errores.Add(errorFamilia);

            if (errores.Count > 0)
                throw new ExcepcionIntegridad(errores);
            // ==========================================
            // NUEVAS ENTIDADES DE NEGOCIO (GALERÍA)
            // ==========================================
            var errorArtista = ValidarIntegridad(dalArtista_VM516.ListarArtistas_VM516(), "Artista_VM516");
            if (errorArtista != null) errores.Add(errorArtista);

            var errorObra = ValidarIntegridad(dalObra_VM516.ListarEspecificaciones_VM516(), "Especificacion_Obra_VM516");
            if (errorObra != null) errores.Add(errorObra);

            var errorReserva = ValidarIntegridad(dalReserva_VM516.ListarReservas_VM516(), "Reserva_Sala_VM516");
            if (errorReserva != null) errores.Add(errorReserva);

            var errorSala = ValidarIntegridad(dalSala_VM516.ListarSalas_VM516(), "Sala_VM516");
            if (errorSala != null) errores.Add(errorSala);

            if (errores.Count > 0)
                throw new ExcepcionIntegridad(errores);
        }

        public void EliminarDigitoYRecalcular<T>(string idElementoEliminado, List<T> listaCompleta, string nombreTabla) where T : IVerificable
        {

            string nombreFila = $"{nombreTabla}_{idElementoEliminado}";
            dalDigito.EliminarRegistroDigito(nombreFila);


            var listaOrdenada = listaCompleta.OrderBy(x => x.ObtenerIdentificadorFila()).ToList();
            string cadenaAcumulada = "";

            foreach (T registro in listaOrdenada)
            {
                cadenaAcumulada += servicioCalcular.CalcularDVH(registro);
            }

            string dvvFinal = servicioCalcular.CalcularHash(cadenaAcumulada);
            string nombreMaestro = $"{nombreTabla}_MAESTRO";

            Servicio_DigitoVerificadorVertical nuevoDVV = new Servicio_DigitoVerificadorVertical(dvvFinal, nombreMaestro);
            dalDigito.GuardarDVV(nuevoDVV);
        }


        public void ActualizarDigitos<T>(T entidadModificada, List<T> listaCompleta, string nombreTabla) where T : IVerificable
        {
            
            string dvhCalculado = servicioCalcular.CalcularDVH(entidadModificada);
            string nombreFila = $"{nombreTabla}_{entidadModificada.ObtenerIdentificadorFila()}";

            Servicio_DigitoVerificadorVertical nuevoDVH = new Servicio_DigitoVerificadorVertical();
            nuevoDVH.Nombre = nombreFila;
            nuevoDVH.DVH = dvhCalculado;

            dalDigito.GuardarDVH(nuevoDVH);

            var listaOrdenada = listaCompleta.OrderBy(x => x.ObtenerIdentificadorFila()).ToList();

            string cadenaAcumulada = "";
            foreach (T registro in listaOrdenada)
            {

                cadenaAcumulada += servicioCalcular.CalcularDVH(registro);
            }

            string dvvFinal = servicioCalcular.CalcularHash(cadenaAcumulada);
            string nombreMaestro = $"{nombreTabla}_MAESTRO";


            Servicio_DigitoVerificadorVertical nuevoDVV = new Servicio_DigitoVerificadorVertical(dvvFinal, nombreMaestro);

            dalDigito.GuardarDVV(nuevoDVV);
        }

        public void RecalcularDigitos()
        {
            string log = SessionManager.GetInstancia().GetUsuarioActual().Login;
            RecalcularUsuarios(log);
            RecalcularRoles(log);
            RecalcularFamilias(log);
            RecalcularIdiomas(log);
            RecalcularPermisos(log);
            RecalcularArtistas(log);
            RecalcularObras(log);
            RecalcularReservas(log);
            RecalcularSalas(log);
        }

        private void RecalcularUsuarios(string log)
        {
            dalDigito.EliminarDVHDeTabla("Usuario");
            List<Servicio_Usuario> usuarios = dalUsuario.ListarUsuarios().OrderBy(u => u.ObtenerIdentificadorFila()).ToList();
            string cadenaDVV = "";

            foreach (Servicio_Usuario usuario in usuarios)
            {
                string dvh = servicioCalcular.CalcularDVH(usuario);

                Servicio_DigitoVerificadorVertical reg = new Servicio_DigitoVerificadorVertical();

                reg.Nombre = "Usuario_" + usuario.ObtenerIdentificadorFila();
                reg.DVH = dvh;

                dalDigito.GuardarDVH(reg);

                cadenaDVV += dvh;
            }

            string dvv = servicioCalcular.CalcularHash(cadenaDVV);

            Servicio_DigitoVerificadorVertical maestro = new Servicio_DigitoVerificadorVertical();

            maestro.Nombre = "Usuario_MAESTRO";
            maestro.DVV = dvv;

            dalDigito.GuardarDVV(maestro);

            bllBitacora.RegistrarBitacora( "Recalculo de Dígitos Verificadores de Usuario", log,"Seguridad",1);     
        }

        private void RecalcularRoles(string log)
        {
            BLL_Rol bllRol = new BLL_Rol();

            // Validar integridad del árbol del rol antes de recalcular DV
            bllRol.ValidarIntegridadRoles();

            dalDigito.EliminarDVHDeTabla("Rol");

            DAL_Rol dalRol = new DAL_Rol();
            List<Servicio_Familia> roles = dalRol.ListarRoles().OrderBy(r => r.ObtenerIdentificadorFila()) .ToList();

            string cadenaDVV = "";
            foreach (Servicio_Familia rol in roles)
            {
                Servicio_Familia rolCompleto =
                    bllRol.ObtenerRolCompleto(rol.IdRol);

                string dvh = servicioCalcular.CalcularDVH(rolCompleto);

                Servicio_DigitoVerificadorVertical reg =
                    new Servicio_DigitoVerificadorVertical
                    {
                        Nombre = "Rol_" + rol.IdRol,
                        DVH = dvh
                    };

                dalDigito.GuardarDVH(reg);

                cadenaDVV += dvh;
            }

            //foreach (Servicio_Familia rol in roles)
            //{
            //    string dvh = servicioCalcular.CalcularDVH(rol);
            //    Servicio_DigitoVerificadorVertical reg = new Servicio_DigitoVerificadorVertical
            //    {
            //        Nombre = "Rol_" + rol.ObtenerIdentificadorFila(),
            //        DVH = dvh
            //    };

            //    dalDigito.GuardarDVH(reg);
            //    cadenaDVV += dvh;
            //}

            string dvv = servicioCalcular.CalcularHash(cadenaDVV);
            Servicio_DigitoVerificadorVertical maestro = new Servicio_DigitoVerificadorVertical(dvv, "Rol_MAESTRO");
            dalDigito.GuardarDVV(maestro);

            bllBitacora.RegistrarBitacora("Recalculo de Dígitos Verificadores de Roles", log , "Seguridad", 1);
        }

        private void RecalcularFamilias(string log)
        {
            BLL_Familia bllFamilia = new BLL_Familia();

            bllFamilia.ValidarIntegridadJerarquia();

            dalDigito.EliminarDVHDeTabla("Familia");

            DAL_Familia dalFam = new DAL_Familia();

            List<Servicio_Familia> familias = dalFam.ListarFamilias()
                .OrderBy(f => f.ObtenerIdentificadorFila())
                .ToList();

            string cadenaDVV = "";

            foreach (Servicio_Familia familia in familias)
            {
                // Cargar la familia completa con permisos y subfamilias
                Servicio_Familia familiaCompleta =
                    bllFamilia.ObtenerFamiliaCompleta(familia.IdRol);

                string dvh = servicioCalcular.CalcularDVH(familiaCompleta);

                Servicio_DigitoVerificadorVertical reg = new Servicio_DigitoVerificadorVertical
                {
                    Nombre = "Familia_" + familia.IdRol,
                    DVH = dvh
                };

                dalDigito.GuardarDVH(reg);

                cadenaDVV += dvh;
            }

            //DAL_Familia dalFam = new DAL_Familia("Data Source=.;Initial Catalog=BD_CuentaClara;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            //List<Servicio_Familia> familias = dalFam.ListarFamilias() .OrderBy(f => f.ObtenerIdentificadorFila()) .ToList();

            //string cadenaDVV = "";

            //foreach (Servicio_Familia familia in familias)
            //{
            //    string dvh = servicioCalcular.CalcularDVH(familia);
            //    Servicio_DigitoVerificadorVertical reg = new Servicio_DigitoVerificadorVertical
            //    {
            //        Nombre = "Familia_" + familia.ObtenerIdentificadorFila(),
            //        DVH = dvh
            //    };

            //    dalDigito.GuardarDVH(reg);
            //    cadenaDVV += dvh;
            //}

            string dvv = servicioCalcular.CalcularHash(cadenaDVV);
            Servicio_DigitoVerificadorVertical maestro = new Servicio_DigitoVerificadorVertical(dvv, "Familia_MAESTRO");
            dalDigito.GuardarDVV(maestro);

            bllBitacora.RegistrarBitacora("Recalculo de Dígitos Verificadores de Familias", log, "Seguridad", 1);
        }


        private void RecalcularPermisos(string log)
        {
            dalDigito.EliminarDVHDeTabla("Permiso");

            List<Servicio_Permiso> permisos =
                dalPermiso.ListarPermisos()
                          .OrderBy(p => p.ObtenerIdentificadorFila())
                          .ToList();

            string cadenaDVV = "";

            foreach (Servicio_Permiso permiso in permisos)
            {
                string dvh = servicioCalcular.CalcularDVH(permiso);

                Servicio_DigitoVerificadorVertical reg =new Servicio_DigitoVerificadorVertical();

                reg.Nombre = "Permiso_" + permiso.ObtenerIdentificadorFila();
                reg.DVH = dvh;

                dalDigito.GuardarDVH(reg);

                cadenaDVV += dvh;
            }

            string dvv = servicioCalcular.CalcularHash(cadenaDVV);

            Servicio_DigitoVerificadorVertical maestro =new Servicio_DigitoVerificadorVertical();
                

            maestro.Nombre = "Permiso_MAESTRO";
            maestro.DVV = dvv;

            dalDigito.GuardarDVV(maestro);

            bllBitacora.RegistrarBitacora(
                "Recalculo de Dígitos Verificadores de Permisos",
                log,
                "Seguridad",
                1);
        }


        private void RecalcularIdiomas(string log)
        {
            dalDigito.EliminarDVHDeTabla("Idioma");

            List<Servicio_Idioma> idiomas =dalIdioma.DameIdiomasBD().OrderBy(i => i.ObtenerIdentificadorFila()).ToList();

            string cadenaDVV = "";

            foreach (Servicio_Idioma idioma in idiomas)
            {
                string dvh = servicioCalcular.CalcularDVH(idioma);

                Servicio_DigitoVerificadorVertical reg = new Servicio_DigitoVerificadorVertical();
                   

                reg.Nombre = "Idioma_" + idioma.ObtenerIdentificadorFila();
                reg.DVH = dvh;

                dalDigito.GuardarDVH(reg);

                cadenaDVV += dvh;
            }

            string dvv = servicioCalcular.CalcularHash(cadenaDVV);
            
            Servicio_DigitoVerificadorVertical maestro =new Servicio_DigitoVerificadorVertical();
                

            maestro.Nombre = "Idioma_MAESTRO";
            maestro.DVV = dvv;

            dalDigito.GuardarDVV(maestro);

            bllBitacora.RegistrarBitacora(
                "Recalculo de Dígitos Verificadores de Idiomas",
                log,
                "Seguridad",
                1);
        }

        private void RecalcularArtistas(string log)
        {
            dalDigito.EliminarDVHDeTabla("Artista_VM516");
            List<BE_Artista_VM516> artistas = dalArtista_VM516.ListarArtistas_VM516().OrderBy(a => a.ObtenerIdentificadorFila()).ToList();
            string cadenaDVV = "";

            foreach (BE_Artista_VM516 artista in artistas)
            {
                string dvh = servicioCalcular.CalcularDVH(artista);
                Servicio_DigitoVerificadorVertical reg = new Servicio_DigitoVerificadorVertical();
                reg.Nombre = "Artista_VM516_" + artista.ObtenerIdentificadorFila();
                reg.DVH = dvh;
                dalDigito.GuardarDVH(reg);
                cadenaDVV += dvh;
            }

            string dvv = servicioCalcular.CalcularHash(cadenaDVV);
            Servicio_DigitoVerificadorVertical maestro = new Servicio_DigitoVerificadorVertical();
            maestro.Nombre = "Artista_VM516_MAESTRO";
            maestro.DVV = dvv;
            dalDigito.GuardarDVV(maestro);

            bllBitacora.RegistrarBitacora("Recalculo de Dígitos Verificadores de Artistas", log, "Seguridad", 1);
        }

        private void RecalcularObras(string log)
        {
            dalDigito.EliminarDVHDeTabla("Especificacion_Obra_VM516");
            List<BE_Especificacion_Obra_VM516> obras = dalObra_VM516.ListarEspecificaciones_VM516().OrderBy(o => o.ObtenerIdentificadorFila()).ToList();
            string cadenaDVV = "";

            foreach (BE_Especificacion_Obra_VM516 obra in obras)
            {
                string dvh = servicioCalcular.CalcularDVH(obra);
                Servicio_DigitoVerificadorVertical reg = new Servicio_DigitoVerificadorVertical();
                reg.Nombre = "Especificacion_Obra_VM516_" + obra.ObtenerIdentificadorFila();
                reg.DVH = dvh;
                dalDigito.GuardarDVH(reg);
                cadenaDVV += dvh;
            }

            string dvv = servicioCalcular.CalcularHash(cadenaDVV);
            Servicio_DigitoVerificadorVertical maestro = new Servicio_DigitoVerificadorVertical();
            maestro.Nombre = "Especificacion_Obra_VM516_MAESTRO";
            maestro.DVV = dvv;
            dalDigito.GuardarDVV(maestro);

            bllBitacora.RegistrarBitacora("Recalculo de Dígitos Verificadores de Obras", log, "Seguridad", 1);
        }

        private void RecalcularReservas(string log)
        {
            dalDigito.EliminarDVHDeTabla("Reserva_Sala_VM516");
            List<BE_Reserva_Sala_VM516> reservas = dalReserva_VM516.ListarReservas_VM516().OrderBy(r => r.ObtenerIdentificadorFila()).ToList();
            string cadenaDVV = "";

            foreach (BE_Reserva_Sala_VM516 reserva in reservas)
            {
                string dvh = servicioCalcular.CalcularDVH(reserva);
                Servicio_DigitoVerificadorVertical reg = new Servicio_DigitoVerificadorVertical();
                reg.Nombre = "Reserva_Sala_VM516_" + reserva.ObtenerIdentificadorFila();
                reg.DVH = dvh;
                dalDigito.GuardarDVH(reg);
                cadenaDVV += dvh;
            }

            string dvv = servicioCalcular.CalcularHash(cadenaDVV);
            Servicio_DigitoVerificadorVertical maestro = new Servicio_DigitoVerificadorVertical();
            maestro.Nombre = "Reserva_Sala_VM516_MAESTRO";
            maestro.DVV = dvv;
            dalDigito.GuardarDVV(maestro);

            bllBitacora.RegistrarBitacora("Recalculo de Dígitos Verificadores de Reservas", log, "Seguridad", 1);
        }
        private void RecalcularSalas(string log)
        {
            dalDigito.EliminarDVHDeTabla("Sala_VM516");
            List<BE_Sala_VM516> salas = dalSala_VM516.ListarSalas_VM516().OrderBy(s => s.ObtenerIdentificadorFila()).ToList();
            string cadenaDVV = "";

            foreach (BE_Sala_VM516 sala in salas)
            {
                string dvh = servicioCalcular.CalcularDVH(sala);
                Servicio_DigitoVerificadorVertical reg = new Servicio_DigitoVerificadorVertical();
                reg.Nombre = "Sala_VM516_" + sala.ObtenerIdentificadorFila();
                reg.DVH = dvh;
                dalDigito.GuardarDVH(reg);
                cadenaDVV += dvh;
            }

            string dvv = servicioCalcular.CalcularHash(cadenaDVV);
            Servicio_DigitoVerificadorVertical maestro = new Servicio_DigitoVerificadorVertical();
            maestro.Nombre = "Sala_VM516_MAESTRO";
            maestro.DVV = dvv;
            dalDigito.GuardarDVV(maestro);

            bllBitacora.RegistrarBitacora("Recalculo de Dígitos Verificadores de Salas", log, "Seguridad", 1);
        }
    }
}

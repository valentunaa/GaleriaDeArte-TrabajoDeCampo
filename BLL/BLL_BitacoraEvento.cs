using DAL;
using Servicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Text;

namespace BLL
{
    public class BLL_BitacoraEvento
    {
        private  DAL_BitacoraEvento _dal;

        public BLL_BitacoraEvento()
        {
            _dal = new DAL_BitacoraEvento();
        }

        public void RegistrarBitacora(string evento,string login,string modulo,int criticidad){
            Servicio_Bitacora bitacora = new Servicio_Bitacora
            {
                id_Evento = Guid.NewGuid().ToString(), 
                Evento = evento,
                Login = login,
                Modulo = modulo,
                Criticidad = criticidad,
                Fecha = DateTime.Now.Date,
                Hora = DateTime.Now.ToString("HH:mm:ss")
            };

            bool guardadoExitoso = _dal.GuardarBitacora(bitacora);
        }

        private List<Servicio_Bitacora> AplicarFiltroSeguridad(List<Servicio_Bitacora> listaOriginal)
        {
            Servicio_Usuario usuarioActual = SessionManager.GetInstancia().GetUsuarioActual();

            if (usuarioActual == null) return new List<Servicio_Bitacora>();

            if (usuarioActual.IdRol == "R1" || usuarioActual.IdRol.Equals("Administrador", StringComparison.OrdinalIgnoreCase))
            {
                return listaOriginal;
            }
            else
            {
                return listaOriginal.Where(b =>
            (!b.Modulo.Equals("Administración", StringComparison.OrdinalIgnoreCase) &&
             !b.Modulo.Equals("Seguridad", StringComparison.OrdinalIgnoreCase) &&
             !b.Modulo.Equals("Gestión de Perfiles y Autorización", StringComparison.OrdinalIgnoreCase))

            || 

            b.Evento.Equals("Impresión/Exportación de Bitácora", StringComparison.OrdinalIgnoreCase)

            || 

            b.Login == usuarioActual.Login

        ).ToList();
            }
        }

        public List<Servicio_Bitacora> ListarBitacora()
        {
            var lista = _dal.ListarBitacora();
            return AplicarFiltroSeguridad(lista);
        }

        public List<Servicio_Bitacora> ListarUltimos3Dias()
        {
            var lista = _dal.ListarUltimos3Dias();
            return AplicarFiltroSeguridad(lista);
        }

        public List<Servicio_Bitacora> FiltrarBitacora(string login, DateTime desde, DateTime hasta, string modulo, string evento, int? criticidad)
        {
            var lista = _dal.FiltrarBitacora(login, desde, hasta, modulo, evento, criticidad);
            return AplicarFiltroSeguridad(lista);
        }

        public List<string> ObtenerEventosBase()
        {
            Servicio_Usuario usuarioActual = SessionManager.GetInstancia().GetUsuarioActual();
            bool esAdmin = usuarioActual != null && (usuarioActual.IdRol == "R1" || usuarioActual.IdRol.Equals("Administrador", StringComparison.OrdinalIgnoreCase));

  
            List<string> eventos = new List<string>
            {
           "Login correcto",
                "Cerrar Sesión",
                "Cambio Clave",
                "Cambio de Idioma en Sesión",
                "Alta Artista",
                "Alta Obra",
                "Alta Reserva",
                "Estado Pago",
                "Cobro",
                "Peritaje",
                "Retiro Obra", 
                "Registro de nueva Sala",
                "Modificación de Sala",
                "Eliminación de Sala",
                "Impresión/Exportación"
            };

      
            if (esAdmin)
            {
                eventos.AddRange(new string[]
                {
            "Login Incorrecto - DV Actualizado",
            "Usuario Creado",
            "Usuario Desbloqueado",
            "Acceso de emergencia por violación de integridad",
            "Violación de integridad detectada",
            "Intento de login bloqueado",
            "Usuario bloqueado o inactivo",
            "Intento de login sin rol asignado",
            "Actualización de Idioma",
            "Activar Usuario",
            "Desactivar Usuario",
            "Usuario Modificado",
            "Alta Familia",
            "Modificación Familia",
            "Baja Familia",
            "Permiso asignado a Familia",
            "Asignación familia a familia",
            "Permiso desasignado de Familia",
            "Subfamilia desasignada de Familia",
            "Alta Perfil (Rol)",
            "Permiso asignado al Rol",
            "Asignación de familias a rol",
            "Permiso desasignado del Rol",
            "Familia desasignada del Rol",
            "Modificación de Rol",
            "Baja de Rol",
            "Backup exitoso",
            "Impresión/Exportación de Bitácora",
            "Recalculo de Dígitos Verificadores de Usuario",
            "Recalculo de Dígitos Verificadores de Roles",
            "Recalculo de Dígitos Verificadores de Familias",
            "Recalculo de Dígitos Verificadores de Permisos",
            "Recalculo de Dígitos Verificadores de Idiomas"
                
                });
            }

            return eventos;
        }

    }
}

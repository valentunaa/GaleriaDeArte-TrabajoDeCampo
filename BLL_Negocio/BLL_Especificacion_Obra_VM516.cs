using BE;
using BLL;
using DAL;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BLL_Negocio
{
    public class BLL_Especificacion_Obra_VM516
    {
        private DAL_Especificacion_Obra_VM516 dalObra_VM516;
        private BLL_Artista_VM516 bllArtista_VM516;
        private BLL_DigitoVerificador bllDigito_VM516;
        private BLL_BitacoraEvento bllBitacora_VM516;

        public BLL_Especificacion_Obra_VM516()
        {
            dalObra_VM516 = new DAL_Especificacion_Obra_VM516();
            bllArtista_VM516 = new BLL_Artista_VM516();
            bllDigito_VM516 = new BLL_DigitoVerificador();
            bllBitacora_VM516 = new BLL_BitacoraEvento();
        }


        public BE_Especificacion_Obra_VM516 ObtenerPorId_VM516(int idObra)
        {

            var lista = dalObra_VM516.ListarEspecificaciones_VM516();
            return lista.FirstOrDefault(o => o.Id_Obra_VM516 == idObra);
        }
        public void RegistrarEspecificacion_VM516(string dni, string titulo, string tecnica, string altoStr, string anchoStr, string pesoStr, string reqIluminacion, string valorMercadoStr, string categoriaSeguro)
        {
            if (string.IsNullOrWhiteSpace(dni) ||
                string.IsNullOrWhiteSpace(titulo) ||
                string.IsNullOrWhiteSpace(tecnica) ||
                string.IsNullOrWhiteSpace(reqIluminacion) ||
                string.IsNullOrWhiteSpace(categoriaSeguro))
            {
                throw new Exception("err_CamposObligatoriosObra");
            }

            if (!bllArtista_VM516.ExisteArtista(dni))
            {
                throw new Exception("err_ArtistaNoRegistradoObra");
            }

          
            if (!decimal.TryParse(altoStr, out decimal alto) || alto <= 0 ||
                !decimal.TryParse(anchoStr, out decimal ancho) || ancho <= 0 ||
                !decimal.TryParse(pesoStr, out decimal peso) || peso <= 0)
            {
                throw new Exception("err_DimensionesInvalidasObra");
            }

            if (!decimal.TryParse(valorMercadoStr, out decimal valorMercado) || valorMercado < 0)
            {
                throw new Exception("err_ValorMercadoNegativoObra");
            }
 
            BE_Especificacion_Obra_VM516 obra = new BE_Especificacion_Obra_VM516(dni, titulo, tecnica, alto, ancho, peso, reqIluminacion, valorMercado, categoriaSeguro);

            dalObra_VM516.GuardarEspecificacion_VM516(obra);

            List<BE_Especificacion_Obra_VM516> lista = dalObra_VM516.ListarEspecificaciones_VM516();
            BE_Especificacion_Obra_VM516 ultimaObra = lista.LastOrDefault();

            if (ultimaObra != null)
            {
                bllDigito_VM516.ActualizarDigitos(ultimaObra, lista, "Especificacion_Obra_VM516");
            }

            string loginActual = SessionManager.GetInstancia().GetUsuarioActual()?.Login;
            string detalleEvento = $"Alta Obra, DNI Artista: {dni}";
            bllBitacora_VM516.RegistrarBitacora(detalleEvento, loginActual, "Negocio - Obra", 3);
        }

        public void ModificarEspecificacion_VM516(int idObra, string dni, string titulo, string tecnica, string altoStr, string anchoStr, string pesoStr, string reqIluminacion, string valorMercadoStr, string categoriaSeguro)
        {
            if (idObra <= 0)
            {
                throw new Exception("err_ObraNoEncontrada");
            }

            if (string.IsNullOrWhiteSpace(dni) ||
                string.IsNullOrWhiteSpace(titulo) ||
                string.IsNullOrWhiteSpace(tecnica) ||
                string.IsNullOrWhiteSpace(reqIluminacion) ||
                string.IsNullOrWhiteSpace(categoriaSeguro))
            {
                throw new Exception("err_CamposObligatoriosObra");
            }

            if (!bllArtista_VM516.ExisteArtista(dni))
            {
                throw new Exception("err_ArtistaNoRegistradoObra");
            }

            if (!decimal.TryParse(altoStr, out decimal alto) || alto <= 0 ||
                !decimal.TryParse(anchoStr, out decimal ancho) || ancho <= 0 ||
                !decimal.TryParse(pesoStr, out decimal peso) || peso <= 0)
            {
                throw new Exception("err_DimensionesInvalidasObra");
            }

            if (!decimal.TryParse(valorMercadoStr, out decimal valorMercado) || valorMercado < 0)
            {
                throw new Exception("err_ValorMercadoNegativoObra");
            }

            List<BE_Especificacion_Obra_VM516> listaOriginal = dalObra_VM516.ListarEspecificaciones_VM516();
            BE_Especificacion_Obra_VM516 obraExistente = listaOriginal.FirstOrDefault(o => o.Id_Obra_VM516 == idObra && !o.Bit_Lo_Bo_VM516);

            if (obraExistente == null)
            {
                throw new Exception("err_ObraNoEncontrada");
            }

            obraExistente.DNI_Artista_VM516 = dni.Trim();
            obraExistente.Titulo_Obra_VM516 = titulo.Trim();
            obraExistente.Tecnica_VM516 = tecnica.Trim();
            obraExistente.Alto_VM516 = alto;
            obraExistente.Ancho_VM516 = ancho;
            obraExistente.Peso_VM516 = peso;
            obraExistente.Req_Iluminacion_VM516 = reqIluminacion;
            obraExistente.Valor_Declarado_Mercado_VM516 = valorMercado;
            obraExistente.Categoria_Seguro_VM516 = categoriaSeguro;

            // Persistencia en modo desconectado (dispara el trigger hacia Especificacion_Obra_C_VM516)
            dalObra_VM516.ModificarEspecificacion_VM516(obraExistente);

            // Recalcular DVH y DVV con toda la tabla física
            List<BE_Especificacion_Obra_VM516> listaActualizada = dalObra_VM516.ListarEspecificaciones_VM516();
            BE_Especificacion_Obra_VM516 obraModificada = listaActualizada.FirstOrDefault(o => o.Id_Obra_VM516 == idObra);
            if (obraModificada != null)
            {
                bllDigito_VM516.ActualizarDigitos(obraModificada, listaActualizada, "Especificacion_Obra_VM516");
            }

            string loginActual = SessionManager.GetInstancia().GetUsuarioActual()?.Login;
            bllBitacora_VM516.RegistrarBitacora($"Modificación Obra ID: {idObra}", loginActual, "Negocio - Obra", 3);
        }

        public void EliminarEspecificacion_VM516(int idObra_VM516)
        {
            List<BE_Especificacion_Obra_VM516> listaCompleta = dalObra_VM516.ListarEspecificaciones_VM516();
            BE_Especificacion_Obra_VM516 obra = listaCompleta.FirstOrDefault(o => o.Id_Obra_VM516 == idObra_VM516);

            if (obra == null)
                throw new Exception("err_ObraNoEncontrada");

            obra.Bit_Lo_Bo_VM516 = true; // Baja lógica (1)
            dalObra_VM516.ModificarEspecificacion_VM516(obra);

            // Recalcular DVH y DVV con toda la tabla física
            List<BE_Especificacion_Obra_VM516> listaActualizada = dalObra_VM516.ListarEspecificaciones_VM516();
            BE_Especificacion_Obra_VM516 obraBorrada = listaActualizada.FirstOrDefault(o => o.Id_Obra_VM516 == idObra_VM516);
            if (obraBorrada != null)
            {
                bllDigito_VM516.ActualizarDigitos(obraBorrada, listaActualizada, "Especificacion_Obra_VM516");
            }

            string loginActual = SessionManager.GetInstancia().GetUsuarioActual()?.Login;
            bllBitacora_VM516.RegistrarBitacora($"Baja Lógica Obra ID: {idObra_VM516}", loginActual, "Negocio - Obra", 3);
        }

        public void RecalcularDigitosPostRestauracion_VM516(int idObra_VM516)
        {
            List<BE_Especificacion_Obra_VM516> listaCompleta_VM516 = dalObra_VM516.ListarEspecificaciones_VM516();
            BE_Especificacion_Obra_VM516 obraRestaurada = listaCompleta_VM516.FirstOrDefault(o => o.Id_Obra_VM516 == idObra_VM516);

            if (obraRestaurada != null)
            {
                bllDigito_VM516.ActualizarDigitos<BE_Especificacion_Obra_VM516>(obraRestaurada, listaCompleta_VM516, "Especificacion_Obra_VM516");
            }
        }
        public List<BE_Especificacion_Obra_VM516> ListarEspecificaciones()
        {
            return dalObra_VM516.ListarEspecificaciones_VM516().Where(o => !o.Bit_Lo_Bo_VM516).ToList();
                      
        }

        // --- MÉTODOS DE SERIALIZACIÓN XML ---

        public void SerializarXML_VM516(List<BE_Especificacion_Obra_VM516> listaObras, string rutaArchivo)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<BE_Especificacion_Obra_VM516>));
                using (StreamWriter writer = new StreamWriter(rutaArchivo))
                {
                    serializer.Serialize(writer, listaObras);
                }

                string loginActual = SessionManager.GetInstancia().GetUsuarioActual()?.Login;
                bllBitacora_VM516.RegistrarBitacora("Exportación XML de Obras", loginActual, "Administración", 4);
            }
            catch (Exception ex)
            {
                throw new Exception("err_ErrorAlSerializar: " + ex.Message);
            }
        }

        public List<BE_Especificacion_Obra_VM516> DeserializarXML_VM516(string rutaArchivo)
        {
            try
            {
                List<BE_Especificacion_Obra_VM516> listaDeserializada;
                XmlSerializer serializer = new XmlSerializer(typeof(List<BE_Especificacion_Obra_VM516>));

                using (StreamReader reader = new StreamReader(rutaArchivo))
                {
                    listaDeserializada = (List<BE_Especificacion_Obra_VM516>)serializer.Deserialize(reader);
                }

                string loginActual = SessionManager.GetInstancia().GetUsuarioActual()?.Login;
                bllBitacora_VM516.RegistrarBitacora("Importación XML de Obras", loginActual, "Administración", 4);

                return listaDeserializada;
            }
            catch (Exception ex)
            {
                throw new Exception("err_ErrorAlDeserializar: " + ex.Message);
            }
        }
    }
}

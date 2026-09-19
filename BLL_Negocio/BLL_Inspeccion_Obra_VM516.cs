using BE;
using BLL;
using DAL;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Negocio
{
    public class BLL_Inspeccion_Obra_VM516
    {
        private DAL_Inspeccion_Obra_VM516 dalInspeccion_VM516;
        private BLL_DigitoVerificador bllDigito_VM516;
        private BLL_BitacoraEvento bllBitacora_VM516;

        public BLL_Inspeccion_Obra_VM516()
        {
            dalInspeccion_VM516 = new DAL_Inspeccion_Obra_VM516();
            bllDigito_VM516 = new BLL_DigitoVerificador();
            bllBitacora_VM516 = new BLL_BitacoraEvento();
        }

        public void RegistrarInspeccion_VM516(string codigoReserva, string estadoPostExhibicion, string observacionesFisicas)
        { 
            if (string.IsNullOrWhiteSpace(codigoReserva))
            {
                throw new Exception("err_CodigoReservaVacio");
            }

            if (string.IsNullOrWhiteSpace(estadoPostExhibicion))
            {
                throw new Exception("err_SeleccioneEstadoExhibicion");
            }

            if (estadoPostExhibicion.Equals("Dañado", StringComparison.OrdinalIgnoreCase) && string.IsNullOrWhiteSpace(observacionesFisicas))
            {
                throw new Exception("Atención: Ha seleccionado el estado Dañado. Es obligatorio detallar minuciosamente los daños de la pieza para el seguro.");
            }

            BE_Inspeccion_Fisica_VM516 inspeccion = new BE_Inspeccion_Fisica_VM516
            {
                Codigo_Reserva_VM516 = codigoReserva,
                Estado_Post_Exhibicion_VM516 = estadoPostExhibicion,
                Observaciones_Fisicas_VM516 = observacionesFisicas,
                Fecha_Inspeccion_VM516 = DateTime.Now
            };

            try
            {
                dalInspeccion_VM516.RegistrarInspeccion_VM516(inspeccion);
                List<BE_Inspeccion_Fisica_VM516> lista = dalInspeccion_VM516.ListarInspecciones_VM516();
                BE_Inspeccion_Fisica_VM516 ultimaInspeccion = lista.LastOrDefault(i => i.Codigo_Reserva_VM516 == codigoReserva);

                if (ultimaInspeccion != null)
                {
                    bllDigito_VM516.ActualizarDigitos<BE_Inspeccion_Fisica_VM516>(ultimaInspeccion, lista, "Inspeccion_Fisica_VM516");
                }

                string loginActual = SessionManager.GetInstancia().GetUsuarioActual()?.Login;
                string detalleEvento = $"Peritaje: {codigoReserva} [{estadoPostExhibicion}]";
                bllBitacora_VM516.RegistrarBitacora(detalleEvento, loginActual, "Negocio - Retiro", 3);
            }
            catch (Exception ex)
            {

                if (ex.Message.Contains("PRIMARY KEY") || ex.Message.Contains("duplicate key"))
                {
                    throw new Exception("err_InspeccionYaRegistrada");
                }
                throw;
            }
        }

        public List<BE_Inspeccion_Fisica_VM516> ListarInspecciones_VM516()
        {
            return dalInspeccion_VM516.ListarInspecciones_VM516();
        }
    }
}

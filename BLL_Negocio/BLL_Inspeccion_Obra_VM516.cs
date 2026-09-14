using BE;
using BLL;
using DAL;
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

        public BLL_Inspeccion_Obra_VM516()
        {
            dalInspeccion_VM516 = new DAL_Inspeccion_Obra_VM516();
            bllDigito_VM516 = new BLL_DigitoVerificador();
        }

        public void RegistrarInspeccion_VM516(string codigoReserva, string estadoPostExhibicion, string observacionesFisicas)
        {
            // Validaciones de negocio y flujos alternativos (ECU05)
            if (string.IsNullOrWhiteSpace(codigoReserva))
            {
                throw new Exception("err_CodigoReservaVacio");
            }

            if (string.IsNullOrWhiteSpace(estadoPostExhibicion))
            {
                throw new Exception("err_SeleccioneEstadoExhibicion");
            }

            // Validación de flujo alternativo 6.1 y 8.1
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

                // Recálculo de dígitos verificadores para mantener la integridad de la tabla
                List<BE_Inspeccion_Fisica_VM516> lista = dalInspeccion_VM516.ListarInspecciones_VM516();
                BE_Inspeccion_Fisica_VM516 ultimaInspeccion = lista.LastOrDefault(i => i.Codigo_Reserva_VM516 == codigoReserva);

                if (ultimaInspeccion != null)
                {
                    bllDigito_VM516.ActualizarDigitos<BE_Inspeccion_Fisica_VM516>(ultimaInspeccion, lista, "Inspeccion_Fisica_VM516");
                }
            }
            catch (Exception ex)
            {
                // Capturamos el error de clave primaria duplicada de SQL y lanzamos la clave traducible
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

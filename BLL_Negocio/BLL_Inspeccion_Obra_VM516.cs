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
        private DAL_Inspeccion_Obra_VM516 dalInspeccion;
        private BLL_DigitoVerificador bllDigito;

        public BLL_Inspeccion_Obra_VM516()
        {
            dalInspeccion = new DAL_Inspeccion_Obra_VM516();
            bllDigito = new BLL_DigitoVerificador();
        }

        public void RegistrarInspeccion_VM516(string codigoReserva, string estadoPostExhibicion, string observacionesFisicas)
        {
            // Validaciones de negocio y flujos alternativos (ECU05)
            if (string.IsNullOrWhiteSpace(codigoReserva))
            {
                throw new Exception("Debe especificar el código de reserva asociado al peritaje.");
            }

            if (string.IsNullOrWhiteSpace(estadoPostExhibicion))
            {
                throw new Exception("Debe seleccionar un Estado Post-Exhibición válido.");
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

            // Persistencia en la DAL
            dalInspeccion.RegistrarInspeccion_VM516(inspeccion);

            // Recálculo de dígitos verificadores (DVH y DVV) gestionado desde la BLL respectiva
            List<BE_Inspeccion_Fisica_VM516> lista = dalInspeccion.ListarInspecciones_VM516();
            BE_Inspeccion_Fisica_VM516 ultimaInspeccion = lista.FirstOrDefault(i => i.Codigo_Reserva_VM516 == inspeccion.Codigo_Reserva_VM516);

            if (ultimaInspeccion != null)
            {
                bllDigito.ActualizarDigitos<BE_Inspeccion_Fisica_VM516>(ultimaInspeccion, lista, "Inspeccion_Fisica_VM516");
            }
        }

        public List<BE_Inspeccion_Fisica_VM516> ListarInspecciones()
        {
            return dalInspeccion.ListarInspecciones_VM516();
        }
    }
}

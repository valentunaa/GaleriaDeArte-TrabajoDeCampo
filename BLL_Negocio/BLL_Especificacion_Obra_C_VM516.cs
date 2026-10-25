using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Negocio
{
    public class BLL_Especificacion_Obra_C_VM516
    {
        private DAL_Especificacion_Obra_C_VM516 dalObraC_VM516;

        public BLL_Especificacion_Obra_C_VM516()
        {
            dalObraC_VM516 = new DAL_Especificacion_Obra_C_VM516();
        }

        // Obtener el historial aplicando los filtros de la interfaz
        public List<BE_Especificacion_Obra_C_VM516> ObtenerHistorialFiltrado_VM516(string idObra_VM516, string titulo_VM516, DateTime? fechaIni_VM516, DateTime? fechaFin_VM516)
        {
            if (fechaIni_VM516.HasValue && fechaFin_VM516.HasValue)
            {
                if (fechaIni_VM516.Value.Date > fechaFin_VM516.Value.Date)
                {
                    throw new Exception("err_RangoFechasInvalido");
                }
            }

            return dalObraC_VM516.ObtenerHistorialFiltrado_VM516(idObra_VM516, titulo_VM516, fechaIni_VM516, fechaFin_VM516);
        }

        // Ejecutar el RollBack del registro histórico seleccionado
        public void ActivarRegistroHistorico_VM516(int idCambio_VM516)
        {
            if (idCambio_VM516 <= 0)
            {
                throw new Exception("err_SeleccionarRegistroHistorico");
            }

            dalObraC_VM516.ActivarRegistroHistorico_VM516(idCambio_VM516);
        }
    }
}

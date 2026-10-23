using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Negocio
{
    public class BLL_Producto_C_VM516
    {
        private DAL_Producto_C_VM516 dalProductoC_VM516;

        public BLL_Producto_C_VM516()
        {
            dalProductoC_VM516 = new DAL_Producto_C_VM516();
        }

        // Método para obtener el historial aplicando los filtros requeridos por la cátedra
        public List<BE_Producto_C_VM516> ObtenerHistorialFiltrado_VM516(string codigo_VM516, string nombre_VM516, DateTime? fechaIni_VM516, DateTime? fechaFin_VM516)
        {
            // Validar que si se ingresa una fecha fin, no sea menor a la fecha inicio
            if (fechaIni_VM516.HasValue && fechaFin_VM516.HasValue)
            {
                if (fechaIni_VM516.Value > fechaFin_VM516.Value)
                {
                    throw new Exception("err_RangoFechasInvalido");
                }
            }

            return dalProductoC_VM516.ObtenerHistorialFiltrado_VM516(codigo_VM516, nombre_VM516, fechaIni_VM516, fechaFin_VM516);
        }

        // Método que ejecuta la reactivación del registro histórico seleccionado
        public void ActivarRegistroHistorico_VM516(int idCambio_VM516)
        {
            if (idCambio_VM516 <= 0)
            {
                throw new Exception("err_SeleccionarRegistroHistorico");
            }

            dalProductoC_VM516.ActivarRegistroHistorico_VM516(idCambio_VM516);
        }
    }
}

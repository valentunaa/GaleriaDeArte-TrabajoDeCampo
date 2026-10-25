using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Producto_C_VM516
    {
        public int Id_Cambio_VM516 { get; set; }
        public string CodigoProducto_VM516 { get; set; }
        public string Descripcion_VM516 { get; set; }
        public int StockDisponible_VM516 { get; set; }
        public decimal PrecioVigente_VM516 { get; set; }
        public bool Bit_Lo_Bo_VM516 { get; set; }
        public DateTime Fecha_VM516 { get; set; }
        public bool Activo_VM516 { get; set; }

        // Constructor con parámetros para facilitar el mapeo
        public BE_Producto_C_VM516(int idCambio, string codigo, string descripcion, int stock, decimal precio, bool bitLoBo, DateTime fecha, bool activo)
        {
            Id_Cambio_VM516 = idCambio;
            CodigoProducto_VM516 = codigo;
            Descripcion_VM516 = descripcion;
            StockDisponible_VM516 = stock;
            PrecioVigente_VM516 = precio;
            Bit_Lo_Bo_VM516 = bitLoBo;
            Fecha_VM516 = fecha;
            Activo_VM516 = activo;
        }
    }
}

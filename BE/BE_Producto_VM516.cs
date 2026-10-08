using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicio;

namespace BE
{
    public class BE_Producto_VM516 : IVerificable
    {
        public string CodigoProducto_VM516 { get; set; }
        public string Descripcion_VM516 { get; set; }
        public int StockDisponible_VM516 { get; set; }
        public decimal PrecioVigente_VM516 { get; set; }

        public BE_Producto_VM516() { }

        public BE_Producto_VM516(string codigoProducto_VM516, string descripcion_VM516, int stockDisponible_VM516, decimal precioVigente_VM516)
        {
            CodigoProducto_VM516 = codigoProducto_VM516;
            Descripcion_VM516 = descripcion_VM516;
            StockDisponible_VM516 = stockDisponible_VM516;
            PrecioVigente_VM516 = precioVigente_VM516;
        }

        public string ObtenerIdentificadorFila()
        {
            return CodigoProducto_VM516;
        }

        public string ObtenerCadenaParaHash()
        {
            return $"{CodigoProducto_VM516}|{Descripcion_VM516}|{StockDisponible_VM516}|{PrecioVigente_VM516}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicio;
namespace BE
{
    public class BE_LineaDetalle_VM516: IVerificable
    {
        public int NumeroPedido_VM516 { get; set; }
        public string CodigoProducto_VM516 { get; set; }
        public int Cantidad_VM516 { get; set; }
        public decimal PrecioUnitario_VM516 { get; set; }

        public BE_LineaDetalle_VM516() { }

        public BE_LineaDetalle_VM516(int numeroPedido_VM516, string codigoProducto_VM516, int cantidad_VM516, decimal precioUnitario_VM516)
        {
            NumeroPedido_VM516 = numeroPedido_VM516;
            CodigoProducto_VM516 = codigoProducto_VM516;
            Cantidad_VM516 = cantidad_VM516;
            PrecioUnitario_VM516 = precioUnitario_VM516;
        }

        public string ObtenerIdentificadorFila()
        {
            // Clave primaria compuesta
            return $"{NumeroPedido_VM516}_{CodigoProducto_VM516}";
        }

        public string ObtenerCadenaParaHash()
        {
            return $"{NumeroPedido_VM516}|{CodigoProducto_VM516}|{Cantidad_VM516}|{PrecioUnitario_VM516}";
        }
    }
}

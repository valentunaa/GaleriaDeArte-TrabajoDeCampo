using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicio;
namespace BE
{
    public class BE_Pedido_VM516 : IVerificable
    {
        public int NumeroPedido_VM516 { get; set; }
        public string EstadoPedido_VM516 { get; set; }
        public string Dni_Cliente_VM516 { get; set; }

        // Propiedad de navegación para guardar el detalle en memoria
        public List<BE_LineaDetalle_VM516> LineasDetalle_VM516 { get; set; }

        public BE_Pedido_VM516()
        {
            LineasDetalle_VM516 = new List<BE_LineaDetalle_VM516>();
        }

        public BE_Pedido_VM516(int numeroPedido_VM516, string estadoPedido_VM516, string dni_Cliente_VM516)
        {
            NumeroPedido_VM516 = numeroPedido_VM516;
            EstadoPedido_VM516 = estadoPedido_VM516;
            Dni_Cliente_VM516 = dni_Cliente_VM516;
            LineasDetalle_VM516 = new List<BE_LineaDetalle_VM516>();
        }

        public string ObtenerIdentificadorFila()
        {
            return NumeroPedido_VM516.ToString();
        }

        public string ObtenerCadenaParaHash()
        {
            return $"{NumeroPedido_VM516}|{EstadoPedido_VM516}|{Dni_Cliente_VM516}";
        }
    }
}

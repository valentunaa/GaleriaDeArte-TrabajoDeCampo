using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicio;
namespace BE
{
    public class BE_ComprobanteCafeteria_VM516: IVerificable
    {
        public int NumeroTicket_VM516 { get; set; }
        public DateTime FechaHora_VM516 { get; set; }
        public decimal MontoAbonado_VM516 { get; set; }
        public string MedioPago_VM516 { get; set; }
        public int NumeroPedido_VM516 { get; set; }

        public BE_ComprobanteCafeteria_VM516() { }

        public BE_ComprobanteCafeteria_VM516(int numeroTicket_VM516, DateTime fechaHora_VM516, decimal montoAbonado_VM516, string medioPago_VM516, int numeroPedido_VM516)
        {
            NumeroTicket_VM516 = numeroTicket_VM516;
            FechaHora_VM516 = fechaHora_VM516;
            MontoAbonado_VM516 = montoAbonado_VM516;
            MedioPago_VM516 = medioPago_VM516;
            NumeroPedido_VM516 = numeroPedido_VM516;
        }

        public string ObtenerIdentificadorFila()
        {
            return NumeroTicket_VM516.ToString();
        }

        public string ObtenerCadenaParaHash()
        {
           
            return $"{NumeroTicket_VM516}|{FechaHora_VM516.ToString("yyyyMMddHHmmss")}|{MontoAbonado_VM516}|{MedioPago_VM516}|{NumeroPedido_VM516}";
        }
    }
}

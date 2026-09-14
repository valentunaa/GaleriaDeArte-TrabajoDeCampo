using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicio;
namespace BE
{
    public class BE_Comprobante_Pago_VM516 : IVerificable
    {
        public string Nro_Comprobante_VM516 { get; set; }
        public DateTime Fecha_Pago_VM516 { get; set; }
        public decimal Monto_Abonado_VM516 { get; set; }
        public string DNI_VM516 { get; set; }
        public string Nombre_VM516 { get; set; }
        public string Apellido_VM516 { get; set; }
        public string Medio_Pago_VM516 { get; set; }
        public decimal Porcentaje_Sena_Aplicado_VM516 { get; set; }
        public string Codigo_Reserva_VM516 { get; set; }

        public string ObtenerIdentificadorFila()
        {
            return Nro_Comprobante_VM516;
        }

        public string ObtenerCadenaParaHash()
        {
            return $"{Nro_Comprobante_VM516}{Fecha_Pago_VM516:yyyyMMddHHmmss}{Monto_Abonado_VM516}{DNI_VM516}{Nombre_VM516}{Apellido_VM516}{Medio_Pago_VM516}{Porcentaje_Sena_Aplicado_VM516}{Codigo_Reserva_VM516}";
        }
    }
}

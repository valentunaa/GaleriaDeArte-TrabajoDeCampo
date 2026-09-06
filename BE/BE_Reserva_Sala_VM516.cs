using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Reserva_Sala_VM516 : IVerificable
    {
        public string Codigo_Reserva_VM516 { get; set; }
        public string Codigo_Sala_VM516 { get; set; }
        public int Id_Obra_VM516 { get; set; }
        public DateTime Fecha_Inicio_VM516 { get; set; }
        public DateTime Fecha_Fin_VM516 { get; set; }
        public decimal Monto_Alquiler_Total_VM516 { get; set; }
        public decimal Porcentaje_Sena_VM516 { get; set; }
        public decimal Saldo_Restante_A_Pagar_VM516 { get; set; }
        public string Estado_Espacio_VM516 { get; set; } = "Reservado";
        public string Estado_Pago_VM516 { get; set; } = "Pendiente_Sena";

        public BE_Reserva_Sala_VM516() { }

        public string ObtenerIdentificadorFila()
        {
            return Codigo_Reserva_VM516;
        }

       
        public string ObtenerCadenaParaHash()
        {
            return $"{Codigo_Reserva_VM516}{Codigo_Sala_VM516}{Id_Obra_VM516}{Fecha_Inicio_VM516:yyyyMMdd}{Fecha_Fin_VM516:yyyyMMdd}{Monto_Alquiler_Total_VM516}{Porcentaje_Sena_VM516}{Saldo_Restante_A_Pagar_VM516}{Estado_Espacio_VM516}{Estado_Pago_VM516}";
        }
    }
}

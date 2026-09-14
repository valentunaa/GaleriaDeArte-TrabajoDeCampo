using System;
using Servicio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Retiro_Obra_VM516: IVerificable
    {
        public string Codigo_Reserva_VM516 { get; set; }
        public string DNI_Responsable_Desmontaje_VM516 { get; set; }
        public DateTime Fecha_Retiro_VM516 { get; set; }

        public BE_Retiro_Obra_VM516() { }

        public BE_Retiro_Obra_VM516(string codigoReserva, string dniResponsable, DateTime fechaRetiro)
        {
            Codigo_Reserva_VM516 = codigoReserva;
            DNI_Responsable_Desmontaje_VM516 = dniResponsable;
            Fecha_Retiro_VM516 = fechaRetiro;
        }

        public string ObtenerIdentificadorFila()
        {
            return Codigo_Reserva_VM516;
        }

        public string ObtenerCadenaParaHash()
        {
            return $"{Codigo_Reserva_VM516}{DNI_Responsable_Desmontaje_VM516}{Fecha_Retiro_VM516:yyyyMMddHHmmss}";
        }
    }
}

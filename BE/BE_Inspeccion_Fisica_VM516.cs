using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicio;

namespace BE
{
    public class BE_Inspeccion_Fisica_VM516 : IVerificable
    {
        public string Codigo_Reserva_VM516 { get; set; }
        public string Estado_Post_Exhibicion_VM516 { get; set; }
        public string Observaciones_Fisicas_VM516 { get; set; }
        public DateTime Fecha_Inspeccion_VM516 { get; set; }

        public string ObtenerCadenaParaHash()
        {
            return $"{Codigo_Reserva_VM516}{Estado_Post_Exhibicion_VM516}{Observaciones_Fisicas_VM516}{Fecha_Inspeccion_VM516:yyyyMMddHHmmss}";
        }

        public string ObtenerIdentificadorFila()
        {
            return Codigo_Reserva_VM516;
        }

    }
}

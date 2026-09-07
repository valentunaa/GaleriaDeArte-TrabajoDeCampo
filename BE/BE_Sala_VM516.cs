using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicio;
namespace BE
{
    public class BE_Sala_VM516 : IVerificable
    {
        public string Codigo_Sala_VM516 { get; set; }
        public string Nombre_Sala_VM516 { get; set; }
        public decimal Alto_Max_Soportado_VM516 { get; set; }
        public decimal Ancho_Max_Soportado_VM516 { get; set; }
        public decimal Peso_Max_Soportado_VM516 { get; set; }
        public string Tipo_Iluminacion_Disponible_VM516 { get; set; }

        public BE_Sala_VM516() { }
        public string ObtenerIdentificadorFila()
        {
            return Codigo_Sala_VM516;
        }

        public string ObtenerCadenaParaHash()
        {
            return $"{Codigo_Sala_VM516}{Nombre_Sala_VM516}{Alto_Max_Soportado_VM516}{Ancho_Max_Soportado_VM516}{Peso_Max_Soportado_VM516}{Tipo_Iluminacion_Disponible_VM516}";
        }

      
    }
}

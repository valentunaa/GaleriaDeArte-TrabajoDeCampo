using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace BE
{
    public class BE_Artista_VM516 : IVerificable
    {
        public string DNI_VM516 { get; set; }
        public string Nombre_VM516 { get; set; }
        public string Apellido_VM516 { get; set; }
        public string Telefono_VM516 { get; set; }
        public string Email_VM516 { get; set; }

        public BE_Artista_VM516(string dni_VM516, string nombre_VM516, string apellido_VM516, string telefono_VM516, string email_VM516)
        {
            DNI_VM516 = dni_VM516;
            Nombre_VM516 = nombre_VM516;
            Apellido_VM516 = apellido_VM516;
            Telefono_VM516 = telefono_VM516;
            Email_VM516 = email_VM516;
        }

        public string ObtenerIdentificadorFila()
        {
            return DNI_VM516;
        }

        public string ObtenerCadenaParaHash()
        {
            return $"{DNI_VM516}|{Nombre_VM516}|{Apellido_VM516}|{Telefono_VM516}|{Email_VM516}";
        }
    }
}

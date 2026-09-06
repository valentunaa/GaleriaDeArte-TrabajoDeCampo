using BE;
using BLL;
using DAL;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace BLL_Negocio
{
    public class BLL_Artista_VM516
    {
        private DAL_Artista_VM516 dalArtista_VM516;
        private BLL_DigitoVerificador bllDigito_VM516;

        public BLL_Artista_VM516()
        {
            dalArtista_VM516 = new DAL_Artista_VM516();
            bllDigito_VM516 = new BLL_DigitoVerificador();
        }

        public void RegistrarArtista_VM516(BE_Artista_VM516 artista_VM516)
        {
            if (string.IsNullOrWhiteSpace(artista_VM516.DNI_VM516) ||
                string.IsNullOrWhiteSpace(artista_VM516.Nombre_VM516) ||
                string.IsNullOrWhiteSpace(artista_VM516.Apellido_VM516) ||
                string.IsNullOrWhiteSpace(artista_VM516.Telefono_VM516) ||
                string.IsNullOrWhiteSpace(artista_VM516.Email_VM516))
            {
                throw new Exception("Campos incompletos. Por favor, ingrese todos los datos del artista.");
            }

            if (!Regex.IsMatch(artista_VM516.DNI_VM516, @"^\d{7,8}$"))
            {
                throw new Exception("El DNI debe contener solo números y tener entre 7 y 8 dígitos.");
            }

            // Validación de Teléfono: Solo números, entre 7 y 15 dígitos
            if (!Regex.IsMatch(artista_VM516.Telefono_VM516, @"^\d{7,15}$"))
            {
                throw new Exception("El teléfono debe contener solo números.");
            }

            // Validación de Email (soporta dominios compuestos como hotmail.com.ar, gmail.com, etc.)
            if (!Regex.IsMatch(artista_VM516.Email_VM516, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                throw new Exception("El formato del email no es válido.");
            }

            dalArtista_VM516.GuardarArtista_VM516(artista_VM516);

            List<BE_Artista_VM516> listaBE_VM516 = dalArtista_VM516.ListarArtistas_VM516();

            bllDigito_VM516.ActualizarDigitos(artista_VM516,listaBE_VM516.Cast<IVerificable>().ToList(), "Artista_VM516" );
 
        }


        public List<BE_Artista_VM516> ListarArtistas_VM516()
        {
            return dalArtista_VM516.ListarArtistas_VM516();
        }
        public List<BE_Artista_VM516> BuscarArtistaPorDNI_VM516(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni))
            {
                return ListarArtistas_VM516();
            }

            return dalArtista_VM516.BuscarArtistaPorDNI_VM516(dni);
        }
    }
}

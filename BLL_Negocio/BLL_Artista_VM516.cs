using BE;
using BLL;
using DAL;
using Microsoft.Extensions.DependencyInjection;
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

        public void RegistrarArtista_VM516(string dni, string nombre, string apellido, string telefono, string email)
        {
            // 1. Validaciones de negocio sobre los datos crudos
            if (string.IsNullOrWhiteSpace(dni) ||
                string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(telefono) ||
                string.IsNullOrWhiteSpace(email))
            {
                throw new Exception("Campos incompletos. Por favor, ingrese todos los datos del artista.");
            }

            if (!Regex.IsMatch(dni, @"^\d{7,8}$"))
            {
                throw new Exception("El DNI debe contener solo números y tener entre 7 y 8 dígitos.");
            }

            if (!Regex.IsMatch(telefono, @"^\d{7,15}$"))
            {
                throw new Exception("El teléfono debe contener solo números.");
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                throw new Exception("El formato del email no es válido.");
            }

            if (dalArtista_VM516.ExisteArtista_VM516(dni))
            {
                throw new Exception("El artista ya se encuentra registrado.");
            }

            BE_Artista_VM516 artista_VM516 = new BE_Artista_VM516(dni, nombre, apellido, telefono, email);

            dalArtista_VM516.GuardarArtista_VM516(artista_VM516);

            List<BE_Artista_VM516> listaBE_VM516 = dalArtista_VM516.ListarArtistas_VM516();
            bllDigito_VM516.ActualizarDigitos(artista_VM516, listaBE_VM516.Cast<IVerificable>().ToList(), "Artista_VM516");
        }

        public List<BE_Artista_VM516> ListarArtistas_VM516()
        {
            return dalArtista_VM516.ListarArtistas_VM516();
        }
        public BE_Artista_VM516 BuscarArtistaPorDNI_VM516(string dni)
        {
            if (string.IsNullOrEmpty(dni)) throw new Exception("El DNI no puede estar vacío.");

            var aux = ListarArtistas_VM516().Find(x => x.DNI_VM516 == dni);
            if (aux == null) throw new Exception("No se encontró un artista con el DNI proporcionado.");
            return aux;


        }
    }
}

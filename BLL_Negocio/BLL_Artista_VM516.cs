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
        private BLL_BitacoraEvento bllBitacora_VM516;

        public BLL_Artista_VM516()
        {
            dalArtista_VM516 = new DAL_Artista_VM516();
            bllDigito_VM516 = new BLL_DigitoVerificador();
            bllBitacora_VM516 = new BLL_BitacoraEvento();
        }

        public void RegistrarArtista_VM516(string dni, string nombre, string apellido, string telefono, string email)
        {
            if (string.IsNullOrWhiteSpace(dni) ||
                string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(telefono) ||
                string.IsNullOrWhiteSpace(email))
            {
                throw new Exception("err_CamposIncompletosArtista");
            }

            if (!Regex.IsMatch(dni, @"^\d{7,8}$"))
            {
                throw new Exception("err_DNIInvalidoArtista");
            }

            if (!Regex.IsMatch(telefono, @"^\d{7,15}$"))
            {
                throw new Exception("err_TelefonoInvalidoArtista");
            }

            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                throw new Exception("err_EmailInvalidoArtista");
            }

            if (dalArtista_VM516.ExisteArtista_VM516(dni))
            {
                throw new Exception("err_ArtistaDuplicado");
            }

            BE_Artista_VM516 artista_VM516 = new BE_Artista_VM516(dni, nombre, apellido, telefono, email);

            dalArtista_VM516.GuardarArtista_VM516(artista_VM516);

            List<BE_Artista_VM516> listaBE_VM516 = dalArtista_VM516.ListarArtistas_VM516();
            bllDigito_VM516.ActualizarDigitos(artista_VM516, listaBE_VM516.Cast<IVerificable>().ToList(), "Artista_VM516");

            string loginActual = SessionManager.GetInstancia().GetUsuarioActual().Login;
            string detalleEvento = $"Alta Artista: {dni}";
            bllBitacora_VM516.RegistrarBitacora(detalleEvento, loginActual, "Negocio - Artísta", 3);
        }

        public List<BE_Artista_VM516> ListarArtistas_VM516()
        {
            return dalArtista_VM516.ListarArtistas_VM516();
        }
        public BE_Artista_VM516 BuscarArtistaPorDNI_VM516(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni))
                throw new Exception("err_DniVacioArtista");

            var artista = dalArtista_VM516.BuscarArtistaPorDNI_VM516(dni);

            if (artista == null)
                throw new Exception("err_ArtistaNoEncontrado");

            return artista;

        }
    }
}

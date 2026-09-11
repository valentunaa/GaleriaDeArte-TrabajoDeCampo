using BE;
using BLL;
using DAL;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Negocio
{
    public class BLL_Especificacion_Obra_VM516
    {
        private DAL_Especificacion_Obra_VM516 dalObra_VM516;
        private DAL_Artista_VM516 dalArtista_VM516;
        private BLL_DigitoVerificador bllDigito_VM516;

        public BLL_Especificacion_Obra_VM516()
        {
            dalObra_VM516 = new DAL_Especificacion_Obra_VM516();
            dalArtista_VM516 = new DAL_Artista_VM516();
            bllDigito_VM516 = new BLL_DigitoVerificador();
        }

        public bool ExisteArtista(string dni)
        {
            return dalArtista_VM516.ExisteArtista_VM516(dni);
        }

        public BE_Especificacion_Obra_VM516 ObtenerPorId_VM516(int idObra)
        {

            var lista = dalObra_VM516.ListarEspecificaciones_VM516();
            return lista.FirstOrDefault(o => o.Id_Obra_VM516 == idObra);
        }
        public void RegistrarEspecificacion_VM516(string dni, string titulo, string tecnica, string altoStr, string anchoStr, string pesoStr, string reqIluminacion, string valorMercadoStr, string categoriaSeguro)
        {
            if (string.IsNullOrWhiteSpace(dni) ||
                string.IsNullOrWhiteSpace(titulo) ||
                string.IsNullOrWhiteSpace(tecnica) ||
                string.IsNullOrWhiteSpace(reqIluminacion) ||
                string.IsNullOrWhiteSpace(categoriaSeguro))
            {
                throw new Exception("Existen campos obligatorios incompletos.");
            }

            if (!dalArtista_VM516.ExisteArtista_VM516(dni))
            {
                throw new Exception("El artista no se encuentra registrado.");
            }

          
            if (!decimal.TryParse(altoStr, out decimal alto) || alto <= 0 ||
                !decimal.TryParse(anchoStr, out decimal ancho) || ancho <= 0 ||
                !decimal.TryParse(pesoStr, out decimal peso) || peso <= 0)
            {
                throw new Exception("El Alto, Ancho y Peso deben ser valores numéricos válidos y mayores a cero.");
            }

            if (!decimal.TryParse(valorMercadoStr, out decimal valorMercado) || valorMercado < 0)
            {
                throw new Exception("El valor declarado de mercado debe ser un número válido y no puede ser negativo.");
            }
 
            BE_Especificacion_Obra_VM516 obra = new BE_Especificacion_Obra_VM516(dni, titulo, tecnica, alto, ancho, peso, reqIluminacion, valorMercado, categoriaSeguro);

            dalObra_VM516.GuardarEspecificacion_VM516(obra);

            List<BE_Especificacion_Obra_VM516> lista = dalObra_VM516.ListarEspecificaciones_VM516();
            BE_Especificacion_Obra_VM516 ultimaObra = lista.LastOrDefault();

            if (ultimaObra != null)
            {
                bllDigito_VM516.ActualizarDigitos(ultimaObra, lista, "Especificacion_Obra_VM516");
            }
        }

        public List<BE_Especificacion_Obra_VM516> ListarEspecificaciones()
        {
            return dalObra_VM516.ListarEspecificaciones_VM516();
        }
    }
}

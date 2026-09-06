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

        public void RegistrarEspecificacion_VM516(BE_Especificacion_Obra_VM516 obra)
        {
            if (string.IsNullOrWhiteSpace(obra.DNI_Artista_VM516) ||
                string.IsNullOrWhiteSpace(obra.Titulo_Obra_VM516) ||
                string.IsNullOrWhiteSpace(obra.Tecnica_VM516) ||
                string.IsNullOrWhiteSpace(obra.Req_Iluminacion_VM516) ||
                string.IsNullOrWhiteSpace(obra.Categoria_Seguro_VM516))
            {
                throw new Exception("Existen campos obligatorios incompletos.");
            }

            if (!dalArtista_VM516.ExisteArtista_VM516(obra.DNI_Artista_VM516))
            {
                throw new Exception("El artista no se encuentra registrado.");
            }

            if (obra.Alto_VM516 <= 0 || obra.Ancho_VM516 <= 0 || obra.Peso_VM516 <= 0)
            {
                throw new Exception("El Alto, Ancho y Peso deben ser valores numéricos mayores a cero.");
            }

            if (obra.Valor_Declarado_Mercado_VM516 < 0)
            {
                throw new Exception("El valor declarado de mercado no puede ser negativo.");
            }

            dalObra_VM516.GuardarEspecificacion_VM516(obra);

            List<BE_Especificacion_Obra_VM516> lista = dalObra_VM516.ListarEspecificaciones_VM516();
            BE_Especificacion_Obra_VM516 ultimaObra = lista.LastOrDefault();

            if (ultimaObra != null)
            {
                bllDigito_VM516.ActualizarDigitos(ultimaObra,lista,"Especificacion_Obra_VM516"
    
                );
            }
        }

        public List<BE_Especificacion_Obra_VM516> ListarEspecificaciones()
        {
            return dalObra_VM516.ListarEspecificaciones_VM516();
        }
    }
}

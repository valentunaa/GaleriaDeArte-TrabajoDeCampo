using BE;
using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Negocio
{
    public class BLL_Sala_VM516
    {
        private DAL_Sala_VM516 dalSala_VM516;
        private BLL_DigitoVerificador bllDigito_VM516;

        public BLL_Sala_VM516()
        {
            dalSala_VM516 = new DAL_Sala_VM516();
            bllDigito_VM516 = new BLL_DigitoVerificador();
        }

        public void RegistrarSala_VM516(BE_Sala_VM516 sala)
        {
            if (string.IsNullOrWhiteSpace(sala.Codigo_Sala_VM516) ||
                string.IsNullOrWhiteSpace(sala.Nombre_Sala_VM516) ||
                string.IsNullOrWhiteSpace(sala.Tipo_Iluminacion_Disponible_VM516))
            {
                throw new Exception("Existen campos obligatorios incompletos.");
            }

            if (sala.Alto_Max_Soportado_VM516 <= 0 || sala.Ancho_Max_Soportado_VM516 <= 0 || sala.Peso_Max_Soportado_VM516 <= 0)
            {
                throw new Exception("Las dimensiones y el peso máximo soportado deben ser valores numéricos mayores a cero.");
            }

            dalSala_VM516.GuardarSala_VM516(sala);

            List<BE_Sala_VM516> lista = dalSala_VM516.ListarSalas_VM516();
            BE_Sala_VM516 ultimaSala = lista.LastOrDefault(s => s.Codigo_Sala_VM516 == sala.Codigo_Sala_VM516);

            if (ultimaSala != null)
            {
                bllDigito_VM516.ActualizarDigitos<BE_Sala_VM516>(ultimaSala, lista, "Sala_VM516");
            }
        }

        public void ModificarSala_VM516(BE_Sala_VM516 sala)
        {
            if (string.IsNullOrWhiteSpace(sala.Codigo_Sala_VM516) ||
                string.IsNullOrWhiteSpace(sala.Nombre_Sala_VM516) ||
                string.IsNullOrWhiteSpace(sala.Tipo_Iluminacion_Disponible_VM516))
            {
                throw new Exception("Existen campos obligatorios incompletos.");
            }

            if (sala.Alto_Max_Soportado_VM516 <= 0 || sala.Ancho_Max_Soportado_VM516 <= 0 || sala.Peso_Max_Soportado_VM516 <= 0)
            {
                throw new Exception("Las dimensiones y el peso máximo soportado deben ser valores numéricos mayores a cero.");
            }

            dalSala_VM516.ModificarSala_VM516(sala);

            List<BE_Sala_VM516> lista = dalSala_VM516.ListarSalas_VM516();
            BE_Sala_VM516 salaModificada = lista.FirstOrDefault(s => s.Codigo_Sala_VM516 == sala.Codigo_Sala_VM516);

            if (salaModificada != null)
            {
                bllDigito_VM516.ActualizarDigitos<BE_Sala_VM516>(salaModificada, lista, "Sala_VM516");
            }
        }

        public void EliminarSala_VM516(string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo))
            {
                throw new Exception("Debe seleccionar una sala para eliminar.");
            }

            dalSala_VM516.EliminarSala_VM516(codigo);

            List<BE_Sala_VM516> lista = dalSala_VM516.ListarSalas_VM516();
            if (lista.Count > 0)
            {
                bllDigito_VM516.ActualizarDigitos<BE_Sala_VM516>(lista.First(), lista, "Sala_VM516");
            }
        }

        public List<BE_Sala_VM516> ListarSalas()
        {
            return dalSala_VM516.ListarSalas_VM516();
        }
    }
}

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
        private BLL_Reserva_Sala_VM516 bllReserva_VM516;
        public BLL_Sala_VM516()
        {
            dalSala_VM516 = new DAL_Sala_VM516();
            bllDigito_VM516 = new BLL_DigitoVerificador();
            bllReserva_VM516 = new BLL_Reserva_Sala_VM516();
        }

        private void ValidarSalaAsignada(string codigoSala)
        {
            var reservas = bllReserva_VM516.ListarReservas_VM516();
            bool estaAsignada = reservas.Any(r => r.Codigo_Sala_VM516.Trim().Equals(codigoSala.Trim(), StringComparison.OrdinalIgnoreCase));

            if (estaAsignada)
            {
                throw new Exception("err_SalaEnUsoReserva");
            }
        }
        public void RegistrarSala_VM516(BE_Sala_VM516 sala)
        {
            if (string.IsNullOrWhiteSpace(sala.Codigo_Sala_VM516) ||
                string.IsNullOrWhiteSpace(sala.Nombre_Sala_VM516) ||
                string.IsNullOrWhiteSpace(sala.Tipo_Iluminacion_Disponible_VM516))
            {
                throw new Exception("err_CamposObligatoriosSalas");
            }

            if (sala.Alto_Max_Soportado_VM516 <= 0 || sala.Ancho_Max_Soportado_VM516 <= 0 || sala.Peso_Max_Soportado_VM516 <= 0)
            {
                throw new Exception("err_DimensionesNumericasSalas");
            }

            try
            {
                dalSala_VM516.GuardarSala_VM516(sala);

                List<BE_Sala_VM516> lista = dalSala_VM516.ListarSalas_VM516();
                BE_Sala_VM516 ultimaSala = lista.LastOrDefault(s => s.Codigo_Sala_VM516 == sala.Codigo_Sala_VM516);

                if (ultimaSala != null)
                {
                    bllDigito_VM516.ActualizarDigitos<BE_Sala_VM516>(ultimaSala, lista, "Sala_VM516");
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("PRIMARY KEY") || ex.Message.Contains("duplicate key"))
                {
                    throw new Exception("err_SalaYaExiste");
                }
                throw;
            }
        }

        public void ModificarSala_VM516(BE_Sala_VM516 sala, bool omitirValidacionUso = false)
        {
            if (string.IsNullOrWhiteSpace(sala.Codigo_Sala_VM516) ||
                string.IsNullOrWhiteSpace(sala.Nombre_Sala_VM516) ||
                string.IsNullOrWhiteSpace(sala.Tipo_Iluminacion_Disponible_VM516))
            {
                throw new Exception("err_CamposObligatoriosSalas");
            }

            if (sala.Alto_Max_Soportado_VM516 <= 0 || sala.Ancho_Max_Soportado_VM516 <= 0 || sala.Peso_Max_Soportado_VM516 <= 0)
            {
                throw new Exception("err_DimensionesNumericasSalas");
            }

            if (!omitirValidacionUso)
            {
                ValidarSalaAsignada(sala.Codigo_Sala_VM516);
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
                throw new Exception("err_SeleccionarSalaEliminar");
            }
            ValidarSalaAsignada(codigo);
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

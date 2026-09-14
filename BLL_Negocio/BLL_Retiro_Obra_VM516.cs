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
    public class BLL_Retiro_Obra_VM516
    {
        private DAL_Retiro_Obra_VM516 dalRetiro_VM516;
        private BLL_Reserva_Sala_VM516 bllReserva_VM516;
        private BLL_Inspeccion_Obra_VM516 bllInspeccion_VM516;
        private BLL_Sala_VM516 bllSala_VM516;
        private BLL_DigitoVerificador bllDigito_VM516;

        public BLL_Retiro_Obra_VM516()
        {
            dalRetiro_VM516 = new DAL_Retiro_Obra_VM516();
            bllReserva_VM516 = new BLL_Reserva_Sala_VM516();
            bllInspeccion_VM516 = new BLL_Inspeccion_Obra_VM516();
            bllSala_VM516 = new BLL_Sala_VM516();
            bllDigito_VM516 = new BLL_DigitoVerificador();
        }

        public BE_Reserva_Sala_VM516 BuscarReservaParaDesmontaje_VM516(string codigoReserva)
        {
            if (string.IsNullOrWhiteSpace(codigoReserva))
            {
                throw new Exception("err_CodigoReservaVacio");
            }

            var reservas = bllReserva_VM516.ListarReservas_VM516();
            var reserva = reservas.FirstOrDefault(r => r.Codigo_Reserva_VM516.Trim().Equals(codigoReserva.Trim(), StringComparison.OrdinalIgnoreCase));

            if (reserva == null)
            {
                throw new Exception("err_ReservaNoEncontradaDesmontaje");
            }
            bool yaRetirada = ListarRetiros_VM516().Any(r => r.Codigo_Reserva_VM516.Trim().Equals(reserva.Codigo_Reserva_VM516.Trim(), StringComparison.OrdinalIgnoreCase));

            if (yaRetirada)
            {
                throw new Exception("err_ObraYaRetirada");
            }
        
            var listaInspecciones = bllInspeccion_VM516.ListarInspecciones_VM516();
            bool tieneInspeccion = listaInspecciones.Any(i => i.Codigo_Reserva_VM516.Trim().Equals(reserva.Codigo_Reserva_VM516.Trim(), StringComparison.OrdinalIgnoreCase));

            if (!tieneInspeccion)
            {
                throw new Exception("err_InspeccionFaltanteDesmontaje");
            }

            if (!reserva.Estado_Pago_VM516.Equals("Saldado", StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception("err_DesmontajeBloqueadoSaldoDeudor");
            }

            if (!reserva.Estado_Pago_VM516.Equals("Saldado", StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception("err_DesmontajeBloqueadoSaldoDeudor");
            }

            return reserva;
        }

        public void RegistrarDesmontaje_VM516(string codigoReserva, string dniResponsable)
        {
            if (string.IsNullOrWhiteSpace(codigoReserva))
            {
                throw new Exception("err_CodigoReservaVacio");
            }

            if (string.IsNullOrWhiteSpace(dniResponsable))
            {
                throw new Exception("err_DniResponsableInvalido");
            }

            var reserva = BuscarReservaParaDesmontaje_VM516(codigoReserva);

            BE_Retiro_Obra_VM516 retiro = new BE_Retiro_Obra_VM516
            {
                Codigo_Reserva_VM516 = reserva.Codigo_Reserva_VM516,
                DNI_Responsable_Desmontaje_VM516 = dniResponsable.Trim(),
                Fecha_Retiro_VM516 = DateTime.Now
            };

            try
            {
                dalRetiro_VM516.GuardarRetiro_VM516(retiro);

                // Liberar la sala actualizando su estado a "Disponible" mediante la BLL o recuperando la sala correspondiente
                var salas = bllSala_VM516.ListarSalas();
                var salaAsignada = salas.FirstOrDefault(s => s.Codigo_Sala_VM516.Trim().Equals(reserva.Codigo_Sala_VM516.Trim(), StringComparison.OrdinalIgnoreCase));

                if (salaAsignada != null)
                {
                    // Permite liberar la sala a pesar de seguir asociada históricamente a la reserva concluida
                    bllSala_VM516.ModificarSala_VM516(salaAsignada, omitirValidacionUso: true);
                }

                List<BE_Retiro_Obra_VM516> lista = dalRetiro_VM516.ListarRetiros_VM516();
                BE_Retiro_Obra_VM516 ultimoRetiro = lista.LastOrDefault(r => r.Codigo_Reserva_VM516 == retiro.Codigo_Reserva_VM516);

                if (ultimoRetiro != null)
                {
                    bllDigito_VM516.ActualizarDigitos<BE_Retiro_Obra_VM516>(ultimoRetiro, lista, "Retiro_Obra_VM516");
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("PRIMARY KEY") || ex.Message.Contains("duplicate key"))
                {
                    throw new Exception("err_RetiroYaRegistrado");
                }
                throw;
            }
        }

        public List<BE_Retiro_Obra_VM516> ListarRetiros_VM516()
        {
            return dalRetiro_VM516.ListarRetiros_VM516();
        }
    }
}

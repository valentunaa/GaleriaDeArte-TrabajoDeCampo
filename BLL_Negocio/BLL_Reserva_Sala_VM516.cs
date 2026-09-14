using BE;
using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Negocio
{
    public class BLL_Reserva_Sala_VM516
    {
        private DAL_Reserva_Sala_VM516 dalReserva_VM516;
        private BLL_DigitoVerificador bllDigito_VM516;
        private BLL_Especificacion_Obra_VM516 bllObra_VM516;
        public BLL_Reserva_Sala_VM516()
        {
            dalReserva_VM516 = new DAL_Reserva_Sala_VM516();
            bllDigito_VM516 = new BLL_DigitoVerificador();
            bllObra_VM516 = new BLL_Especificacion_Obra_VM516();
        }
        public BE_Reserva_Sala_VM516 BuscarReservaParaPeritaje_VM516(string codigoReserva)
        {
            if (string.IsNullOrWhiteSpace(codigoReserva))
            {
                throw new Exception("err_CodigoReservaVacio");
            }

            var listaReservas = dalReserva_VM516.ListarReservas_VM516();
            var reserva = listaReservas.FirstOrDefault(r => r.Codigo_Reserva_VM516.Trim().Equals(codigoReserva.Trim(), StringComparison.OrdinalIgnoreCase));

            if (reserva == null)
            {
                throw new Exception("err_ReservaNoEncontradaPeritaje");
            }

            if (reserva.Estado_Pago_VM516.Equals("Pendiente_Sena", StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception("err_ReservaPendienteSenaPeritaje");
            }

            return reserva;
        }
        public (decimal Monto, string TipoPago, string EstadoActual) ObtenerDetalleCobroReserva_VM516(string codigoReserva)
        {
            if (string.IsNullOrWhiteSpace(codigoReserva))
            {
                throw new Exception("err_CodigoReservaVacio");
            }

            var reserva = dalReserva_VM516.ListarReservas_VM516()
                .FirstOrDefault(r => r.Codigo_Reserva_VM516.Trim().Equals(codigoReserva.Trim(), StringComparison.OrdinalIgnoreCase));

            if (reserva == null)
            {
                throw new Exception("err_ReservaNoEncontrada");
            }

            decimal montoACobrar = 0;
            string tipoPago = "";

            if (reserva.Estado_Pago_VM516.Equals("Pendiente_Seña", StringComparison.OrdinalIgnoreCase) ||
                reserva.Estado_Pago_VM516.Equals("Pendiente", StringComparison.OrdinalIgnoreCase))
            {
                montoACobrar = reserva.Monto_Alquiler_Total_VM516 * (reserva.Porcentaje_Sena_VM516 / 100);
                tipoPago = "Seña";
            }
            else if (reserva.Estado_Pago_VM516.Equals("Seña Abonada", StringComparison.OrdinalIgnoreCase))
            {
                montoACobrar = reserva.Saldo_Restante_A_Pagar_VM516;
                tipoPago = "Pago Final";
            }
            else
            {
                throw new Exception("err_ReservaYaLiquidada");
            }

            return (montoACobrar, tipoPago, reserva.Estado_Pago_VM516);
        }
        public BE_Reserva_Sala_VM516 BuscarReservaPorCodigo_VM516(string codigoReserva)
        {
            if (string.IsNullOrWhiteSpace(codigoReserva))
            {
                throw new Exception("err_CodigoReservaVacio");
            }

            var lista = dalReserva_VM516.ListarReservas_VM516();
            var reserva = lista.FirstOrDefault(r => r.Codigo_Reserva_VM516.Trim().Equals(codigoReserva.Trim(), StringComparison.OrdinalIgnoreCase));

            if (reserva == null)
            {
                throw new Exception("err_ReservaNoEncontradaPeritaje");
            }

            return reserva;
        }
        public List<BE_Sala_VM516> ObtenerSalasDisponiblesPorObra_VM516(int idObra, DateTime inicio, DateTime fin)
        {
            if (inicio >= fin)
            {
                throw new Exception("err_FechasCronologicamenteIncorrectas");
            }

            var listaObras = bllObra_VM516.ListarEspecificaciones();
            BE_Especificacion_Obra_VM516 obraSeleccionada = null;

            foreach (var o in listaObras)
            {
                if (o.Id_Obra_VM516 == idObra)
                {
                    obraSeleccionada = o;
                    break;
                }
            }

            if (obraSeleccionada == null)
            {
                throw new Exception("err_ObraNoEncontrada");
            }

            return dalReserva_VM516.ObtenerSalasDisponiblesPorObra_VM516(
                inicio,
                fin,
                obraSeleccionada.Alto_VM516,
                obraSeleccionada.Ancho_VM516,
                obraSeleccionada.Peso_VM516,
                obraSeleccionada.Req_Iluminacion_VM516
            );
        }

        public void RegistrarReserva_VM516(string codigoSala, string idObraStr, DateTime fechaInicio, DateTime fechaFin, string montoTotalStr, string porcentajeSenaStr)
        {
            if (string.IsNullOrWhiteSpace(codigoSala))
            {
                throw new Exception("err_SeleccionarSalaGrilla");
            }

            if (string.IsNullOrWhiteSpace(idObraStr) || !int.TryParse(idObraStr.Trim(), out int idObra))
            {
                throw new Exception("err_IdObraNumerico");
            }

            if (fechaInicio >= fechaFin)
            {
                throw new Exception("err_FechasCronologicamenteIncorrectas");
            }

            if (!decimal.TryParse(montoTotalStr.Trim(), out decimal montoTotal) || montoTotal <= 0)
            {
                throw new Exception("err_MontoTotalInvalido");
            }

            if (!decimal.TryParse(porcentajeSenaStr.Trim(), out decimal porcentajeSena) || porcentajeSena < 1 || porcentajeSena > 100)
            {
                throw new Exception("El porcentaje de seña requerido debe ser un valor mayor a 0% y menor o igual al 100%.");
            }

            
            decimal senaMonto = (montoTotal * porcentajeSena) / 100;
            decimal saldoRestante = montoTotal - senaMonto;
            string codigoReserva = "RES_" + DateTime.Now.Ticks.ToString().Substring(10);

            BE_Reserva_Sala_VM516 reserva = new BE_Reserva_Sala_VM516
            {
                Codigo_Reserva_VM516 = codigoReserva,
                Codigo_Sala_VM516 = codigoSala,
                Id_Obra_VM516 = idObra,
                Fecha_Inicio_VM516 = fechaInicio,
                Fecha_Fin_VM516 = fechaFin,
                Monto_Alquiler_Total_VM516 = montoTotal,
                Porcentaje_Sena_VM516 = porcentajeSena,
                Saldo_Restante_A_Pagar_VM516 = saldoRestante,
                Estado_Espacio_VM516 = "Reservado",
                Estado_Pago_VM516 = "Pendiente_Sena"
            };

            dalReserva_VM516.GuardarReserva_VM516(reserva);

            List<BE_Reserva_Sala_VM516> lista = dalReserva_VM516.ListarReservas_VM516();
            BE_Reserva_Sala_VM516 ultimaReserva = lista.LastOrDefault();

            if (ultimaReserva != null)
            {
                bllDigito_VM516.ActualizarDigitos<BE_Reserva_Sala_VM516>(
                    ultimaReserva,
                    lista,
                    "Reserva_Sala_VM516"
                );
            }
        }
        public BE_Reserva_Sala_VM516 BuscarReservaParaCobranza_VM516(string codigoReserva)
        {
            if (string.IsNullOrWhiteSpace(codigoReserva))
            {
                throw new Exception("err_CodigoReservaVacio");
            }

            var reservas = dalReserva_VM516.ListarReservas_VM516();
            var reserva = reservas.FirstOrDefault(r => r.Codigo_Reserva_VM516 == codigoReserva);

            if (reserva == null)
            {
                throw new Exception("err_ReservaNoEncontrada");
            }

            if (reserva.Estado_Pago_VM516 != "Pendiente_Sena" && reserva.Estado_Pago_VM516 != "Sena_Abonada")
            {
                throw new Exception("err_ReservaSinSaldoPendiente");
            }

            // Precondición exclusiva para el Pago Final: Verificar que la inspección/peritaje esté hecha
            if (reserva.Estado_Pago_VM516 == "Sena_Abonada")
            {
                bool inspeccionLista = VerificarInspeccionRegistrada_VM516(codigoReserva);
                if (!inspeccionLista)
                {
                    throw new Exception("err_InspeccionEgresoPendiente");
                }
            }

            return reserva;
        }
        private bool VerificarInspeccionRegistrada_VM516(string codigoReserva)
        {
            DAL_Inspeccion_Obra_VM516 dalInspeccion = new DAL_Inspeccion_Obra_VM516();
            return dalInspeccion.ExisteInspeccionPorReserva_VM516(codigoReserva);
        }
        public void ActualizarEstadoPagoReserva_VM516(string codigoReserva, string nuevoEstadoPago)
        {
            
            dalReserva_VM516.ActualizarEstadoPago_VM516(codigoReserva, nuevoEstadoPago);

            // Recalcula y actualiza los dígitos verificadores (DVH y DVV) de la tabla Reserva_Sala_VM516
            List<BE_Reserva_Sala_VM516> listaReservas = dalReserva_VM516.ListarReservas_VM516();
            BE_Reserva_Sala_VM516 reservaModificada = listaReservas.FirstOrDefault(r => r.Codigo_Reserva_VM516 == codigoReserva);

            if (reservaModificada != null)
            {
                bllDigito_VM516.ActualizarDigitos<BE_Reserva_Sala_VM516>(reservaModificada, listaReservas, "Reserva_Sala_VM516");
            }
        }
        public List<BE_Reserva_Sala_VM516> ListarReservas_VM516()
        {
            return dalReserva_VM516.ListarReservas_VM516();
        }
    }
}

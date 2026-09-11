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
                throw new Exception("Por favor, ingrese un código de reserva para buscar.");
            }

            var listaReservas = dalReserva_VM516.ListarReservas_VM516();
            var reserva = listaReservas.FirstOrDefault(r => r.Codigo_Reserva_VM516.Trim().Equals(codigoReserva.Trim(), StringComparison.OrdinalIgnoreCase));

            // Flujo alternativo 1.1: Si no existe, se dispara la excepción de negocio
            if (reserva == null)
            {
                throw new Exception("No se registran reservas vigentes en etapa de cierre para el criterio ingresado.");
            }

            return reserva;
        }
        public (decimal Monto, string TipoPago, string EstadoActual) ObtenerDetalleCobroReserva_VM516(string codigoReserva)
        {
            if (string.IsNullOrWhiteSpace(codigoReserva))
            {
                throw new Exception("Debe ingresar un código de reserva válido.");
            }

            var reserva = dalReserva_VM516.ListarReservas_VM516()
                .FirstOrDefault(r => r.Codigo_Reserva_VM516.Trim().Equals(codigoReserva.Trim(), StringComparison.OrdinalIgnoreCase));

            if (reserva == null)
            {
                throw new Exception("No se registra ninguna reserva activa para el código ingresado.");
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
                throw new Exception($"La reserva ya se encuentra liquidada bajo el estado: {reserva.Estado_Pago_VM516}");
            }

            return (montoACobrar, tipoPago, reserva.Estado_Pago_VM516);
        }
        public BE_Reserva_Sala_VM516 BuscarReservaPorCodigo_VM516(string codigoReserva)
        {
            if (string.IsNullOrWhiteSpace(codigoReserva))
            {
                throw new Exception("Por favor, ingrese un código de reserva para realizar la búsqueda.");
            }

            var lista = dalReserva_VM516.ListarReservas_VM516();
            var reserva = lista.FirstOrDefault(r => r.Codigo_Reserva_VM516.Trim().Equals(codigoReserva.Trim(), StringComparison.OrdinalIgnoreCase));

            if (reserva == null)
            {
                throw new Exception("No se registran reservas vigentes en etapa de cierre para el criterio ingresado.");
            }

            return reserva;
        }
        public List<BE_Sala_VM516> ObtenerSalasDisponiblesPorObra(int idObra, DateTime inicio, DateTime fin)
        {
            if (inicio >= fin)
            {
                throw new Exception("El rango de fechas ingresado es cronológicamente incorrecto. La fecha de inicio debe ser anterior a la fecha de fin.");
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
                throw new Exception("No se encontró ninguna especificación de obra registrada con el ID ingresado.");
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
                throw new Exception("Debe seleccionar una sala de la grilla interactiva para continuar.");
            }

            if (string.IsNullOrWhiteSpace(idObraStr) || !int.TryParse(idObraStr.Trim(), out int idObra))
            {
                throw new Exception("El ID de obra está vacío o no posee un formato numérico válido.");
            }

            if (fechaInicio >= fechaFin)
            {
                throw new Exception("El rango de fechas ingresado es cronológicamente incorrecto.");
            }

            if (!decimal.TryParse(montoTotalStr.Trim(), out decimal montoTotal) || montoTotal <= 0)
            {
                throw new Exception("El monto total del alquiler debe ser un valor numérico superior a cero.");
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
        public List<BE_Reserva_Sala_VM516> ListarReservas()
        {
            return dalReserva_VM516.ListarReservas_VM516();
        }
    }
}

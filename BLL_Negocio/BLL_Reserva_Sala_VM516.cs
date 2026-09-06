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

        public BLL_Reserva_Sala_VM516()
        {
            dalReserva_VM516 = new DAL_Reserva_Sala_VM516();
            bllDigito_VM516 = new BLL_DigitoVerificador();
        }

        public List<BE_Sala_VM516> ObtenerSalasDisponiblesPorObra(int idObra, DateTime inicio, DateTime fin)
        {
            if (inicio >= fin)
            {
                throw new Exception("El rango de fechas ingresado es cronológicamente incorrecto. La fecha de inicio debe ser anterior a la fecha de fin.");
            }

            var listaObras = dalObra_VM516.ListarEspecificaciones_VM516();
            BE_EspecificacionObra_VM516 obraSeleccionada = null;

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

        public void RegistrarReserva_VM516(BE_Reserva_Sala_VM516 reserva, decimal montoTotal, decimal porcentajeSena)
        {
            if (reserva.Fecha_Inicio_VM516 >= reserva.Fecha_Fin_VM516)
            {
                throw new Exception("El rango de fechas ingresado es cronológicamente incorrecto.");
            }

            if (montoTotal <= 0)
            {
                throw new Exception("El monto total del alquiler debe ser un valor numérico superior a cero.");
            }

            if (porcentajeSena < 1 || porcentajeSena > 100)
            {
                throw new Exception("El porcentaje de seña requerido debe ser mayor a 0% y menor o igual al 100%.");
            }

            // Cálculos automáticos solicitados
            decimal senaMonto = (montoTotal * porcentajeSena) / 100;
            decimal saldoRestante = montoTotal - senaMonto;

            reserva.Monto_Alquiler_Total_VM516 = montoTotal;
            reserva.Porcentaje_Sena_VM516 = porcentajeSena;
            reserva.Saldo_Restante_A_Pagar_VM516 = saldoRestante;
            reserva.Estado_Espacio_VM516 = "Reservado";
            reserva.Estado_Pago_VM516 = "Pendiente_Sena";

            if (string.IsNullOrWhiteSpace(reserva.Codigo_Reserva_VM516))
            {
                reserva.Codigo_Reserva_VM516 = "RES_" + DateTime.Now.Ticks.ToString().Substring(10);
            }

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

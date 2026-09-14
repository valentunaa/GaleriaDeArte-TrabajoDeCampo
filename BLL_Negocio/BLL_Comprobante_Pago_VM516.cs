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
    public class BLL_Comprobante_Pago_VM516
    {
        private DAL_Comprobante_Pago_VM516 dalComprobante_VM516;
        private BLL_DigitoVerificador bllDigito_VM516;

        public BLL_Comprobante_Pago_VM516()
        {
            dalComprobante_VM516 = new DAL_Comprobante_Pago_VM516();
            bllDigito_VM516 = new BLL_DigitoVerificador();
        }

        public BE_Comprobante_Pago_VM516 ProcesarYRegistrarCobro_VM516(BE_Reserva_Sala_VM516 reserva, string medioPago, decimal montoAbonado)
        {
            if (reserva == null)
                throw new Exception("err_ReservaNoValida");

            if (string.IsNullOrWhiteSpace(medioPago))
                throw new Exception("err_SeleccioneMedioPago");

            if (montoAbonado <= 0)
                throw new Exception("err_MontoAbonadoInvalido");

            if (reserva.Porcentaje_Sena_VM516 < 0 || reserva.Porcentaje_Sena_VM516 > 100)
                throw new Exception("err_PorcentajeSenaInvalido");

            
            BLL_Especificacion_Obra_VM516 bllObra_VM516 = new BLL_Especificacion_Obra_VM516();
            var obraAsociada = bllObra_VM516.ObtenerPorId_VM516(reserva.Id_Obra_VM516);

            if (obraAsociada == null)
                throw new Exception("err_ObraNoEncontrada");

            BLL_Artista_VM516 bllArtista_VM516 = new BLL_Artista_VM516();
            var artista = bllArtista_VM516.BuscarArtistaPorDNI_VM516(obraAsociada.DNI_Artista_VM516);

            BE_Comprobante_Pago_VM516 comprobante = new BE_Comprobante_Pago_VM516
            {
                Nro_Comprobante_VM516 = "CP-" + DateTime.Now.ToString("yyyyMMddHHmmss"),
                Fecha_Pago_VM516 = DateTime.Now,
                Monto_Abonado_VM516 = montoAbonado,
                DNI_VM516 = artista.DNI_VM516,
                Nombre_VM516 = artista.Nombre_VM516,
                Apellido_VM516 = artista.Apellido_VM516,
                Medio_Pago_VM516 = medioPago,
                Porcentaje_Sena_Aplicado_VM516 = reserva.Porcentaje_Sena_VM516,
                Codigo_Reserva_VM516 = reserva.Codigo_Reserva_VM516
            };

            if (string.IsNullOrWhiteSpace(comprobante.Nro_Comprobante_VM516) ||
                string.IsNullOrWhiteSpace(comprobante.DNI_VM516) ||
                string.IsNullOrWhiteSpace(comprobante.Nombre_VM516) ||
                string.IsNullOrWhiteSpace(comprobante.Apellido_VM516) ||
                string.IsNullOrWhiteSpace(comprobante.Medio_Pago_VM516) ||
                string.IsNullOrWhiteSpace(comprobante.Codigo_Reserva_VM516))
            {
                throw new Exception("err_CamposObligatoriosComprobante");
            }

            dalComprobante_VM516.GuardarComprobante_VM516(comprobante);

            List<BE_Comprobante_Pago_VM516> lista = dalComprobante_VM516.ListarComprobantes_VM516();
            BE_Comprobante_Pago_VM516 ultimoComprobante = lista.LastOrDefault(c => c.Nro_Comprobante_VM516 == comprobante.Nro_Comprobante_VM516);

            if (ultimoComprobante != null)
            {
                bllDigito_VM516.ActualizarDigitos<BE_Comprobante_Pago_VM516>(ultimoComprobante, lista, "Comprobante_Pago_VM516");
            }

            string nuevoEstadoReserva = (reserva.Estado_Pago_VM516 == "Pendiente_Sena") ? "Sena_Abonada" : "Saldado";

            BLL_Reserva_Sala_VM516 bllReserva = new BLL_Reserva_Sala_VM516();
            bllReserva.ActualizarEstadoPagoReserva_VM516(reserva.Codigo_Reserva_VM516, nuevoEstadoReserva);

            return comprobante;
        }
        public List<BE_Comprobante_Pago_VM516> ListarComprobantes_VM516()
        {
            return dalComprobante_VM516.ListarComprobantes_VM516();
        }
    }
}

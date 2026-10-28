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
    public class BLL_ComprobanteCafeteria_VM516
    {
        private  DAL_ComprobanteCafeteria_VM516 dalComprobante_VM516;
        private BLL_Pedido_VM516 bllPedido_VM516;     
        private BLL_Cliente_VM516 bllCliente_VM516;
        private  BLL_DigitoVerificador bllDigito_VM516;
        private BLL_Producto_VM516 bllProducto_VM516;
        private  BLL_BitacoraEvento bllBitacora_VM516;

        public BLL_ComprobanteCafeteria_VM516()
        {
            dalComprobante_VM516 = new DAL_ComprobanteCafeteria_VM516();
            bllPedido_VM516 = new BLL_Pedido_VM516();
            bllDigito_VM516 = new BLL_DigitoVerificador();
            bllBitacora_VM516 = new BLL_BitacoraEvento();
            bllCliente_VM516 = new BLL_Cliente_VM516();
            bllProducto_VM516 = new BLL_Producto_VM516();
        }

        public BE_ComprobanteCafeteria_VM516 ProcesarYRegistrarCobro_VM516(
              BE_Pedido_VM516 pedido_VM516,
              string medioPago_VM516,
              decimal montoAbonado_VM516,
              bool transaccionAprobadaPorBanco_VM516 = true)
        {
            if (pedido_VM516 == null)
                throw new Exception("err_PedidoNoValido");

            // Flujo Alternativo 2.1: Campo vacío
            if (string.IsNullOrWhiteSpace(medioPago_VM516))
                throw new Exception("err_SeleccioneMedioPago");

            if (montoAbonado_VM516 <= 0)
                throw new Exception("err_MontoAbonadoInvalido");

            if (pedido_VM516.EstadoPedido_VM516 != "Pendiente de Pago")
                throw new Exception("err_PedidoSinSaldoPendiente");

            // Validamos que el cliente asociado al pedido exista
            var clienteAsociado_VM516 = bllCliente_VM516.BuscarClientePorDNI_VM516(pedido_VM516.Dni_Cliente_VM516);
            if (clienteAsociado_VM516 == null)
                throw new Exception("err_ClienteNoRegistrado");

            // Flujo Alternativo 5.1: Simulación de rechazo de la Entidad Financiera
            if (!transaccionAprobadaPorBanco_VM516)
                throw new Exception("err_TransaccionRechazadaFinanciera");

            DateTime ahora_VM516 = DateTime.Now;
            DateTime fechaPago_VM516 = new DateTime(
                ahora_VM516.Year, ahora_VM516.Month, ahora_VM516.Day,
                ahora_VM516.Hour, ahora_VM516.Minute, ahora_VM516.Second);

            BE_ComprobanteCafeteria_VM516 comprobante_VM516 = new BE_ComprobanteCafeteria_VM516
            {
                FechaHora_VM516 = fechaPago_VM516,
                MontoAbonado_VM516 = montoAbonado_VM516,
                MedioPago_VM516 = medioPago_VM516,
                NumeroPedido_VM516 = pedido_VM516.NumeroPedido_VM516
            };

            if (string.IsNullOrWhiteSpace(comprobante_VM516.MedioPago_VM516) ||
                comprobante_VM516.NumeroPedido_VM516 <= 0 ||
                comprobante_VM516.MontoAbonado_VM516 <= 0)
            {
                throw new Exception("err_CamposObligatoriosComprobante");
            }

            dalComprobante_VM516.GuardarComprobante_VM516(comprobante_VM516);

            List<BE_ComprobanteCafeteria_VM516> lista_VM516 = dalComprobante_VM516.ListarComprobantes_VM516();
            BE_ComprobanteCafeteria_VM516 ultimoComprobante_VM516 = lista_VM516.LastOrDefault(c => c.NumeroTicket_VM516 == comprobante_VM516.NumeroTicket_VM516);

            if (ultimoComprobante_VM516 != null)
            {
                bllDigito_VM516.ActualizarDigitos<BE_ComprobanteCafeteria_VM516>(ultimoComprobante_VM516, lista_VM516, "ComprobanteCafeteria_VM516");
            }

            bllPedido_VM516.ActualizarEstadoPagoPedido_VM516(pedido_VM516.NumeroPedido_VM516, "Pagado");

            // NUEVO: El sistema descuenta las existencias del inventario en este momento
            foreach (var linea_VM516 in pedido_VM516.LineasDetalle_VM516)
            {
                bllProducto_VM516.DescontarStock_VM516(linea_VM516.CodigoProducto_VM516, linea_VM516.Cantidad_VM516);
            }

            string loginActual_VM516 = SessionManager.GetInstancia().GetUsuarioActual()?.Login;
            string detalleEvento_VM516 = $"Cobro Ticket: {comprobante_VM516.NumeroTicket_VM516} - Pedido: {comprobante_VM516.NumeroPedido_VM516}";
            bllBitacora_VM516.RegistrarBitacora(detalleEvento_VM516, loginActual_VM516, "Negocio - Tesorería", 4);

            return comprobante_VM516;
        }

        public List<BE_ComprobanteCafeteria_VM516> ListarComprobantes_VM516()
        {
            return dalComprobante_VM516.ListarComprobantes_VM516();
        }
    }
}


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
    public class BLL_Pedido_VM516
    {
        private DAL_Pedido_VM516 dalPedido_VM516;
        private BLL_Producto_VM516 bllProducto_VM516;
        private BLL_DigitoVerificador bllDigito_VM516;
        private BLL_BitacoraEvento bllBitacora_VM516;

        public BLL_Pedido_VM516()
        {
            dalPedido_VM516 = new DAL_Pedido_VM516();
            bllProducto_VM516 = new BLL_Producto_VM516();
            bllDigito_VM516 = new BLL_DigitoVerificador();
            bllBitacora_VM516 = new BLL_BitacoraEvento();
        }

        public void AgregarItemAlCarrito_VM516(List<BE_LineaDetalle_VM516> carrito_VM516, List<string> productosInhabilitados_VM516,BE_Producto_VM516 productoSeleccionado_VM516,string cantidadTexto_VM516)
    
        {
            if (carrito_VM516 == null)
                throw new Exception("err_PedidoSinArticulos");

            if (productoSeleccionado_VM516 == null)
                throw new Exception("err_SeleccioneProducto");

            if (productosInhabilitados_VM516 != null && productosInhabilitados_VM516.Contains(productoSeleccionado_VM516.CodigoProducto_VM516))
                throw new Exception("err_ProductoInhabilitadoStock");

            if (string.IsNullOrWhiteSpace(cantidadTexto_VM516) || !int.TryParse(cantidadTexto_VM516.Trim(), out int cantidad_VM516) || cantidad_VM516 <= 0)
                throw new Exception("err_CantidadInvalidaPedido");

            BE_Producto_VM516 productoBD_VM516 = bllProducto_VM516.ObtenerProductoPorCodigo_VM516(productoSeleccionado_VM516.CodigoProducto_VM516);
            if (productoBD_VM516 == null)
                throw new Exception("err_ProductoNoEncontrado");

            BE_LineaDetalle_VM516 lineaExistente_VM516 = carrito_VM516.FirstOrDefault(x => x.CodigoProducto_VM516 == productoBD_VM516.CodigoProducto_VM516);
            int cantidadTotalRequerida_VM516 = (lineaExistente_VM516 != null ? lineaExistente_VM516.Cantidad_VM516 : 0) + cantidad_VM516;

            // Flujo Alternativo 2.1: Indisponibilidad de Stock
            if (cantidadTotalRequerida_VM516 > productoBD_VM516.StockDisponible_VM516)
            {
                if (productosInhabilitados_VM516 != null && !productosInhabilitados_VM516.Contains(productoBD_VM516.CodigoProducto_VM516))
                {
                    productosInhabilitados_VM516.Add(productoBD_VM516.CodigoProducto_VM516);
                }

                throw new Exception($"err_IndisponibilidadStock|{productoBD_VM516.Descripcion_VM516} ({productoBD_VM516.StockDisponible_VM516})");
            }

            if (lineaExistente_VM516 != null)
            {
                lineaExistente_VM516.Cantidad_VM516 = cantidadTotalRequerida_VM516;
            }
            else
            {
                carrito_VM516.Add(new BE_LineaDetalle_VM516(0,productoBD_VM516.CodigoProducto_VM516,cantidad_VM516,productoBD_VM516.PrecioVigente_VM516));       
                
            }
        }

        public void QuitarItemDelCarrito_VM516(List<BE_LineaDetalle_VM516> carrito_VM516, string codigoProducto_VM516)
        {
            if (carrito_VM516 == null || string.IsNullOrWhiteSpace(codigoProducto_VM516))
                throw new Exception("err_SeleccioneArticuloQuitar");

            var item_VM516 = carrito_VM516.FirstOrDefault(x => x.CodigoProducto_VM516 == codigoProducto_VM516);
            if (item_VM516 == null)
                throw new Exception("err_SeleccioneArticuloQuitar");

            carrito_VM516.Remove(item_VM516);
        }

        public decimal CalcularTotalCarrito_VM516(List<BE_LineaDetalle_VM516> carrito_VM516)
        {
            if (carrito_VM516 == null || carrito_VM516.Count == 0) return 0m;
            return carrito_VM516.Sum(x => x.Cantidad_VM516 * x.PrecioUnitario_VM516);
        }

        // Confirmación y registro (Pasos 5 y 6)
        public BE_Pedido_VM516 ConfirmarYRegistrarPedido_VM516(BE_Cliente_VM516 cliente_VM516, List<BE_LineaDetalle_VM516> carrito_VM516)
        {
            if (carrito_VM516 == null || carrito_VM516.Count == 0)
                throw new Exception("err_PedidoSinArticulos");

            if (cliente_VM516 == null || string.IsNullOrWhiteSpace(cliente_VM516.Dni_VM516))
                throw new Exception("err_ClienteNoSeleccionado");

            // Revalidación de stock antes de persistir
            foreach (var linea_VM516 in carrito_VM516)
            {
                BE_Producto_VM516 producto_VM516 = bllProducto_VM516.ObtenerProductoPorCodigo_VM516(linea_VM516.CodigoProducto_VM516);
                if (producto_VM516 == null)
                    throw new Exception("err_ProductoNoEncontrado");

                if (linea_VM516.Cantidad_VM516 > producto_VM516.StockDisponible_VM516)
                    throw new Exception($"err_IndisponibilidadStock|{producto_VM516.Descripcion_VM516} ({producto_VM516.StockDisponible_VM516})");
            }

            BE_Pedido_VM516 pedido_VM516 = new BE_Pedido_VM516
            {
                Dni_Cliente_VM516 = cliente_VM516.Dni_VM516,
                EstadoPedido_VM516 = "Pendiente de Pago",
                LineasDetalle_VM516 = new List<BE_LineaDetalle_VM516>(carrito_VM516)
            };

            dalPedido_VM516.GuardarPedido_VM516(pedido_VM516);

            // Actualizar Dígitos Verificadores (DVH y DVV)
            List<BE_Pedido_VM516> listaPedidos_VM516 = dalPedido_VM516.ListarPedidos_VM516();
            bllDigito_VM516.ActualizarDigitos(pedido_VM516, listaPedidos_VM516.Cast<IVerificable>().ToList(), "Pedido_VM516");

            List<BE_LineaDetalle_VM516> listaLineas_VM516 = dalPedido_VM516.ListarLineasDetalle_VM516();
            foreach (var linea_VM516 in pedido_VM516.LineasDetalle_VM516)
            {
                bllDigito_VM516.ActualizarDigitos(linea_VM516, listaLineas_VM516.Cast<IVerificable>().ToList(), "LineaDetalle_VM516");
            }

            // Registrar en Bitácora
            string loginUsuario_VM516 = SessionManager.GetInstancia().GetUsuarioActual().Login;
            string detalleEvento_VM516 = $"Alta Pedido: {pedido_VM516.NumeroPedido_VM516} - Estado: {pedido_VM516.EstadoPedido_VM516}";
            bllBitacora_VM516.RegistrarBitacora(detalleEvento_VM516, loginUsuario_VM516, "Negocio - Cafetería", 2);

            return pedido_VM516;
        }

        public void ActualizarEstadoPagoPedido_VM516(int numeroPedido_VM516, string nuevoEstado_VM516)
        {
            BE_Pedido_VM516 pedido_VM516 = dalPedido_VM516.ObtenerPedidoPorNumero_VM516(numeroPedido_VM516);
            if (pedido_VM516 == null)
                throw new Exception("err_PedidoNoEncontrado");

            pedido_VM516.EstadoPedido_VM516 = nuevoEstado_VM516;
            dalPedido_VM516.ActualizarEstadoPedido_VM516(pedido_VM516);

            List<BE_Pedido_VM516> listaPedidos_VM516 = dalPedido_VM516.ListarPedidos_VM516();
            BE_Pedido_VM516 pedidoActualizado_VM516 = listaPedidos_VM516.LastOrDefault(p => p.NumeroPedido_VM516 == numeroPedido_VM516);

            if (pedidoActualizado_VM516 != null)
            {
                bllDigito_VM516.ActualizarDigitos<BE_Pedido_VM516>(pedidoActualizado_VM516, listaPedidos_VM516, "Pedido_VM516");
            }
        }
        public List<BE_Pedido_VM516> ListarPedidosPendientesEntrega_VM516()
        {
            return dalPedido_VM516.ListarPedidos_VM516().Where(p => p.EstadoPedido_VM516.Equals("Pagado", StringComparison.OrdinalIgnoreCase)).ToList();
      
        }

        // Paso 2, 3 y Flujo Alternativo 2.1: Localizar orden para retiro y traer su detalle
        public BE_Pedido_VM516 BuscarPedidoParaRetiro_VM516(string numeroPedidoTexto_VM516)
        {
            if (string.IsNullOrWhiteSpace(numeroPedidoTexto_VM516) || !int.TryParse(numeroPedidoTexto_VM516.Trim(), out int numeroPedido_VM516) || numeroPedido_VM516 <= 0)
            {
                throw new Exception("err_NumeroPedidoInvalido");
            }

            BE_Pedido_VM516 pedido_VM516 = dalPedido_VM516.ObtenerPedidoPorNumero_VM516(numeroPedido_VM516);

            // Flujo Alternativo 2.1: Pedido Inexistente
            if (pedido_VM516 == null)
            {
                throw new Exception("err_PedidoInexistenteRetiro");
            }

            // Flujo Alternativo 2.1: Pedido Ya Entregado
            if (pedido_VM516.EstadoPedido_VM516.Equals("Entregado", StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception("err_PedidoYaEntregado");
            }

            // Validación de Precondición: Debe estar en estado "Pagado"
            if (!pedido_VM516.EstadoPedido_VM516.Equals("Pagado", StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception("err_PedidoNoPagadoRetiro");
            }

            return pedido_VM516;
        }

        // Paso 4, 5 y Postcondición: Actualizar a "Entregado", descontar inventario, actualizar DV y Bitácora
        public void RegistrarEntregaPedido_VM516(BE_Pedido_VM516 pedidoVerificado_VM516)
        {
            if (pedidoVerificado_VM516 == null) throw new Exception("err_DebeBuscarPedidoPrimero");

            BE_Pedido_VM516 pedidoBD_VM516 = dalPedido_VM516.ObtenerPedidoPorNumero_VM516(pedidoVerificado_VM516.NumeroPedido_VM516);
            if (pedidoBD_VM516 == null) throw new Exception("err_PedidoInexistenteRetiro");
            if (pedidoBD_VM516.EstadoPedido_VM516.Equals("Entregado", StringComparison.OrdinalIgnoreCase)) throw new Exception("err_PedidoYaEntregado");
            if (!pedidoBD_VM516.EstadoPedido_VM516.Equals("Pagado", StringComparison.OrdinalIgnoreCase)) throw new Exception("err_PedidoNoPagadoRetiro");

            pedidoBD_VM516.EstadoPedido_VM516 = "Entregado";
            dalPedido_VM516.ActualizarEstadoPedido_VM516(pedidoBD_VM516);

            foreach (var linea_VM516 in pedidoBD_VM516.LineasDetalle_VM516)
            {
                bllProducto_VM516.DescontarStock_VM516(linea_VM516.CodigoProducto_VM516, linea_VM516.Cantidad_VM516);
            }

            List<BE_Pedido_VM516> listaPedidos_VM516 = dalPedido_VM516.ListarPedidos_VM516();
            BE_Pedido_VM516 pedidoActualizado_VM516 = listaPedidos_VM516.LastOrDefault(p => p.NumeroPedido_VM516 == pedidoBD_VM516.NumeroPedido_VM516);
            if (pedidoActualizado_VM516 != null)
            {
                bllDigito_VM516.ActualizarDigitos<BE_Pedido_VM516>(pedidoActualizado_VM516, listaPedidos_VM516, "Pedido_VM516");
            }

            string loginActual_VM516 = SessionManager.GetInstancia().GetUsuarioActual()?.Login;
            bllBitacora_VM516.RegistrarBitacora($"Entrega Pedido: {pedidoBD_VM516.NumeroPedido_VM516} - Estado: Entregado", loginActual_VM516, "Negocio - Cafetería", 3);
        }
        public List<BE_Pedido_VM516> ListarPedidosEntregados_VM516(string filtro_VM516 = "")
        {
            var listaEntregados_VM516 = dalPedido_VM516.ListarPedidos_VM516()
                .Where(p => p.EstadoPedido_VM516.Equals("Entregado", StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (!string.IsNullOrWhiteSpace(filtro_VM516))
            {
                string busq_VM516 = filtro_VM516.Trim();
                listaEntregados_VM516 = listaEntregados_VM516
                    .Where(p => p.NumeroPedido_VM516.ToString().Contains(busq_VM516) ||
                                (p.Dni_Cliente_VM516 != null && p.Dni_Cliente_VM516.IndexOf(busq_VM516, StringComparison.OrdinalIgnoreCase) >= 0))
                    .ToList();
            }

            return listaEntregados_VM516;
        }
    }

}


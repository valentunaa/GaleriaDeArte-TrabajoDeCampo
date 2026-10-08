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
        private DAL_Producto_VM516 dalProducto_VM516; // Para validar stock
        private BLL_DigitoVerificador bllDigito_VM516;
        private BLL_BitacoraEvento bllBitacora_VM516;

        public BLL_Pedido_VM516()
        {
            dalPedido_VM516 = new DAL_Pedido_VM516();
            dalProducto_VM516 = new DAL_Producto_VM516();
            bllDigito_VM516 = new BLL_DigitoVerificador();
            bllBitacora_VM516 = new BLL_BitacoraEvento();
        }

        public void RegistrarPedido_VM516(BE_Pedido_VM516 pedido_VM516)
        {
            // 1. Validaciones Iniciales
            if (pedido_VM516.LineasDetalle_VM516 == null || pedido_VM516.LineasDetalle_VM516.Count == 0)
            {
                throw new Exception("err_PedidoSinArticulos");
            }

            if (string.IsNullOrWhiteSpace(pedido_VM516.Dni_Cliente_VM516))
            {
                throw new Exception("err_ClienteNoSeleccionado");
            }

            // 2. Comprobar Disponibilidad de Existencias (Flujo Alternativo 2.1)
            foreach (var linea_VM516 in pedido_VM516.LineasDetalle_VM516)
            {
                BE_Producto_VM516 producto_VM516 = dalProducto_VM516.ObtenerProducto_VM516(linea_VM516.CodigoProducto_VM516);

                if (producto_VM516 == null) throw new Exception("err_ProductoNoEncontrado");

                if (linea_VM516.Cantidad_VM516 > producto_VM516.StockDisponible_VM516)
                {
                    // Lanza el error y le pasa el nombre del producto al Formulario usando el delimitador |
                    throw new Exception($"err_IndisponibilidadStock|{producto_VM516.Descripcion_VM516}");
                }
            }

            // 3. Asignar Estado y Guardar en la Base de Datos
            pedido_VM516.EstadoPedido_VM516 = "Pendiente de Pago";
            dalPedido_VM516.GuardarPedido_VM516(pedido_VM516);

            // =================================================================
            // 4. SEGURIDAD: ACTUALIZAR DÍGITOS VERIFICADORES
            // =================================================================

            // Actualizamos la tabla cabecera
            List<BE_Pedido_VM516> listaPedidos_VM516 = dalPedido_VM516.ListarPedidos_VM516();
            bllDigito_VM516.ActualizarDigitos(pedido_VM516, listaPedidos_VM516, "Pedido_VM516");

            // Actualizamos la tabla de detalles fila por fila
            List<BE_LineaDetalle_VM516> listaLineas_VM516 = dalPedido_VM516.ListarLineasDetalle_VM516();
            foreach (var linea_VM516 in pedido_VM516.LineasDetalle_VM516)
            {
                bllDigito_VM516.ActualizarDigitos(linea_VM516, listaLineas_VM516, "LineaDetalle_VM516");
            }

            // =================================================================
            // 5. AUDITORÍA: REGISTRAR BITÁCORA
            // =================================================================
            string loginUsuario_VM516 = SessionManager.GetInstancia().GetUsuarioActual().Login;
            string detalleEvento_VM516 = $"Pedido Registrado: {pedido_VM516.NumeroPedido_VM516} - Estado: {pedido_VM516.EstadoPedido_VM516}";

            bllBitacora_VM516.RegistrarBitacora(detalleEvento_VM516, loginUsuario_VM516, "Ventas - Cafetería", 2);
        }
    }


}
}

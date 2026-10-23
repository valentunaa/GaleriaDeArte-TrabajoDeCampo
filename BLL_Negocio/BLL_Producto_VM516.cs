using BE;
using BLL;
using DAL;
using Servicio;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Negocio
{
    public class BLL_Producto_VM516
    {
        private DAL_Producto_VM516 dalProducto_VM516;
        private BLL_DigitoVerificador bllDigito_VM516;
        private BLL_BitacoraEvento bllBitacora_VM516;

        public BLL_Producto_VM516()
        {
            dalProducto_VM516 = new DAL_Producto_VM516();
            bllDigito_VM516 = new BLL_DigitoVerificador();
            bllBitacora_VM516 = new BLL_BitacoraEvento();
        }

        public void RegistrarProducto_VM516(string codigo_VM516, string descripcion_VM516, int stock_VM516, decimal precio_VM516)
        {
            // 1. Validaciones
            if (string.IsNullOrWhiteSpace(codigo_VM516) || string.IsNullOrWhiteSpace(descripcion_VM516))
                throw new Exception("err_CamposIncompletosProducto");

            if (precio_VM516 <= 0)
                throw new Exception("err_PrecioInvalidoProducto");

            if (stock_VM516 < 0)
                throw new Exception("err_StockInvalidoProducto");

            if (dalProducto_VM516.ObtenerProducto_VM516(codigo_VM516) != null)
                throw new Exception("err_ProductoDuplicado");

            // 2. Armado de la Entidad
            BE_Producto_VM516 producto_VM516 = new BE_Producto_VM516(codigo_VM516, descripcion_VM516, stock_VM516, precio_VM516);

            // 3. Persistencia mediante DAL
            dalProducto_VM516.GuardarProducto_VM516(producto_VM516);

            // 4. Seguridad: Recálculo de Dígitos Verificadores
            List<BE_Producto_VM516> listaBE_VM516 = dalProducto_VM516.ListarProductos_VM516();
            bllDigito_VM516.ActualizarDigitos(producto_VM516, listaBE_VM516.Cast<IVerificable>().ToList(), "Producto_VM516");

            // 5. Trazabilidad: Bitácora de Eventos
            string loginActual = SessionManager.GetInstancia().GetUsuarioActual()?.Login ?? "Sistema";
            string detalleEvento = $"Alta Producto Cafetería: {codigo_VM516}";
            bllBitacora_VM516.RegistrarBitacora(detalleEvento, loginActual, "Negocio - Cafetería", 3);
        }

        public void DescontarStock_VM516(string codigo_VM516, int cantidadADescontar_VM516)
        {
            BE_Producto_VM516 producto_VM516 = dalProducto_VM516.ObtenerProducto_VM516(codigo_VM516);

            if (producto_VM516 != null)
            {
                // 1. Resta el stock asegurando que no quede negativo
                producto_VM516.StockDisponible_VM516 -= cantidadADescontar_VM516;
                if (producto_VM516.StockDisponible_VM516 < 0)
                    producto_VM516.StockDisponible_VM516 = 0;

                // 2. Persiste el cambio
                dalProducto_VM516.ActualizarStockProducto_VM516(producto_VM516);

                // 3. Recalcula el DV (Responsabilidad de la BLL de Producto)
                List<BE_Producto_VM516> listaProductos_VM516 = dalProducto_VM516.ListarProductos_VM516();
                BE_Producto_VM516 prodActualizado_VM516 = listaProductos_VM516.FirstOrDefault(p => p.CodigoProducto_VM516 == codigo_VM516);

                if (prodActualizado_VM516 != null)
                {
                    bllDigito_VM516.ActualizarDigitos<BE_Producto_VM516>(prodActualizado_VM516, listaProductos_VM516, "Producto_VM516");
                }
            }
        }
        public void ModificarProducto_VM516(string codigo_VM516, string descripcion_VM516, string stockTxt_VM516, string precioTxt_VM516)
        {
            if (string.IsNullOrWhiteSpace(codigo_VM516) ||
                string.IsNullOrWhiteSpace(descripcion_VM516) ||
                string.IsNullOrWhiteSpace(stockTxt_VM516) ||
                string.IsNullOrWhiteSpace(precioTxt_VM516))
            {
                throw new Exception("err_CamposObligatoriosProducto");
            }

            if (!int.TryParse(stockTxt_VM516.Trim(), out int stock_VM516) || stock_VM516 < 0)
            {
                throw new Exception("err_StockProductoInvalido");
            }

            string precioNormalizado_VM516 = precioTxt_VM516.Trim().Replace(",", ".");
            if (!decimal.TryParse(precioNormalizado_VM516, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal precio_VM516) || precio_VM516 <= 0)
            {
                throw new Exception("err_PrecioProductoInvalido");
            }

            string codigoLimpio_VM516 = codigo_VM516.Trim().ToUpper();
            if (dalProducto_VM516.ObtenerProducto_VM516(codigoLimpio_VM516) == null)
            {
                throw new Exception("err_ProductoNoEncontrado");
            }

            BE_Producto_VM516 prodModificado_VM516 = new BE_Producto_VM516(
                codigoLimpio_VM516,
                descripcion_VM516.Trim(),
                stock_VM516,
                precio_VM516
            );

            dalProducto_VM516.ModificarProducto_VM516(prodModificado_VM516);

            // Actualizar Dígitos Verificadores (DVH y DVV)
            List<BE_Producto_VM516> lista_VM516 = dalProducto_VM516.ListarProductos_VM516();
            BE_Producto_VM516 prodActualizado_VM516 = lista_VM516.LastOrDefault(p => p.CodigoProducto_VM516 == codigoLimpio_VM516);
            if (prodActualizado_VM516 != null)
            {
                bllDigito_VM516.ActualizarDigitos<BE_Producto_VM516>(prodActualizado_VM516, lista_VM516, "Producto_VM516");
            }

            // Registrar en Bitácora
            string loginActual_VM516 = SessionManager.GetInstancia().GetUsuarioActual()?.Login;
            bllBitacora_VM516.RegistrarBitacora(
                $"Modificación Producto Cafetería: {prodModificado_VM516.CodigoProducto_VM516} (Stock: {stock_VM516} | Precio: ${precio_VM516:0.00})",
                loginActual_VM516,
                "Negocio - Cafetería",
                3);
        }

        public void EliminarProducto_VM516(string codigo_VM516)
        {
            if (string.IsNullOrWhiteSpace(codigo_VM516))
            {
                throw new Exception("err_SeleccionarProductoEliminar");
            }

            string codigoLimpio_VM516 = codigo_VM516.Trim().ToUpper();

            if (dalProducto_VM516.ObtenerProducto_VM516(codigoLimpio_VM516) == null)
            {
                throw new Exception("err_ProductoNoEncontrado");
            }

            // Validación de integridad referencial: No permitir borrar si está asociado a pedidos
            if (dalProducto_VM516.EstaProductoEnUso_VM516(codigoLimpio_VM516))
            {
                throw new Exception("err_ProductoEnUsoPedido");
            }

            dalProducto_VM516.EliminarProducto_VM516(codigoLimpio_VM516);

            // Actualizar Dígitos Verificadores usando tu método exacto de BLL_DigitoVerificador:
            List<BE_Producto_VM516> listaRestante_VM516 = dalProducto_VM516.ListarProductos_VM516();
            bllDigito_VM516.EliminarDigitoYRecalcular<BE_Producto_VM516>(codigoLimpio_VM516, listaRestante_VM516, "Producto_VM516");

            // Registrar en Bitácora
            string loginActual_VM516 = SessionManager.GetInstancia().GetUsuarioActual()?.Login;
            bllBitacora_VM516.RegistrarBitacora(
                $"Baja Producto Cafetería: {codigoLimpio_VM516}",
                loginActual_VM516,
                "Negocio - Cafetería",
                4);
        }
        public List<BE_Producto_VM516> ListarProductos_VM516()
        {
            return dalProducto_VM516.ListarProductos_VM516();
        }

        public BE_Producto_VM516 ObtenerProductoPorCodigo_VM516(string codigo_VM516)
        {
            return dalProducto_VM516.ObtenerProducto_VM516(codigo_VM516);
        }
    }
}

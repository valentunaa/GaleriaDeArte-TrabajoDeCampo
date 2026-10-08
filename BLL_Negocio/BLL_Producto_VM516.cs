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

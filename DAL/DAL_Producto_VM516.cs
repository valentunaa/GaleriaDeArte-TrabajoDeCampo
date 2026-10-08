using BE;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Producto_VM516
    {
        private readonly string _connectionString_VM516 = DAL_ConexionDB.ObtenerCadena();

        public List<BE_Producto_VM516> MapearLista(DataTable dt_VM516)
        {
            List<BE_Producto_VM516> lista_VM516 = new List<BE_Producto_VM516>();

            foreach (DataRow row_VM516 in dt_VM516.Rows)
            {
                BE_Producto_VM516 producto_VM516 = new BE_Producto_VM516(
                    row_VM516["CodigoProducto_VM516"].ToString(),
                    row_VM516["Descripcion_VM516"].ToString(),
                    Convert.ToInt32(row_VM516["StockDisponible_VM516"]),
                    Convert.ToDecimal(row_VM516["PrecioVigente_VM516"])
                );
                lista_VM516.Add(producto_VM516);
            }

            return lista_VM516;
        }

        public BE_Producto_VM516 ObtenerProducto_VM516(string codigoProducto_VM516)
        {
            using (SqlConnection conn_VM516 = new SqlConnection(_connectionString_VM516))
            {
                SqlDataAdapter da_VM516 = new SqlDataAdapter("SELECT * FROM Producto_VM516 WHERE CodigoProducto_VM516 = @Codigo", conn_VM516);
                da_VM516.SelectCommand.Parameters.AddWithValue("@Codigo", codigoProducto_VM516);

                DataTable dt_VM516 = new DataTable();
                da_VM516.Fill(dt_VM516); // Traemos a memoria desconectada

                return MapearLista(dt_VM516).FirstOrDefault();
            }
        }

        public List<BE_Producto_VM516> ListarProductos_VM516()
        {
            using (SqlConnection conn_VM516 = new SqlConnection(_connectionString_VM516))
            {
                SqlDataAdapter da_VM516 = new SqlDataAdapter("SELECT * FROM Producto_VM516", conn_VM516);
                DataTable dt_VM516 = new DataTable();
                da_VM516.Fill(dt_VM516);

                return MapearLista(dt_VM516);
            }
        }

        public void GuardarProducto_VM516(BE_Producto_VM516 producto_VM516)
        {
            using (SqlConnection conn_VM516 = new SqlConnection(_connectionString_VM516))
            {
                SqlDataAdapter da_VM516 = new SqlDataAdapter("SELECT * FROM Producto_VM516", conn_VM516);
                SqlCommandBuilder builder_VM516 = new SqlCommandBuilder(da_VM516);
                DataSet ds_VM516 = new DataSet();

                // 1. Llenamos el DataSet (estado desconectado)
                da_VM516.Fill(ds_VM516, "Producto_VM516");

                // 2. Buscamos en memoria si el registro ya existe
                DataRow[] filas_VM516 = ds_VM516.Tables["Producto_VM516"].Select($"CodigoProducto_VM516 = '{producto_VM516.CodigoProducto_VM516}'");

                if (filas_VM516.Length > 0)
                {
                    // Si existe, lo modificamos en memoria
                    filas_VM516[0]["Descripcion_VM516"] = producto_VM516.Descripcion_VM516;
                    filas_VM516[0]["StockDisponible_VM516"] = producto_VM516.StockDisponible_VM516;
                    filas_VM516[0]["PrecioVigente_VM516"] = producto_VM516.PrecioVigente_VM516;
                }
                else
                {
                    // Si no existe, creamos una nueva fila
                    DataRow nuevaFila_VM516 = ds_VM516.Tables["Producto_VM516"].NewRow();
                    nuevaFila_VM516["CodigoProducto_VM516"] = producto_VM516.CodigoProducto_VM516;
                    nuevaFila_VM516["Descripcion_VM516"] = producto_VM516.Descripcion_VM516;
                    nuevaFila_VM516["StockDisponible_VM516"] = producto_VM516.StockDisponible_VM516;
                    nuevaFila_VM516["PrecioVigente_VM516"] = producto_VM516.PrecioVigente_VM516;
                    ds_VM516.Tables["Producto_VM516"].Rows.Add(nuevaFila_VM516);
                }

                // 3. Sincronizamos los cambios de la memoria a la base de datos
                da_VM516.Update(ds_VM516, "Producto_VM516");
            }
        }
    }
}


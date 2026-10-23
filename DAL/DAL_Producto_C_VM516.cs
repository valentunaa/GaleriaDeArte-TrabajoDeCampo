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
    public class DAL_Producto_C_VM516
    {
        private readonly string _connectionString_VM516 = DAL_ConexionDB.ObtenerCadena();

        public List<BE_Producto_C_VM516> MapearListaHistorial(DataTable dt_VM516)
        {
            List<BE_Producto_C_VM516> lista_VM516 = new List<BE_Producto_C_VM516>();

            foreach (DataRow row_VM516 in dt_VM516.Rows)
            {
                BE_Producto_C_VM516 item_VM516 = new BE_Producto_C_VM516(
                    Convert.ToInt32(row_VM516["Id_Cambio_VM516"]),
                    row_VM516["CodigoProducto_VM516"].ToString(),
                    row_VM516["Descripcion_VM516"].ToString(),
                    Convert.ToInt32(row_VM516["StockDisponible_VM516"]),
                    Convert.ToDecimal(row_VM516["PrecioVigente_VM516"]),
                    Convert.ToBoolean(row_VM516["Bit_Lo_Bo_VM516"]),
                    Convert.ToDateTime(row_VM516["Fecha_VM516"]),
                    Convert.ToBoolean(row_VM516["Activo_VM516"])
                );
                lista_VM516.Add(item_VM516);
            }

            return lista_VM516;
        }

        // Listar y Filtrar la Bitácora de Cambios (Código, Nombre y Fechas)
        public List<BE_Producto_C_VM516> ObtenerHistorialFiltrado_VM516(string codigo_VM516, string nombre_VM516, DateTime? fechaIni_VM516, DateTime? fechaFin_VM516)
        {
            using (SqlConnection conn_VM516 = new SqlConnection(_connectionString_VM516))
            {
                string query_VM516 = "SELECT * FROM Producto_C_VM516 WHERE 1=1";
                SqlCommand cmd_VM516 = new SqlCommand();

                if (!string.IsNullOrWhiteSpace(codigo_VM516))
                {
                    query_VM516 += " AND CodigoProducto_VM516 LIKE @Codigo";
                    cmd_VM516.Parameters.Add("@Codigo", SqlDbType.VarChar).Value = $"%{codigo_VM516.Trim()}%";
                }

                if (!string.IsNullOrWhiteSpace(nombre_VM516))
                {
                    query_VM516 += " AND Descripcion_VM516 LIKE @Nombre";
                    cmd_VM516.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = $"%{nombre_VM516.Trim()}%";
                }

                if (fechaIni_VM516.HasValue && fechaFin_VM516.HasValue)
                {
                    query_VM516 += " AND Fecha_VM516 BETWEEN @FechaIni AND @FechaFin";
                    cmd_VM516.Parameters.Add("@FechaIni", SqlDbType.DateTime).Value = fechaIni_VM516.Value.Date;
                    cmd_VM516.Parameters.Add("@FechaFin", SqlDbType.DateTime).Value = fechaFin_VM516.Value.Date.AddDays(1).AddSeconds(-1);
                }

                query_VM516 += " ORDER BY Fecha_VM516 DESC";

                cmd_VM516.CommandText = query_VM516;
                cmd_VM516.Connection = conn_VM516;

                SqlDataAdapter da_VM516 = new SqlDataAdapter(cmd_VM516);
                DataTable dt_VM516 = new DataTable();
                da_VM516.Fill(dt_VM516);

                return MapearListaHistorial(dt_VM516);
            }
        }

        // El Botón "ACTIVAR": Actualiza la tabla _C poniendo Activo = 1 en el registro seleccionado, 
        // lo que dispara el trigger para resetear automáticamente la tabla principal.
        public void ActivarRegistroHistorico_VM516(int idCambio_VM516)
        {
            using (SqlConnection conn_VM516 = new SqlConnection(_connectionString_VM516))
            {
                SqlDataAdapter da_VM516 = new SqlDataAdapter(
                    "SELECT Id_Cambio_VM516, CodigoProducto_VM516, Activo_VM516 FROM Producto_C_VM516 WHERE Id_Cambio_VM516 = @Id",
                    conn_VM516);
                da_VM516.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value = idCambio_VM516;

                da_VM516.UpdateCommand = new SqlCommand(
                    "UPDATE Producto_C_VM516 SET Activo_VM516 = 1 WHERE Id_Cambio_VM516 = @IdCambio",
                    conn_VM516);
                da_VM516.UpdateCommand.Parameters.Add("@IdCambio", SqlDbType.Int, 4, "Id_Cambio_VM516");

                DataTable dt_VM516 = new DataTable();
                da_VM516.Fill(dt_VM516);

                if (dt_VM516.Rows.Count > 0)
                {
                    dt_VM516.Rows[0]["Activo_VM516"] = true;
                    da_VM516.Update(dt_VM516);
                }
            }
        }
    }
}

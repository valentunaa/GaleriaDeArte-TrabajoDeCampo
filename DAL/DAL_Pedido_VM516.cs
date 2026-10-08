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
    public class DAL_Pedido_VM516
    {
        private readonly string _connectionString_VM516 = DAL_ConexionDB.ObtenerCadena();

        public void GuardarPedido_VM516(BE_Pedido_VM516 pedido_VM516)
        {
            using (SqlConnection conn_VM516 = new SqlConnection(_connectionString_VM516))
            {
                // =================================================================
                // 1. GUARDAR CABECERA (Pedido_VM516)
                // =================================================================
                SqlDataAdapter daPedido_VM516 = new SqlDataAdapter("SELECT NumeroPedido_VM516, EstadoPedido_VM516, Dni_Cliente_VM516 FROM Pedido_VM516 WHERE 1=0", conn_VM516);

                // Usamos OUTPUT INSERTED para recuperar el ID generado
                daPedido_VM516.InsertCommand = new SqlCommand("INSERT INTO Pedido_VM516 (EstadoPedido_VM516, Dni_Cliente_VM516) OUTPUT INSERTED.NumeroPedido_VM516 VALUES (@EstadoPedido_VM516, @Dni_Cliente_VM516)", conn_VM516);
                daPedido_VM516.InsertCommand.Parameters.Add("@EstadoPedido_VM516", SqlDbType.VarChar, 50, "EstadoPedido_VM516");
                daPedido_VM516.InsertCommand.Parameters.Add("@Dni_Cliente_VM516", SqlDbType.VarChar, 20, "Dni_Cliente_VM516");

                // Esto mapea el ID devuelto directamente al DataRow
                daPedido_VM516.InsertCommand.UpdatedRowSource = UpdateRowSource.FirstReturnedRecord;

                DataTable dtPedido_VM516 = new DataTable();
                daPedido_VM516.Fill(dtPedido_VM516);

                DataRow filaPedido_VM516 = dtPedido_VM516.NewRow();
                filaPedido_VM516["EstadoPedido_VM516"] = pedido_VM516.EstadoPedido_VM516;
                filaPedido_VM516["Dni_Cliente_VM516"] = pedido_VM516.Dni_Cliente_VM516;
                dtPedido_VM516.Rows.Add(filaPedido_VM516);

                // Sincronizamos y el ID se carga automáticamente en filaPedido_VM516
                daPedido_VM516.Update(dtPedido_VM516);

                // Recuperamos el ID autonumérico y lo guardamos en la BE
                pedido_VM516.NumeroPedido_VM516 = Convert.ToInt32(dtPedido_VM516.Rows[0]["NumeroPedido_VM516"]);

                // =================================================================
                // 2. GUARDAR DETALLES (LineaDetalle_VM516)
                // =================================================================
                SqlDataAdapter daDetalle_VM516 = new SqlDataAdapter("SELECT NumeroPedido_VM516, CodigoProducto_VM516, Cantidad_VM516, PrecioUnitario_VM516 FROM LineaDetalle_VM516 WHERE 1=0", conn_VM516);

                daDetalle_VM516.InsertCommand = new SqlCommand("INSERT INTO LineaDetalle_VM516 (NumeroPedido_VM516, CodigoProducto_VM516, Cantidad_VM516, PrecioUnitario_VM516) VALUES (@NumeroPedido_VM516, @CodigoProducto_VM516, @Cantidad_VM516, @PrecioUnitario_VM516)", conn_VM516);
                daDetalle_VM516.InsertCommand.Parameters.Add("@NumeroPedido_VM516", SqlDbType.Int, 4, "NumeroPedido_VM516");
                daDetalle_VM516.InsertCommand.Parameters.Add("@CodigoProducto_VM516", SqlDbType.VarChar, 50, "CodigoProducto_VM516");
                daDetalle_VM516.InsertCommand.Parameters.Add("@Cantidad_VM516", SqlDbType.Int, 4, "Cantidad_VM516");
                daDetalle_VM516.InsertCommand.Parameters.Add("@PrecioUnitario_VM516", SqlDbType.Decimal, 18, "PrecioUnitario_VM516");

                DataTable dtDetalle_VM516 = new DataTable();
                daDetalle_VM516.Fill(dtDetalle_VM516);

                foreach (var linea_VM516 in pedido_VM516.LineasDetalle_VM516)
                {
                    // Asignamos el número de pedido recién creado a la cabecera de la línea
                    linea_VM516.NumeroPedido_VM516 = pedido_VM516.NumeroPedido_VM516;

                    DataRow filaDetalle_VM516 = dtDetalle_VM516.NewRow();
                    filaDetalle_VM516["NumeroPedido_VM516"] = linea_VM516.NumeroPedido_VM516;
                    filaDetalle_VM516["CodigoProducto_VM516"] = linea_VM516.CodigoProducto_VM516;
                    filaDetalle_VM516["Cantidad_VM516"] = linea_VM516.Cantidad_VM516;
                    filaDetalle_VM516["PrecioUnitario_VM516"] = linea_VM516.PrecioUnitario_VM516;

                    dtDetalle_VM516.Rows.Add(filaDetalle_VM516);
                }

                // Sincronizamos todas las líneas juntas a la BD
                daDetalle_VM516.Update(dtDetalle_VM516);
            }
        }

        // Métodos de lectura necesarios para que el Dígito Verificador pueda recalcular el DVV global
        public List<BE_Pedido_VM516> ListarPedidos_VM516()
        {
            List<BE_Pedido_VM516> lista_VM516 = new List<BE_Pedido_VM516>();
            using (SqlConnection conn_VM516 = new SqlConnection(_connectionString_VM516))
            {
                SqlDataAdapter adapter_VM516 = new SqlDataAdapter("SELECT * FROM Pedido_VM516", conn_VM516);
                DataTable dt_VM516 = new DataTable();
                adapter_VM516.Fill(dt_VM516);

                foreach (DataRow row_VM516 in dt_VM516.Rows)
                {
                    lista_VM516.Add(new BE_Pedido_VM516(
                        Convert.ToInt32(row_VM516["NumeroPedido_VM516"]),
                        row_VM516["EstadoPedido_VM516"].ToString(),
                        row_VM516["Dni_Cliente_VM516"].ToString()
                    ));
                }
            }
            return lista_VM516;
        }

        public List<BE_LineaDetalle_VM516> ListarLineasDetalle_VM516()
        {
            List<BE_LineaDetalle_VM516> lista_VM516 = new List<BE_LineaDetalle_VM516>();
            using (SqlConnection conn_VM516 = new SqlConnection(_connectionString_VM516))
            {
                SqlDataAdapter adapter_VM516 = new SqlDataAdapter("SELECT * FROM LineaDetalle_VM516", conn_VM516);
                DataTable dt_VM516 = new DataTable();
                adapter_VM516.Fill(dt_VM516);

                foreach (DataRow row_VM516 in dt_VM516.Rows)
                {
                    lista_VM516.Add(new BE_LineaDetalle_VM516(
                        Convert.ToInt32(row_VM516["NumeroPedido_VM516"]),
                        row_VM516["CodigoProducto_VM516"].ToString(),
                        Convert.ToInt32(row_VM516["Cantidad_VM516"]),
                        Convert.ToDecimal(row_VM516["PrecioUnitario_VM516"])
                    ));
                }
            }
            return lista_VM516;
        }
    }
}


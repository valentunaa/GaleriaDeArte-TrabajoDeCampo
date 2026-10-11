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
    public class DAL_ComprobanteCafeteria_VM516
    {
        private readonly string _connectionString_VM516 = DAL_ConexionDB.ObtenerCadena();

        public void GuardarComprobante_VM516(BE_ComprobanteCafeteria_VM516 comprobante_VM516)
        {
            using (SqlConnection conn_VM516 = new SqlConnection(_connectionString_VM516))
            {
                SqlDataAdapter da_VM516 = new SqlDataAdapter(
                    "SELECT NumeroTicket_VM516, FechaHora_VM516, MontoAbonado_VM516, MedioPago_VM516, NumeroPedido_VM516 FROM ComprobanteCafeteria_VM516 WHERE 1=0",
                    conn_VM516);

                da_VM516.InsertCommand = new SqlCommand(
                    @"INSERT INTO ComprobanteCafeteria_VM516 (FechaHora_VM516, MontoAbonado_VM516, MedioPago_VM516, NumeroPedido_VM516) 
                      OUTPUT INSERTED.NumeroTicket_VM516 
                      VALUES (@FechaHora_VM516, @MontoAbonado_VM516, @MedioPago_VM516, @NumeroPedido_VM516)",
                    conn_VM516);

                da_VM516.InsertCommand.Parameters.Add("@FechaHora_VM516", SqlDbType.DateTime, 8, "FechaHora_VM516");
                da_VM516.InsertCommand.Parameters.Add("@MontoAbonado_VM516", SqlDbType.Decimal, 18, "MontoAbonado_VM516");
                da_VM516.InsertCommand.Parameters.Add("@MedioPago_VM516", SqlDbType.VarChar, 50, "MedioPago_VM516");
                da_VM516.InsertCommand.Parameters.Add("@NumeroPedido_VM516", SqlDbType.Int, 4, "NumeroPedido_VM516");

                da_VM516.InsertCommand.UpdatedRowSource = UpdateRowSource.FirstReturnedRecord;

                DataTable dt_VM516 = new DataTable();
                da_VM516.Fill(dt_VM516);

                DataRow fila_VM516 = dt_VM516.NewRow();
                fila_VM516["FechaHora_VM516"] = comprobante_VM516.FechaHora_VM516;
                fila_VM516["MontoAbonado_VM516"] = comprobante_VM516.MontoAbonado_VM516;
                fila_VM516["MedioPago_VM516"] = comprobante_VM516.MedioPago_VM516;
                fila_VM516["NumeroPedido_VM516"] = comprobante_VM516.NumeroPedido_VM516;

                dt_VM516.Rows.Add(fila_VM516);
                da_VM516.Update(dt_VM516);

                comprobante_VM516.NumeroTicket_VM516 = Convert.ToInt32(dt_VM516.Rows[0]["NumeroTicket_VM516"]);
            }
        }

        public List<BE_ComprobanteCafeteria_VM516> ListarComprobantes_VM516()
        {
            List<BE_ComprobanteCafeteria_VM516> lista_VM516 = new List<BE_ComprobanteCafeteria_VM516>();

            using (SqlConnection conn_VM516 = new SqlConnection(_connectionString_VM516))
            {
                SqlDataAdapter da_VM516 = new SqlDataAdapter(
                    "SELECT NumeroTicket_VM516, FechaHora_VM516, MontoAbonado_VM516, MedioPago_VM516, NumeroPedido_VM516 FROM ComprobanteCafeteria_VM516",
                    conn_VM516);

                DataTable dt_VM516 = new DataTable();
                da_VM516.Fill(dt_VM516);

                foreach (DataRow row_VM516 in dt_VM516.Rows)
                {
                    // Normalizamos FechaHora al segundo para que coincida exactamente con ObtenerCadenaParaHash("yyyyMMddHHmmss")
                    DateTime fechaBD_VM516 = Convert.ToDateTime(row_VM516["FechaHora_VM516"]);
                    DateTime fechaNormalizada_VM516 = new DateTime(
                        fechaBD_VM516.Year, fechaBD_VM516.Month, fechaBD_VM516.Day,
                        fechaBD_VM516.Hour, fechaBD_VM516.Minute, fechaBD_VM516.Second);

                    lista_VM516.Add(new BE_ComprobanteCafeteria_VM516(
                        Convert.ToInt32(row_VM516["NumeroTicket_VM516"]),
                        fechaNormalizada_VM516,
                        Convert.ToDecimal(row_VM516["MontoAbonado_VM516"]),
                        row_VM516["MedioPago_VM516"].ToString(),
                        Convert.ToInt32(row_VM516["NumeroPedido_VM516"])
                    ));
                }
            }

            return lista_VM516;
        }
    }
}

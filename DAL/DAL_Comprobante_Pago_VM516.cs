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
    public class DAL_Comprobante_Pago_VM516
    {
        private readonly string _connectionString_VM516 = DAL_ConexionDB.ObtenerCadena();

        public List<BE_Comprobante_Pago_VM516> MapearLista(DataTable dt)
        {
            List<BE_Comprobante_Pago_VM516> lista = new List<BE_Comprobante_Pago_VM516>();

            foreach (DataRow row in dt.Rows)
            {
                BE_Comprobante_Pago_VM516 item = new BE_Comprobante_Pago_VM516
                {
                    Nro_Comprobante_VM516 = row["Nro_Comprobante_VM516"].ToString(),
                    Fecha_Pago_VM516 = Convert.ToDateTime(row["Fecha_Pago_VM516"]),
                    Monto_Abonado_VM516 = Convert.ToDecimal(row["Monto_Abonado_VM516"]),
                    DNI_VM516 = row["DNI_VM516"].ToString(),
                    Nombre_VM516 = row["Nombre_VM516"].ToString(),
                    Apellido_VM516 = row["Apellido_VM516"].ToString(),
                    Medio_Pago_VM516 = row["Medio_Pago_VM516"].ToString(),
                    Porcentaje_Sena_Aplicado_VM516 = Convert.ToDecimal(row["Porcentaje_Sena_Aplicado_VM516"]),
                    Codigo_Reserva_VM516 = row["Codigo_Reserva_VM516"].ToString()
                };
                lista.Add(item);
            }
            return lista;
        }

        public void GuardarComprobante_VM516(BE_Comprobante_Pago_VM516 comprobante)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString_VM516))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Comprobante_Pago_VM516 WHERE 1=0", conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Comprobante_Pago_VM516");

                DataRow row = ds.Tables["Comprobante_Pago_VM516"].NewRow();
                row["Nro_Comprobante_VM516"] = comprobante.Nro_Comprobante_VM516;
                row["Fecha_Pago_VM516"] = comprobante.Fecha_Pago_VM516;
                row["Monto_Abonado_VM516"] = comprobante.Monto_Abonado_VM516;
                row["DNI_VM516"] = comprobante.DNI_VM516;
                row["Nombre_VM516"] = comprobante.Nombre_VM516;
                row["Apellido_VM516"] = comprobante.Apellido_VM516;
                row["Medio_Pago_VM516"] = comprobante.Medio_Pago_VM516;
                row["Porcentaje_Sena_Aplicado_VM516"] = comprobante.Porcentaje_Sena_Aplicado_VM516;
                row["Codigo_Reserva_VM516"] = comprobante.Codigo_Reserva_VM516;

                ds.Tables["Comprobante_Pago_VM516"].Rows.Add(row);

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(ds, "Comprobante_Pago_VM516");
            }
        }

        public List<BE_Comprobante_Pago_VM516> ListarComprobantes_VM516()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString_VM516))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Comprobante_Pago_VM516", conn);
                adapter.Fill(dt);
            }
            return MapearLista(dt);
        }
    }
}

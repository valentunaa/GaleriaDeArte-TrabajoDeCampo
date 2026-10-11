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
    public class DAL_Cliente_VM516
    {
        private string _connectionString_VM516 = DAL_ConexionDB.ObtenerCadena();
        
        public List<BE_Cliente_VM516> MapearLista_VM516(DataTable dt_VM516)
        {
            List<BE_Cliente_VM516> lista_VM516 = new List<BE_Cliente_VM516>();
            foreach (DataRow row_VM516 in dt_VM516.Rows)
            {
                lista_VM516.Add(new BE_Cliente_VM516(
                    row_VM516["Dni_VM516"].ToString(),
                    row_VM516["Nombre_VM516"].ToString(),
                    row_VM516["Apellido_VM516"].ToString(),
                    row_VM516["Telefono_VM516"].ToString(),
                    row_VM516["Email_VM516"].ToString()
                ));
            }
            return lista_VM516;
        }

        public BE_Cliente_VM516 BuscarClientePorDNI_VM516(string dni_VM516)
        {
            using (SqlConnection conn_VM516 = new SqlConnection(_connectionString_VM516))
            {
                SqlDataAdapter da_VM516 = new SqlDataAdapter(
                    "SELECT Dni_VM516, Nombre_VM516, Apellido_VM516, Telefono_VM516, Email_VM516 FROM Cliente_VM516 WHERE Dni_VM516 = @Dni_VM516",
                    conn_VM516);
                da_VM516.SelectCommand.Parameters.Add("@Dni_VM516", SqlDbType.VarChar, 20).Value = dni_VM516;

                DataTable dt_VM516 = new DataTable();
                da_VM516.Fill(dt_VM516);

                return MapearLista_VM516(dt_VM516).FirstOrDefault();
            }
        }

        public List<BE_Cliente_VM516> ListarClientes_VM516()
        {
            using (SqlConnection conn_VM516 = new SqlConnection(_connectionString_VM516))
            {
                SqlDataAdapter da_VM516 = new SqlDataAdapter("SELECT * FROM Cliente_VM516", conn_VM516);
                DataTable dt_VM516 = new DataTable();
                da_VM516.Fill(dt_VM516);
                return MapearLista_VM516(dt_VM516);
            }
        }

        public void GuardarCliente_VM516(BE_Cliente_VM516 cliente_VM516)
        {
            using (SqlConnection conn_VM516 = new SqlConnection(_connectionString_VM516))
            {
                SqlDataAdapter da_VM516 = new SqlDataAdapter("SELECT * FROM Cliente_VM516 WHERE 1=0", conn_VM516);
                da_VM516.InsertCommand = new SqlCommand(
                    "INSERT INTO Cliente_VM516 (Dni_VM516, Nombre_VM516, Apellido_VM516, Telefono_VM516, Email_VM516) VALUES (@Dni_VM516, @Nombre_VM516, @Apellido_VM516, @Telefono_VM516, @Email_VM516)",
                    conn_VM516);

                da_VM516.InsertCommand.Parameters.Add("@Dni_VM516", SqlDbType.VarChar, 20, "Dni_VM516");
                da_VM516.InsertCommand.Parameters.Add("@Nombre_VM516", SqlDbType.VarChar, 100, "Nombre_VM516");
                da_VM516.InsertCommand.Parameters.Add("@Apellido_VM516", SqlDbType.VarChar, 100, "Apellido_VM516");
                da_VM516.InsertCommand.Parameters.Add("@Telefono_VM516", SqlDbType.VarChar, 50, "Telefono_VM516");
                da_VM516.InsertCommand.Parameters.Add("@Email_VM516", SqlDbType.VarChar, 150, "Email_VM516");

                DataTable dt_VM516 = new DataTable();
                da_VM516.Fill(dt_VM516);

                DataRow fila_VM516 = dt_VM516.NewRow();
                fila_VM516["Dni_VM516"] = cliente_VM516.Dni_VM516;
                fila_VM516["Nombre_VM516"] = cliente_VM516.Nombre_VM516;
                fila_VM516["Apellido_VM516"] = cliente_VM516.Apellido_VM516;
                fila_VM516["Telefono_VM516"] = cliente_VM516.Telefono_VM516;
                fila_VM516["Email_VM516"] = cliente_VM516.Email_VM516;

                dt_VM516.Rows.Add(fila_VM516);
                da_VM516.Update(dt_VM516);
            }
        }
        public void ModificarCliente_VM516(BE_Cliente_VM516 cliente_VM516)
        {
            using (SqlConnection conn_VM516 = new SqlConnection(_connectionString_VM516))
            {
                SqlDataAdapter da_VM516 = new SqlDataAdapter(
                    "SELECT Dni_VM516, Nombre_VM516, Apellido_VM516, Telefono_VM516, Email_VM516 FROM Cliente_VM516 WHERE Dni_VM516 = @Dni_VM516",
                    conn_VM516);
                da_VM516.SelectCommand.Parameters.Add("@Dni_VM516", SqlDbType.VarChar, 15).Value = cliente_VM516.Dni_VM516;

                da_VM516.UpdateCommand = new SqlCommand(
                    @"UPDATE Cliente_VM516 
                      SET Nombre_VM516 = @Nombre_VM516, 
                          Apellido_VM516 = @Apellido_VM516, 
                          Telefono_VM516 = @Telefono_VM516, 
                          Email_VM516 = @Email_VM516 
                      WHERE Dni_VM516 = @Dni_VM516",
                    conn_VM516);

                da_VM516.UpdateCommand.Parameters.Add("@Nombre_VM516", SqlDbType.VarChar, 100, "Nombre_VM516");
                da_VM516.UpdateCommand.Parameters.Add("@Apellido_VM516", SqlDbType.VarChar, 100, "Apellido_VM516");
                da_VM516.UpdateCommand.Parameters.Add("@Telefono_VM516", SqlDbType.VarChar, 30, "Telefono_VM516");
                da_VM516.UpdateCommand.Parameters.Add("@Email_VM516", SqlDbType.VarChar, 120, "Email_VM516");
                da_VM516.UpdateCommand.Parameters.Add("@Dni_VM516", SqlDbType.VarChar, 15, "Dni_VM516");

                DataTable dt_VM516 = new DataTable();
                da_VM516.Fill(dt_VM516);

                if (dt_VM516.Rows.Count > 0)
                {
                    DataRow fila_VM516 = dt_VM516.Rows[0];
                    fila_VM516["Nombre_VM516"] = cliente_VM516.Nombre_VM516;
                    fila_VM516["Apellido_VM516"] = cliente_VM516.Apellido_VM516;
                    fila_VM516["Telefono_VM516"] = cliente_VM516.Telefono_VM516;
                    fila_VM516["Email_VM516"] = cliente_VM516.Email_VM516;

                    da_VM516.Update(dt_VM516);
                }
            }
        }
    }

}

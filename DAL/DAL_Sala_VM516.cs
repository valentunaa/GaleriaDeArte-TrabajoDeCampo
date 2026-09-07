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
    public class DAL_Sala_VM516
    {
        private readonly string _connectionString_VM516 = DAL_ConexionDB.ObtenerCadena();

        public List<BE_Sala_VM516> MapearLista(DataTable dt)
        {
            List<BE_Sala_VM516> lista = new List<BE_Sala_VM516>();

            foreach (DataRow row in dt.Rows)
            {
                BE_Sala_VM516 sala = new BE_Sala_VM516
                {
                    Codigo_Sala_VM516 = row["Codigo_Sala_VM516"].ToString(),
                    Nombre_Sala_VM516 = row["Nombre_Sala_VM516"].ToString(),
                    Alto_Max_Soportado_VM516 = Convert.ToDecimal(row["Alto_Max_Soportado_VM516"]),
                    Ancho_Max_Soportado_VM516 = Convert.ToDecimal(row["Ancho_Max_Soportado_VM516"]),
                    Peso_Max_Soportado_VM516 = Convert.ToDecimal(row["Peso_Max_Soportado_VM516"]),
                    Tipo_Iluminacion_Disponible_VM516 = row["Tipo_Iluminacion_Disponible_VM516"].ToString()
                };
                lista.Add(sala);
            }
            return lista;
        }

        public void GuardarSala_VM516(BE_Sala_VM516 sala)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString_VM516))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Sala_VM516 WHERE 1=0", conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Sala_VM516");

                DataRow row = ds.Tables["Sala_VM516"].NewRow();
                row["Codigo_Sala_VM516"] = sala.Codigo_Sala_VM516;
                row["Nombre_Sala_VM516"] = sala.Nombre_Sala_VM516;
                row["Alto_Max_Soportado_VM516"] = sala.Alto_Max_Soportado_VM516;
                row["Ancho_Max_Soportado_VM516"] = sala.Ancho_Max_Soportado_VM516;
                row["Peso_Max_Soportado_VM516"] = sala.Peso_Max_Soportado_VM516;
                row["Tipo_Iluminacion_Disponible_VM516"] = sala.Tipo_Iluminacion_Disponible_VM516;

                ds.Tables["Sala_VM516"].Rows.Add(row);

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(ds, "Sala_VM516");
            }
        }

        public void ModificarSala_VM516(BE_Sala_VM516 sala)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString_VM516))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Sala_VM516 WHERE Codigo_Sala_VM516 = @Codigo", conn);
                adapter.SelectCommand.Parameters.AddWithValue("@Codigo", sala.Codigo_Sala_VM516);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Sala_VM516");

                if (ds.Tables["Sala_VM516"].Rows.Count > 0)
                {
                    DataRow row = ds.Tables["Sala_VM516"].Rows[0];
                    row["Nombre_Sala_VM516"] = sala.Nombre_Sala_VM516;
                    row["Alto_Max_Soportado_VM516"] = sala.Alto_Max_Soportado_VM516;
                    row["Ancho_Max_Soportado_VM516"] = sala.Ancho_Max_Soportado_VM516;
                    row["Peso_Max_Soportado_VM516"] = sala.Peso_Max_Soportado_VM516;
                    row["Tipo_Iluminacion_Disponible_VM516"] = sala.Tipo_Iluminacion_Disponible_VM516;

                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.Update(ds, "Sala_VM516");
                }
            }
        }

        public void EliminarSala_VM516(string codigo)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString_VM516))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Sala_VM516 WHERE Codigo_Sala_VM516 = @Codigo", conn);
                adapter.SelectCommand.Parameters.AddWithValue("@Codigo", codigo);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Sala_VM516");

                if (ds.Tables["Sala_VM516"].Rows.Count > 0)
                {
                    ds.Tables["Sala_VM516"].Rows[0].Delete();
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.Update(ds, "Sala_VM516");
                }
            }
        }

        public List<BE_Sala_VM516> ListarSalas_VM516()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString_VM516))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Sala_VM516", conn);
                adapter.Fill(dt);
            }
            return MapearLista(dt);
        }
    }
}

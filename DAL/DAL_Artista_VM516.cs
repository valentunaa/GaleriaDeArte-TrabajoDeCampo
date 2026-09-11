using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class DAL_Artista_VM516
    {
        private readonly string _connectionString_VM516 = DAL_ConexionDB.ObtenerCadena();

        public DAL_Artista_VM516() { }

        public List<BE_Artista_VM516> MapearLista(DataTable dt)
        {
            List<BE_Artista_VM516> lista = new List<BE_Artista_VM516>();

            foreach (DataRow row in dt.Rows)
            {
                BE_Artista_VM516 artista = new BE_Artista_VM516(
                    row["DNI_VM516"].ToString(),
                    row["Nombre_VM516"].ToString(),
                    row["Apellido_VM516"].ToString(),
                    row["Telefono_VM516"].ToString(),
                    row["Email_VM516"].ToString()
                );
                lista.Add(artista);
            }

            return lista;
        }

        public bool ExisteArtista_VM516(string dni_VM516)
        {
            using (SqlConnection conn_VM516 = new SqlConnection(_connectionString_VM516))
            {
                SqlDataAdapter adapter_VM516 = new SqlDataAdapter("SELECT * FROM Artista_VM516", conn_VM516);
                DataSet ds_VM516 = new DataSet();

                adapter_VM516.Fill(ds_VM516, "Artista_VM516");

                foreach (DataRow fila_VM516 in ds_VM516.Tables["Artista_VM516"].Rows)
                {
                    if (fila_VM516["DNI_VM516"].ToString() == dni_VM516)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public void GuardarArtista_VM516(BE_Artista_VM516 artista_VM516)
        {
            using (SqlConnection conn_VM516 = new SqlConnection(_connectionString_VM516))
            {
                SqlDataAdapter adapter_VM516 = new SqlDataAdapter("SELECT * FROM Artista_VM516", conn_VM516);
                DataSet ds_VM516 = new DataSet();

                adapter_VM516.Fill(ds_VM516, "Artista_VM516");

                DataRow fila_VM516 = ds_VM516.Tables["Artista_VM516"].NewRow();
                fila_VM516["DNI_VM516"] = artista_VM516.DNI_VM516;
                fila_VM516["Nombre_VM516"] = artista_VM516.Nombre_VM516;
                fila_VM516["Apellido_VM516"] = artista_VM516.Apellido_VM516;
                fila_VM516["Telefono_VM516"] = artista_VM516.Telefono_VM516;
                fila_VM516["Email_VM516"] = artista_VM516.Email_VM516;

                ds_VM516.Tables["Artista_VM516"].Rows.Add(fila_VM516);
                SqlCommandBuilder builder_VM516 = new SqlCommandBuilder(adapter_VM516);

                adapter_VM516.Update(ds_VM516, "Artista_VM516");
            }
        }
        public List<BE_Artista_VM516> BuscarArtistaPorDNI_VM516(string dni)
        {
            DataTable tabla = new DataTable();
          
            string consulta = "SELECT DNI_VM516, Nombre_VM516, Apellido_VM516, Telefono_VM516, Email_VM516 FROM Artista_VM516 WHERE DNI_VM516 LIKE @DNI + '%'";

            using (SqlConnection conexion = new SqlConnection(_connectionString_VM516))
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@DNI", dni);
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            return MapearLista(tabla);
        }

        public List<BE_Artista_VM516> ListarArtistas_VM516()
        {
            List<BE_Artista_VM516> lista_VM516 = new List<BE_Artista_VM516>();

            using (SqlConnection conn_VM516 = new SqlConnection(_connectionString_VM516))
            {
                SqlDataAdapter adapter_VM516 = new SqlDataAdapter("SELECT * FROM Artista_VM516", conn_VM516);
                DataTable dt_VM516 = new DataTable();

                adapter_VM516.Fill(dt_VM516);

                lista_VM516 = MapearLista(dt_VM516);
            }
            return lista_VM516;
        }
    }
}

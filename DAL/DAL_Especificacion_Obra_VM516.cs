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
    public class DAL_Especificacion_Obra_VM516
    {
        private readonly string _connectionString_VM516 = DAL_ConexionDB.ObtenerCadena();

        public List<BE_Especificacion_Obra_VM516> MapearLista(DataTable dt)
        {
            List<BE_Especificacion_Obra_VM516> lista = new List<BE_Especificacion_Obra_VM516>();

            foreach (DataRow row in dt.Rows)
            {
                BE_Especificacion_Obra_VM516 obra = new BE_Especificacion_Obra_VM516
                {
                    Id_Obra_VM516 = Convert.ToInt32(row["Id_Obra_VM516"]),
                    DNI_Artista_VM516 = row["DNI_Artista_VM516"].ToString(),
                    Titulo_Obra_VM516 = row["Titulo_Obra_VM516"].ToString(),
                    Tecnica_VM516 = row["Tecnica_VM516"].ToString(),
                    Alto_VM516 = Convert.ToDecimal(row["Alto_VM516"]),
                    Ancho_VM516 = Convert.ToDecimal(row["Ancho_VM516"]),
                    Peso_VM516 = Convert.ToDecimal(row["Peso_VM516"]),
                    Req_Iluminacion_VM516 = row["Req_Iluminacion_VM516"].ToString(),
                    Valor_Declarado_Mercado_VM516 = Convert.ToDecimal(row["Valor_Declarado_Mercado_VM516"]),
                    Categoria_Seguro_VM516 = row["Categoria_Seguro_VM516"].ToString(),
                    Estado_Asignacion_VM516 = row["Estado_Asignacion_VM516"].ToString(),
                    Bit_Lo_Bo_VM516 = row.Table.Columns.Contains("Bit_Lo_Bo_VM516") && row["Bit_Lo_Bo_VM516"] != DBNull.Value
                                      ? Convert.ToBoolean(row["Bit_Lo_Bo_VM516"])
                                      : false
                };
                lista.Add(obra);
            }
            return lista;
        }
       

        public void GuardarEspecificacion_VM516(BE_Especificacion_Obra_VM516 obra)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString_VM516))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Especificacion_Obra_VM516 WHERE 1=0", conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Especificacion_Obra_VM516");
                
                DataRow row = ds.Tables["Especificacion_Obra_VM516"].NewRow();
                row["Id_Obra_VM516"] = obra.Id_Obra_VM516;
                row["DNI_Artista_VM516"] = obra.DNI_Artista_VM516;
                row["Titulo_Obra_VM516"] = obra.Titulo_Obra_VM516;
                row["Tecnica_VM516"] = obra.Tecnica_VM516;
                row["Alto_VM516"] = obra.Alto_VM516;
                row["Ancho_VM516"] = obra.Ancho_VM516;
                row["Peso_VM516"] = obra.Peso_VM516;
                row["Req_Iluminacion_VM516"] = obra.Req_Iluminacion_VM516;
                row["Valor_Declarado_Mercado_VM516"] = obra.Valor_Declarado_Mercado_VM516;
                row["Categoria_Seguro_VM516"] = obra.Categoria_Seguro_VM516;
                row["Estado_Asignacion_VM516"] = obra.Estado_Asignacion_VM516;
                row["Bit_Lo_Bo_VM516"] = obra.Bit_Lo_Bo_VM516;

                ds.Tables["Especificacion_Obra_VM516"].Rows.Add(row);

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(ds, "Especificacion_Obra_VM516");
            }
        }
        public void ModificarEspecificacion_VM516(BE_Especificacion_Obra_VM516 obra)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString_VM516))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Especificacion_Obra_VM516 WHERE Id_Obra_VM516 = @Id", conn);
                adapter.SelectCommand.Parameters.AddWithValue("@Id", obra.Id_Obra_VM516);

                DataSet ds = new DataSet();
                adapter.Fill(ds, "Especificacion_Obra_VM516");

                if (ds.Tables["Especificacion_Obra_VM516"].Rows.Count > 0)
                {
                    DataRow row = ds.Tables["Especificacion_Obra_VM516"].Rows[0];
                    row["DNI_Artista_VM516"] = obra.DNI_Artista_VM516;
                    row["Titulo_Obra_VM516"] = obra.Titulo_Obra_VM516;
                    row["Tecnica_VM516"] = obra.Tecnica_VM516;
                    row["Alto_VM516"] = obra.Alto_VM516;
                    row["Ancho_VM516"] = obra.Ancho_VM516;
                    row["Peso_VM516"] = obra.Peso_VM516;
                    row["Req_Iluminacion_VM516"] = obra.Req_Iluminacion_VM516;
                    row["Valor_Declarado_Mercado_VM516"] = obra.Valor_Declarado_Mercado_VM516;
                    row["Categoria_Seguro_VM516"] = obra.Categoria_Seguro_VM516;
                    row["Estado_Asignacion_VM516"] = obra.Estado_Asignacion_VM516;
                    row["Bit_Lo_Bo_VM516"] = obra.Bit_Lo_Bo_VM516;

                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    adapter.Update(ds, "Especificacion_Obra_VM516");
                }
            }
        }
        public List<BE_Especificacion_Obra_VM516> ListarEspecificaciones_VM516()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString_VM516))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Especificacion_Obra_VM516", conn);
                adapter.Fill(dt);
            }
            return MapearLista(dt);
        }
    }
}

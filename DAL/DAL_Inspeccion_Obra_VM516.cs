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
    public class DAL_Inspeccion_Obra_VM516
    {
        private readonly string _connectionString_VM516 = DAL_ConexionDB.ObtenerCadena();

        public DAL_Inspeccion_Obra_VM516() { }
        public void RegistrarInspeccion_VM516(BE_Inspeccion_Fisica_VM516 inspeccion)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString_VM516))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Inspeccion_Fisica_VM516 WHERE 1=0", conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Inspeccion_Fisica_VM516");

                DataRow row = ds.Tables["Inspeccion_Fisica_VM516"].NewRow();
                row["Codigo_Reserva_VM516"] = inspeccion.Codigo_Reserva_VM516;
                row["Estado_Post_Exhibicion_VM516"] = inspeccion.Estado_Post_Exhibicion_VM516;
                row["Observaciones_Fisicas_VM516"] = inspeccion.Observaciones_Fisicas_VM516;
                row["Fecha_Inspeccion_VM516"] = inspeccion.Fecha_Inspeccion_VM516;

                ds.Tables["Inspeccion_Fisica_VM516"].Rows.Add(row);

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(ds, "Inspeccion_Fisica_VM516");
            }
        }

        public List<BE_Inspeccion_Fisica_VM516> ListarInspecciones_VM516()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString_VM516))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Inspeccion_Fisica_VM516", conn);
                adapter.Fill(dt);
            }

            List<BE_Inspeccion_Fisica_VM516> lista = new List<BE_Inspeccion_Fisica_VM516>();
            foreach (DataRow row in dt.Rows)
            {
                BE_Inspeccion_Fisica_VM516 insp = new BE_Inspeccion_Fisica_VM516
                {
                    Codigo_Reserva_VM516 = row["Codigo_Reserva_VM516"].ToString(),
                    Estado_Post_Exhibicion_VM516 = row["Estado_Post_Exhibicion_VM516"].ToString(),
                    Observaciones_Fisicas_VM516 = row["Observaciones_Fisicas_VM516"].ToString(),
                    Fecha_Inspeccion_VM516 = Convert.ToDateTime(row["Fecha_Inspeccion_VM516"])
                };
                lista.Add(insp);
            }
            return lista;
        }
    }
}

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
    public class DAL_Retiro_Obra_VM516
    {
        private readonly string _connectionString_VM516 = DAL_ConexionDB.ObtenerCadena();

        public List<BE_Retiro_Obra_VM516> ListarRetiros_VM516()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString_VM516))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Codigo_Reserva_VM516, DNI_Responsable_Desmontaje_VM516, Fecha_Retiro_VM516 FROM Retiro_Obra_VM516", conn);
                adapter.Fill(dt);
            }

            List<BE_Retiro_Obra_VM516> lista = new List<BE_Retiro_Obra_VM516>();
            foreach (DataRow row in dt.Rows)
            {
                BE_Retiro_Obra_VM516 retiro = new BE_Retiro_Obra_VM516
                {
                    Codigo_Reserva_VM516 = row["Codigo_Reserva_VM516"].ToString(),
                    DNI_Responsable_Desmontaje_VM516 = row["DNI_Responsable_Desmontaje_VM516"].ToString(),
                    Fecha_Retiro_VM516 = Convert.ToDateTime(row["Fecha_Retiro_VM516"])
                };
                lista.Add(retiro);
            }
            return lista;
        }

        public void GuardarRetiro_VM516(BE_Retiro_Obra_VM516 retiro)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString_VM516))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT Codigo_Reserva_VM516, DNI_Responsable_Desmontaje_VM516, Fecha_Retiro_VM516 FROM Retiro_Obra_VM516 WHERE 1=0", conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Retiro_Obra_VM516");

                DataRow row = ds.Tables["Retiro_Obra_VM516"].NewRow();
                row["Codigo_Reserva_VM516"] = retiro.Codigo_Reserva_VM516;
                row["DNI_Responsable_Desmontaje_VM516"] = retiro.DNI_Responsable_Desmontaje_VM516;
                row["Fecha_Retiro_VM516"] = retiro.Fecha_Retiro_VM516;

                ds.Tables["Retiro_Obra_VM516"].Rows.Add(row);

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.InsertCommand = new SqlCommand("INSERT INTO Retiro_Obra_VM516 (Codigo_Reserva_VM516, DNI_Responsable_Desmontaje_VM516, Fecha_Retiro_VM516) VALUES (@Codigo, @Dni, @Fecha)", conn);
                adapter.InsertCommand.Parameters.Add("@Codigo", SqlDbType.VarChar, 50, "Codigo_Reserva_VM516");
                adapter.InsertCommand.Parameters.Add("@Dni", SqlDbType.VarChar, 20, "DNI_Responsable_Desmontaje_VM516");
                adapter.InsertCommand.Parameters.Add("@Fecha", SqlDbType.DateTime, 0, "Fecha_Retiro_VM516");

                adapter.Update(ds, "Retiro_Obra_VM516");
            }
        }
    }
}

using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Instalador
    {
        public DAL_Instalador()
        {
        }
        public static bool VerificarBaseDeDatos(string servidor, string nombreBD)
        {
            string masterConnStr = $"Data Source={servidor};Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True;";

          
            string consulta = "SELECT name FROM sys.databases WHERE name = @NombreBD";

            using (SqlConnection conn = new SqlConnection(masterConnStr))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(consulta, conn))
                {
                   
                    da.SelectCommand.Parameters.Add(new SqlParameter("@NombreBD", SqlDbType.VarChar) { Value = nombreBD });

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    return dt.Rows.Count > 0;
                }
            }
        }

 
        public static void EjecutarScriptPrimeraVez(string servidor, string contenidoScript)
        {
            string masterConnStr = $"Data Source={servidor};Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True;Connection Timeout=5;";

            string[] comandos = contenidoScript.Split(new[] { "GO\r\n", "GO\n", "GO " }, StringSplitOptions.RemoveEmptyEntries);

            using (SqlConnection conn = new SqlConnection(masterConnStr))
            {
                try
                {
                    conn.Open(); 
                }
                catch (SqlException)
                {
                    throw new Exception("No pudimos encontrar el servidor. Por favor, revisa que el nombre esté bien escrito.");
                }
                foreach (string comando in comandos)
                {
                    if (!string.IsNullOrWhiteSpace(comando))
                    {
                        using (SqlCommand cmd = new SqlCommand(comando, conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }
        public static void EliminarBaseDeDatosSiExiste(string servidor, string nombreBD)
        {
            string masterConnStr = $"Data Source={servidor};Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True;Connection Timeout=5;";

            string sqlDrop = $@"
        IF EXISTS (SELECT 1 FROM sys.databases WHERE name = @NombreBD)
        BEGIN
            ALTER DATABASE [{nombreBD}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
            DROP DATABASE [{nombreBD}];
        END";

            using (SqlConnection conn = new SqlConnection(masterConnStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(sqlDrop, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@NombreBD", SqlDbType.NVarChar, 128) { Value = nombreBD });
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static bool ExistenUsuariosEnBase(string servidor, string nombreBD = "BD_VanguardiaArte")
        {
            if (string.IsNullOrWhiteSpace(servidor))
                return false;

            string connStr = $"Data Source={servidor};Initial Catalog={nombreBD};Integrated Security=True;TrustServerCertificate=True;Connection Timeout=3;";

            string query = @"
        SELECT COUNT(1)
        FROM [dbo].[Usuario]
        WHERE ISNULL(Activo, 1) = 1";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    int cantidad = (result != null && result != DBNull.Value) ? Convert.ToInt32(result) : 0;
                    return cantidad > 0;
                }
            }
        }
    }
}

using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Respaldo
    {
        private readonly string connMaster = DAL_ConexionDB.ObtenerCadenaMaster(null);

        private readonly string connBD = DAL_ConexionDB.ObtenerCadena();

           
        public DAL_Respaldo()
        {

        }

        public void EjecutarBackup(string rutaCompleta)
        {
            using (SqlConnection conn = new SqlConnection(connBD))
            {
                string sql = "BACKUP DATABASE [BD_VanguardiaArte] TO DISK = @path";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@path", rutaCompleta);

                conn.Open();
                cmd.CommandTimeout = 0;

                cmd.ExecuteNonQuery();
            }
        }

        public void EjecutarRestore(string rutaCompleta)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connMaster))
                {
                    conn.Open();

                    DataTable archivos = ObtenerLogicalNames(conn, rutaCompleta);

                    if (archivos.Rows.Count < 2)
                        throw new Exception("El archivo de respaldo no es válido o está dañado.");

                    string logicalData = archivos.Rows[0]["LogicalName"].ToString();
                    string logicalLog = archivos.Rows[1]["LogicalName"].ToString();
                    string rutaDatos = ObtenerRutaDatosSQL(conn);
                    string archivoMDF = Path.Combine(rutaDatos, "BD_VanguardiaArte.mdf");
                    string archivoLDF = Path.Combine(rutaDatos, "BD_VanguardiaArte_log.ldf");

                    string sqlRestore = ConstruirRestoreSQL(
                        rutaCompleta,
                        logicalData,
                        logicalLog,
                        archivoMDF,
                        archivoLDF);

                    SqlCommand cmd = new SqlCommand(sqlRestore, conn);
                    cmd.CommandTimeout = 0;

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
               
                try
                {
                    using (SqlConnection conn = new SqlConnection(connMaster))
                    {
                        conn.Open();

                        SqlCommand cmd = new SqlCommand(
                            "ALTER DATABASE [BD_VanguardiaArte] SET MULTI_USER",
                            conn);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch
                {
                    
                }

                throw new Exception( "No fue posible restaurar la base de datos.\n\n" + ex.Message);
 
            }
        }

        private DataTable ObtenerLogicalNames(SqlConnection conn, string rutaCompleta)
        {
            DataTable archivos = new DataTable();

            string sql = $"RESTORE FILELISTONLY FROM DISK = '{rutaCompleta}'";
  
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            da.Fill(archivos);

            return archivos;
        }

        private string ObtenerRutaDatosSQL(SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand( "SELECT SERVERPROPERTY('InstanceDefaultDataPath')", conn);
               
            string ruta = cmd.ExecuteScalar()?.ToString();

            if (string.IsNullOrEmpty(ruta))
            {
                cmd = new SqlCommand(@"
                SELECT SUBSTRING(physical_name,1,
                LEN(physical_name)-CHARINDEX('\',REVERSE(physical_name))+1)
                FROM sys.master_files
                WHERE database_id = DB_ID('master')
                AND file_id = 1", conn);

                ruta = cmd.ExecuteScalar().ToString();
            }

            return ruta;
        }

        private string ConstruirRestoreSQL( string rutaBackup,string logicalData,string logicalLog, string archivoMDF,string archivoLDF)
        {
            return $@"
                ALTER DATABASE [BD_VanguardiaArte]
                SET SINGLE_USER
                WITH ROLLBACK IMMEDIATE;

                RESTORE DATABASE [BD_VanguardiaArte]
                FROM DISK = '{rutaBackup}'
                WITH REPLACE,
                MOVE '{logicalData}' TO '{archivoMDF}',
                MOVE '{logicalLog}' TO '{archivoLDF}';

                ALTER DATABASE [BD_VanguardiaArte]
                SET MULTI_USER;";
        }
    }
}

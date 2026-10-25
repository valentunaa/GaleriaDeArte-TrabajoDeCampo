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
    public class DAL_Especificacion_Obra_C_VM516
    {
        private readonly string _connectionString_VM516 = DAL_ConexionDB.ObtenerCadena();

        public List<BE_Especificacion_Obra_C_VM516> MapearListaHistorial(DataTable dt_VM516)
        {
            List<BE_Especificacion_Obra_C_VM516> lista_VM516 = new List<BE_Especificacion_Obra_C_VM516>();

            foreach (DataRow row_VM516 in dt_VM516.Rows)
            {
                BE_Especificacion_Obra_C_VM516 item_VM516 = new BE_Especificacion_Obra_C_VM516(
                    Convert.ToInt32(row_VM516["Id_Cambio_VM516"]),
                    Convert.ToInt32(row_VM516["Id_Obra_VM516"]),
                    row_VM516["DNI_Artista_VM516"].ToString(),
                    row_VM516["Titulo_Obra_VM516"].ToString(),
                    row_VM516["Tecnica_VM516"].ToString(),
                    Convert.ToDecimal(row_VM516["Alto_VM516"]),
                    Convert.ToDecimal(row_VM516["Ancho_VM516"]),
                    Convert.ToDecimal(row_VM516["Peso_VM516"]),
                    row_VM516["Req_Iluminacion_VM516"].ToString(),
                    Convert.ToDecimal(row_VM516["Valor_Declarado_Mercado_VM516"]),
                    row_VM516["Categoria_Seguro_VM516"].ToString(),
                    row_VM516["Estado_Asignacion_VM516"].ToString(),
                    Convert.ToBoolean(row_VM516["Bit_Lo_Bo_VM516"]),
                    Convert.ToDateTime(row_VM516["Fecha_VM516"]),
                    Convert.ToBoolean(row_VM516["Activo_VM516"])
                );
                lista_VM516.Add(item_VM516);
            }

            return lista_VM516;
        }

        // Listar y Filtrar la Bitácora de Cambios (ID de Obra, Título/Nombre y Fechas)
        public List<BE_Especificacion_Obra_C_VM516> ObtenerHistorialFiltrado_VM516(string idObra_VM516, string titulo_VM516, DateTime? fechaIni_VM516, DateTime? fechaFin_VM516)
        {
            using (SqlConnection conn_VM516 = new SqlConnection(_connectionString_VM516))
            {
                string query_VM516 = "SELECT * FROM Especificacion_Obra_C_VM516 WHERE 1=1";
                SqlCommand cmd_VM516 = new SqlCommand();

                if (!string.IsNullOrWhiteSpace(idObra_VM516))
                {
                    query_VM516 += " AND CAST(Id_Obra_VM516 AS VARCHAR) LIKE @IdObra";
                    cmd_VM516.Parameters.Add("@IdObra", SqlDbType.VarChar).Value = $"%{idObra_VM516.Trim()}%";
                }

                if (!string.IsNullOrWhiteSpace(titulo_VM516))
                {
                    query_VM516 += " AND Titulo_Obra_VM516 LIKE @Titulo";
                    cmd_VM516.Parameters.Add("@Titulo", SqlDbType.VarChar).Value = $"%{titulo_VM516.Trim()}%";
                }

                if (fechaIni_VM516.HasValue && fechaFin_VM516.HasValue)
                {
                    query_VM516 += " AND Fecha_VM516 BETWEEN @FechaIni AND @FechaFin";
                    cmd_VM516.Parameters.Add("@FechaIni", SqlDbType.DateTime).Value = fechaIni_VM516.Value.Date;
                    cmd_VM516.Parameters.Add("@FechaFin", SqlDbType.DateTime).Value = fechaFin_VM516.Value.Date.AddDays(1).AddSeconds(-1);
                }

                query_VM516 += " ORDER BY Fecha_VM516 DESC";

                cmd_VM516.CommandText = query_VM516;
                cmd_VM516.Connection = conn_VM516;

                SqlDataAdapter da_VM516 = new SqlDataAdapter(cmd_VM516);
                DataTable dt_VM516 = new DataTable();
                da_VM516.Fill(dt_VM516);

                return MapearListaHistorial(dt_VM516);
            }
        }

        // Botón "ACTIVAR" con ADO.NET Desconectado: asegura que solo 1 registro del grupo quede con Activo = 1
        public void ActivarRegistroHistorico_VM516(int idCambio_VM516)
        {
            using (SqlConnection conn_VM516 = new SqlConnection(_connectionString_VM516))
            {
                // 1. Consultamos todos los registros históricos de la MISMA obra en una estructura desconectada
                string query = @"SELECT Id_Cambio_VM516, Id_Obra_VM516, Activo_VM516 
                                 FROM Especificacion_Obra_C_VM516 
                                 WHERE Id_Obra_VM516 = (SELECT Id_Obra_VM516 FROM Especificacion_Obra_C_VM516 WHERE Id_Cambio_VM516 = @Id)";

                SqlDataAdapter da_VM516 = new SqlDataAdapter(query, conn_VM516);
                da_VM516.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value = idCambio_VM516;

                // 2. Definimos el comando de actualización (UpdateCommand) para el adaptador
                da_VM516.UpdateCommand = new SqlCommand(
                    "UPDATE Especificacion_Obra_C_VM516 SET Activo_VM516 = @Activo WHERE Id_Cambio_VM516 = @IdCambioUpd",
                    conn_VM516);
                da_VM516.UpdateCommand.Parameters.Add("@Activo", SqlDbType.Bit, 1, "Activo_VM516");
                da_VM516.UpdateCommand.Parameters.Add("@IdCambioUpd", SqlDbType.Int, 4, "Id_Cambio_VM516");

                DataTable dt_VM516 = new DataTable();
                da_VM516.Fill(dt_VM516);

                // 3. Modificamos los estados de las filas directamente en la memoria local (DataTable)
                foreach (DataRow row in dt_VM516.Rows)
                {
                    int currentId = Convert.ToInt32(row["Id_Cambio_VM516"]);

                    if (currentId == idCambio_VM516)
                    {
                        row["Activo_VM516"] = true;  // Activamos la versión elegida
                    }
                    else
                    {
                        row["Activo_VM516"] = false; // Apagamos el resto de versiones de esta obra
                    }
                }

                // 4. Sincronizamos los cambios desde la memoria hacia la base de datos (disparando el RollBack)
                da_VM516.Update(dt_VM516);
            }
        }
    }
    
}

using Microsoft.Data.SqlClient;
using Servicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DAL
{
    public class DAL_DigitoVerificador
    {
        private string cadenaConexion = DAL_ConexionDB.ObtenerCadena();
        public void EliminarRegistroDigito(string nombreFila)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                // 1. Configuramos el SelectCommand
                string selectQuery = "SELECT Nombre, DVV, DVH FROM DIGITOVERIFICADOR WHERE Nombre = @Nombre";
                SqlDataAdapter da = new SqlDataAdapter(selectQuery, conn);
                da.SelectCommand.Parameters.AddWithValue("@Nombre", nombreFila);

                // 2. Configuramos el DeleteCommand (CON PARÁMETROS EXPLÍCITOS)
                da.DeleteCommand = new SqlCommand("DELETE FROM DIGITOVERIFICADOR WHERE Nombre = @Nombre", conn);

                // Mapeo explícito: el 4to parámetro ("Nombre") indica de qué columna del DataTable saca el valor
                da.DeleteCommand.Parameters.Add("@Nombre", SqlDbType.NVarChar, 255, "Nombre");

                // 3. Llenamos el DataTable (Modo Desconectado)
                DataTable dt = new DataTable();
                da.Fill(dt);

                // 4. Modificamos los datos en memoria
                if (dt.Rows.Count > 0)
                {
                    // Marca la fila con el estado 'Deleted' (No la remueve de la colección inmediatamente)
                    dt.Rows[0].Delete();
                }

                // 5. Sincronizamos los cambios hacia la base de datos
                da.Update(dt);
            }
        }
        public Servicio_DigitoVerificadorVertical ObtenerRegistroDigito(string nombre)
        {
            Servicio_DigitoVerificadorVertical entidad = null;

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = "SELECT Nombre, DVV, DVH FROM DIGITOVERIFICADOR WHERE Nombre = @Nombre";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Nombre", nombre);

                DataTable dt = new DataTable();

                // 1. Fill: Se conecta, trae los datos y se desconecta
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    entidad = new Servicio_DigitoVerificadorVertical();
                    entidad.Nombre = row["Nombre"].ToString();
                    entidad.DVV = row["DVV"] != DBNull.Value ? row["DVV"].ToString() : null;
                    entidad.DVH = row["DVH"] != DBNull.Value ? row["DVH"].ToString() : null;
                }
            }

            return entidad;
        }


        public void GuardarDVH(Servicio_DigitoVerificadorVertical registro)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery = "SELECT Nombre, DVV, DVH FROM DIGITOVERIFICADOR WHERE Nombre = @Nombre";
                SqlDataAdapter da = new SqlDataAdapter(selectQuery, conn);
                da.SelectCommand.Parameters.AddWithValue("@Nombre", registro.Nombre);

                // Configuración de comandos parametrizados para el Update
                da.InsertCommand = new SqlCommand("INSERT INTO DIGITOVERIFICADOR (Nombre, DVH) VALUES (@Nombre, @DVH)", conn);
                da.InsertCommand.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100, "Nombre");
                da.InsertCommand.Parameters.Add("@DVH", SqlDbType.NVarChar, 100, "DVH");

                da.UpdateCommand = new SqlCommand("UPDATE DIGITOVERIFICADOR SET DVH = @DVH WHERE Nombre = @Nombre", conn);
                da.UpdateCommand.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100, "Nombre");
                da.UpdateCommand.Parameters.Add("@DVH", SqlDbType.NVarChar, 100, "DVH");

                DataTable dt = new DataTable();

                // 1. Fill (Estado conectado brevemente)
                da.Fill(dt);

                // 2. ModificarFilaLocal (Estado desconectado)
                if (dt.Rows.Count > 0)
                {
                    dt.Rows[0]["DVH"] = registro.DVH; // Actualiza la fila existente
                }
                else
                {
                    DataRow nuevaFila = dt.NewRow(); // Crea una nueva fila
                    nuevaFila["Nombre"] = registro.Nombre;
                    nuevaFila["DVH"] = registro.DVH;
                    dt.Rows.Add(nuevaFila);
                }

                // 3. Update (Se reconecta y sincroniza los cambios)
                da.Update(dt);
            }
        }

        // =================================================================
        // Guardar DVV (Maestro)
        // =================================================================
        public void GuardarDVV(Servicio_DigitoVerificadorVertical registroMaestro)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery = "SELECT Nombre, DVV, DVH FROM DIGITOVERIFICADOR WHERE Nombre = @Nombre";
                SqlDataAdapter da = new SqlDataAdapter(selectQuery, conn);
                da.SelectCommand.Parameters.AddWithValue("@Nombre", registroMaestro.Nombre);

                // Mapeo EXPLÍCITO: el 4to parámetro es el nombre de la columna en el DataTable
                da.InsertCommand = new SqlCommand("INSERT INTO DIGITOVERIFICADOR (Nombre, DVV) VALUES (@Nombre, @DVV)", conn);
                da.InsertCommand.Parameters.Add("@Nombre", SqlDbType.NVarChar, 255, "Nombre");
                da.InsertCommand.Parameters.Add("@DVV", SqlDbType.NVarChar, 255, "DVV");

                da.UpdateCommand = new SqlCommand("UPDATE DIGITOVERIFICADOR SET DVV = @DVV WHERE Nombre = @Nombre", conn);
                da.UpdateCommand.Parameters.Add("@Nombre", SqlDbType.NVarChar, 255, "Nombre");
                da.UpdateCommand.Parameters.Add("@DVV", SqlDbType.NVarChar, 255, "DVV");

                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dt.Rows[0]["DVV"] = registroMaestro.DVV;
                    dt.Rows[0]["Nombre"] = registroMaestro.Nombre;
                }
                else
                {
                    DataRow nuevaFila = dt.NewRow();
                    nuevaFila["Nombre"] = registroMaestro.Nombre;
                    nuevaFila["DVV"] = registroMaestro.DVV;
                    nuevaFila["DVH"] = DBNull.Value; // Importante
                    dt.Rows.Add(nuevaFila);
                }

                da.Update(dt);
            }
        }
        public List<string> ObtenerRegistrosDVH(string nombreTabla)
        {
            List<string> registros = new List<string>();

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string query = @"SELECT Nombre
                         FROM DIGITOVERIFICADOR
                         WHERE Nombre LIKE @Tabla
                         AND Nombre <> @Maestro";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);

                da.SelectCommand.Parameters.AddWithValue("@Tabla", nombreTabla + "_%");
                da.SelectCommand.Parameters.AddWithValue("@Maestro", nombreTabla + "_MAESTRO");

                DataTable dt = new DataTable();

                da.Fill(dt);

                foreach (DataRow fila in dt.Rows)
                {
                    registros.Add(fila["Nombre"].ToString());
                }
            }

            return registros;
        }


        public void EliminarDVHDeTabla(string nombreTabla)
        {
            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            {
                string select = @"SELECT Nombre, DVV, DVH
                          FROM DIGITOVERIFICADOR
                          WHERE Nombre LIKE @Tabla
                          AND Nombre <> @Maestro";

                SqlDataAdapter da = new SqlDataAdapter(select, conn);

                da.SelectCommand.Parameters.AddWithValue("@Tabla", nombreTabla + "_%");
                da.SelectCommand.Parameters.AddWithValue("@Maestro", nombreTabla + "_MAESTRO");

                da.DeleteCommand = new SqlCommand(
                    "DELETE FROM DIGITOVERIFICADOR WHERE Nombre = @Nombre", conn);

                da.DeleteCommand.Parameters.Add("@Nombre", SqlDbType.NVarChar, 255, "Nombre");

                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow fila in dt.Rows)
                {
                    fila.Delete();
                }

                da.Update(dt);
            }
        }




       
    }
    
}

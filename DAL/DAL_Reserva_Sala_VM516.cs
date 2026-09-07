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
    public class DAL_Reserva_Sala_VM516
    {
        private readonly string _connectionString_VM516 = DAL_ConexionDB.ObtenerCadena();

        public List<BE_Reserva_Sala_VM516> MapearLista(DataTable dt)
        {
            List<BE_Reserva_Sala_VM516> lista = new List<BE_Reserva_Sala_VM516>();

            foreach (DataRow row in dt.Rows)
            {
                BE_Reserva_Sala_VM516 reserva = new BE_Reserva_Sala_VM516
                {
                    Codigo_Reserva_VM516 = row["Codigo_Reserva_VM516"].ToString(),
                    Codigo_Sala_VM516 = row["Codigo_Sala_VM516"].ToString(),
                    Id_Obra_VM516 = Convert.ToInt32(row["Id_Obra_VM516"]),
                    Fecha_Inicio_VM516 = Convert.ToDateTime(row["Fecha_Inicio_VM516"]),
                    Fecha_Fin_VM516 = Convert.ToDateTime(row["Fecha_Fin_VM516"]),
                    Monto_Alquiler_Total_VM516 = Convert.ToDecimal(row["Monto_Alquiler_Total_VM516"]),
                    Porcentaje_Sena_VM516 = Convert.ToDecimal(row["Porcentaje_Sena_VM516"]),
                    Saldo_Restante_A_Pagar_VM516 = Convert.ToDecimal(row["Saldo_Restante_A_Pagar_VM516"]),
                    Estado_Espacio_VM516 = row["Estado_Espacio_VM516"].ToString(),
                    Estado_Pago_VM516 = row["Estado_Pago_VM516"].ToString()
                };
                lista.Add(reserva);
            }
            return lista;
        }
        public List<BE_Sala_VM516> MapearSalas(DataTable dt)
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
        public List<BE_Sala_VM516> ObtenerSalasDisponiblesPorObra_VM516(DateTime inicio, DateTime fin, decimal alto, decimal ancho, decimal peso, string iluminacion)
        {
            DataTable tabla = new DataTable();
            string consulta = @"SELECT * FROM Sala_VM516 
                        WHERE Alto_Max_Soportado_VM516 >= @Alto 
                          AND Ancho_Max_Soportado_VM516 >= @Ancho 
                          AND Peso_Max_Soportado_VM516 >= @Peso 
                          AND Tipo_Iluminacion_Disponible_VM516 = @Iluminacion 
                          AND Codigo_Sala_VM516 NOT IN (
                              SELECT Codigo_Sala_VM516 FROM Reserva_Sala_VM516 
                              WHERE NOT (Fecha_Fin_VM516 < @FechaInicio OR Fecha_Inicio_VM516 > @FechaFin)
                          )";

            using (SqlConnection conexion = new SqlConnection(_connectionString_VM516))
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Alto", alto);
                    comando.Parameters.AddWithValue("@Ancho", ancho);
                    comando.Parameters.AddWithValue("@Peso", peso);
                    comando.Parameters.AddWithValue("@Iluminacion", iluminacion);
                    comando.Parameters.AddWithValue("@FechaInicio", inicio);
                    comando.Parameters.AddWithValue("@FechaFin", fin);

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            return MapearSalas(tabla);
        }
        public void GuardarReserva_VM516(BE_Reserva_Sala_VM516 reserva)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString_VM516))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Reserva_Sala_VM516 WHERE 1=0", conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Reserva_Sala_VM516");

                DataRow row = ds.Tables["Reserva_Sala_VM516"].NewRow();
                row["Codigo_Reserva_VM516"] = reserva.Codigo_Reserva_VM516;
                row["Codigo_Sala_VM516"] = reserva.Codigo_Sala_VM516;
                row["Id_Obra_VM516"] = reserva.Id_Obra_VM516;
                row["Fecha_Inicio_VM516"] = reserva.Fecha_Inicio_VM516;
                row["Fecha_Fin_VM516"] = reserva.Fecha_Fin_VM516;
                row["Monto_Alquiler_Total_VM516"] = reserva.Monto_Alquiler_Total_VM516;
                row["Porcentaje_Sena_VM516"] = reserva.Porcentaje_Sena_VM516;
                row["Saldo_Restante_A_Pagar_VM516"] = reserva.Saldo_Restante_A_Pagar_VM516;
                row["Estado_Espacio_VM516"] = reserva.Estado_Espacio_VM516;
                row["Estado_Pago_VM516"] = reserva.Estado_Pago_VM516;

                ds.Tables["Reserva_Sala_VM516"].Rows.Add(row);

                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(ds, "Reserva_Sala_VM516");
            }
        }

        public DataTable ObtenerSalasDisponibles_VM516(DateTime inicio, DateTime fin, decimal alto, decimal ancho, decimal peso, string iluminacion)
        {
            DataTable tabla = new DataTable();
            string consulta = @"SELECT * FROM Sala 
                                WHERE Alto_Max_Soportado >= @Alto 
                                  AND Ancho_Max_Soportado >= @Ancho 
                                  AND Peso_Max_Soportado >= @Peso 
                                  AND Tipo_Iluminacion_Disponible = @Iluminacion 
                                  AND Codigo_Sala NOT IN (
                                      SELECT Codigo_Sala_VM516 FROM Reserva_Sala_VM516 
                                      WHERE NOT (Fecha_Fin_VM516 < @FechaInicio OR Fecha_Inicio_VM516 > @FechaFin)
                                  )";

            using (SqlConnection conexion = new SqlConnection(_connectionString_VM516))
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Alto", alto);
                    comando.Parameters.AddWithValue("@Ancho", ancho);
                    comando.Parameters.AddWithValue("@Peso", peso);
                    comando.Parameters.AddWithValue("@Iluminacion", iluminacion);
                    comando.Parameters.AddWithValue("@FechaInicio", inicio);
                    comando.Parameters.AddWithValue("@FechaFin", fin);

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }
            return tabla;
        }

        public List<BE_Reserva_Sala_VM516> ListarReservas_VM516()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString_VM516))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Reserva_Sala_VM516", conn);
                adapter.Fill(dt);
            }
            return MapearLista(dt);
        }
    }
}


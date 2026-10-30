using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Instalador
    {

        private DAL_ConexionDB dalConexion = new DAL_ConexionDB();

        public List<string> ObtenerListaServidores()
        {
            List<string> lista = new List<string>();
            DataTable table = dalConexion.ObtenerServidoresRed();

            foreach (DataRow row in table.Rows)
            {
                string serverName = row["ServerName"].ToString();
                string instanceName = row["InstanceName"].ToString();

                if (string.IsNullOrEmpty(instanceName))
                    lista.Add(serverName);
                else
                    lista.Add($"{serverName}\\{instanceName}");
            }

            if (lista.Count == 0)
            {
                lista.Add(".");
                lista.Add(".\\SQLEXPRESS");
            }

            return lista;
        } 

        public void InstalarBaseDeDatos(string servidorElegido, string script = "")
        {
            bool baseYaExiste = DAL_ConexionDB.VerificarBaseDatosExistente(servidorElegido);

            if (!baseYaExiste)
            {
                dalConexion.EjecutarScriptSQL(script, servidorElegido);
            }

            string configFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Configuracion");

            if (!Directory.Exists(configFolder))
            {
                Directory.CreateDirectory(configFolder);
            }

            string configPath = Path.Combine(configFolder, "servidor_config.txt");
            File.WriteAllText(configPath, servidorElegido);

            string banderaPath = Path.Combine(configFolder, "bandera.txt");
            File.WriteAllText(banderaPath, "INSTALADO OK - " + DateTime.Now);
        }

        public bool EsNecesarioInstalar()
        {

            try
            {
                string configFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Configuracion");
                string configPath = Path.Combine(configFolder, "servidor_config.txt");

                // ESCENARIO A: El archivo existe (El camino normal)
                if (File.Exists(configPath))
                {
                    string servidorGuardado = File.ReadAllText(configPath).Trim();

                    // Verificamos si la base está en el servidor que habíamos guardado
                    if (DAL_ConexionDB.VerificarBaseDatosExistente(servidorGuardado))
                    {
                        return false; // Todo en orden, saltea el instalador
                    }
                }
                else
                {
                    // ESCENARIO B: Borraste la carpeta o estás en una PC nueva con la base ya cargada a mano
                    // Hacemos que busque "a ciegas" en los servidores locales por defecto.

                    if (DAL_ConexionDB.VerificarBaseDatosExistente(".\\SQLEXPRESS"))
                    {
                        RestaurarArchivos(configFolder, configPath, ".\\SQLEXPRESS");
                        return false;
                    }

                    if (DAL_ConexionDB.VerificarBaseDatosExistente("."))
                    {
                        RestaurarArchivos(configFolder, configPath, ".");
                        return false;
                    }
                }

                // Si probó todo y no encontró la base de datos por ningún lado, hay que instalar.
                return true;
            }
            catch
            {
                // Si el SQL Server está apagado o tira error de red, forzamos el form por seguridad
                return true;
            }
        }
        private void RestaurarArchivos(string carpeta, string archivoConfig, string servidorEncontrado)
        {
            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }
            File.WriteAllText(archivoConfig, servidorEncontrado);
            File.WriteAllText(Path.Combine(carpeta, "bandera.txt"), "RECUPERADO AUTOMÁTICAMENTE - " + DateTime.Now);
        }
    }
}

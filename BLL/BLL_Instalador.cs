using DAL;
using System.IO;
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

        public void InstalarBaseDeDatos(string servidorElegido, string script = "", bool forzarLimpia = false, string nombreBD = "VanguardiaArte")
        {
            if (forzarLimpia)
            {
                DAL_Instalador.EliminarBaseDeDatosSiExiste(servidorElegido, nombreBD);
                dalConexion.EjecutarScriptSQL(script, servidorElegido);
            }
            else
            {
                bool baseYaExiste = DAL_ConexionDB.VerificarBaseDatosExistente(servidorElegido);

                if (!baseYaExiste)
                {
                    dalConexion.EjecutarScriptSQL(script, servidorElegido);
                }
            }

            string rutaPublica = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string configFolder = Path.Combine(rutaPublica, "VanguardiaArte", "Configuracion");

            if (!Directory.Exists(configFolder))
            {
                Directory.CreateDirectory(configFolder);
            }

            string configPath = Path.Combine(configFolder, "servidor_config.txt");
            File.WriteAllText(configPath, servidorElegido);

            string banderaPath = Path.Combine(configFolder, "bandera.txt");
            File.WriteAllText(banderaPath, forzarLimpia ? "INSTALADO LIMPIO - " + DateTime.Now : "INSTALADO OK - " + DateTime.Now);

            string flagLimpiaPath = Path.Combine(configFolder, "forzar_bd_limpia.flag");
            if (File.Exists(flagLimpiaPath))
            {
                File.Delete(flagLimpiaPath);
            }
        }

        public bool EsNecesarioInstalar()
        {

            try
            {
                string rutaPublica = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                string configFolder = Path.Combine(rutaPublica, "VanguardiaArte", "Configuracion");
                string flagLimpiaPath = Path.Combine(configFolder, "forzar_bd_limpia.flag");
                string configPath = Path.Combine(configFolder, "servidor_config.txt");

                // Si se eligió instalación desde cero en el instalador, siempre pasamos por Configuración Inicial
                if (File.Exists(flagLimpiaPath))
                {
                    return true;
                }

                // ESCENARIO A: El archivo existe (El camino normal / reinstalación)
                if (File.Exists(configPath))
                {
                    string servidorGuardado = File.ReadAllText(configPath).Trim();

                    if (DAL_ConexionDB.VerificarBaseDatosExistente(servidorGuardado))
                    {
                        return false;
                    }
                }
                else
                {
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

                return true;
            }
            catch
            {
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
        public void LimpiarFlagBackupInstalacion()
        {
            string rutaPublica = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string flagPath = Path.Combine(rutaPublica, "VanguardiaArte", "Configuracion", "hacer_backup_instalacion.flag");
            if (File.Exists(flagPath))
            {
                File.Delete(flagPath);
            }
        }

        public void LimpiarFlagsReinstalacion()
        {
            string rutaPublica = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string configFolder = Path.Combine(rutaPublica, "VanguardiaArte", "Configuracion");

            string flagReinstalar = Path.Combine(configFolder, "reinstalacion.flag");
            if (File.Exists(flagReinstalar))
            {
                File.Delete(flagReinstalar);
            }

            string flagBackup = Path.Combine(configFolder, "cargar_backup_reinstalacion.flag");
            if (File.Exists(flagBackup))
            {
                File.Delete(flagBackup);
            }
        }

        public bool DebeHacerBackupInstalacion()
        {
            string rutaPublica = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string flagPath = Path.Combine(rutaPublica, "VanguardiaArte", "Configuracion", "hacer_backup_instalacion.flag");
            return File.Exists(flagPath);
        }

        public bool DebeCargarBackupReinstalacion()
        {
            string rutaPublica = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            string flagPath = Path.Combine(rutaPublica, "VanguardiaArte", "Configuracion", "cargar_backup_reinstalacion.flag");
            return File.Exists(flagPath);
        }
        public bool ExistenUsuariosEnBase(string nombreBD = "BD_VanguardiaArte")
        {
            try
            {
                string rutaPublica = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                string configPath = Path.Combine(rutaPublica, "VanguardiaArte", "Configuracion", "servidor_config.txt");

                List<string> servidoresCandidatos = new List<string>();

                if (File.Exists(configPath))
                {
                    string servidorGuardado = File.ReadAllText(configPath).Trim();
                    if (!string.IsNullOrWhiteSpace(servidorGuardado))
                        servidoresCandidatos.Add(servidorGuardado);
                }

                servidoresCandidatos.Add(".");
                servidoresCandidatos.Add(".\\SQLEXPRESS");

                foreach (string srv in servidoresCandidatos.Distinct())
                {
                    try
                    {
                        if (DAL_Instalador.ExistenUsuariosEnBase(srv, nombreBD))
                            return true;
                    }
                    catch
                    {
                        // Probamos el siguiente servidor candidato
                    }
                }

                return false;
            }
            catch
            {
                return false;
            }
        }

    }
}

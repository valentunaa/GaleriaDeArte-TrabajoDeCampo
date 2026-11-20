using BLL;
using System.IO;
using Microsoft.Data.Sql;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IU
{
    public partial class FormPrimeraVez : Form
    {
        private BLL_Instalador bllInstalador = new BLL_Instalador();
        public FormPrimeraVez()
        {
            InitializeComponent();
        }

        private void FormPrimeraVez_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            listaServidores.Items.Clear();

            try
            {
                List<string> servidores = bllInstalador.ObtenerListaServidores();

                foreach (string srv in servidores)
                {
                    listaServidores.Items.Add(srv);
                }

                if (servidores.Count == 2 && servidores.Contains("."))
                {
                    MessageBox.Show("No se detectaron servidores automáticamente en la red. Se agregaron las opciones locales por defecto ( . y .\\SQLEXPRESS ). También puedes escribir el nombre manualmente.", "Búsqueda finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (servidores.Count > 0)
                {
                    // Si encontró servidores reales en la red, selecciona el primero automáticamente
                    listaServidores.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar servidores: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (listaServidores.SelectedItem == null && string.IsNullOrWhiteSpace(listaServidores.Text))
            {
                MessageBox.Show("Por favor, selecciona o escribe el nombre de un servidor SQL.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si seleccionó uno de la lista usa ese, si no, usa el que escribió a mano
            string servidorElegido = listaServidores.SelectedItem != null ? listaServidores.SelectedItem.ToString() : listaServidores.Text.Trim();

            this.Cursor = Cursors.WaitCursor;
            btnGuardar.Enabled = false;

            try
            {
                string script = null;
                var assembly = typeof(FormPrimeraVez).Assembly;

                string nombreRecurso = assembly.GetManifestResourceNames()
                    .FirstOrDefault(r => r.EndsWith("SetupData.sql", StringComparison.OrdinalIgnoreCase));

                if (!string.IsNullOrEmpty(nombreRecurso))
                {
                    using Stream stream = assembly.GetManifestResourceStream(nombreRecurso);
                    if (stream != null)
                    {
                        using StreamReader reader = new StreamReader(stream);
                        script = reader.ReadToEnd();
                    }
                }

                if (string.IsNullOrWhiteSpace(script))
                {
                    string rutaArchivo = Path.Combine(AppContext.BaseDirectory, "SetupData.sql");
                    if (File.Exists(rutaArchivo))
                    {
                        script = File.ReadAllText(rutaArchivo);
                    }
                }

                if (string.IsNullOrWhiteSpace(script))
                    throw new Exception($"No se encontró SetupData.sql. Buscado en: {Path.Combine(AppContext.BaseDirectory, "SetupData.sql")}");


                string configFolder = Path.Combine(
    Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
    "VanguardiaArte",
    "Configuracion"
);
                string flagLimpiaPath = Path.Combine(configFolder, "forzar_bd_limpia.flag");
                bool forzarLimpia = File.Exists(flagLimpiaPath);


                bllInstalador.InstalarBaseDeDatos(servidorElegido, script, forzarLimpia, "BD_VanguardiaArte");
                BLL_DigitoVerificador bllDV = new BLL_DigitoVerificador();
                bllDV.RecalcularDigitos("Sistema");
                MessageBox.Show(
                    "¡Base de datos instalada y configurada con éxito! A continuación se abrirá la pantalla para crear el primer usuario.",
                    "Configuración Completa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Instalación", MessageBoxButtons.OK, MessageBoxIcon.Error);

                btnGuardar.Enabled = true;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }


    }
}

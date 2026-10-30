using BLL;
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
                MessageBox.Show("Por favor, selecciona o escribe el nombre de un servidor SQL.","Atención",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;       
            }

            // Si seleccionó uno de la lista usa ese, si no, usa el que escribió a mano
            string servidorElegido = listaServidores.SelectedItem != null ? listaServidores.SelectedItem.ToString() : listaServidores.Text.Trim();

            this.Cursor = Cursors.WaitCursor;
            btnGuardar.Enabled = false;

            try
            {
                var assembly = typeof(FormPrimeraVez).Assembly;

                using Stream stream = assembly.GetManifestResourceStream("IU.SetupData.sql");

                if (stream == null)
                    throw new Exception("No se encontró el recurso SetupData.sql. Verifica que esté marcado como 'Recurso incrustado'.");

                using StreamReader reader = new StreamReader(stream);
                string script = reader.ReadToEnd();

                bllInstalador.InstalarBaseDeDatos(servidorElegido, script);

                MessageBox.Show("¡Base de datos instalada y configurada con éxito!","Configuración Completa",MessageBoxButtons.OK,MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error de Instalación", MessageBoxButtons.OK,MessageBoxIcon.Error);

                btnGuardar.Enabled = true;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }


    }
}

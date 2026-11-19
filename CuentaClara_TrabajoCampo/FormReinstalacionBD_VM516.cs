using BLL;
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
    public partial class FormReinstalacionBD_VM516 : Form
    {

        private readonly BLL_Respaldo _bllRespaldo = new BLL_Respaldo();
        private readonly BLL_Instalador _bllInstalador = new BLL_Instalador();
        public FormReinstalacionBD_VM516()
        {
            InitializeComponent();
        }

        private void FormReinstalacionBD_VM516_Load(object sender, EventArgs e)
        {
            btnExaminar.Enabled = true;
            txtRutaBackup.Enabled = true;
            lblRutaBackup.Enabled = true;
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Seleccionar archivo de respaldo (.bak)",
                Filter = "Archivos de respaldo SQL (*.bak)|*.bak|Todos los archivos (*.*)|*.*",
                CheckFileExists = true
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtRutaBackup.Text = ofd.FileName;
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            string rutaBak = txtRutaBackup.Text.Trim();
            if (string.IsNullOrWhiteSpace(rutaBak) || !File.Exists(rutaBak))
            {
                MessageBox.Show(
                    "Seleccioná un archivo de respaldo (.bak) válido antes de continuar.",
                    "Archivo requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            btnContinuar.Enabled = false;
            btnCancelar.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            try
            {
                _bllRespaldo.HacerRestore(rutaBak);
                _bllRespaldo.RecalcularDigitos();
                _bllInstalador.LimpiarFlagsReinstalacion();

                MessageBox.Show(
                    "El respaldo (.bak) se restauró correctamente en BD_VanguardiaArte.",
                    "Respaldo Restaurado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo restaurar el respaldo: " + ex.Message,
                    "Error en Reinstalación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                this.Cursor = Cursors.Default;
                btnContinuar.Enabled = true;
                btnCancelar.Enabled = true;
            }
        }
    }
}

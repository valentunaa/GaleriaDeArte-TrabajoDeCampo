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
    public partial class FormBackupInstalacion_VM516 : Form
    {
        private readonly BLL_Respaldo _bllRespaldo = new BLL_Respaldo();
        private readonly BLL_Instalador _bllInstalador = new BLL_Instalador();
        public FormBackupInstalacion_VM516()
        {
            InitializeComponent();
        }

        private void FormBackupInstalacion_VM516_Load(object sender, EventArgs e)
        {
            string carpetaDefault = Path.Combine(
                 Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
                 "VanguardiaArte",
                 "Backups"
             );
            txtRutaDestinoBak.Text = carpetaDefault;
        }

        private void btnHacerBackup_Click(object sender, EventArgs e)
        {
            string carpetaDestino = txtRutaDestinoBak.Text.Trim();
            if (string.IsNullOrWhiteSpace(carpetaDestino))
            {
                MessageBox.Show(
                    "Indicá una carpeta válida para guardar el respaldo.",
                    "Carpeta requerida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (!Directory.Exists(carpetaDestino))
            {
                Directory.CreateDirectory(carpetaDestino);
            }

            btnHacerBackup.Enabled = false;
            btnContinuar.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            try
            {
                _bllRespaldo.HacerBackup(carpetaDestino);

                MessageBox.Show(
                    "El respaldo se generó correctamente en la carpeta:\n" + carpetaDestino,
                    "Backup completado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo realizar el backup: " + ex.Message,
                    "Error de backup",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                this.Cursor = Cursors.Default;
                btnHacerBackup.Enabled = true;
                btnContinuar.Enabled = true;
            }
        }

        private void btnExaminarBak_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog fbd = new FolderBrowserDialog
            {
                Description = "Seleccioná la carpeta donde guardar el backup (.bak)",
                UseDescriptionForTitle = true,
                SelectedPath = txtRutaDestinoBak.Text
            };

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtRutaDestinoBak.Text = fbd.SelectedPath;
            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            _bllInstalador.LimpiarFlagBackupInstalacion();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

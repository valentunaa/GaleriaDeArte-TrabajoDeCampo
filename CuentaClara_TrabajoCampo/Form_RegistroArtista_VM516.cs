using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_Negocio;


namespace IU
{
    public partial class Form_RegistroArtista_VM516 : Form
    {
        private BLL_Artista_VM516 bllArtista;

        public Form_RegistroArtista_VM516()
        {
            InitializeComponent();
            bllArtista = new BLL_Artista_VM516();
        }

        private void Form_RegistroArtista_VM516_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                dgvArtistas.DataSource = null;

                dgvArtistas.DataSource = bllArtista.ListarArtistas_VM516();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de artistas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void LimpiarCampos()
        {
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtDNI.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                BE_Artista_VM516 nuevoArtista = new BE_Artista_VM516(
                    txtDNI.Text.Trim(),
                    txtNombre.Text.Trim(),
                    txtApellido.Text.Trim(),
                    txtTelefono.Text.Trim(),
                    txtEmail.Text.Trim()
                );

                bllArtista.RegistrarArtista_VM516(nuevoArtista);

                MessageBox.Show("¡Artista registrado con éxito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarGrilla();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validación / Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string dniBuscado = textBox1.Text.Trim();

                if (string.IsNullOrEmpty(dniBuscado))
                {
                    CargarGrilla(); 
                    return;
                }

                dgvArtistas.DataSource = null;
                dgvArtistas.DataSource = bllArtista.BuscarArtistaPorDNI_VM516(dniBuscado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Búsqueda / Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvArtistas.DataSource = null;
                dgvArtistas.DataSource = bllArtista.BuscarArtistaPorDNI_VM516(textBox1.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

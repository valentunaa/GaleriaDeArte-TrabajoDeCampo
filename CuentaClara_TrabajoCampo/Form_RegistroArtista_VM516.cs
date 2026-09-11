using BE;
using BLL;
using BLL_Negocio;
using DAL;
using Servicio;
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
    public partial class Form_RegistroArtista_VM516 : Form, IObserverIdioma
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
            ActualizarIdioma();
        }

        public void ActualizarIdioma()
        {
            string idIdioma = SessionManager.GetInstancia().GetUsuarioActual().Id_Idioma;
            BLL_Idioma bllIdioma = new BLL_Idioma();
            Servicio_Idioma idioma = bllIdioma.ObtenerIdiomaPorId(idIdioma);

            if (idioma == null)
                return;

            TraducirControles(this.Controls, idioma);

            // Traducimos el título del formulario manualmente
            this.Text = TraducirTexto("titulo_FormRegistroArtista");
        }

        private void TraducirControles(Control.ControlCollection controles, Servicio_Idioma idioma)
        {
            foreach (Control c in controles)
            {
                if (c.Tag != null)
                {
                    string clave = c.Tag.ToString();
                    var etiqueta = idioma.Etiquetas.FirstOrDefault(x => x.Clave == clave);
                    if (etiqueta != null) c.Text = etiqueta.Texto;
                }

                if (c is DataGridView dgv)
                {
                    foreach (DataGridViewColumn col in dgv.Columns)
                    {
                        string clave = col.Name; // Toma el nombre de la propiedad (ej: DNI_VM516)
                        var etiqueta = idioma.Etiquetas.FirstOrDefault(x => x.Clave == clave);
                        if (etiqueta != null) col.HeaderText = etiqueta.Texto;
                    }
                }

                if (c.HasChildren)
                    TraducirControles(c.Controls, idioma);
            }
        }

        private string TraducirTexto(string clave)
        {
            string idIdioma = SessionManager.GetInstancia().GetUsuarioActual().Id_Idioma;
            BLL_Idioma bllIdioma = new BLL_Idioma();
            Servicio_Idioma idioma = bllIdioma.ObtenerIdiomaPorId(idIdioma);

            if (idioma == null)
                return clave;

            var etiqueta = idioma.Etiquetas.FirstOrDefault(x => x.Clave == clave);
            return etiqueta != null ? etiqueta.Texto : clave;
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
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                bllArtista.RegistrarArtista_VM516(
                    txtDNI.Text.Trim(),
                    txtNombre.Text.Trim(),
                    txtApellido.Text.Trim(),
                    txtTelefono.Text.Trim(),
                    txtEmail.Text.Trim()
                );

                MessageBox.Show(
                    TraducirTexto("msg_RegistroArtistaExito"),
                    TraducirTexto("titulo_Exito"),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                CargarGrilla();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    TraducirTexto(ex.Message),
                    TraducirTexto("titulo_Error"),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
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
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void Form_RegistroArtista_VM516_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestorIdioma.GetInstancia().Desuscribir(this);
        }
    }
}

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
    public partial class Form_Sala_VM516 : Form, IObserverIdioma
    {
        private BLL_Sala_VM516 bllSala;
        public Form_Sala_VM516()
        {
            InitializeComponent();
            bllSala = new BLL_Sala_VM516();
        }



        private void Form_Sala_VM516_Load(object sender, EventArgs e)
        {
            GestorIdioma.GetInstancia().Suscribir(this);
            ActualizarIdioma();
            Servicio_Usuario usuario = SessionManager.GetInstancia().GetUsuarioActual();
            BLL_Rol bllRol = new BLL_Rol();
            string nombreLegibleDelRol = bllRol.ObtenerNombreRol(usuario.IdRol);

            lblUsuarioValor.Text = $"{usuario.Login} -  {nombreLegibleDelRol}";

            CargarGrilla();
        }
        public void ActualizarIdioma()
        {
            string idIdioma = SessionManager.GetInstancia().GetUsuarioActual().Id_Idioma;
            BLL_Idioma bllIdioma = new BLL_Idioma();
            Servicio_Idioma idioma = bllIdioma.ObtenerIdiomaPorId(idIdioma);

            if (idioma == null)
                return;

            TraducirControles(this.Controls, idioma);
            this.Text = TraducirTexto("titulo_FormGestionSalas");
            FormatearGrilla();
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
                        string clave = col.Name;
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
                dgvSalas.DataSource = null;
                dgvSalas.DataSource = bllSala.ListarSalas();
                FormatearGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(TraducirTexto("err_ErrorCargarGrilla") + ex.Message, TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatearGrilla()
        {
            if (dgvSalas.Columns.Contains("Codigo_Sala_VM516"))
                dgvSalas.Columns["Codigo_Sala_VM516"].HeaderText = TraducirTexto("Codigo_Sala_VM516");
            if (dgvSalas.Columns.Contains("Nombre_Sala_VM516"))
                dgvSalas.Columns["Nombre_Sala_VM516"].HeaderText = TraducirTexto("Nombre_Sala_VM516");
            if (dgvSalas.Columns.Contains("Alto_Max_Soportado_VM516"))
                dgvSalas.Columns["Alto_Max_Soportado_VM516"].HeaderText = TraducirTexto("Alto_Max_Soportado_VM516");
            if (dgvSalas.Columns.Contains("Ancho_Max_Soportado_VM516"))
                dgvSalas.Columns["Ancho_Max_Soportado_VM516"].HeaderText = TraducirTexto("Ancho_Max_Soportado_VM516");
            if (dgvSalas.Columns.Contains("Peso_Max_Soportado_VM516"))
                dgvSalas.Columns["Peso_Max_Soportado_VM516"].HeaderText = TraducirTexto("Peso_Max_Soportado_VM516");
            if (dgvSalas.Columns.Contains("Tipo_Iluminacion_Disponible_VM516"))
                dgvSalas.Columns["Tipo_Iluminacion_Disponible_VM516"].HeaderText = TraducirTexto("Tipo_Iluminacion_Disponible_VM516");

            dgvSalas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtAlto.Clear();
            txtAncho.Clear();
            txtPeso.Clear();
            
            txtCodigo.Enabled = true;
            txtCodigo.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigo.Text.Trim();
                bllSala.EliminarSala_VM516(codigo);

                MessageBox.Show(TraducirTexto("msg_SalaEliminadaExito"), TraducirTexto("titulo_Exito"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txtAlto.Text.Trim(), out decimal alto) ||
                    !decimal.TryParse(txtAncho.Text.Trim(), out decimal ancho) ||
                    !decimal.TryParse(txtPeso.Text.Trim(), out decimal peso))
                {
                    throw new Exception(TraducirTexto("err_DimensionesNumericasSalas"));
                }

                BE_Sala_VM516 sala = new BE_Sala_VM516
                {
                    Codigo_Sala_VM516 = txtCodigo.Text.Trim(),
                    Nombre_Sala_VM516 = txtNombre.Text.Trim(),
                    Alto_Max_Soportado_VM516 = alto,
                    Ancho_Max_Soportado_VM516 = ancho,
                    Peso_Max_Soportado_VM516 = peso,
                    Tipo_Iluminacion_Disponible_VM516 = comboBox1.Text.Trim()
                };

                bllSala.ModificarSala_VM516(sala);

                MessageBox.Show(TraducirTexto("msg_SalaModificadaExito"), TraducirTexto("titulo_Exito"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(txtAlto.Text.Trim(), out decimal alto) ||
                    !decimal.TryParse(txtAncho.Text.Trim(), out decimal ancho) ||
                    !decimal.TryParse(txtPeso.Text.Trim(), out decimal peso))
                {
                    throw new Exception(TraducirTexto("err_DimensionesNumericasSalas"));
                }

                BE_Sala_VM516 sala = new BE_Sala_VM516
                {
                    Codigo_Sala_VM516 = txtCodigo.Text.Trim(),
                    Nombre_Sala_VM516 = txtNombre.Text.Trim(),
                    Alto_Max_Soportado_VM516 = alto,
                    Ancho_Max_Soportado_VM516 = ancho,
                    Peso_Max_Soportado_VM516 = peso,
                    Tipo_Iluminacion_Disponible_VM516 = comboBox1.Text.Trim()
                };

                bllSala.RegistrarSala_VM516(sala);

                MessageBox.Show(TraducirTexto("msg_SalaRegistradaExito"), TraducirTexto("titulo_Exito"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Sala_VM516_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestorIdioma.GetInstancia().Desuscribir(this);
        }

        private void dgvSalas_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSalas.Rows[e.RowIndex];

                txtCodigo.Text = row.Cells["Codigo_Sala_VM516"].Value?.ToString();
                txtNombre.Text = row.Cells["Nombre_Sala_VM516"].Value?.ToString();
                txtAlto.Text = row.Cells["Alto_Max_Soportado_VM516"].Value?.ToString();
                txtAncho.Text = row.Cells["Ancho_Max_Soportado_VM516"].Value?.ToString();
                txtPeso.Text = row.Cells["Peso_Max_Soportado_VM516"].Value?.ToString();
                comboBox1.Text = row.Cells["Tipo_Iluminacion_Disponible_VM516"].Value?.ToString();

             
                txtCodigo.Enabled = false;
            }
        }
    }
}

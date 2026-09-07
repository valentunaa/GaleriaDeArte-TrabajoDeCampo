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
    public partial class Form_Sala_VM516 : Form
    {
        private BLL_Sala_VM516 bllSala;
        public Form_Sala_VM516()
        {
            InitializeComponent();
            bllSala = new BLL_Sala_VM516();
        }



        private void Form_Sala_VM516_Load(object sender, EventArgs e)
        {
            Servicio_Usuario usuario = SessionManager.GetInstancia().GetUsuarioActual();
            BLL_Rol bllRol = new BLL_Rol();
            string nombreLegibleDelRol = bllRol.ObtenerNombreRol(usuario.IdRol);

            lblUsuarioValor.Text = $"{usuario.Login} -  {nombreLegibleDelRol}";

            CargarGrilla();
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
                MessageBox.Show("Error al cargar la grilla: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatearGrilla()
        {
            if (dgvSalas.Columns.Contains("Codigo_Sala_VM516"))
                dgvSalas.Columns["Codigo_Sala_VM516"].HeaderText = "Código";
            if (dgvSalas.Columns.Contains("Nombre_Sala_VM516"))
                dgvSalas.Columns["Nombre_Sala_VM516"].HeaderText = "Nombre";
            if (dgvSalas.Columns.Contains("Alto_Max_Soportado_VM516"))
                dgvSalas.Columns["Alto_Max_Soportado_VM516"].HeaderText = "Alto Máx";
            if (dgvSalas.Columns.Contains("Ancho_Max_Soportado_VM516"))
                dgvSalas.Columns["Ancho_Max_Soportado_VM516"].HeaderText = "Ancho Máx";
            if (dgvSalas.Columns.Contains("Peso_Max_Soportado_VM516"))
                dgvSalas.Columns["Peso_Max_Soportado_VM516"].HeaderText = "Peso Máx";
            if (dgvSalas.Columns.Contains("Tipo_Iluminacion_Disponible_VM516"))
                dgvSalas.Columns["Tipo_Iluminacion_Disponible_VM516"].HeaderText = "Iluminación";
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

                MessageBox.Show("Sala eliminada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validación / Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    throw new Exception("Los campos de Alto, Ancho y Peso máximo deben ser numéricos.");
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

                MessageBox.Show("Sala modificada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validación / Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    throw new Exception("Los campos de Alto, Ancho y Peso máximo deben ser numéricos.");
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

                MessageBox.Show("Sala registrada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validación / Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}

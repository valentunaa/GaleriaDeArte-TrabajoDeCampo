using BE;
using BLL;
using BLL_Negocio;
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
    public partial class Form_Gestion_Productos_VM516 : Form, IObserverIdioma
    {
        private BLL_Producto_VM516 bllProducto_VM516;
        public Form_Gestion_Productos_VM516()
        {
            InitializeComponent();
        }
        private void Form_Gestion_Productos_VM516_Load(object sender, EventArgs e)
        {
            GestorIdioma.GetInstancia().Suscribir(this);

            CargarGrilla_VM516();
            ActualizarIdioma();

            Servicio_Usuario usuario = SessionManager.GetInstancia().GetUsuarioActual();

            BLL_Rol bllRol = new BLL_Rol();
            string nombreLegibleDelRol = bllRol.ObtenerNombreRol(usuario.IdRol);
            lblUsuarioValor_VM516.Text = $"{usuario.Login} - {nombreLegibleDelRol}";

        }

        public void ActualizarIdioma()
        {
            var usuario = SessionManager.GetInstancia().GetUsuarioActual();
            if (usuario == null) return;

            BLL_Idioma bllIdioma = new BLL_Idioma();
            Servicio_Idioma idioma = bllIdioma.ObtenerIdiomaPorId(usuario.Id_Idioma);

            if (idioma == null) return;

            TraducirControles(this.Controls, idioma);
            this.Text = TraducirTexto("titulo_FormGestionProductos");
            FormatearGrilla_VM516();
            dgvProductos_VM516.Refresh();
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
            var usuario = SessionManager.GetInstancia().GetUsuarioActual();
            if (usuario == null) return clave;

            BLL_Idioma bllIdioma = new BLL_Idioma();
            Servicio_Idioma idioma = bllIdioma.ObtenerIdiomaPorId(usuario.Id_Idioma);

            if (idioma == null) return clave;

            var etiqueta = idioma.Etiquetas.FirstOrDefault(x => x.Clave == clave);
            return etiqueta != null ? etiqueta.Texto : clave;
        }

        private void FormatearGrilla_VM516()
        {
            if (dgvProductos_VM516.Columns.Contains("CodigoProducto_VM516"))
                dgvProductos_VM516.Columns["CodigoProducto_VM516"].HeaderText = TraducirTexto("CodigoProducto_VM516");
            if (dgvProductos_VM516.Columns.Contains("Descripcion_VM516"))
                dgvProductos_VM516.Columns["Descripcion_VM516"].HeaderText = TraducirTexto("Descripcion_VM516");
            if (dgvProductos_VM516.Columns.Contains("StockDisponible_VM516"))
                dgvProductos_VM516.Columns["StockDisponible_VM516"].HeaderText = TraducirTexto("StockDisponible_VM516");
            if (dgvProductos_VM516.Columns.Contains("PrecioVigente_VM516"))
            {
                dgvProductos_VM516.Columns["PrecioVigente_VM516"].HeaderText = TraducirTexto("PrecioVigente_VM516");
                dgvProductos_VM516.Columns["PrecioVigente_VM516"].DefaultCellStyle.Format = "0.00";
            }

            dgvProductos_VM516.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarGrilla_VM516()
        {
            try
            {
                dgvProductos_VM516.DataSource = null;
                dgvProductos_VM516.DataSource = bllProducto_VM516.ListarProductos_VM516();
                FormatearGrilla_VM516();
            }
            catch (Exception ex)
            {
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos_VM516()
        {
            txtCodigoProducto_VM516.Clear();
            txtCodigoProducto_VM516.Enabled = true;
            txtDescripcion_VM516.Clear();
            txtStockDisponible_VM516.Clear();
            txtPrecioVigente_VM516.Clear();
            dgvProductos_VM516.ClearSelection();
        }


        private void panelContenedor_VM516_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_VM516_Click(object sender, EventArgs e)
        {
            try
            {
                bllProducto_VM516.RegistrarProducto_VM516(
                    txtCodigoProducto_VM516.Text,
                    txtDescripcion_VM516.Text,
                    (int)decimal.Parse(txtStockDisponible_VM516.Text),
                    decimal.Parse(txtPrecioVigente_VM516.Text)
                );

                MessageBox.Show(TraducirTexto("msg_ProductoRegistradoExito"), TraducirTexto("titulo_Exito"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla_VM516();
                LimpiarCampos_VM516();
            }
            catch (Exception ex)
            {
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificar_VM516_Click(object sender, EventArgs e)
        {
            try
            {
                bllProducto_VM516.ModificarProducto_VM516(
                    txtCodigoProducto_VM516.Text,
                    txtDescripcion_VM516.Text,
                    txtStockDisponible_VM516.Text,
                    txtPrecioVigente_VM516.Text
                );

                MessageBox.Show(TraducirTexto("msg_ProductoModificadoExito"), TraducirTexto("titulo_Exito"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla_VM516();
                LimpiarCampos_VM516();
            }
            catch (Exception ex)
            {
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_VM516_Click(object sender, EventArgs e)
        {
            try
            {
                bllProducto_VM516.EliminarProducto_VM516(txtCodigoProducto_VM516.Text);

                MessageBox.Show(TraducirTexto("msg_ProductoEliminadoExito"), TraducirTexto("titulo_Exito"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarGrilla_VM516();
                LimpiarCampos_VM516();
            }
            catch (Exception ex)
            {
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiar_VM516_Click(object sender, EventArgs e)
        {
            LimpiarCampos_VM516();
        }

        private void btnSalir_VM516_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvProductos_VM516_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvProductos_VM516.Rows[e.RowIndex].DataBoundItem is BE_Producto_VM516 prod_VM516)
            {
                txtCodigoProducto_VM516.Text = prod_VM516.CodigoProducto_VM516;
                txtCodigoProducto_VM516.Enabled = false;
                txtDescripcion_VM516.Text = prod_VM516.Descripcion_VM516;
                txtStockDisponible_VM516.Text = prod_VM516.StockDisponible_VM516.ToString();
                txtPrecioVigente_VM516.Text = prod_VM516.PrecioVigente_VM516.ToString("0.00");
            }
        }

        private void dgvProductos_VM516_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvProductos_VM516.Columns[e.ColumnIndex].Name == "Descripcion_VM516")
            {
                if (dgvProductos_VM516.Rows[e.RowIndex].DataBoundItem is BE_Producto_VM516 prod_VM516)
                {
                    string claveProducto = $"prod_{prod_VM516.CodigoProducto_VM516}";
                    string traduccion = TraducirTexto(claveProducto);

                    if (traduccion != claveProducto)
                    {
                        e.Value = traduccion;
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void Form_Gestion_Productos_VM516_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestorIdioma.GetInstancia().Desuscribir(this);
        }
    }
}

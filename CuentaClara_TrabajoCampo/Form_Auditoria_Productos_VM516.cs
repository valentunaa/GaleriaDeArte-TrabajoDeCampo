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
    public partial class Form_Auditoria_Productos_VM516 : Form, IObserverIdioma
    {
        private BLL_Producto_C_VM516 bllBitacoraProducto_VM516;
        public Form_Auditoria_Productos_VM516()
        {
            InitializeComponent();
            bllBitacoraProducto_VM516 = new BLL_Producto_C_VM516();
        }

        private void Form_Auditoria_Productos_VM516_Load(object sender, EventArgs e)
        {
            this.MaximumSize = Screen.FromControl(this).WorkingArea.Size;
            this.WindowState = FormWindowState.Normal;
            this.Width = Screen.FromControl(this).WorkingArea.Width;
            this.Height = Screen.FromControl(this).WorkingArea.Height;
            this.Location = new Point(0, 0);
            GestorIdioma.GetInstancia().Suscribir(this);

            // Inicializar fechas por defecto (último mes hasta hoy)
            dtpFechaInicio.Value = DateTime.Now.AddMonths(-1);
            dtpFechaFin.Value = DateTime.Now;

            CargarHistorial_VM516();
            ActualizarIdioma();

            // Mostrar usuario activo en el panel inferior
            Servicio_Usuario usuario = SessionManager.GetInstancia().GetUsuarioActual();

            BLL_Rol bllRol = new BLL_Rol();
            string nombreLegibleDelRol = bllRol.ObtenerNombreRol(usuario.IdRol);
            lblUsuarioValor.Text = $"{usuario.Login} - {nombreLegibleDelRol}";

        }

        public void ActualizarIdioma()
        {
            var usuario = SessionManager.GetInstancia().GetUsuarioActual();
            if (usuario == null) return;

            BLL_Idioma bllIdioma = new BLL_Idioma();
            Servicio_Idioma idioma = bllIdioma.ObtenerIdiomaPorId(usuario.Id_Idioma);

            if (idioma == null) return;

            TraducirControles(this.Controls, idioma);
            this.Text = TraducirTexto("lbl_FormBitacoraProducto");
            FormatearGrilla_VM516();
            dgvBitacoraProducto.Refresh();
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
            // Ocultar ID interno y traducir cabeceras de la grilla de productos históricos
            if (dgvBitacoraProducto.Columns.Contains("Id_Cambio_VM516"))
                dgvBitacoraProducto.Columns["Id_Cambio_VM516"].Visible = false;

            if (dgvBitacoraProducto.Columns.Contains("CodigoProducto_VM516"))
                dgvBitacoraProducto.Columns["CodigoProducto_VM516"].HeaderText = TraducirTexto("CodigoProducto_VM516");
            if (dgvBitacoraProducto.Columns.Contains("Descripcion_VM516"))
                dgvBitacoraProducto.Columns["Descripcion_VM516"].HeaderText = TraducirTexto("Descripcion_VM516");
            if (dgvBitacoraProducto.Columns.Contains("StockDisponible_VM516"))
                dgvBitacoraProducto.Columns["StockDisponible_VM516"].HeaderText = TraducirTexto("StockDisponible_VM516");
            if (dgvBitacoraProducto.Columns.Contains("PrecioVigente_VM516"))
            {
                dgvBitacoraProducto.Columns["PrecioVigente_VM516"].HeaderText = TraducirTexto("PrecioVigente_VM516");
                dgvBitacoraProducto.Columns["PrecioVigente_VM516"].DefaultCellStyle.Format = "0.00";
            }
            if (dgvBitacoraProducto.Columns.Contains("Bit_Lo_Bo_VM516"))
                dgvBitacoraProducto.Columns["Bit_Lo_Bo_VM516"].HeaderText = TraducirTexto("Bit_Lo_Bo_VM516");
            if (dgvBitacoraProducto.Columns.Contains("Fecha_VM516"))
                dgvBitacoraProducto.Columns["Fecha_VM516"].HeaderText = TraducirTexto("Fecha_VM516");
            if (dgvBitacoraProducto.Columns.Contains("Activo_VM516"))
                dgvBitacoraProducto.Columns["Activo_VM516"].HeaderText = TraducirTexto("Activo_VM516");

            dgvBitacoraProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarHistorial_VM516()
        {
            try
            {
                string codigo_VM516 = txtCodigoProducto.Text.Trim();
                string nombre_VM516 = txtNombreProducto.Text.Trim();
                DateTime fechaIni_VM516 = dtpFechaInicio.Value;
                DateTime fechaFin_VM516 = dtpFechaFin.Value;

                var lista_VM516 = bllBitacoraProducto_VM516.ObtenerHistorialFiltrado_VM516(codigo_VM516, nombre_VM516, fechaIni_VM516, fechaFin_VM516);

                dgvBitacoraProducto.DataSource = null;
                dgvBitacoraProducto.DataSource = lista_VM516;
                FormatearGrilla_VM516();

                lblCantRegistrosValor.Text = lista_VM516.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBitacoraProducto.SelectedRows.Count > 0)
                {
                    var registroSeleccionado = dgvBitacoraProducto.SelectedRows[0].DataBoundItem as BE_Producto_C_VM516;
                    if (registroSeleccionado != null)
                    {
                        // Ejecutamos la activación para resetear la tabla principal mediante el trigger
                        bllBitacoraProducto_VM516.ActivarRegistroHistorico_VM516(registroSeleccionado.Id_Cambio_VM516);

                        MessageBox.Show(TraducirTexto("msg_RegistroActivadoExito"), TraducirTexto("titulo_Exito"), MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CargarHistorial_VM516();
                    }
                }
                else
                {
                    throw new Exception("err_SeleccionarRegistroHistorico");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigoProducto.Clear();
            txtNombreProducto.Clear();
            dtpFechaInicio.Value = DateTime.Now.AddMonths(-1);
            dtpFechaFin.Value = DateTime.Now;
            CargarHistorial_VM516();
        }

        private void Form_Auditoria_Productos_VM516_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestorIdioma.GetInstancia().Desuscribir(this);
        }
    }
}

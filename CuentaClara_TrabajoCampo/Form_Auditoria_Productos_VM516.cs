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
            GestorIdioma.GetInstancia().Suscribir(this);

            // 1. Fechas por defecto correctas (cubriendo la diferencia horaria)
            dtpFechaInicio.Value = DateTime.Now.AddMonths(-1);
            dtpFechaFin.Value = DateTime.Now.AddDays(1);

            CargarHistorial_VM516();
            ActualizarIdioma();

            Servicio_Usuario usuario = SessionManager.GetInstancia().GetUsuarioActual();
            BLL_Rol bllRol = new BLL_Rol();
            string nombreLegibleDelRol = bllRol.ObtenerNombreRol(usuario.IdRol);

            // 2. Corregido el error de sintaxis y salto de línea
            lblUsuarioValor.Text = $"{usuario.Login} - {nombreLegibleDelRol}";
        }

        public void ActualizarIdioma()
        {
            dtpFechaFin.Value = DateTime.Now.AddDays(1);
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
                //dgvBitacoraProducto.Columns["Id_Cambio_VM516"].Visible = false;

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
            dgvBitacoraProducto.ReadOnly = true;

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
                        bllBitacoraProducto_VM516.ActivarRegistroHistorico_VM516(registroSeleccionado.Id_Cambio_VM516);

                        // 2. Ejecutamos el recálculo de seguridad (BLL Principal)
                        BLL_Producto_VM516 bllProducto = new BLL_Producto_VM516();
                        bllProducto.RecalcularDigitosPostRestauracion_VM516(registroSeleccionado.CodigoProducto_VM516);
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            CargarHistorial_VM516();
        }

        private void dgvBitacoraProducto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Verificamos que sea una fila válida y la columna de Descripción
            if (e.RowIndex >= 0 && dgvBitacoraProducto.Columns[e.ColumnIndex].Name == "Descripcion_VM516")
            {
                if (dgvBitacoraProducto.Rows[e.RowIndex].DataBoundItem is BE_Producto_C_VM516 prodHistorico_VM516)
                {
                    // Generamos la misma clave de diccionario que usás en Gestión (ej: prod_CAF-01)
                    string claveProducto = $"prod_{prodHistorico_VM516.CodigoProducto_VM516}";
                    string traduccion = TraducirTexto(claveProducto);

                    // Si encontró la traducción en la base de datos/diccionario, reemplaza el texto visual
                    if (traduccion != claveProducto)
                    {
                        e.Value = traduccion;
                        e.FormattingApplied = true;
                    }
                }
            }
        }
    }
}

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
    public partial class Form_Cafeteria_VM516 : Form, IObserverIdioma
    {
        private BLL_Producto_VM516 bllProducto_VM516;
        private BLL_Pedido_VM516 bllPedido_VM516;
        private BLL_Cliente_VM516 bllCliente_VM516;
        private BLL_Rol bllRol_VM516;

        private List<BE_LineaDetalle_VM516> carrito_VM516;
        private List<string> productosInhabilitados_VM516;
        private BE_Cliente_VM516 clienteSeleccionado_VM516;

        public Form_Cafeteria_VM516()
        {
            InitializeComponent();
            bllProducto_VM516 = new BLL_Producto_VM516();
            bllPedido_VM516 = new BLL_Pedido_VM516();
            bllCliente_VM516 = new BLL_Cliente_VM516();
            bllRol_VM516 = new BLL_Rol();

            carrito_VM516 = new List<BE_LineaDetalle_VM516>();
            productosInhabilitados_VM516 = new List<string>();
        }

        private void Form_Cafeteria_VM516_Load(object sender, EventArgs e)
        {
            GestorIdioma.GetInstancia().Suscribir(this);
            ConfigurarGrillaCarrito_VM516();
            CargarGrilla_VM516();
            ActualizarIdioma();

            Servicio_Usuario usuario = SessionManager.GetInstancia().GetUsuarioActual();
            if (usuario != null)
            {
                string nombreLegibleDelRol = bllRol_VM516.ObtenerNombreRol(usuario.IdRol);
                lblUsuarioValor_VM516.Text = $"{usuario.Login} - {nombreLegibleDelRol}";
            }
        }
        public void ActualizarIdioma()
        {
            var usuario = SessionManager.GetInstancia().GetUsuarioActual();
            if (usuario == null) return;

            BLL_Idioma bllIdioma = new BLL_Idioma();
            Servicio_Idioma idioma = bllIdioma.ObtenerIdiomaPorId(usuario.Id_Idioma);

            if (idioma == null) return;

            TraducirControles(this.Controls, idioma);
            this.Text = TraducirTexto("titulo_FormRegistrarPedido");
            FormatearGrilla();

            if (clienteSeleccionado_VM516 != null)
            {
                lblNombreCliente_VM516.Text = $"👤 {clienteSeleccionado_VM516.Nombre_VM516} {clienteSeleccionado_VM516.Apellido_VM516}";
            }
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
            if (string.IsNullOrEmpty(clave)) return clave;

            string[] partes = clave.Split('|');
            string claveBase = partes[0];

            var usuario = SessionManager.GetInstancia().GetUsuarioActual();
            if (usuario == null) return clave;

            BLL_Idioma bllIdioma = new BLL_Idioma();
            Servicio_Idioma idioma = bllIdioma.ObtenerIdiomaPorId(usuario.Id_Idioma);

            if (idioma == null) return clave;

            var etiqueta = idioma.Etiquetas.FirstOrDefault(x => x.Clave == claveBase);
            string textoTraducido = etiqueta != null ? etiqueta.Texto : claveBase;

            if (partes.Length > 1)
                textoTraducido += " " + partes[1];

            return textoTraducido;
        }

        private void FormatearGrilla()
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

            if (dgvCarrito_VM516.Columns.Contains("CodigoProducto_VM516"))
                dgvCarrito_VM516.Columns["CodigoProducto_VM516"].HeaderText = TraducirTexto("CodigoProducto_VM516");
            if (dgvCarrito_VM516.Columns.Contains("Descripcion_VM516"))
                dgvCarrito_VM516.Columns["Descripcion_VM516"].HeaderText = TraducirTexto("Descripcion_VM516");
            if (dgvCarrito_VM516.Columns.Contains("Cantidad_VM516"))
                dgvCarrito_VM516.Columns["Cantidad_VM516"].HeaderText = TraducirTexto("Cantidad_VM516");
            if (dgvCarrito_VM516.Columns.Contains("PrecioUnitario_VM516"))
                dgvCarrito_VM516.Columns["PrecioUnitario_VM516"].HeaderText = TraducirTexto("PrecioUnitario_VM516");
            if (dgvCarrito_VM516.Columns.Contains("Subtotal_VM516"))
                dgvCarrito_VM516.Columns["Subtotal_VM516"].HeaderText = TraducirTexto("Subtotal_VM516");

            dgvProductos_VM516.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrito_VM516.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ConfigurarGrillaCarrito_VM516()
        {
            dgvCarrito_VM516.Columns.Clear();
            dgvCarrito_VM516.AutoGenerateColumns = false;

            dgvCarrito_VM516.Columns.Add(new DataGridViewTextBoxColumn { Name = "CodigoProducto_VM516" });
            dgvCarrito_VM516.Columns.Add(new DataGridViewTextBoxColumn { Name = "Descripcion_VM516" });
            dgvCarrito_VM516.Columns.Add(new DataGridViewTextBoxColumn { Name = "Cantidad_VM516" });
            dgvCarrito_VM516.Columns.Add(new DataGridViewTextBoxColumn { Name = "PrecioUnitario_VM516" });
            dgvCarrito_VM516.Columns.Add(new DataGridViewTextBoxColumn { Name = "Subtotal_VM516" });
        }

        private void CargarGrilla_VM516()
        {
            try
            {
                dgvProductos_VM516.DataSource = null;
                dgvProductos_VM516.DataSource = bllProducto_VM516.ListarProductos_VM516();
                FormatearGrilla();
                MarcarProductosInhabilitados_VM516();
            }
            catch (Exception ex)
            {
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefrescarCarritoVisual_VM516()
        {
            dgvCarrito_VM516.Rows.Clear();
            var catalogo_VM516 = bllProducto_VM516.ListarProductos_VM516();

            foreach (var item_VM516 in carrito_VM516)
            {
                var prod_VM516 = catalogo_VM516.FirstOrDefault(p => p.CodigoProducto_VM516 == item_VM516.CodigoProducto_VM516);
                string desc_VM516 = prod_VM516 != null ? prod_VM516.Descripcion_VM516 : item_VM516.CodigoProducto_VM516;
                decimal subtotal_VM516 = item_VM516.Cantidad_VM516 * item_VM516.PrecioUnitario_VM516;

                dgvCarrito_VM516.Rows.Add(
                    item_VM516.CodigoProducto_VM516,
                    desc_VM516,
                    item_VM516.Cantidad_VM516,
                    item_VM516.PrecioUnitario_VM516.ToString("0.00"),
                    subtotal_VM516.ToString("0.00")
                );
            }

            decimal total_VM516 = bllPedido_VM516.CalcularTotalCarrito_VM516(carrito_VM516);
            lblTotalMonto_VM516.Text = $"$ {total_VM516:0.00}";
        }
        private void btnBuscarCliente_VM516_Click(object sender, EventArgs e)
        {
            try
            {
                string dni_VM516 = txtDniCliente_VM516.Text;
                clienteSeleccionado_VM516 = bllCliente_VM516.BuscarClientePorDNI_VM516(dni_VM516);

                lblNombreCliente_VM516.Text = $"👤 {clienteSeleccionado_VM516.Nombre_VM516} {clienteSeleccionado_VM516.Apellido_VM516}";
                lblNombreCliente_VM516.ForeColor = Color.FromArgb(18, 120, 50);
            }
            catch (Exception ex)
            {
                clienteSeleccionado_VM516 = null;
                lblNombreCliente_VM516.Text = TraducirTexto("lbl_ClienteNoEncontrado");
                lblNombreCliente_VM516.ForeColor = Color.FromArgb(180, 40, 40);

                // Flujo Alternativo 4.1: Cliente No Registrado -> <<extend>> ECU09
                if (ex.Message == "err_ClienteNoRegistrado")
                {
                    DialogResult rta_VM516 = MessageBox.Show(
                        TraducirTexto("msg_ClienteNoRegistradoExtend"),
                        TraducirTexto("titulo_Error"),
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (rta_VM516 == DialogResult.Yes)
                    {
                        using (Form_RegistrarCliente_VM516 frmAltaCliente_VM516 = new Form_RegistrarCliente_VM516(txtDniCliente_VM516.Text.Trim()))
                        {
                            if (frmAltaCliente_VM516.ShowDialog() == DialogResult.OK)
                            {
                                btnBuscarCliente_VM516_Click(sender, e);
                            }
                        }
                    }
                    return;
                }

                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAgregarCarrito_VM516_Click(object sender, EventArgs e)
        {
            try
            {
                BE_Producto_VM516 prodSeleccionado_VM516 = dgvProductos_VM516.CurrentRow?.DataBoundItem as BE_Producto_VM516;

                bllPedido_VM516.AgregarItemAlCarrito_VM516(
                    carrito_VM516,
                    productosInhabilitados_VM516,
                    prodSeleccionado_VM516,
                    txtCantidad_VM516.Text
                );

                RefrescarCarritoVisual_VM516();
                txtCantidad_VM516.Text = "1";
            }
            catch (Exception ex)
            {
                // Flujo Alternativo 2.1: Indisponibilidad de Stock
                if (ex.Message.StartsWith("err_IndisponibilidadStock"))
                {
                    MarcarProductosInhabilitados_VM516();
                    btnAgregarCarrito_VM516.Enabled = false;

                    string advertencia_VM516 = TraducirTexto(ex.Message) + "\n\n" + TraducirTexto("msg_PreguntaContinuarOCancelarVenta");
                    DialogResult respuesta_VM516 = MessageBox.Show(
                        advertencia_VM516,
                        TraducirTexto("titulo_Error"),
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (respuesta_VM516 == DialogResult.No)
                    {
                        LimpiarOperacionCompleta_VM516();
                    }
                    return;
                }

                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnQuitarCarrito_VM516_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo_VM516 = dgvCarrito_VM516.CurrentRow?.Cells["CodigoProducto_VM516"].Value?.ToString();
                bllPedido_VM516.QuitarItemDelCarrito_VM516(carrito_VM516, codigo_VM516);
                RefrescarCarritoVisual_VM516();
            }
            catch (Exception ex)
            {
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnConfirmarPedido_VM516_Click(object sender, EventArgs e)
        {
            try
            {
                BE_Pedido_VM516 nuevoPedido_VM516 = bllPedido_VM516.ConfirmarYRegistrarPedido_VM516(clienteSeleccionado_VM516, carrito_VM516);
                decimal montoTotal_VM516 = bllPedido_VM516.CalcularTotalCarrito_VM516(carrito_VM516);

                MessageBox.Show(
                    $"{TraducirTexto("msg_PedidoRegistradoExito")} (N° {nuevoPedido_VM516.NumeroPedido_VM516})",
                    TraducirTexto("titulo_Exito"),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Paso 6: Ejecuta <<include>> ECU10 - Cobrar Pedido
                using (Form_Cobrar_Pedido_VM516 frmCobro_VM516 = new Form_Cobrar_Pedido_VM516(nuevoPedido_VM516, montoTotal_VM516))
                {
                    frmCobro_VM516.ShowDialog();
                }

                LimpiarOperacionCompleta_VM516();
            }
            catch (Exception ex)
            {
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvProductos_VM516_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductos_VM516.CurrentRow?.DataBoundItem is BE_Producto_VM516 prod_VM516)
            {
                btnAgregarCarrito_VM516.Enabled = !productosInhabilitados_VM516.Contains(prod_VM516.CodigoProducto_VM516);
            }
        }
        private void MarcarProductosInhabilitados_VM516()
        {
            foreach (DataGridViewRow row_VM516 in dgvProductos_VM516.Rows)
            {
                if (row_VM516.DataBoundItem is BE_Producto_VM516 prod_VM516 &&
                    productosInhabilitados_VM516.Contains(prod_VM516.CodigoProducto_VM516))
                {
                    row_VM516.DefaultCellStyle.BackColor = Color.LightGray;
                    row_VM516.DefaultCellStyle.ForeColor = Color.DarkGray;
                }
            }
        }

        private void LimpiarOperacionCompleta_VM516()
        {
            carrito_VM516.Clear();
            productosInhabilitados_VM516.Clear();
            clienteSeleccionado_VM516 = null;
            txtDniCliente_VM516.Clear();
            txtCantidad_VM516.Text = "1";
            lblNombreCliente_VM516.Text = TraducirTexto("lbl_NombreClienteInfo");
            lblNombreCliente_VM516.ForeColor = Color.DimGray;
            btnAgregarCarrito_VM516.Enabled = true;

            RefrescarCarritoVisual_VM516();
            CargarGrilla_VM516();
        }

        private void Form_Cafeteria_VM516_Resize(object sender, EventArgs e)
        {
            //if (WindowState == FormWindowState.Minimized) return;
            //int altoDisponible_VM516 = ClientSize.Height - panelInferior_VM516.Height;
            //panelContenedor_VM516.Location = new Point(
            //    (ClientSize.Width - panelContenedor_VM516.Width) / 2,
            //    (altoDisponible_VM516 - panelContenedor_VM516.Height) / 2
            //);
        }

        private void Form_Cafeteria_VM516_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestorIdioma.GetInstancia().Desuscribir(this);
        }
    }
}

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
    public partial class Form_Cobrar_Pedido_VM516 : Form, IObserverIdioma
    {
        private BLL_ComprobanteCafeteria_VM516 bllComprobante_VM516;
        private BE_Pedido_VM516 pedidoVerificado_VM516;
        private decimal montoACobrar_VM516;
        public Form_Cobrar_Pedido_VM516()
        {
            InitializeComponent();
            bllComprobante_VM516 = new BLL_ComprobanteCafeteria_VM516();
        }
        public Form_Cobrar_Pedido_VM516(BE_Pedido_VM516 pedido_VM516, decimal montoTotal_VM516) : this()
        {
            pedidoVerificado_VM516 = pedido_VM516;
            montoACobrar_VM516 = montoTotal_VM516;
        }

        private void Form_Cobrar_Pedido_VM516_Load(object sender, EventArgs e)
        {
            GestorIdioma.GetInstancia().Suscribir(this);
            ActualizarIdioma();
            CargarGrilla();

            Servicio_Usuario usuario = SessionManager.GetInstancia().GetUsuarioActual();
            BLL_Rol bllRol = new BLL_Rol();
            string nombreLegibleDelRol = bllRol.ObtenerNombreRol(usuario.IdRol);
            lblUsuarioValor_VM516.Text = $"{usuario.Login} - {nombreLegibleDelRol}";

            if (pedidoVerificado_VM516 != null)
            {
                txtNumeroPedido_VM516.Text = pedidoVerificado_VM516.NumeroPedido_VM516.ToString();
                txtMontoAbonado_VM516.Text = montoACobrar_VM516.ToString("0.00");
                lblEstadoPedido_VM516.Text = TraducirTexto("lbl_EstadoPedidoPendiente");
                lblEstadoPedido_VM516.ForeColor = Color.FromArgb(18, 120, 50);
                BloquearAccionesPago(true);
            }
            else
            {
                BloquearAccionesPago(false);
            }
        }
        public void ActualizarIdioma()
        {
            string idIdioma = SessionManager.GetInstancia().GetUsuarioActual().Id_Idioma;
            BLL_Idioma bllIdioma = new BLL_Idioma();
            Servicio_Idioma idioma = bllIdioma.ObtenerIdiomaPorId(idIdioma);

            if (idioma == null) return;

            TraducirControles(this.Controls, idioma);
            this.Text = TraducirTexto("titulo_FormCobroCafeteria");
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

            if (idioma == null) return clave;

            var etiqueta = idioma.Etiquetas.FirstOrDefault(x => x.Clave == clave);
            return etiqueta != null ? etiqueta.Texto : clave;
        }

        private void FormatearGrilla()
        {
            if (dgvComprobantes_VM516.Columns.Contains("NumeroTicket_VM516"))
                dgvComprobantes_VM516.Columns["NumeroTicket_VM516"].HeaderText = TraducirTexto("NumeroTicket_VM516");
            if (dgvComprobantes_VM516.Columns.Contains("FechaHora_VM516"))
                dgvComprobantes_VM516.Columns["FechaHora_VM516"].HeaderText = TraducirTexto("FechaHora_VM516");
            if (dgvComprobantes_VM516.Columns.Contains("MontoAbonado_VM516"))
                dgvComprobantes_VM516.Columns["MontoAbonado_VM516"].HeaderText = TraducirTexto("MontoAbonado_VM516");
            if (dgvComprobantes_VM516.Columns.Contains("MedioPago_VM516"))
                dgvComprobantes_VM516.Columns["MedioPago_VM516"].HeaderText = TraducirTexto("MedioPago_VM516");
            if (dgvComprobantes_VM516.Columns.Contains("NumeroPedido_VM516"))
                dgvComprobantes_VM516.Columns["NumeroPedido_VM516"].HeaderText = TraducirTexto("NumeroPedido_VM516");

            dgvComprobantes_VM516.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarGrilla()
        {
            try
            {
                dgvComprobantes_VM516.DataSource = null;
                dgvComprobantes_VM516.DataSource = bllComprobante_VM516.ListarComprobantes_VM516();
                FormatearGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BloquearAccionesPago(bool habilitar)
        {
            cmbMedioPago_VM516.Enabled = habilitar;
            btnRegistrarCobro_VM516.Enabled = habilitar;
        }

        private void btnRegistrarCobro_VM516_Click(object sender, EventArgs e)
        {
            try
            {
                bool transaccionAprobadaPorBanco = true;

                decimal montoAbonado = decimal.Parse(txtMontoAbonado_VM516.Text);
                string medioPago = cmbMedioPago_VM516.SelectedItem != null ? cmbMedioPago_VM516.SelectedItem.ToString() : "";

                BE_ComprobanteCafeteria_VM516 comprobante = bllComprobante_VM516.ProcesarYRegistrarCobro_VM516(
                    pedidoVerificado_VM516,
                    medioPago,
                    montoAbonado,
                    transaccionAprobadaPorBanco);

                MessageBox.Show(TraducirTexto("msg_CobroRegistradoExito"), TraducirTexto("titulo_Exito"), MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarGrilla();
                lblEstadoPedido_VM516.Text = TraducirTexto("lbl_EstadoPedidoPagado");
                BloquearAccionesPago(false);
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "PDF Files|*.pdf";
                saveDialog.FileName = $"Ticket_{comprobante.NumeroTicket_VM516}.pdf";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    // 1. Obtenemos los datos del cliente que hizo el pedido
                    BLL_Cliente_VM516 bllCliente_VM516 = new BLL_Cliente_VM516();
                    BE_Cliente_VM516 cliente_VM516 = bllCliente_VM516.BuscarClientePorDNI_VM516(pedidoVerificado_VM516.Dni_Cliente_VM516);

                    // 2. Armamos el DataTable con la descripción, cantidad, precio unitario y subtotal de cada producto
                    BLL_Producto_VM516 bllProducto_VM516 = new BLL_Producto_VM516();
                    var catalogo_VM516 = bllProducto_VM516.ListarProductos_VM516();

                    DataTable dtItems_VM516 = new DataTable();
                    dtItems_VM516.Columns.Add("Cantidad", typeof(int));
                    dtItems_VM516.Columns.Add("Descripcion", typeof(string));
                    dtItems_VM516.Columns.Add("PrecioUnitario", typeof(decimal));
                    dtItems_VM516.Columns.Add("Subtotal", typeof(decimal));

                    foreach (var linea_VM516 in pedidoVerificado_VM516.LineasDetalle_VM516)
                    {
                        var prod_VM516 = catalogo_VM516.FirstOrDefault(p => p.CodigoProducto_VM516 == linea_VM516.CodigoProducto_VM516);
                        string descripcion_VM516 = prod_VM516 != null ? $"{prod_VM516.CodigoProducto_VM516} - {prod_VM516.Descripcion_VM516}" : linea_VM516.CodigoProducto_VM516;
                        decimal subtotal_VM516 = linea_VM516.Cantidad_VM516 * linea_VM516.PrecioUnitario_VM516;

                        dtItems_VM516.Rows.Add(
                            linea_VM516.Cantidad_VM516,
                            descripcion_VM516,
                            linea_VM516.PrecioUnitario_VM516,
                            subtotal_VM516
                        );
                    }

                    BLL_PDF bllPdf = new BLL_PDF();

                    bllPdf.GenerarTicketCafeteria_VM516(
                        comprobante.NumeroTicket_VM516,
                        comprobante.FechaHora_VM516,
                        comprobante.MontoAbonado_VM516,
                        comprobante.MedioPago_VM516,
                        comprobante.NumeroPedido_VM516,
                        cliente_VM516.Dni_VM516,
                        cliente_VM516.Nombre_VM516,
                        cliente_VM516.Apellido_VM516,
                        dtItems_VM516,
                        saveDialog.FileName
                    );

                    MessageBox.Show(TraducirTexto("PdfGenerado"), TraducirTexto("msg_Exito"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form_Cobrar_Pedido_VM516_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestorIdioma.GetInstancia().Desuscribir(this);
        }

        private void btnSalir_VM516_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

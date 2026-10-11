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
    public partial class Form_Retiro_Pedido_VM516 : Form, IObserverIdioma
    {
        private BLL_Pedido_VM516 bllPedido_VM516;
        private BLL_Producto_VM516 bllProducto_VM516;
        private BE_Pedido_VM516 pedidoVerificado_VM516;
        public Form_Retiro_Pedido_VM516()
        {
            InitializeComponent();
            bllPedido_VM516 = new BLL_Pedido_VM516();
            bllProducto_VM516 = new BLL_Producto_VM516();
        }

        private void Form_Retiro_Pedido_VM516_Load(object sender, EventArgs e)
        {
            GestorIdioma.GetInstancia().Suscribir(this);
            ConfigurarGrillaDetalle_VM516();
            CargarGrillaPendientes_VM516();
            ActualizarIdioma();

            Servicio_Usuario usuario = SessionManager.GetInstancia().GetUsuarioActual();
            BLL_Rol bllRol = new BLL_Rol();
            string nombreLegibleDelRol = bllRol.ObtenerNombreRol(usuario.IdRol);
            lblUsuarioValor_VM516.Text = $"{usuario.Login} - {nombreLegibleDelRol}";

            BloquearAccionEntrega_VM516(false);
        }
        public void ActualizarIdioma()
        {
            var usuario = SessionManager.GetInstancia().GetUsuarioActual();
            if (usuario == null) return;

            BLL_Idioma bllIdioma = new BLL_Idioma();
            Servicio_Idioma idioma = bllIdioma.ObtenerIdiomaPorId(usuario.Id_Idioma);

            if (idioma == null) return;

            TraducirControles(this.Controls, idioma);
            this.Text = TraducirTexto("titulo_FormRetiroPedido");
            FormatearGrillas_VM516();
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

        private void ConfigurarGrillaDetalle_VM516()
        {
            dgvDetallePedido_VM516.Columns.Clear();
            dgvDetallePedido_VM516.AutoGenerateColumns = false;

            dgvDetallePedido_VM516.Columns.Add(new DataGridViewTextBoxColumn { Name = "CodigoProducto_VM516" });
            dgvDetallePedido_VM516.Columns.Add(new DataGridViewTextBoxColumn { Name = "Descripcion_VM516" });
            dgvDetallePedido_VM516.Columns.Add(new DataGridViewTextBoxColumn { Name = "Cantidad_VM516" });
            dgvDetallePedido_VM516.Columns.Add(new DataGridViewTextBoxColumn { Name = "PrecioUnitario_VM516" });
        }

        private void FormatearGrillas_VM516()
        {
            // Grilla de Pedidos Pendientes
            if (dgvPedidosPendientes_VM516.Columns.Contains("NumeroPedido_VM516"))
                dgvPedidosPendientes_VM516.Columns["NumeroPedido_VM516"].HeaderText = TraducirTexto("NumeroPedido_VM516");
            if (dgvPedidosPendientes_VM516.Columns.Contains("EstadoPedido_VM516"))
                dgvPedidosPendientes_VM516.Columns["EstadoPedido_VM516"].HeaderText = TraducirTexto("EstadoPedido_VM516");
            if (dgvPedidosPendientes_VM516.Columns.Contains("Dni_Cliente_VM516"))
                dgvPedidosPendientes_VM516.Columns["Dni_Cliente_VM516"].HeaderText = TraducirTexto("Dni_VM516");

            // Grilla de Detalle de la Orden
            if (dgvDetallePedido_VM516.Columns.Contains("CodigoProducto_VM516"))
                dgvDetallePedido_VM516.Columns["CodigoProducto_VM516"].HeaderText = TraducirTexto("CodigoProducto_VM516");
            if (dgvDetallePedido_VM516.Columns.Contains("Descripcion_VM516"))
                dgvDetallePedido_VM516.Columns["Descripcion_VM516"].HeaderText = TraducirTexto("Descripcion_VM516");
            if (dgvDetallePedido_VM516.Columns.Contains("Cantidad_VM516"))
                dgvDetallePedido_VM516.Columns["Cantidad_VM516"].HeaderText = TraducirTexto("Cantidad_VM516");
            if (dgvDetallePedido_VM516.Columns.Contains("PrecioUnitario_VM516"))
                dgvDetallePedido_VM516.Columns["PrecioUnitario_VM516"].HeaderText = TraducirTexto("PrecioUnitario_VM516");

            dgvPedidosPendientes_VM516.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetallePedido_VM516.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Paso 1: Lista de pedidos pendientes de entrega
        private void CargarGrillaPendientes_VM516()
        {
            try
            {
                dgvPedidosPendientes_VM516.DataSource = null;
                dgvPedidosPendientes_VM516.DataSource = bllPedido_VM516.ListarPedidosPendientesEntrega_VM516();
                FormatearGrillas_VM516();
            }
            catch (Exception ex)
            {
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarDetalleOrden_VM516(BE_Pedido_VM516 pedido_VM516)
        {
            dgvDetallePedido_VM516.Rows.Clear();
            List<BE_Producto_VM516> catalogo_VM516 = bllProducto_VM516.ListarProductos_VM516();

            foreach (var linea_VM516 in pedido_VM516.LineasDetalle_VM516)
            {
                var prod_VM516 = catalogo_VM516.FirstOrDefault(p => p.CodigoProducto_VM516 == linea_VM516.CodigoProducto_VM516);
                string desc_VM516 = prod_VM516 != null ? prod_VM516.Descripcion_VM516 : linea_VM516.CodigoProducto_VM516;

                dgvDetallePedido_VM516.Rows.Add(
                    linea_VM516.CodigoProducto_VM516,
                    desc_VM516,
                    linea_VM516.Cantidad_VM516,
                    linea_VM516.PrecioUnitario_VM516.ToString("0.00")
                );
            }
        }

        private void BloquearAccionEntrega_VM516(bool habilitar)
        {
            btnRegistrarEntrega_VM516.Enabled = habilitar;
        }

        private void btnBuscarPedido_VM516_Click(object sender, EventArgs e)
        {
            try
            {
                pedidoVerificado_VM516 = bllPedido_VM516.BuscarPedidoParaRetiro_VM516(txtNumeroPedido_VM516.Text);

                MostrarDetalleOrden_VM516(pedidoVerificado_VM516);
                lblEstadoPedido_VM516.Text = TraducirTexto("msg_PedidoListoParaEntregar");
                lblEstadoPedido_VM516.ForeColor = Color.FromArgb(18, 120, 50);
                BloquearAccionEntrega_VM516(true);
            }
            catch (Exception ex)
            {
                // Flujo Alternativo 2.1: Muestra alerta indicando el estado, borra el campo de búsqueda y cancela la operación
                pedidoVerificado_VM516 = null;
                dgvDetallePedido_VM516.Rows.Clear();
                txtNumeroPedido_VM516.Clear();
                lblEstadoPedido_VM516.Text = TraducirTexto(ex.Message);
                lblEstadoPedido_VM516.ForeColor = Color.FromArgb(180, 40, 40);
                BloquearAccionEntrega_VM516(false);

                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRegistrarEntrega_VM516_Click(object sender, EventArgs e)
        {
            try
            {
                bllPedido_VM516.RegistrarEntregaPedido_VM516(pedidoVerificado_VM516);

                MessageBox.Show(TraducirTexto("msg_EntregaRegistradaExito"), TraducirTexto("titulo_Exito"), MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Paso 6: Quita el pedido de la lista visual de pendientes y limpia la operación
                CargarGrillaPendientes_VM516();
                dgvDetallePedido_VM516.Rows.Clear();
                txtNumeroPedido_VM516.Clear();
                lblEstadoPedido_VM516.Text = TraducirTexto("lbl_EstadoPedidoEsperaRetiro");
                lblEstadoPedido_VM516.ForeColor = Color.FromArgb(15, 45, 75);
                pedidoVerificado_VM516 = null;
                BloquearAccionEntrega_VM516(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form_Retiro_Pedido_VM516_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestorIdioma.GetInstancia().Desuscribir(this);
        }

        private void btnSalir_VM516_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerEntregados_VM516_Click(object sender, EventArgs e)
        {
            using (Form_Historial_Entregados_VM516 frmHistorial_VM516 = new Form_Historial_Entregados_VM516())
            {
                frmHistorial_VM516.ShowDialog();
            }
        }

    }
}

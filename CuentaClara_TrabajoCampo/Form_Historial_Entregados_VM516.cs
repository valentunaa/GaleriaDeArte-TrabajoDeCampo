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
    public partial class Form_Historial_Entregados_VM516 : Form, IObserverIdioma
    {
        private BLL_Pedido_VM516 bllPedido_VM516;
        public Form_Historial_Entregados_VM516()
        {
            InitializeComponent();
            ConfigurarToolTips();
            bllPedido_VM516 = new BLL_Pedido_VM516();
        }

        private void ConfigurarToolTips()
        {
            toolTipHistorialEntregados.SetToolTip(btnFiltrar_VM516, TraducirTexto("HistorialEntregados_Tip_Filtrar"));
            toolTipHistorialEntregados.SetToolTip(btnLimpiar_VM516, TraducirTexto("HistorialEntregados_Tip_VerTodos")); // btnLimpiar_VM516 es el botón "Ver Todos" según tu código
            toolTipHistorialEntregados.SetToolTip(btnSalir_VM516, TraducirTexto("HistorialEntregados_Tip_Salir"));
        }

        private void Form_Historial_Entregados_VM516_Load(object sender, EventArgs e)
        {
            GestorIdioma.GetInstancia().Suscribir(this);
            CargarGrilla_VM516();
            ActualizarIdioma();
        }
        public void ActualizarIdioma()
        {
            var usuario = SessionManager.GetInstancia().GetUsuarioActual();
            if (usuario == null) return;

            BLL_Idioma bllIdioma = new BLL_Idioma();
            Servicio_Idioma idioma = bllIdioma.ObtenerIdiomaPorId(usuario.Id_Idioma);

            if (idioma == null) return;

            TraducirControles(this.Controls, idioma);
            this.Text = TraducirTexto("titulo_FormHistorialEntregados");
            FormatearGrilla_VM516();
            ConfigurarToolTips();
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
            if (dgvEntregados_VM516.Columns.Contains("NumeroPedido_VM516"))
                dgvEntregados_VM516.Columns["NumeroPedido_VM516"].HeaderText = TraducirTexto("NumeroPedido_VM516");
            if (dgvEntregados_VM516.Columns.Contains("EstadoPedido_VM516"))
                dgvEntregados_VM516.Columns["EstadoPedido_VM516"].HeaderText = TraducirTexto("EstadoPedido_VM516");
            if (dgvEntregados_VM516.Columns.Contains("Dni_Cliente_VM516"))
                dgvEntregados_VM516.Columns["Dni_Cliente_VM516"].HeaderText = TraducirTexto("Dni_VM516");

            dgvEntregados_VM516.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarGrilla_VM516(string filtro_VM516 = "")
        {
            try
            {
                dgvEntregados_VM516.DataSource = null;
                dgvEntregados_VM516.DataSource = bllPedido_VM516.ListarPedidosEntregados_VM516(filtro_VM516);
                FormatearGrilla_VM516();
            }
            catch (Exception ex)
            {
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFiltrar_VM516_Click(object sender, EventArgs e)
        {
            CargarGrilla_VM516(txtFiltro_VM516.Text);
        }

        private void btnLimpiar_VM516_Click(object sender, EventArgs e)
        {
            txtFiltro_VM516.Clear();
            CargarGrilla_VM516();
        }

        private void btnSalir_VM516_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Historial_Entregados_VM516_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestorIdioma.GetInstancia().Desuscribir(this);
        }

        private void lblFiltro_VM516_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla_VM516(txtFiltro_VM516.Text);
        }
    }
}

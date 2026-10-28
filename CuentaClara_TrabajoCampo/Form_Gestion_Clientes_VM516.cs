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
    public partial class Form_Gestion_Clientes_VM516 : Form, IObserverIdioma
    {
        private BLL_Cliente_VM516 bllCliente_VM516;
        public Form_Gestion_Clientes_VM516()
        {
            InitializeComponent();
            ConfigurarToolTips();
            bllCliente_VM516 = new BLL_Cliente_VM516();
        }
        private void Form_Gestion_Clientes_VM516_Load(object sender, EventArgs e)
        {
            GestorIdioma.GetInstancia().Suscribir(this);
            CargarGrilla_VM516();
            ActualizarIdioma();
            HabilitarEdicion_VM516(false);

            Servicio_Usuario usuario = SessionManager.GetInstancia().GetUsuarioActual();

            BLL_Rol bllRol = new BLL_Rol();
            string nombreLegibleDelRol = bllRol.ObtenerNombreRol(usuario.IdRol);
            lblUsuarioValor_VM516.Text = $"{usuario.Login} - {nombreLegibleDelRol}";
  

        }

        private void ConfigurarToolTips()
        {
            toolTipClientes.SetToolTip(btnBuscarCliente_VM516, TraducirTexto("Cliente_Tip_Buscar"));
            toolTipClientes.SetToolTip(btnModificar_VM516, TraducirTexto("Cliente_Tip_Modificar"));
            toolTipClientes.SetToolTip(btnLimpiar_VM516, TraducirTexto("Cliente_Tip_Limpiar"));
            toolTipClientes.SetToolTip(btnSalir_VM516, TraducirTexto("Cliente_Tip_Salir"));
        }
        public void ActualizarIdioma()
        {
            var usuario = SessionManager.GetInstancia().GetUsuarioActual();
            if (usuario == null) return;

            BLL_Idioma bllIdioma = new BLL_Idioma();
            Servicio_Idioma idioma = bllIdioma.ObtenerIdiomaPorId(usuario.Id_Idioma);

            if (idioma == null) return;

            TraducirControles(this.Controls, idioma);
            this.Text = TraducirTexto("titulo_FormGestionClientes");
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
            if (dgvClientes_VM516.Columns.Contains("Dni_VM516"))
                dgvClientes_VM516.Columns["Dni_VM516"].HeaderText = TraducirTexto("Dni_VM516");
            if (dgvClientes_VM516.Columns.Contains("Nombre_VM516"))
                dgvClientes_VM516.Columns["Nombre_VM516"].HeaderText = TraducirTexto("Nombre_VM516");
            if (dgvClientes_VM516.Columns.Contains("Apellido_VM516"))
                dgvClientes_VM516.Columns["Apellido_VM516"].HeaderText = TraducirTexto("Apellido_VM516");
            if (dgvClientes_VM516.Columns.Contains("Telefono_VM516"))
                dgvClientes_VM516.Columns["Telefono_VM516"].HeaderText = TraducirTexto("Telefono_VM516");
            if (dgvClientes_VM516.Columns.Contains("Email_VM516"))
                dgvClientes_VM516.Columns["Email_VM516"].HeaderText = TraducirTexto("Email_VM516");

            dgvClientes_VM516.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarGrilla_VM516()
        {
            try
            {
                dgvClientes_VM516.DataSource = null;
                dgvClientes_VM516.DataSource = bllCliente_VM516.ListarClientes_VM516();
                FormatearGrilla_VM516();
            }
            catch (Exception ex)
            {
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HabilitarEdicion_VM516(bool habilitar)
        {
            txtNombre_VM516.Enabled = habilitar;
            txtApellido_VM516.Enabled = habilitar;
            txtTelefono_VM516.Enabled = habilitar;
            txtEmail_VM516.Enabled = habilitar;
            btnModificar_VM516.Enabled = habilitar;
        }

        private void LimpiarCampos_VM516()
        {
            txtDni_VM516.Clear();
            txtNombre_VM516.Clear();
            txtApellido_VM516.Clear();
            txtTelefono_VM516.Clear();
            txtEmail_VM516.Clear();
            txtBuscarDni_VM516.Clear();
            lblResultadoBusqueda_VM516.Text = TraducirTexto("lbl_ResultadoCliente");
            lblResultadoBusqueda_VM516.ForeColor = Color.DimGray;
            dgvClientes_VM516.ClearSelection();
            HabilitarEdicion_VM516(false);
        }

        private void CargarClienteEnControles_VM516(BE_Cliente_VM516 cliente_VM516)
        {
            txtDni_VM516.Text = cliente_VM516.Dni_VM516;
            txtNombre_VM516.Text = cliente_VM516.Nombre_VM516;
            txtApellido_VM516.Text = cliente_VM516.Apellido_VM516;
            txtTelefono_VM516.Text = cliente_VM516.Telefono_VM516;
            txtEmail_VM516.Text = cliente_VM516.Email_VM516;
            HabilitarEdicion_VM516(true);
        }
        private void btnBuscarCliente_VM516_Click(object sender, EventArgs e)
        {
            try
            {
                BE_Cliente_VM516 cliente_VM516 = bllCliente_VM516.BuscarClientePorDNI_VM516(txtBuscarDni_VM516.Text);

                CargarClienteEnControles_VM516(cliente_VM516);
                lblResultadoBusqueda_VM516.Text = $"✔ {cliente_VM516.Nombre_VM516} {cliente_VM516.Apellido_VM516} ({cliente_VM516.Dni_VM516})";
                lblResultadoBusqueda_VM516.ForeColor = Color.FromArgb(18, 120, 50);

                foreach (DataGridViewRow row in dgvClientes_VM516.Rows)
                {
                    if (row.DataBoundItem is BE_Cliente_VM516 item && item.Dni_VM516 == cliente_VM516.Dni_VM516)
                    {
                        row.Selected = true;
                        dgvClientes_VM516.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                LimpiarCampos_VM516();
                lblResultadoBusqueda_VM516.Text = TraducirTexto(ex.Message);
                lblResultadoBusqueda_VM516.ForeColor = Color.FromArgb(180, 40, 40);
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnModificar_VM516_Click(object sender, EventArgs e)
        {
            try
            {
                bllCliente_VM516.ModificarCliente_VM516(
                    txtDni_VM516.Text,
                    txtNombre_VM516.Text,
                    txtApellido_VM516.Text,
                    txtTelefono_VM516.Text,
                    txtEmail_VM516.Text
                );

                MessageBox.Show(TraducirTexto("msg_ClienteModificadoExito"), TraducirTexto("titulo_Exito"), MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void dgvClientes_VM516_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvClientes_VM516.Rows[e.RowIndex].DataBoundItem is BE_Cliente_VM516 cliente_VM516)
            {
                CargarClienteEnControles_VM516(cliente_VM516);
                lblResultadoBusqueda_VM516.Text = $"✔ {cliente_VM516.Nombre_VM516} {cliente_VM516.Apellido_VM516} ({cliente_VM516.Dni_VM516})";
                lblResultadoBusqueda_VM516.ForeColor = Color.FromArgb(18, 120, 50);
            }
        }

        private void btnSalir_VM516_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

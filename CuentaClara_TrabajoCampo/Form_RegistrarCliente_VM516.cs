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
    public partial class Form_RegistrarCliente_VM516 : Form, IObserverIdioma
    {
        private BLL_Cliente_VM516 bllCliente_VM516;

        public Form_RegistrarCliente_VM516()
        {
            InitializeComponent();
            bllCliente_VM516 = new BLL_Cliente_VM516();

        }
        public Form_RegistrarCliente_VM516(string dniPrecargado_VM516) : this()
        {
            txtDNI_VM516.Text = dniPrecargado_VM516;
            txtDNI_VM516.ReadOnly = true;

        }
        private void Form_RegistrarCliente_VM516_Load(object sender, EventArgs e)
        {
            GestorIdioma.GetInstancia().Suscribir(this);
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
            this.Text = TraducirTexto("titulo_FormRegistroCliente");

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

        private void btnGuardar_VM516_Click(object sender, EventArgs e)
        {
            try
            {
                bllCliente_VM516.RegistrarCliente_VM516(
                    txtDNI_VM516.Text,
                    txtNombre_VM516.Text,
                    txtApellido_VM516.Text,
                    txtTelefono_VM516.Text,
                    txtEmail_VM516.Text
                );

                MessageBox.Show(TraducirTexto("msg_ClienteRegistradoExito"), TraducirTexto("titulo_Exito"), MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Retorna inmediatamente al Paso 5 de Registrar Pedido
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form_RegistrarCliente_VM516_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestorIdioma.GetInstancia().Desuscribir(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

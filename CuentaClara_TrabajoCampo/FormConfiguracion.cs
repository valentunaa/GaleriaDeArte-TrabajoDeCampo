
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BLL;
namespace IU
{
    public partial class FormConfiguracion : Form, IObserverIdioma
    {
        private BLL_Usuario bllUsuario = new BLL_Usuario();

        private BLL_Idioma bllIdioma = new BLL_Idioma();
        public FormConfiguracion()
        {
            InitializeComponent();
            ConfigurarToolTips();
            GestorIdioma.GetInstancia().Suscribir(this);
        }


        private void FormConfiguracion_Load(object sender, EventArgs e)
        {
            cmbIdioma.DataSource = bllIdioma.ListarIdiomasBD();
            cmbIdioma.DisplayMember = "Nombre";
            cmbIdioma.ValueMember = "Id_Idioma";
            ActualizarIdioma();
        }

        private void ConfigurarToolTips()
        {
            toolTipConfig.SetToolTip(cmbIdioma, TraducirTexto("Config_Tip_Idioma"));
            toolTipConfig.SetToolTip(btnGuardarr, TraducirTexto("Config_Tip_Guardar")); // btnGuardarr es el botón Guardar según tu código
            toolTipConfig.SetToolTip(button1, TraducirTexto("Config_Tip_Salir"));      // button1 es el botón Salir según tu código
        }

        private void btnGuardarr_Click(object sender, EventArgs e)
        {
            if (cmbIdioma.SelectedValue == null) return;
            string nuevoIdioma = cmbIdioma.SelectedValue.ToString();
            
            bllUsuario.CambiarIdiomaEnSesion(nuevoIdioma);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ActualizarIdioma()
        {
            string idIdioma = cmbIdioma.SelectedValue.ToString();

            BLL_Idioma bllIdioma = new BLL_Idioma();

            Servicio_Idioma idioma =
                bllIdioma.ObtenerIdiomaPorId(idIdioma);

            if (idioma == null)
                return;

            TraducirControles(this.Controls, idioma);
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
            string idIdioma = SessionManager.GetInstancia().GetUsuarioActual().Id_Idioma;

            BLL_Idioma bllIdioma = new BLL_Idioma();

            Servicio_Idioma idioma = bllIdioma.ObtenerIdiomaPorId(idIdioma);

            if (idioma == null)
                return clave;

            var etiqueta = idioma.Etiquetas.FirstOrDefault(x => x.Clave == clave);

            return etiqueta != null ? etiqueta.Texto : clave;
        }

        private void FormConfiguracion_FormClosed(object sender, FormClosedEventArgs e)
        {

          GestorIdioma.GetInstancia().Desuscribir(this);

        }

        private void cmbIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarIdioma();
        }
    }
}

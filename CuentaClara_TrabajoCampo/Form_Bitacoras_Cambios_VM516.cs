using BLL;
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
    public partial class Form_Bitacoras_Cambios_VM516 : Form, IObserverIdioma
    {
        public Form_Bitacoras_Cambios_VM516()
        {
            InitializeComponent();
        }

        public void ActualizarIdioma()
        {
            string idIdioma = SessionManager.GetInstancia().GetUsuarioActual().Id_Idioma;

            BLL_Idioma bllIdioma = new BLL_Idioma();

            Servicio_Idioma idioma = bllIdioma.ObtenerIdiomaPorId(idIdioma);

            if (idioma == null)
                return;


            TraducirControles(this.Controls, idioma);
            this.Text = TraducirTexto("titulo_FormMenu");

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


        private void Form_Bitacoras_Cambios_VM516_Load(object sender, EventArgs e)
        {
            var usuario = SessionManager.GetInstancia().GetUsuarioActual();
            BLL_Rol bllRol = new BLL_Rol();
            string nombreLegibleDelRol = bllRol.ObtenerNombreRol(usuario.IdRol);
            lblUsuarioValor.Text = $"{usuario.Login} - {nombreLegibleDelRol}";
 
            GestorIdioma.GetInstancia().Suscribir(this);
            ActualizarIdioma();
        }

        private void btnBitacoraProductos_Click(object sender, EventArgs e)
        {
            Form_Auditoria_Productos_VM516 formAuditoriaProductos = new Form_Auditoria_Productos_VM516();
            formAuditoriaProductos.ShowDialog();
        }

        private void btnBitacoraObras_Click(object sender, EventArgs e)
        {
            Form_Auditoria_Especificacion_Obra_VM516 formAuditoriaObras = new Form_Auditoria_Especificacion_Obra_VM516();
            formAuditoriaObras.ShowDialog();
        }

        private void Form_Bitacoras_Cambios_VM516_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestorIdioma.GetInstancia().Desuscribir(this);
        }
    }
}

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
using Servicio;

namespace IU
{
    public partial class Form_Especificacion_Obra_VM516 : Form, IObserverIdioma
    {
        public Form_Especificacion_Obra_VM516()
        {
            InitializeComponent();
            bllObra = new BLL_Especificacion_Obra_VM516();
            bllArtista = new BLL_Artista_VM516();
        }
        private BLL_Especificacion_Obra_VM516 bllObra;
        private BLL_Artista_VM516 bllArtista;
        private string dniArtistaVerificado = "";

        private void Form_Especificacion_Obra_VM516_Load(object sender, EventArgs e)
        {
            GestorIdioma.GetInstancia().Suscribir(this);
            ActualizarIdioma();
            Servicio_Usuario usuario = SessionManager.GetInstancia().GetUsuarioActual();
            BLL_Rol bllRol = new BLL_Rol();
            string nombreLegibleDelRol = bllRol.ObtenerNombreRol(usuario.IdRol);

            lblUsuarioValor.Text = $"{usuario.Login} -  {nombreLegibleDelRol}";

            BloquearCamposObra(false);
            CargarGrilla();

        }
        public void ActualizarIdioma()
        {
            string idIdioma = SessionManager.GetInstancia().GetUsuarioActual().Id_Idioma;
            BLL_Idioma bllIdioma = new BLL_Idioma();
            Servicio_Idioma idioma = bllIdioma.ObtenerIdiomaPorId(idIdioma);

            if (idioma == null)
                return;

            TraducirControles(this.Controls, idioma);

            this.Text = TraducirTexto("titulo_FormEspecificacionObra");
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

            if (idioma == null)
                return clave;

            var etiqueta = idioma.Etiquetas.FirstOrDefault(x => x.Clave == clave);
            return etiqueta != null ? etiqueta.Texto : clave;
        }
        private void FormatearGrilla()
        {
            if (dgvEspecificaciones.Columns.Contains("Id_Obra_VM516"))
                dgvEspecificaciones.Columns["Id_Obra_VM516"].HeaderText = TraducirTexto("Id_Obra_VM516");

            if (dgvEspecificaciones.Columns.Contains("DNI_Artista_VM516"))
                dgvEspecificaciones.Columns["DNI_Artista_VM516"].HeaderText = TraducirTexto("DNI_Artista_VM516");

            if (dgvEspecificaciones.Columns.Contains("Titulo_Obra_VM516"))
                dgvEspecificaciones.Columns["Titulo_Obra_VM516"].HeaderText = TraducirTexto("Titulo_Obra_VM516");

            if (dgvEspecificaciones.Columns.Contains("Tecnica_VM516"))
                dgvEspecificaciones.Columns["Tecnica_VM516"].HeaderText = TraducirTexto("Tecnica_VM516");

            if (dgvEspecificaciones.Columns.Contains("Alto_VM516"))
                dgvEspecificaciones.Columns["Alto_VM516"].HeaderText = TraducirTexto("Alto_VM516");

            if (dgvEspecificaciones.Columns.Contains("Ancho_VM516"))
                dgvEspecificaciones.Columns["Ancho_VM516"].HeaderText = TraducirTexto("Ancho_VM516");

            if (dgvEspecificaciones.Columns.Contains("Peso_VM516"))
                dgvEspecificaciones.Columns["Peso_VM516"].HeaderText = TraducirTexto("Peso_VM516");

            if (dgvEspecificaciones.Columns.Contains("Req_Iluminacion_VM516"))
                dgvEspecificaciones.Columns["Req_Iluminacion_VM516"].HeaderText = TraducirTexto("Req_Iluminacion_VM516");

            if (dgvEspecificaciones.Columns.Contains("Valor_Declarado_Mercado_VM516"))
                dgvEspecificaciones.Columns["Valor_Declarado_Mercado_VM516"].HeaderText = TraducirTexto("Valor_Declarado_Mercado_VM516");

            if (dgvEspecificaciones.Columns.Contains("Categoria_Seguro_VM516"))
                dgvEspecificaciones.Columns["Categoria_Seguro_VM516"].HeaderText = TraducirTexto("Categoria_Seguro_VM516");

            if (dgvEspecificaciones.Columns.Contains("Estado_Asignacion_VM516"))
                dgvEspecificaciones.Columns["Estado_Asignacion_VM516"].HeaderText = TraducirTexto("Estado_Asignacion_VM516");

            dgvEspecificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
       


        private void CargarGrilla()
        {
            try
            {
                dgvEspecificaciones.DataSource = null;
                dgvEspecificaciones.DataSource = bllObra.ListarEspecificaciones();
                FormatearGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BloquearCamposObra(bool habilitar)
        {
            txtTitulo.Enabled = habilitar;
            txtTecnica.Enabled = habilitar;
            txtAlto.Enabled = habilitar;
            txtAncho.Enabled = habilitar;
            txtPeso.Enabled = habilitar;
            comboBox2.Enabled = habilitar;
            txtValorMercado.Enabled = habilitar;
            comboBox1.Enabled = habilitar;
            btnConfirmarRegistro.Enabled = habilitar;
        }

        private void LimpiarCamposObra()
        {
            txtDNIBuscar.Clear();
            txtTitulo.Clear();
            txtTecnica.Clear();
            txtAlto.Clear();
            txtAncho.Clear();
            txtPeso.Clear();

            txtValorMercado.Clear();

            lblNombreArtista.Text = TraducirTexto("lbl_EstadoArtistaPendiente");
            lblNombreArtista.ForeColor = System.Drawing.Color.FromArgb(15, 45, 75);
            dniArtistaVerificado = "";
            BloquearCamposObra(false);
            txtDNIBuscar.Focus();
        }



        private void btnBuscarArtista_Click_1(object sender, EventArgs e)
        {
            try
            {
                string dni = txtDNIBuscar.Text.Trim();
                var artista = bllArtista.BuscarArtistaPorDNI_VM516(dni);

                if (artista != null)
                {
                    dniArtistaVerificado = artista.DNI_VM516;
                    lblNombreArtista.Text = $"Artista verificado: {artista.Nombre_VM516} {artista.Apellido_VM516}";
                    lblNombreArtista.ForeColor = System.Drawing.Color.FromArgb(18, 120, 50);
                    BloquearCamposObra(true);
                }
            }
            catch (Exception ex)
            {
                dniArtistaVerificado = "";
                lblNombreArtista.Text = TraducirTexto("err_ArtistaNoRegistradoObra");
                lblNombreArtista.ForeColor = System.Drawing.Color.FromArgb(180, 40, 40);
                BloquearCamposObra(false);
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnConfirmarRegistro_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(dniArtistaVerificado))
                {
                    throw new Exception("err_DebeVerificarArtistaObra");
                }


                bllObra.RegistrarEspecificacion_VM516(
                    dniArtistaVerificado,
                    txtTitulo.Text.Trim(),
                    txtTecnica.Text.Trim(),
                    txtAlto.Text.Trim(),
                    txtAncho.Text.Trim(),
                    txtPeso.Text.Trim(),
                    comboBox1.Text.Trim(),
                    txtValorMercado.Text.Trim(),
                    comboBox2.Text.Trim()
                );

                MessageBox.Show(
                    TraducirTexto("msg_ExitoRegistroObra"),
                    TraducirTexto("titulo_Exito"),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                CargarGrilla();
                LimpiarCamposObra();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validación / Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Especificacion_Obra_VM516_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestorIdioma.GetInstancia().Desuscribir(this);
        }
    }
}

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
    public partial class Form_Retiro_Obra_VM516 : Form, IObserverIdioma
    {
        private BLL_Retiro_Obra_VM516 bllRetiro_VM516;
        private BE_Reserva_Sala_VM516 reservaVerificada;
        public Form_Retiro_Obra_VM516()
        {
            InitializeComponent();
            bllRetiro_VM516 = new BLL_Retiro_Obra_VM516();
        }
        private void Form_Retiro_Obra_VM516_Load(object sender, EventArgs e)
        {
            GestorIdioma.GetInstancia().Suscribir(this);
            ActualizarIdioma();
            CargarGrilla();

            Servicio_Usuario usuario = SessionManager.GetInstancia().GetUsuarioActual();
            BLL_Rol bllRol = new BLL_Rol();
            string nombreLegibleDelRol = bllRol.ObtenerNombreRol(usuario.IdRol);
            lblUsuarioValor.Text = $"{usuario.Login} - {nombreLegibleDelRol}";

            BloquearAccionesDesmontaje(false);
        }
        public void ActualizarIdioma()
        {
            string idIdioma = SessionManager.GetInstancia().GetUsuarioActual().Id_Idioma;
            BLL_Idioma bllIdioma = new BLL_Idioma();
            Servicio_Idioma idioma = bllIdioma.ObtenerIdiomaPorId(idIdioma);

            if (idioma == null) return;

            TraducirControles(this.Controls, idioma);
            this.Text = TraducirTexto("titulo_FormRetiroObra");
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
            if (dgvRetiros.Columns.Contains("Codigo_Reserva_VM516"))
                dgvRetiros.Columns["Codigo_Reserva_VM516"].HeaderText = TraducirTexto("Codigo_Reserva_VM516");
            if (dgvRetiros.Columns.Contains("DNI_Responsable_Desmontaje_VM516"))
                dgvRetiros.Columns["DNI_Responsable_Desmontaje_VM516"].HeaderText = TraducirTexto("DNI_Responsable_Desmontaje_VM516");
            if (dgvRetiros.Columns.Contains("Fecha_Retiro_VM516"))
                dgvRetiros.Columns["Fecha_Retiro_VM516"].HeaderText = TraducirTexto("Fecha_Retiro_VM516");

            dgvRetiros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarGrilla()
        {
            try
            {
                dgvRetiros.DataSource = null;
                dgvRetiros.DataSource = bllRetiro_VM516.ListarRetiros_VM516();
                FormatearGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BloquearAccionesDesmontaje(bool habilitar)
        {
            txtDniResponsable.Enabled = habilitar;
            btnRegistrarDesmontaje.Enabled = habilitar;
        }


        private void btnRegistrarDesmontaje_Click(object sender, EventArgs e)
        {
            try
            {
                if (reservaVerificada == null)
                    throw new Exception("err_DebeBuscarReservaPrimero");

                string dniResponsable = txtDniResponsable.Text.Trim();

                bllRetiro_VM516.RegistrarDesmontaje_VM516(reservaVerificada.Codigo_Reserva_VM516, dniResponsable);

                MessageBox.Show(
                    TraducirTexto("msg_DesmontajeExitoso"),
                    TraducirTexto("titulo_Exito"),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "PDF Files|*.pdf";
                saveDialog.FileName = $"Constancia_LibreDeuda_{reservaVerificada.Codigo_Reserva_VM516}.pdf";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    BLL_PDF bllPdf = new BLL_PDF();

                    bllPdf.GenerarConstanciaLibreDeuda_VM516(
                        reservaVerificada.Codigo_Reserva_VM516,
                        dniResponsable,
                        DateTime.Now,
                        saveDialog.FileName
                    );

                    MessageBox.Show(TraducirTexto("PdfGenerado"), TraducirTexto("titulo_Exito"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CargarGrilla();
                txtCodigoReserva.Clear();
                txtDniResponsable.Clear();
                lblInfoReserva.Text = TraducirTexto("lbl_InfoReservaPendiente");
                BloquearAccionesDesmontaje(false);
                reservaVerificada = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBuscarReserva_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigoReserva.Text.Trim();
                reservaVerificada = bllRetiro_VM516.BuscarReservaParaDesmontaje_VM516(codigo);

                lblInfoReserva.Text = $"{TraducirTexto("lbl_InfoReservaSaldada")} [Saldado] - Sala: {reservaVerificada.Codigo_Sala_VM516}";
                lblInfoReserva.ForeColor = Color.FromArgb(18, 120, 50);
                BloquearAccionesDesmontaje(true);
            }
            catch (Exception ex)
            {
                reservaVerificada = null;
                txtDniResponsable.Clear();
                lblInfoReserva.Text = TraducirTexto("lbl_InfoReservaNoValida");
                lblInfoReserva.ForeColor = Color.FromArgb(180, 40, 40);
                BloquearAccionesDesmontaje(false);
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Retiro_Obra_VM516_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestorIdioma.GetInstancia().Desuscribir(this);
        }
    }
}

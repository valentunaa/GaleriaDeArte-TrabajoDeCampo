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
    public partial class Form_Inspeccion_Obra_VM516 : Form, IObserverIdioma
    {
        private BLL_Inspeccion_Obra_VM516 bllInspeccion_VM516;
        private BLL_Reserva_Sala_VM516 bllReserva_VM516;
        private string reservaEncontradaCodigo = "";
        public Form_Inspeccion_Obra_VM516()
        {
            InitializeComponent();
            bllInspeccion_VM516 = new BLL_Inspeccion_Obra_VM516();
            bllReserva_VM516 = new BLL_Reserva_Sala_VM516();
        }

        private void Form_Inspeccion_Obra_VM516_Load(object sender, EventArgs e)
        {
            GestorIdioma.GetInstancia().Suscribir(this);
            ActualizarIdioma();
            CargarGrillaInspecciones();
            Servicio_Usuario usuario = SessionManager.GetInstancia().GetUsuarioActual();
            BLL_Rol bllRol = new BLL_Rol();
            string nombreLegibleDelRol = bllRol.ObtenerNombreRol(usuario.IdRol);
            lblUsuarioValor.Text = $"Usuario activo: {usuario.Login} - {nombreLegibleDelRol}";

        }

        public void ActualizarIdioma()
        {
            string idIdioma = SessionManager.GetInstancia().GetUsuarioActual().Id_Idioma;
            BLL_Idioma bllIdioma = new BLL_Idioma();
            Servicio_Idioma idioma = bllIdioma.ObtenerIdiomaPorId(idIdioma);

            if (idioma == null) return;

            TraducirControles(this.Controls, idioma);
            this.Text = TraducirTexto("titulo_FormInspeccion");
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
            if (dgvInspecciones.Columns.Contains("Codigo_Reserva_VM516"))
                dgvInspecciones.Columns["Codigo_Reserva_VM516"].HeaderText = TraducirTexto("Codigo_Reserva_VM516");
            if (dgvInspecciones.Columns.Contains("Estado_Post_Exhibicion_VM516"))
                dgvInspecciones.Columns["Estado_Post_Exhibicion_VM516"].HeaderText = TraducirTexto("Estado_Post_Exhibicion_VM516");
            if (dgvInspecciones.Columns.Contains("Observaciones_Fisicas_VM516"))
                dgvInspecciones.Columns["Observaciones_Fisicas_VM516"].HeaderText = TraducirTexto("Observaciones_Fisicas_VM516");
            if (dgvInspecciones.Columns.Contains("Fecha_Inspeccion_VM516"))
                dgvInspecciones.Columns["Fecha_Inspeccion_VM516"].HeaderText = TraducirTexto("Fecha_Inspeccion_VM516");

            dgvInspecciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarGrillaInspecciones()
        {
            try
            {
                dgvInspecciones.DataSource = null;
                dgvInspecciones.DataSource = bllInspeccion_VM516.ListarInspecciones_VM516();
                FormatearGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(TraducirTexto("err_ErrorCargarHistorialPeritajes") + ": " + ex.Message, TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            txtCodigoReserva.Clear();
            lblInfoReserva.Text = TraducirTexto("lbl_InfoReservaPendiente");
            cboEstadoExhibicion.SelectedIndex = -1;
            cboEstadoExhibicion.Enabled = false;
            txtObservaciones.Clear();
            txtObservaciones.Enabled = false;
            btnConfirmarPeritaje.Enabled = false;
            reservaEncontradaCodigo = "";
            txtCodigoReserva.Focus();
        }

        private void btnBuscarReserva_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigoReserva.Text.Trim();

                var reserva = bllReserva_VM516.BuscarReservaParaPeritaje_VM516(codigo);

                reservaEncontradaCodigo = reserva.Codigo_Reserva_VM516;
                lblInfoReserva.Text = $"Reserva: {reserva.Codigo_Reserva_VM516} | Sala: {reserva.Codigo_Sala_VM516} | Obra ID: {reserva.Id_Obra_VM516} | Estado: {reserva.Estado_Espacio_VM516}";

                cboEstadoExhibicion.Enabled = true;
                txtObservaciones.Enabled = true;
                btnConfirmarPeritaje.Enabled = true;
                cboEstadoExhibicion.Focus();
            }
            catch (Exception ex)
            {
                reservaEncontradaCodigo = "";
                lblInfoReserva.Text = TraducirTexto("lbl_InfoReservaNoEncontrada");
                cboEstadoExhibicion.Enabled = false;
                txtObservaciones.Enabled = false;
                btnConfirmarPeritaje.Enabled = false;

                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_ValidacionError"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnConfirmarPeritaje_Click(object sender, EventArgs e)
        {
            try
            {
                string estadoSeleccionado = cboEstadoExhibicion.SelectedItem?.ToString();
                string observaciones = txtObservaciones.Text.Trim();

                bllInspeccion_VM516.RegistrarInspeccion_VM516(reservaEncontradaCodigo, estadoSeleccionado, observaciones);

                if (estadoSeleccionado.Equals("Intacto", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(TraducirTexto("msg_PeritajeIntactoExito"), TraducirTexto("titulo_PeritajeExitoso"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(TraducirTexto("msg_PeritajeDañadoAdvertencia"), TraducirTexto("titulo_AtencionObraDanada"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                CargarGrillaInspecciones();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_ValidacionError"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form_Inspeccion_Obra_VM516_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestorIdioma.GetInstancia().Desuscribir(this);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

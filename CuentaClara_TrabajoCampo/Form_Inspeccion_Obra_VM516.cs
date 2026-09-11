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
    public partial class Form_Inspeccion_Obra_VM516 : Form
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
            Servicio_Usuario usuario = SessionManager.GetInstancia().GetUsuarioActual();
            BLL_Rol bllRol = new BLL_Rol();
            string nombreLegibleDelRol = bllRol.ObtenerNombreRol(usuario.IdRol);
            lblUsuarioValor.Text = $"Usuario activo: {usuario.Login} - {nombreLegibleDelRol}";
            CargarGrillaInspecciones();
        }

        private void FormatearGrilla()
        {
            if (dgvInspecciones.Columns.Contains("Codigo_Reserva_VM516"))
                dgvInspecciones.Columns["Codigo_Reserva_VM516"].HeaderText = "Cod. Reserva";
            if (dgvInspecciones.Columns.Contains("Estado_Post_Exhibicion_VM516"))
                dgvInspecciones.Columns["Estado_Post_Exhibicion_VM516"].HeaderText = "Estado Post-Exhibición";
            if (dgvInspecciones.Columns.Contains("Observaciones_Fisicas_VM516"))
                dgvInspecciones.Columns["Observaciones_Fisicas_VM516"].HeaderText = "Observaciones Físicas";
            if (dgvInspecciones.Columns.Contains("Fecha_Inspeccion_VM516"))
                dgvInspecciones.Columns["Fecha_Inspeccion_VM516"].HeaderText = "Fecha Inspección";

            dgvInspecciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarGrillaInspecciones()
        {
            try
            {
                dgvInspecciones.DataSource = null;
                dgvInspecciones.DataSource = bllInspeccion_VM516.ListarInspecciones();
                FormatearGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el historial de peritajes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            txtCodigoReserva.Clear();
            lblInfoReserva.Text = "Información de la reserva: [Pendiente]";
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
                lblInfoReserva.Text = "Información de la reserva: [No encontrada]";
                cboEstadoExhibicion.Enabled = false;
                txtObservaciones.Enabled = false;
                btnConfirmarPeritaje.Enabled = false;

                MessageBox.Show(ex.Message, "Sin resultados / Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Peritaje de egreso registrado con éxito. La obra se encuentra en estado Intacto. Póliza de seguro liberada de responsabilidades.",
                        "Peritaje Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Peritaje registrado. Obra registrada como Dañada. Trámite de seguro de la galería retenido para peritaje de liquidación externa. Se inhabilita provisionalmente el desmontaje.",
                        "Atención - Obra Dañada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                CargarGrillaInspecciones();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validación / Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

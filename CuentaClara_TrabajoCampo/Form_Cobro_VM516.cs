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
    public partial class Form_Cobro_VM516 : Form, IObserverIdioma
    {
        private BLL_Comprobante_Pago_VM516 bllComprobante_VM516;
        private BLL_Reserva_Sala_VM516 bllReserva_VM516;
        private BE_Reserva_Sala_VM516 reservaVerificada;
        private BLL_Especificacion_Obra_VM516 bllObra_VM516;
        private BLL_Artista_VM516 bllArtista_VM516;
        private bool pagoValidadoExternamente = false;
        public Form_Cobro_VM516()
        {
            InitializeComponent();
            bllComprobante_VM516 = new BLL_Comprobante_Pago_VM516();
            bllReserva_VM516 = new BLL_Reserva_Sala_VM516();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void Form_Cobro_VM516_Load(object sender, EventArgs e)
        {
            GestorIdioma.GetInstancia().Suscribir(this);
            ActualizarIdioma();
            CargarGrilla();

            Servicio_Usuario usuario = SessionManager.GetInstancia().GetUsuarioActual();
            BLL_Rol bllRol = new BLL_Rol();
            string nombreLegibleDelRol = bllRol.ObtenerNombreRol(usuario.IdRol);
            lblUsuarioValor.Text = $"{usuario.Login} - {nombreLegibleDelRol}";

            BloquearAccionesPago(false);
        }
        public void ActualizarIdioma()
        {
            string idIdioma = SessionManager.GetInstancia().GetUsuarioActual().Id_Idioma;
            BLL_Idioma bllIdioma = new BLL_Idioma();
            Servicio_Idioma idioma = bllIdioma.ObtenerIdiomaPorId(idIdioma);

            if (idioma == null) return;

            TraducirControles(this.Controls, idioma);
            this.Text = TraducirTexto("titulo_FormCobros");
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
            if (dgvComprobantes.Columns.Contains("Nro_Comprobante_VM516"))
                dgvComprobantes.Columns["Nro_Comprobante_VM516"].HeaderText = TraducirTexto("Nro_Comprobante_VM516");
            if (dgvComprobantes.Columns.Contains("Fecha_Pago_VM516"))
                dgvComprobantes.Columns["Fecha_Pago_VM516"].HeaderText = TraducirTexto("Fecha_Pago_VM516");
            if (dgvComprobantes.Columns.Contains("Monto_Abonado_VM516"))
                dgvComprobantes.Columns["Monto_Abonado_VM516"].HeaderText = TraducirTexto("Monto_Abonado_VM516");
            if (dgvComprobantes.Columns.Contains("DNI_VM516"))
                dgvComprobantes.Columns["DNI_VM516"].HeaderText = TraducirTexto("DNI_VM516");
            if (dgvComprobantes.Columns.Contains("Nombre_VM516"))
                dgvComprobantes.Columns["Nombre_VM516"].HeaderText = TraducirTexto("Nombre_VM516");
            if (dgvComprobantes.Columns.Contains("Apellido_VM516"))
                dgvComprobantes.Columns["Apellido_VM516"].HeaderText = TraducirTexto("Apellido_VM516");
            if (dgvComprobantes.Columns.Contains("Medio_Pago_VM516"))
                dgvComprobantes.Columns["Medio_Pago_VM516"].HeaderText = TraducirTexto("Medio_Pago_VM516");
            if (dgvComprobantes.Columns.Contains("Porcentaje_Sena_Aplicado_VM516"))
                dgvComprobantes.Columns["Porcentaje_Sena_Aplicado_VM516"].HeaderText = TraducirTexto("Porcentaje_Sena_Aplicado_VM516");
            if (dgvComprobantes.Columns.Contains("Codigo_Reserva_VM516"))
                dgvComprobantes.Columns["Codigo_Reserva_VM516"].HeaderText = TraducirTexto("Codigo_Reserva_VM516");

            dgvComprobantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarGrilla()
        {
            try
            {
                dgvComprobantes.DataSource = null;
                dgvComprobantes.DataSource = bllComprobante_VM516.ListarComprobantes_VM516();
                FormatearGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BloquearAccionesPago(bool habilitar)
        {
            cmbMedioPago.Enabled = habilitar;
           
            btnRegistrarCobro.Enabled = habilitar;
        }

        private void btnBuscarReserva_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = txtCodigoReserva.Text.Trim();

               
                reservaVerificada = bllReserva_VM516.BuscarReservaParaCobranza_VM516(codigo);

                if (reservaVerificada.Estado_Pago_VM516 == "Pendiente_Sena")
                {
                    decimal montoSeña = (reservaVerificada.Monto_Alquiler_Total_VM516 * reservaVerificada.Porcentaje_Sena_VM516) / 100;
                    txtMontoAbonado.Text = montoSeña.ToString("0.00");
                    lblEstadoReserva.Text = TraducirTexto("msg_ReservaEncontradaPendiente");
                }
                else if (reservaVerificada.Estado_Pago_VM516 == "Sena_Abonada")
                {
                    txtMontoAbonado.Text = reservaVerificada.Saldo_Restante_A_Pagar_VM516.ToString("0.00");
                    lblEstadoReserva.Text = TraducirTexto("msg_ReservaSenaAbonada");
                }

                lblEstadoReserva.ForeColor = Color.FromArgb(18, 120, 50);
                BloquearAccionesPago(true);
            }
            catch (Exception ex)
            {
                reservaVerificada = null;
                txtMontoAbonado.Clear();
                lblEstadoReserva.Text = TraducirTexto("err_ReservaSinSaldoPendiente");
                lblEstadoReserva.ForeColor = Color.FromArgb(180, 40, 40);
                BloquearAccionesPago(false);
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

        private void btnRegistrarCobro_Click(object sender, EventArgs e)
        {
            try
            {
                if (reservaVerificada == null)
                    throw new Exception("err_DebeBuscarReservaPrimero");

                if (cmbMedioPago.SelectedItem == null)
                    throw new Exception("err_SeleccioneMedioPago");
  
                bool transaccionAprobadaPorBanco = true;

                if (!transaccionAprobadaPorBanco)
                {
                    throw new Exception("err_TransaccionRechazadaFinanciera");
                }

                decimal montoAbonado = decimal.Parse(txtMontoAbonado.Text);
                string medioPago = cmbMedioPago.SelectedItem.ToString();
                bool esPagoFinal = (reservaVerificada.Estado_Pago_VM516 == "Sena_Abonada");
 
                BE_Comprobante_Pago_VM516 comprobante = bllComprobante_VM516.ProcesarYRegistrarCobro_VM516(reservaVerificada, medioPago, montoAbonado);

                MessageBox.Show(TraducirTexto("msg_CobroRegistradoExito"), TraducirTexto("titulo_Exito"), MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarGrilla();
                txtCodigoReserva.Clear();
                txtMontoAbonado.Clear();
                lblEstadoReserva.Text = TraducirTexto("lbl_EstadoReservaPendiente");
                BloquearAccionesPago(false);
                reservaVerificada = null;

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "PDF Files|*.pdf";
                saveDialog.FileName = $"Comprobante_{comprobante.Nro_Comprobante_VM516}.pdf";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                   
                    BLL_PDF bllPdf = new BLL_PDF();

                    bllPdf.GenerarComprobante_VM516(
                        comprobante.Nro_Comprobante_VM516,
                        comprobante.Fecha_Pago_VM516,
                        comprobante.Monto_Abonado_VM516,
                        comprobante.DNI_VM516,
                        comprobante.Nombre_VM516,
                        comprobante.Apellido_VM516,
                        comprobante.Medio_Pago_VM516,
                        comprobante.Porcentaje_Sena_Aplicado_VM516,
                        comprobante.Codigo_Reserva_VM516,
                        saveDialog.FileName,
                        esPagoFinal
                    );

                    MessageBox.Show(TraducirTexto("PdfGenerado"), TraducirTexto("msg_Exito"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form_Cobro_VM516_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestorIdioma.GetInstancia().Desuscribir(this);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

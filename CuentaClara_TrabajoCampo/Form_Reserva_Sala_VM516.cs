using BE;
using BLL_Negocio;
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
    public partial class Form_Reserva_Sala_VM516 : Form
    {
        private BLL_Reserva_Sala_VM516 bllReserva;
        private string codigoSalaSeleccionada = "";
        public Form_Reserva_Sala_VM516()
        {
            InitializeComponent();
        }

        private void Form_Reserva_Sala_VM516_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultarDisponibilidad_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtIdObra.Text.Trim(), out int idObra))
                {
                    throw new Exception("Debe ingresar un ID de obra válido para consultar las especificaciones.");
                }

                DateTime inicio = dtpFechaInicio.Value;
                DateTime fin = dtpFechaFin.Value;

                var dtSalas = bllReserva.ObtenerSalasDisponiblesPorObra(idObra, inicio, fin);

                if (dtSalas.Rows.Count == 0)
                {
                    MessageBox.Show("No existen salas compatibles disponibles en el período solicitado.", "Sin disponibilidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvSalas.DataSource = null;
                dgvSalas.DataSource = dtSalas;
                FormatearGrillaSalas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validación / Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnConfirmarReserva_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSalas.SelectedRows.Count == 0)
                {
                    throw new Exception("Debe seleccionar una sala de la grilla interactiva para continuar.");
                }

                var row = dgvSalas.SelectedRows[0];
                codigoSalaSeleccionada = row.Cells["Codigo_Sala"].Value.ToString();

                if (!int.TryParse(txtIdObra.Text.Trim(), out int idObra))
                {
                    throw new Exception("ID de obra inválido.");
                }

                if (!decimal.TryParse(txtMontoTotal.Text.Trim(), out decimal montoTotal) || montoTotal <= 0)
                {
                    throw new Exception("El monto total del alquiler debe ser un valor numérico superior a cero.");
                }

                if (!decimal.TryParse(txtPorcentajeSena.Text.Trim(), out decimal porcentajeSena) || porcentajeSena < 1 || porcentajeSena > 100)
                {
                    throw new Exception("El porcentaje de seña requerido debe ser un valor mayor a 0% y menor o igual al 100%.");
                }

                BE_Reserva_Sala_VM516 nuevaReserva = new BE_Reserva_Sala_VM516
                {
                    Codigo_Sala_VM516 = codigoSalaSeleccionada,
                    Id_Obra_VM516 = idObra,
                    Fecha_Inicio_VM516 = dtpFechaInicio.Value,
                    Fecha_Fin_VM516 = dtpFechaFin.Value
                };

                bllReserva.RegistrarReserva_VM516(nuevaReserva, montoTotal, porcentajeSena);

                MessageBox.Show("Espacio de exhibición adjudicado con éxito. La reserva ha sido registrada y se encuentra en espera para el cobro de la seña", "Reserva Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validación / Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormatearGrillaSalas()
        {
            if (dgvSalas.Columns.Contains("Codigo_Sala"))
                dgvSalas.Columns["Codigo_Sala"].HeaderText = "Código Sala";
            if (dgvSalas.Columns.Contains("Nombre_Sala"))
                dgvSalas.Columns["Nombre_Sala"].HeaderText = "Nombre";
            if (dgvSalas.Columns.Contains("Alto_Max_Soportado"))
                dgvSalas.Columns["Alto_Max_Soportado"].HeaderText = "Alto Máx";
            if (dgvSalas.Columns.Contains("Ancho_Max_Soportado"))
                dgvSalas.Columns["Ancho_Max_Soportado"].HeaderText = "Ancho Máx";
            if (dgvSalas.Columns.Contains("Peso_Max_Soportado"))
                dgvSalas.Columns["Peso_Max_Soportado"].HeaderText = "Peso Máx";
            if (dgvSalas.Columns.Contains("Tipo_Iluminacion_Disponible"))
                dgvSalas.Columns["Tipo_Iluminacion_Disponible"].HeaderText = "Iluminación";
        }

        private void CargarGrillaVacia()
        {
            try
            {
                dgvSalas.DataSource = null;
                dgvSalas.DataSource = bllReserva.ListarReservas();
            }
            catch
            {
               
            }
        }

        private void LimpiarFormulario()
        {
            txtIdObra.Clear();
            txtMontoTotal.Clear();
            txtPorcentajeSena.Clear();
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;
            codigoSalaSeleccionada = "";
            CargarGrillaVacia();
            txtIdObra.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

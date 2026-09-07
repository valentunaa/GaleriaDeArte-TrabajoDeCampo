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
    public partial class Form_Reserva_Sala_VM516 : Form
    {
        private BLL_Reserva_Sala_VM516 bllReserva;
        private BLL_Especificacion_Obra_VM516 bllObra;
        private string codigoSalaSeleccionada = "";
        public Form_Reserva_Sala_VM516()
        {
            InitializeComponent(); bllReserva = new BLL_Reserva_Sala_VM516();
            bllObra = new BLL_Especificacion_Obra_VM516();
        }
        private void Form_Reserva_Sala_VM516_Load(object sender, EventArgs e)
        {
            dgvSalas.DataSource = null;
            Servicio_Usuario usuario = SessionManager.GetInstancia().GetUsuarioActual();
            BLL_Rol bllRol = new BLL_Rol();
            string nombreLegibleDelRol = bllRol.ObtenerNombreRol(usuario.IdRol);

            lblUsuarioValor.Text = $"{usuario.Login} -  {nombreLegibleDelRol}";
        }
        private void FormatearGrillaSalas()
        {
            if (dgvSalas.Columns.Contains("Codigo_Sala_VM516"))
                dgvSalas.Columns["Codigo_Sala_VM516"].HeaderText = "Código Sala";
            if (dgvSalas.Columns.Contains("Nombre_Sala_VM516"))
                dgvSalas.Columns["Nombre_Sala_VM516"].HeaderText = "Nombre";
            if (dgvSalas.Columns.Contains("Alto_Max_Soportado_VM516"))
                dgvSalas.Columns["Alto_Max_Soportado_VM516"].HeaderText = "Alto Máx";
            if (dgvSalas.Columns.Contains("Ancho_Max_Soportado_VM516"))
                dgvSalas.Columns["Ancho_Max_Soportado_VM516"].HeaderText = "Ancho Máx";
            if (dgvSalas.Columns.Contains("Peso_Max_Soportado_VM516"))
                dgvSalas.Columns["Peso_Max_Soportado_VM516"].HeaderText = "Peso Máx";
            if (dgvSalas.Columns.Contains("Tipo_Iluminacion_Disponible_VM516"))
                dgvSalas.Columns["Tipo_Iluminacion_Disponible_VM516"].HeaderText = "Iluminación";

            dgvSalas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void LimpiarFormulario()
        {
            txtIdObra.Clear();
            txtMontoTotal.Clear();
            txtPorcentajeSena.Clear();
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;
            codigoSalaSeleccionada = "";
            dgvSalas.DataSource = null;
            txtIdObra.Focus();
        }

        private void EspecificacionesObra()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdObra.Text)) return;

                if (!int.TryParse(txtIdObra.Text.Trim(), out int idObra))
                {
                    throw new Exception("El ID de obra debe ser un valor numérico.");
                }


                var obra = bllObra.ObtenerPorId_VM516(idObra);

                if (obra != null)
                {
                    string detalle = $"--- Especificaciones de la Obra ---\n" +
                                     $"Título: {obra.Titulo_Obra_VM516}\n" +
                                     $"Artista DNI: {obra.DNI_Artista_VM516}\n" +
                                     $"Alto: {obra.Alto_VM516} | Ancho: {obra.Ancho_VM516} | Peso: {obra.Peso_VM516}\n" +
                                     $"Iluminación: {obra.Req_Iluminacion_VM516}\n" +
                                     $"Seguro: {obra.Categoria_Seguro_VM516}";

                    MessageBox.Show(detalle, "Información de la Obra", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se encontró ninguna obra registrada con ese ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIdObra.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
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

                var listSalas = bllReserva.ObtenerSalasDisponiblesPorObra(idObra, inicio, fin);

                if (listSalas.Count == 0)
                {
                    MessageBox.Show("No existen salas compatibles disponibles en el período solicitado.", "Sin disponibilidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvSalas.DataSource = null;
                dgvSalas.DataSource = listSalas;
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
                codigoSalaSeleccionada = row.Cells["Codigo_Sala_VM516"].Value.ToString();

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

        private void txtIdObra_TextChanged(object sender, EventArgs e)
        {
            EspecificacionesObra();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_ListarReservas_VM516 frm = new Form_ListarReservas_VM516();
            frm.ShowDialog();
        }
    }
}

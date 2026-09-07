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
    public partial class Form_ListarReservas_VM516 : Form
    {
        private BLL_Reserva_Sala_VM516 bllReserva_VM516;
        public Form_ListarReservas_VM516()
        {
            InitializeComponent();
            bllReserva_VM516 = new BLL_Reserva_Sala_VM516();
        }

        private void Form_ListarReservas_VM516_Load(object sender, EventArgs e)
        {
            Servicio_Usuario usuario = SessionManager.GetInstancia().GetUsuarioActual();
            BLL_Rol bllRol = new BLL_Rol();
            string nombreLegibleDelRol = bllRol.ObtenerNombreRol(usuario.IdRol);
            lblUsuarioValor.Text = $"Usuario activo: {usuario.Login} - {nombreLegibleDelRol}";
            CargarGrillaReservas();
        }
        private void FormatearGrillaReservas()
        {
            if (dgvReservas.Columns.Contains("Codigo_Reserva_VM516"))
                dgvReservas.Columns["Codigo_Reserva_VM516"].HeaderText = "Cod. Reserva";
            if (dgvReservas.Columns.Contains("Codigo_Sala_VM516"))
                dgvReservas.Columns["Codigo_Sala_VM516"].HeaderText = "Sala";
            if (dgvReservas.Columns.Contains("Id_Obra_VM516"))
                dgvReservas.Columns["Id_Obra_VM516"].HeaderText = "ID Obra";
            if (dgvReservas.Columns.Contains("Fecha_Inicio_VM516"))
                dgvReservas.Columns["Fecha_Inicio_VM516"].HeaderText = "Fecha Inicio";
            if (dgvReservas.Columns.Contains("Fecha_Fin_VM516"))
                dgvReservas.Columns["Fecha_Fin_VM516"].HeaderText = "Fecha Fin";

            if (dgvReservas.Columns.Contains("Monto_Alquiler_Total_VM516"))
            {
                dgvReservas.Columns["Monto_Alquiler_Total_VM516"].HeaderText = "Monto Total";
                dgvReservas.Columns["Monto_Alquiler_Total_VM516"].DefaultCellStyle.Format = "C2";
            }

            if (dgvReservas.Columns.Contains("Porcentaje_Sena_VM516"))
                dgvReservas.Columns["Porcentaje_Sena_VM516"].HeaderText = "% Seña";

            if (dgvReservas.Columns.Contains("Saldo_Restante_A_Pagar_VM516"))
            {
                dgvReservas.Columns["Saldo_Restante_A_Pagar_VM516"].HeaderText = "Saldo Pendiente";
                dgvReservas.Columns["Saldo_Restante_A_Pagar_VM516"].DefaultCellStyle.Format = "C2";
            }

            if (dgvReservas.Columns.Contains("Estado_Espacio_VM516"))
                dgvReservas.Columns["Estado_Espacio_VM516"].HeaderText = "Estado Espacio";

            if (dgvReservas.Columns.Contains("Estado_Pago_VM516"))
                dgvReservas.Columns["Estado_Pago_VM516"].HeaderText = "Estado Pago";

            dgvReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarGrillaReservas()
        {
            try
            {
                dgvReservas.DataSource = null;
                dgvReservas.DataSource = bllReserva_VM516.ListarReservas();
                FormatearGrillaReservas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el listado de reservas: " + ex.Message, "Validación / Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarGrillaReservas();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

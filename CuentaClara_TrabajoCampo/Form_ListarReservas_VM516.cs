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
    public partial class Form_ListarReservas_VM516 : Form, IObserverIdioma
    {
        private BLL_Reserva_Sala_VM516 bllReserva_VM516;
        public Form_ListarReservas_VM516()
        {
            InitializeComponent();
            bllReserva_VM516 = new BLL_Reserva_Sala_VM516();
        }

        private void Form_ListarReservas_VM516_Load(object sender, EventArgs e)
        {
            GestorIdioma.GetInstancia().Suscribir(this);
            ActualizarIdioma();
            Servicio_Usuario usuario = SessionManager.GetInstancia().GetUsuarioActual();
            BLL_Rol bllRol = new BLL_Rol();
            string nombreLegibleDelRol = bllRol.ObtenerNombreRol(usuario.IdRol);
            lblUsuarioValor.Text = $"Usuario activo: {usuario.Login} - {nombreLegibleDelRol}";
            CargarGrillaReservas();
        }
        public void ActualizarIdioma()
        {
            string idIdioma = SessionManager.GetInstancia().GetUsuarioActual().Id_Idioma;
            BLL_Idioma bllIdioma = new BLL_Idioma();
            Servicio_Idioma idioma = bllIdioma.ObtenerIdiomaPorId(idIdioma);

            if (idioma == null)
                return;

            TraducirControles(this.Controls, idioma);

            this.Text = TraducirTexto("titulo_FormListarReservas");

            Servicio_Usuario usuario = SessionManager.GetInstancia().GetUsuarioActual();
            BLL_Rol bllRol = new BLL_Rol();
            string nombreLegibleDelRol = bllRol.ObtenerNombreRol(usuario.IdRol);
            lblUsuarioValor.Text = $"{TraducirTexto("lbl_Usuario")} {usuario.Login} - {nombreLegibleDelRol}";

            FormatearGrillaReservas();
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
        private void FormatearGrillaReservas()
        {
            if (dgvReservas.Columns.Contains("Codigo_Reserva_VM516"))
                dgvReservas.Columns["Codigo_Reserva_VM516"].HeaderText = TraducirTexto("Codigo_Reserva_VM516");

            if (dgvReservas.Columns.Contains("Codigo_Sala_VM516"))
                dgvReservas.Columns["Codigo_Sala_VM516"].HeaderText = TraducirTexto("Codigo_Sala_VM516");

            if (dgvReservas.Columns.Contains("Id_Obra_VM516"))
                dgvReservas.Columns["Id_Obra_VM516"].HeaderText = TraducirTexto("Id_Obra_VM516");

            if (dgvReservas.Columns.Contains("Fecha_Inicio_VM516"))
                dgvReservas.Columns["Fecha_Inicio_VM516"].HeaderText = TraducirTexto("Fecha_Inicio_VM516");

            if (dgvReservas.Columns.Contains("Fecha_Fin_VM516"))
                dgvReservas.Columns["Fecha_Fin_VM516"].HeaderText = TraducirTexto("Fecha_Fin_VM516");

            if (dgvReservas.Columns.Contains("Monto_Alquiler_Total_VM516"))
            {
                dgvReservas.Columns["Monto_Alquiler_Total_VM516"].HeaderText = TraducirTexto("Monto_Alquiler_Total_VM516");
                dgvReservas.Columns["Monto_Alquiler_Total_VM516"].DefaultCellStyle.Format = "C2";
            }

            if (dgvReservas.Columns.Contains("Porcentaje_Sena_VM516"))
                dgvReservas.Columns["Porcentaje_Sena_VM516"].HeaderText = TraducirTexto("Porcentaje_Sena_VM516");

            if (dgvReservas.Columns.Contains("Saldo_Restante_A_Pagar_VM516"))
            {
                dgvReservas.Columns["Saldo_Restante_A_Pagar_VM516"].HeaderText = TraducirTexto("Saldo_Restante_A_Pagar_VM516");
                dgvReservas.Columns["Saldo_Restante_A_Pagar_VM516"].DefaultCellStyle.Format = "C2";
            }

            if (dgvReservas.Columns.Contains("Estado_Espacio_VM516"))
                dgvReservas.Columns["Estado_Espacio_VM516"].HeaderText = TraducirTexto("Estado_Espacio_VM516");

            if (dgvReservas.Columns.Contains("Estado_Pago_VM516"))
                dgvReservas.Columns["Estado_Pago_VM516"].HeaderText = TraducirTexto("Estado_Pago_VM516");

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
                MessageBox.Show(TraducirTexto("err_ErrorCargarReservas") + " " + ex.Message, TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

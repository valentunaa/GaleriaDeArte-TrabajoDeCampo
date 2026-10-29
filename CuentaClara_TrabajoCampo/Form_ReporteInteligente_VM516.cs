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
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.WinForms;


namespace IU
{
    public partial class Form_ReporteInteligente_VM516 : Form, IObserverIdioma
    {
        //private CartesianChart graficoReporte_VM516;
        private BLL_Pedido_VM516 bllPedido_VM516;
        private BLL_Reserva_Sala_VM516 bllReserva_VM516;
        private BLL_PDF bllPdf_VM516;
        public Form_ReporteInteligente_VM516()
        {
            InitializeComponent();
            bllPedido_VM516 = new BLL_Pedido_VM516();
            bllReserva_VM516 = new BLL_Reserva_Sala_VM516();
            bllPdf_VM516 = new BLL_PDF();
        }
        private void Form_ReporteInteligente_VM516_Load(object sender, EventArgs e)
        {
            GestorIdioma.GetInstancia().Suscribir(this);

            // Mostrar el usuario logueado en la sesión y su rol
            Servicio_Usuario usuario = SessionManager.GetInstancia().GetUsuarioActual();
            BLL_Rol bllRol = new BLL_Rol();
            string nombreLegibleDelRol = usuario != null ? bllRol.ObtenerNombreRol(usuario.IdRol) : "Admin";
            lblUsuarioValor_VM516.Text = $"{usuario?.Login ?? "Administrador"} | {nombreLegibleDelRol}";

            // Cargar las opciones del ComboBox y aplicar idioma inicial
            ActualizarIdioma();
            CargarOpcionesComboBox();

            // Seleccionar la primera opción por defecto (Dispara CargarDatosSeleccionados)
            if (cmbTipoReporte_VM516.Items.Count > 0)
            {
                cmbTipoReporte_VM516.SelectedIndex = 0;
            }
        }
        private void ConfigurarToolTips()
        {
            toolTipReporte.SetToolTip(cmbTipoReporte_VM516, TraducirTexto("Reporte_Tip_Seleccionar"));
            toolTipReporte.SetToolTip(btnExportarPdf_VM516, TraducirTexto("Reporte_Tip_Exportar"));
            toolTipReporte.SetToolTip(btnSalir_VM516, TraducirTexto("Reporte_Tip_Salir"));
            toolTipReporte.SetToolTip(dgvReporteInteligente_VM516, TraducirTexto("Reporte_Tip_Grilla"));
        }
        public void ActualizarIdioma()
        {
            string idIdioma = SessionManager.GetInstancia().GetUsuarioActual().Id_Idioma;
            BLL_Idioma bllIdioma = new BLL_Idioma();
            Servicio_Idioma idioma = bllIdioma.ObtenerIdiomaPorId(idIdioma);

            if (idioma == null) return;

            TraducirControles(this.Controls, idioma);
            this.Text = TraducirTexto("titulo_FormReporteInteligente");
            CargarOpcionesComboBox();
            FormatearGrilla();
            ConfigurarToolTips();
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
            if (dgvReporteInteligente_VM516.Columns.Count == 0) return;

            // Formato para Reporte de Cafetería
            if (dgvReporteInteligente_VM516.Columns.Contains("Descripcion"))
                dgvReporteInteligente_VM516.Columns["Descripcion"].HeaderText = TraducirTexto("col_Rep_Descripcion");

            if (dgvReporteInteligente_VM516.Columns.Contains("CantidadTotal"))
                dgvReporteInteligente_VM516.Columns["CantidadTotal"].HeaderText = TraducirTexto("col_Rep_UnidadesVendidas");

            if (dgvReporteInteligente_VM516.Columns.Contains("RecaudacionTotal"))
            {
                dgvReporteInteligente_VM516.Columns["RecaudacionTotal"].HeaderText = TraducirTexto("col_Rep_RecaudacionTotal");
                dgvReporteInteligente_VM516.Columns["RecaudacionTotal"].DefaultCellStyle.Format = "N2";
            }

            // Formato para Reporte de Salas
            if (dgvReporteInteligente_VM516.Columns.Contains("CodigoSala"))
                dgvReporteInteligente_VM516.Columns["CodigoSala"].HeaderText = TraducirTexto("col_Rep_CodigoSala");

            if (dgvReporteInteligente_VM516.Columns.Contains("NombreSala"))
                dgvReporteInteligente_VM516.Columns["NombreSala"].HeaderText = TraducirTexto("col_Rep_NombreEspacio");

            if (dgvReporteInteligente_VM516.Columns.Contains("CantidadReservas"))
                dgvReporteInteligente_VM516.Columns["CantidadReservas"].HeaderText = TraducirTexto("col_Rep_EventosMuestras");

            if (dgvReporteInteligente_VM516.Columns.Contains("RecaudacionSalas"))
            {
                dgvReporteInteligente_VM516.Columns["RecaudacionSalas"].HeaderText = TraducirTexto("col_Rep_VolumenFinanciero");
                dgvReporteInteligente_VM516.Columns["RecaudacionSalas"].DefaultCellStyle.Format = "N2";
            }
        }

        
        private void btnExportarPdf_VM516_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvReporteInteligente_VM516.Rows.Count == 0 || dgvReporteInteligente_VM516.DataSource == null)
                {
                    MessageBox.Show("No hay información analítica disponible para exportar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";

                // Exportación Opción A
                if (cmbTipoReporte_VM516.SelectedIndex == 0)
                {
                    saveDialog.FileName = $"Reporte_Inteligente_Cafeteria_{DateTime.Now:yyyyMMdd_HHmm}.pdf";
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        DataTable dt = (DataTable)dgvReporteInteligente_VM516.DataSource;
                        bllPdf_VM516.GenerarReporteInteligenteCafeteria_VM516(dt, saveDialog.FileName);
                        MessageBox.Show("Reporte ejecutivo de Cafetería generado y exportado con éxito.", "Exportación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                // Exportación Opción B
                else if (cmbTipoReporte_VM516.SelectedIndex == 1)
                {
                    saveDialog.FileName = $"Reporte_Inteligente_Salas_{DateTime.Now:yyyyMMdd_HHmm}.pdf";
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        DataTable dt = (DataTable)dgvReporteInteligente_VM516.DataSource;
                        bllPdf_VM516.GenerarReporteInteligenteSalas_VM516(dt, saveDialog.FileName);
                        MessageBox.Show("Reporte ejecutivo de Ocupación de Salas generado y exportado con éxito.", "Exportación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar construir el archivo PDF: " + ex.Message, "Error de Exportación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void CargarOpcionesComboBox()
        {
            int indexGuardado = cmbTipoReporte_VM516.SelectedIndex;

            cmbTipoReporte_VM516.Items.Clear();
            cmbTipoReporte_VM516.Items.Add(TraducirTexto("opt_ReporteCafeteria"));
            cmbTipoReporte_VM516.Items.Add(TraducirTexto("opt_ReporteSalas"));

            if (indexGuardado >= 0 && indexGuardado < cmbTipoReporte_VM516.Items.Count)
            {
                cmbTipoReporte_VM516.SelectedIndex = indexGuardado;
            }
        }
        private void CargarDatosSeleccionados()
        {
            try
            {
                if (cmbTipoReporte_VM516.SelectedIndex == 0)
                {
                    // PROCESO DE NEGOCIO A: Consumos de Cafetería
                    DataTable dtCafeteria = bllPedido_VM516.ObtenerReporteCafeteria_VM516();
                    dgvReporteInteligente_VM516.DataSource = dtCafeteria;

                    // Formateamos las columnas visualmente para el usuario
                    if (dgvReporteInteligente_VM516.Columns.Count > 0)
                    {
                        dgvReporteInteligente_VM516.Columns["Descripcion"].HeaderText = "Producto / Ítem";
                        dgvReporteInteligente_VM516.Columns["CantidadTotal"].HeaderText = "Unidades Vendidas";
                        dgvReporteInteligente_VM516.Columns["RecaudacionTotal"].HeaderText = "Recaudación Total ($)";
                        dgvReporteInteligente_VM516.Columns["RecaudacionTotal"].DefaultCellStyle.Format = "N2";
                    }
                }
                else if (cmbTipoReporte_VM516.SelectedIndex == 1)
                {
                    // PROCESO DE NEGOCIO B: Ocupación de Salas
                    DataTable dtSalas = bllReserva_VM516.ObtenerReporteOcupacionSalas_VM516();
                    dgvReporteInteligente_VM516.DataSource = dtSalas;

                    // Formateamos las columnas visualmente para el usuario
                    if (dgvReporteInteligente_VM516.Columns.Count > 0)
                    {
                        dgvReporteInteligente_VM516.Columns["CodigoSala"].HeaderText = "Código de Sala";
                        dgvReporteInteligente_VM516.Columns["NombreSala"].HeaderText = "Nombre del Espacio";
                        dgvReporteInteligente_VM516.Columns["CantidadReservas"].HeaderText = "Eventos / Muestras";
                        dgvReporteInteligente_VM516.Columns["RecaudacionSalas"].HeaderText = "Volumen Financiero ($)";
                        dgvReporteInteligente_VM516.Columns["RecaudacionSalas"].DefaultCellStyle.Format = "N2";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar el motor de base de datos: " + ex.Message, "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbTipoReporte_VM516_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatosSeleccionados();
        }

        private void btnSalir_VM516_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

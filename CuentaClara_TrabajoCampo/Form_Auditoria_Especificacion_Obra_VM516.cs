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
    public partial class Form_Auditoria_Especificacion_Obra_VM516 : Form, IObserverIdioma
    {
        private BLL_Especificacion_Obra_C_VM516 bllBitacoraObra_VM516;
        private BLL_Especificacion_Obra_VM516 bllObraPrincipal_VM516;
        public Form_Auditoria_Especificacion_Obra_VM516()
        {
            InitializeComponent();
            ConfigurarToolTips();
            bllBitacoraObra_VM516 = new BLL_Especificacion_Obra_C_VM516();
            bllObraPrincipal_VM516 = new BLL_Especificacion_Obra_VM516();
        }


        private void ConfigurarToolTips()
        {
            toolTipAudit.SetToolTip(btnAplicar, TraducirTexto("AuditObra_Tip_Aplicar"));
            toolTipAudit.SetToolTip(btnLimpiar, TraducirTexto("AuditObra_Tip_Limpiar"));
            toolTipAudit.SetToolTip(btnActivar, TraducirTexto("AuditObra_Tip_Activar"));
            toolTipAudit.SetToolTip(btnSalir, TraducirTexto("AuditObra_Tip_Salir"));
        }

        private void Form_Auditoria_Especificacion_Obra_VM516_Load(object sender, EventArgs e)
        {
            GestorIdioma.GetInstancia().Suscribir(this);
            ActualizarIdioma();

            // Inicializar filtros por defecto (último mes hasta hoy)
            dtpFechaInicio.Value = DateTime.Now.AddMonths(-1);
            dtpFechaFin.Value = DateTime.Now;

            CargarHistorial_VM516();

            Servicio_Usuario usuario = SessionManager.GetInstancia().GetUsuarioActual();
            BLL_Rol bllRol = new BLL_Rol();
            string nombreLegibleDelRol = bllRol.ObtenerNombreRol(usuario.IdRol);
            lblUsuarioValor.Text = $"{usuario.Login} - {nombreLegibleDelRol}";
        }


        public void ActualizarIdioma()
        {
            string idIdioma = SessionManager.GetInstancia().GetUsuarioActual().Id_Idioma;
            BLL_Idioma bllIdioma = new BLL_Idioma();
            Servicio_Idioma idioma = bllIdioma.ObtenerIdiomaPorId(idIdioma);

            if (idioma == null) return;

            TraducirControles(this.Controls, idioma);
            this.Text = TraducirTexto("lbl_FormBitacoraObra");
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
            if (dgvBitacoraObra.Columns.Contains("Id_Cambio_VM516"))
                dgvBitacoraObra.Columns["Id_Cambio_VM516"].HeaderText = TraducirTexto("Id_Cambio_VM516");

            if (dgvBitacoraObra.Columns.Contains("Id_Obra_VM516"))
                dgvBitacoraObra.Columns["Id_Obra_VM516"].HeaderText = TraducirTexto("Id_Obra_VM516");

            if (dgvBitacoraObra.Columns.Contains("DNI_Artista_VM516"))
                dgvBitacoraObra.Columns["DNI_Artista_VM516"].HeaderText = TraducirTexto("DNI_Artista_VM516");

            if (dgvBitacoraObra.Columns.Contains("Titulo_Obra_VM516"))
                dgvBitacoraObra.Columns["Titulo_Obra_VM516"].HeaderText = TraducirTexto("Titulo_Obra_VM516");

            if (dgvBitacoraObra.Columns.Contains("Tecnica_VM516"))
                dgvBitacoraObra.Columns["Tecnica_VM516"].HeaderText = TraducirTexto("Tecnica_VM516");

            if (dgvBitacoraObra.Columns.Contains("Alto_VM516"))
                dgvBitacoraObra.Columns["Alto_VM516"].HeaderText = TraducirTexto("Alto_VM516");

            if (dgvBitacoraObra.Columns.Contains("Ancho_VM516"))
                dgvBitacoraObra.Columns["Ancho_VM516"].HeaderText = TraducirTexto("Ancho_VM516");

            if (dgvBitacoraObra.Columns.Contains("Peso_VM516"))
                dgvBitacoraObra.Columns["Peso_VM516"].HeaderText = TraducirTexto("Peso_VM516");

            if (dgvBitacoraObra.Columns.Contains("Req_Iluminacion_VM516"))
                dgvBitacoraObra.Columns["Req_Iluminacion_VM516"].HeaderText = TraducirTexto("Req_Iluminacion_VM516");

            if (dgvBitacoraObra.Columns.Contains("Valor_Declarado_Mercado_VM516"))
                dgvBitacoraObra.Columns["Valor_Declarado_Mercado_VM516"].HeaderText = TraducirTexto("Valor_Declarado_Mercado_VM516");

            if (dgvBitacoraObra.Columns.Contains("Categoria_Seguro_VM516"))
                dgvBitacoraObra.Columns["Categoria_Seguro_VM516"].HeaderText = TraducirTexto("Categoria_Seguro_VM516");

            if (dgvBitacoraObra.Columns.Contains("Estado_Asignacion_VM516"))
                dgvBitacoraObra.Columns["Estado_Asignacion_VM516"].HeaderText = TraducirTexto("Estado_Asignacion_VM516");

            if (dgvBitacoraObra.Columns.Contains("Bit_Lo_Bo_VM516"))
                dgvBitacoraObra.Columns["Bit_Lo_Bo_VM516"].HeaderText = TraducirTexto("Bit_Lo_Bo_VM516");

            if (dgvBitacoraObra.Columns.Contains("Fecha_VM516"))
                dgvBitacoraObra.Columns["Fecha_VM516"].HeaderText = TraducirTexto("Fecha_VM516");

            if (dgvBitacoraObra.Columns.Contains("Activo_VM516"))
                dgvBitacoraObra.Columns["Activo_VM516"].HeaderText = TraducirTexto("Activo_VM516");

            dgvBitacoraObra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void CargarHistorial_VM516()
        {
            try
            {
                string idObraFiltro = txtIdObra.Text.Trim();
                string tituloFiltro = txtTituloObra.Text.Trim();
                DateTime fechaIni = dtpFechaInicio.Value;
                DateTime fechaFin = dtpFechaFin.Value;

                var lista = bllBitacoraObra_VM516.ObtenerHistorialFiltrado_VM516(idObraFiltro, tituloFiltro, fechaIni, fechaFin);

                dgvBitacoraObra.DataSource = null;
                dgvBitacoraObra.DataSource = lista;
                FormatearGrilla();

                lblCantRegistrosValor.Text = lista.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtIdObra.Clear();
            txtTituloObra.Clear();
            dtpFechaInicio.Value = DateTime.Now.AddMonths(-1);
            dtpFechaFin.Value = DateTime.Now;
            CargarHistorial_VM516();
        }

        private void btnActivar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvBitacoraObra.SelectedRows.Count > 0)
                {
                    var registroSeleccionado = dgvBitacoraObra.SelectedRows[0].DataBoundItem as BE_Especificacion_Obra_C_VM516;
                    if (registroSeleccionado != null)
                    {
                        // 1. Ejecutamos la activación para que el trigger actualice la tabla principal
                        bllBitacoraObra_VM516.ActivarRegistroHistorico_VM516(registroSeleccionado.Id_Cambio_VM516);

                        // 2. Recalibración inmediata de DVH y DVV tras la acción del trigger (Evita Modo Emergencia)
                        bllObraPrincipal_VM516.RecalcularDigitosPostRestauracion_VM516(registroSeleccionado.Id_Obra_VM516);

                        MessageBox.Show(TraducirTexto("msg_RegistroActivadoExito"), TraducirTexto("titulo_Exito"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarHistorial_VM516();
                    }
                }
                else
                {
                    throw new Exception("err_SeleccionarRegistroHistorico");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAplicar_Click_1(object sender, EventArgs e)
        {
            CargarHistorial_VM516();
        }

        private void Form_Auditoria_Especificacion_Obra_VM516_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestorIdioma.GetInstancia().Desuscribir(this);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


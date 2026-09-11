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
    public partial class Form_Reserva_Sala_VM516 : Form, IObserverIdioma
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
            GestorIdioma.GetInstancia().Suscribir(this);
            ActualizarIdioma();
            dgvSalas.DataSource = null;
            Servicio_Usuario usuario = SessionManager.GetInstancia().GetUsuarioActual();
            BLL_Rol bllRol = new BLL_Rol();
            string nombreLegibleDelRol = bllRol.ObtenerNombreRol(usuario.IdRol);

            lblUsuarioValor.Text = $"{usuario.Login} -  {nombreLegibleDelRol}";
        }

        public void ActualizarIdioma()
        {
            string idIdioma = SessionManager.GetInstancia().GetUsuarioActual().Id_Idioma;
            BLL_Idioma bllIdioma = new BLL_Idioma();
            Servicio_Idioma idioma = bllIdioma.ObtenerIdiomaPorId(idIdioma);

            if (idioma == null)
                return;

            TraducirControles(this.Controls, idioma);

            this.Text = TraducirTexto("titulo_FormReservaSala");
            FormatearGrillaSalas();
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
        private void FormatearGrillaSalas()
        {
            if (dgvSalas.Columns.Contains("Codigo_Sala_VM516"))
                dgvSalas.Columns["Codigo_Sala_VM516"].HeaderText = TraducirTexto("Codigo_Sala_VM516");
            if (dgvSalas.Columns.Contains("Nombre_Sala_VM516"))
                dgvSalas.Columns["Nombre_Sala_VM516"].HeaderText = TraducirTexto("Nombre_Sala_VM516");
            if (dgvSalas.Columns.Contains("Alto_Max_Soportado_VM516"))
                dgvSalas.Columns["Alto_Max_Soportado_VM516"].HeaderText = TraducirTexto("Alto_Max_Soportado_VM516");
            if (dgvSalas.Columns.Contains("Ancho_Max_Soportado_VM516"))
                dgvSalas.Columns["Ancho_Max_Soportado_VM516"].HeaderText = TraducirTexto("Ancho_Max_Soportado_VM516");
            if (dgvSalas.Columns.Contains("Peso_Max_Soportado_VM516"))
                dgvSalas.Columns["Peso_Max_Soportado_VM516"].HeaderText = TraducirTexto("Peso_Max_Soportado_VM516");
            if (dgvSalas.Columns.Contains("Tipo_Iluminacion_Disponible_VM516"))
                dgvSalas.Columns["Tipo_Iluminacion_Disponible_VM516"].HeaderText = TraducirTexto("Tipo_Iluminacion_Disponible_VM516");

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
                    throw new Exception(TraducirTexto("err_IdObraNumerico"));
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

                    MessageBox.Show(detalle, TraducirTexto("titulo_Exito"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(TraducirTexto("err_ObraNoEncontrada"), TraducirTexto("msg_Atencion"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtIdObra.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    throw new Exception(TraducirTexto("err_IdObraNumerico"));
                }

                DateTime inicio = dtpFechaInicio.Value;
                DateTime fin = dtpFechaFin.Value;

                var listSalas = bllReserva.ObtenerSalasDisponiblesPorObra(idObra, inicio, fin);

                if (listSalas.Count == 0)
                {
                    MessageBox.Show(TraducirTexto("err_SinSalasDisponibles"), TraducirTexto("msg_Atencion"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dgvSalas.DataSource = null;
                dgvSalas.DataSource = listSalas;
                FormatearGrillaSalas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnConfirmarReserva_Click(object sender, EventArgs e)
        {
            try
            {
                string codigoSala = "";
                if (dgvSalas.SelectedRows.Count > 0)
                {
                    var row = dgvSalas.SelectedRows[0];
                    codigoSala = row.Cells["Codigo_Sala_VM516"].Value?.ToString() ?? "";
                }

                // Se envían los datos crudos a la BLL para su validación y posterior creación del objeto
                bllReserva.RegistrarReserva_VM516(
                    codigoSala,
                    txtIdObra.Text.Trim(),
                    dtpFechaInicio.Value,
                    dtpFechaFin.Value,
                    txtMontoTotal.Text.Trim(),
                    txtPorcentajeSena.Text.Trim()
                );

                MessageBox.Show(TraducirTexto("msg_ReservaExitosa"), TraducirTexto("titulo_Exito"), MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void Form_Reserva_Sala_VM516_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestorIdioma.GetInstancia().Desuscribir(this);
        }
    }
}

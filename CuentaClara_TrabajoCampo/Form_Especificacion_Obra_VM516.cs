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
    public partial class Form_Especificacion_Obra_VM516 : Form, IObserverIdioma
    {
        public Form_Especificacion_Obra_VM516()
        {
            InitializeComponent();
            ConfigurarToolTips();
            bllObra = new BLL_Especificacion_Obra_VM516();
            bllArtista = new BLL_Artista_VM516();
        }
        private BLL_Especificacion_Obra_VM516 bllObra;
        private BLL_Artista_VM516 bllArtista;
        private string dniArtistaVerificado = "";
        private int idObraSeleccionada = 0;
        private bool esModoVistaXML = false;


        private void Form_Especificacion_Obra_VM516_Load(object sender, EventArgs e)
        {
            GestorIdioma.GetInstancia().Suscribir(this); ActualizarIdioma();
            dgvEspecificaciones.DataSource = null;

            Servicio_Usuario usuario = SessionManager.GetInstancia().GetUsuarioActual();
            BLL_Rol bllRol = new BLL_Rol();
            string nombreLegibleDelRol = bllRol.ObtenerNombreRol(usuario.IdRol);

            lblUsuarioValor.Text = $"{usuario.Login} -  {nombreLegibleDelRol}";

            BloquearCamposObra(false);
            CargarGrilla();
            ConfigurarToolTips();

        }

        private void ConfigurarToolTips()
        {
            toolTipObras.SetToolTip(btnBuscarArtista, TraducirTexto("Obra_Tip_BuscarArtista"));
            toolTipObras.SetToolTip(btnConfirmarRegistro, TraducirTexto("Obra_Tip_Confirmar"));
            toolTipObras.SetToolTip(btnModificar_VM516, TraducirTexto("Obra_Tip_Modificar"));
            toolTipObras.SetToolTip(btnEliminar_VM516, TraducirTexto("Obra_Tip_Eliminar"));
            toolTipObras.SetToolTip(btnSerializar, TraducirTexto("Obra_Tip_Serializar"));
            toolTipObras.SetToolTip(button1, TraducirTexto("Obra_Tip_Deserializar")); 
            toolTipObras.SetToolTip(btnLimpiar_VM516, TraducirTexto("Obra_Tip_Limpiar"));
            toolTipObras.SetToolTip(button2, TraducirTexto("Obra_Tip_Actualizar"));   
            toolTipObras.SetToolTip(btnSalir, TraducirTexto("Obra_Tip_Salir")); 
        }
        public void ActualizarIdioma()
        {
            string idIdioma = SessionManager.GetInstancia().GetUsuarioActual().Id_Idioma;
            BLL_Idioma bllIdioma = new BLL_Idioma();
            Servicio_Idioma idioma = bllIdioma.ObtenerIdiomaPorId(idIdioma);

            if (idioma == null)
            {

                return;
            }

            TraducirControles(this.Controls, idioma);

            this.Text = TraducirTexto("titulo_FormEspecificacionObra");
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

            if (idioma == null)
                return clave;

            var etiqueta = idioma.Etiquetas.FirstOrDefault(x => x.Clave == clave);
            return etiqueta != null ? etiqueta.Texto : clave;
        }

        private void BloquearBotonesABM(bool estado)
        {
            btnConfirmarRegistro.Enabled = estado;
            btnModificar_VM516.Enabled = estado;
            btnEliminar_VM516.Enabled = estado;
        }

        private void FormatearGrilla()
        {
            if (dgvEspecificaciones.Columns.Contains("Id_Obra_VM516"))
                dgvEspecificaciones.Columns["Id_Obra_VM516"].HeaderText = TraducirTexto("Id_Obra_VM516");

            if (dgvEspecificaciones.Columns.Contains("DNI_Artista_VM516"))
                dgvEspecificaciones.Columns["DNI_Artista_VM516"].HeaderText = TraducirTexto("DNI_Artista_VM516");

            if (dgvEspecificaciones.Columns.Contains("Titulo_Obra_VM516"))
                dgvEspecificaciones.Columns["Titulo_Obra_VM516"].HeaderText = TraducirTexto("Titulo_Obra_VM516");

            if (dgvEspecificaciones.Columns.Contains("Tecnica_VM516"))
                dgvEspecificaciones.Columns["Tecnica_VM516"].HeaderText = TraducirTexto("Tecnica_VM516");

            if (dgvEspecificaciones.Columns.Contains("Alto_VM516"))
                dgvEspecificaciones.Columns["Alto_VM516"].HeaderText = TraducirTexto("Alto_VM516");

            if (dgvEspecificaciones.Columns.Contains("Ancho_VM516"))
                dgvEspecificaciones.Columns["Ancho_VM516"].HeaderText = TraducirTexto("Ancho_VM516");

            if (dgvEspecificaciones.Columns.Contains("Peso_VM516"))
                dgvEspecificaciones.Columns["Peso_VM516"].HeaderText = TraducirTexto("Peso_VM516");

            if (dgvEspecificaciones.Columns.Contains("Req_Iluminacion_VM516"))
                dgvEspecificaciones.Columns["Req_Iluminacion_VM516"].HeaderText = TraducirTexto("Req_Iluminacion_VM516");

            if (dgvEspecificaciones.Columns.Contains("Valor_Declarado_Mercado_VM516"))
                dgvEspecificaciones.Columns["Valor_Declarado_Mercado_VM516"].HeaderText = TraducirTexto("Valor_Declarado_Mercado_VM516");

            if (dgvEspecificaciones.Columns.Contains("Categoria_Seguro_VM516"))
                dgvEspecificaciones.Columns["Categoria_Seguro_VM516"].HeaderText = TraducirTexto("Categoria_Seguro_VM516");

            if (dgvEspecificaciones.Columns.Contains("Estado_Asignacion_VM516"))
                dgvEspecificaciones.Columns["Estado_Asignacion_VM516"].HeaderText = TraducirTexto("Estado_Asignacion_VM516");
            if (dgvEspecificaciones.Columns.Contains("Bit_Lo_Bo_VM516"))
                dgvEspecificaciones.Columns["Bit_Lo_Bo_VM516"].Visible = false;

            dgvEspecificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }



        private void CargarGrilla()
        {
            try
            {
                dgvEspecificaciones.DataSource = null;
                dgvEspecificaciones.DataSource = bllObra.ListarEspecificaciones();
                FormatearGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BloquearCamposObra(bool habilitar)
        {
            txtTitulo.Enabled = habilitar;
            txtTecnica.Enabled = habilitar;
            txtAlto.Enabled = habilitar;
            txtAncho.Enabled = habilitar;
            txtPeso.Enabled = habilitar;
            comboBox2.Enabled = habilitar;
            txtValorMercado.Enabled = habilitar;
            comboBox1.Enabled = habilitar;
            btnConfirmarRegistro.Enabled = habilitar;
        }

        private void LimpiarCamposObra()
        {
            txtDNIBuscar.Clear();
            txtTitulo.Clear();
            txtTecnica.Clear();
            txtAlto.Clear();
            txtAncho.Clear();
            txtPeso.Clear();

            txtValorMercado.Clear();

            lblNombreArtista.Text = TraducirTexto("lbl_EstadoArtistaPendiente");
            lblNombreArtista.ForeColor = System.Drawing.Color.FromArgb(15, 45, 75);
            dniArtistaVerificado = "";
            BloquearCamposObra(false);
            txtDNIBuscar.Focus();
        }



        private void btnBuscarArtista_Click_1(object sender, EventArgs e)
        {
            try
            {
                string dni = txtDNIBuscar.Text.Trim();
                var artista = bllArtista.BuscarArtistaPorDNI_VM516(dni);

                if (artista != null)
                {
                    dniArtistaVerificado = artista.DNI_VM516;
                    lblNombreArtista.Text = $"Artista verificado: {artista.Nombre_VM516} {artista.Apellido_VM516}";
                    lblNombreArtista.ForeColor = System.Drawing.Color.FromArgb(18, 120, 50);
                    BloquearCamposObra(true);

                    // Mantenemos la protección de la BD si estamos viendo un XML
                    if (esModoVistaXML)
                    {
                        BloquearBotonesABM(false);
                    }
                }
            }
            catch (Exception ex)
            {
                dniArtistaVerificado = "";
                lblNombreArtista.Text = TraducirTexto("err_ArtistaNoRegistradoObra");
                lblNombreArtista.ForeColor = System.Drawing.Color.FromArgb(180, 40, 40);
                BloquearCamposObra(false);
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnConfirmarRegistro_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(dniArtistaVerificado))
                {
                    throw new Exception("err_DebeVerificarArtistaObra");
                }


                bllObra.RegistrarEspecificacion_VM516(
                    dniArtistaVerificado,
                    txtTitulo.Text.Trim(),
                    txtTecnica.Text.Trim(),
                    txtAlto.Text.Trim(),
                    txtAncho.Text.Trim(),
                    txtPeso.Text.Trim(),
                    comboBox1.Text.Trim(),
                    txtValorMercado.Text.Trim(),
                    comboBox2.Text.Trim()
                );

                listBox1.Items.Add($"[{DateTime.Now:HH:mm:ss}] {TraducirTexto("msg_LogAltaObra")}");

                MessageBox.Show(TraducirTexto("msg_ExitoRegistroObra"), TraducirTexto("titulo_Exito"), MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarGrilla();
                LimpiarCamposObra();
            }
            catch (Exception ex)
            {
                listBox1.Items.Add($"[{DateTime.Now:HH:mm:ss}] {TraducirTexto("msg_LogErrorAlta")}: {TraducirTexto(ex.Message)}");
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_Especificacion_Obra_VM516_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestorIdioma.GetInstancia().Desuscribir(this);
        }

        private void btnModificar_VM516_Click(object sender, EventArgs e)
        {
            try
            {
                if (idObraSeleccionada <= 0)
                {
                    throw new Exception("err_ObraNoEncontrada");
                }

                if (string.IsNullOrEmpty(dniArtistaVerificado))
                {
                    throw new Exception("err_DebeVerificarArtistaObra");
                }

                bllObra.ModificarEspecificacion_VM516(
                    idObraSeleccionada,
                    dniArtistaVerificado,
                    txtTitulo.Text.Trim(),
                    txtTecnica.Text.Trim(),
                    txtAlto.Text.Trim(),
                    txtAncho.Text.Trim(),
                    txtPeso.Text.Trim(),
                    comboBox1.Text.Trim(),
                    txtValorMercado.Text.Trim(),
                    comboBox2.Text.Trim()
                );

                listBox1.Items.Add($"[{DateTime.Now:HH:mm:ss}] {TraducirTexto("msg_LogModificacionObra")}");

                MessageBox.Show(TraducirTexto("msg_SalaModificadaExito"), TraducirTexto("titulo_Exito"), MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarGrilla();
                LimpiarCamposObra();
            }
            catch (Exception ex)
            {
                listBox1.Items.Add($"[{DateTime.Now:HH:mm:ss}] {TraducirTexto("msg_LogErrorModificacion")}: {TraducirTexto(ex.Message)}");
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_VM516_Click(object sender, EventArgs e)
        {
            try
            {
                if (idObraSeleccionada <= 0)
                {
                    throw new Exception("err_ObraNoEncontrada");
                }

                DialogResult resultado = MessageBox.Show(
                    TraducirTexto("msg_ConfirmarRestauracion"),
                    TraducirTexto("msg_Confirmacion"),
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (resultado == DialogResult.Yes)
                {
                    bllObra.EliminarEspecificacion_VM516(idObraSeleccionada);

                    listBox1.Items.Add($"[{DateTime.Now:HH:mm:ss}] {TraducirTexto("msg_LogBajaObra")}");

                    MessageBox.Show(TraducirTexto("msg_SalaEliminadaExito"), TraducirTexto("titulo_Exito"), MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarGrilla();
                    LimpiarCamposObra();
                }
            }
            catch (Exception ex)
            {
                listBox1.Items.Add($"[{DateTime.Now:HH:mm:ss}] {TraducirTexto("msg_LogErrorBaja")}: {TraducirTexto(ex.Message)}");
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiar_VM516_Click(object sender, EventArgs e)
        {
            LimpiarCamposObra(); BloquearBotonesABM(false); esModoVistaXML = false;
            dgvEspecificaciones.DataSource = null; // Vacía la matriz visualmente
            listBox1.Items.Add($"[{DateTime.Now:HH:mm:ss}] {TraducirTexto("msg_LogGrillaLimpiada")}");
        }

        private void dgvEspecificaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvEspecificaciones.Rows[e.RowIndex].DataBoundItem is BE_Especificacion_Obra_VM516 obra)
            {
                idObraSeleccionada = obra.Id_Obra_VM516;
                dniArtistaVerificado = obra.DNI_Artista_VM516;

                txtDNIBuscar.Text = obra.DNI_Artista_VM516;
                txtTitulo.Text = obra.Titulo_Obra_VM516;
                txtTecnica.Text = obra.Tecnica_VM516;
                txtAlto.Text = obra.Alto_VM516.ToString("0.00");
                txtAncho.Text = obra.Ancho_VM516.ToString("0.00");
                txtPeso.Text = obra.Peso_VM516.ToString("0.00");
                txtValorMercado.Text = obra.Valor_Declarado_Mercado_VM516.ToString("0.00");
                comboBox1.Text = obra.Req_Iluminacion_VM516;
                comboBox2.Text = obra.Categoria_Seguro_VM516;

                lblNombreArtista.Text = $"ID Obra Seleccionada: {obra.Id_Obra_VM516}";
                lblNombreArtista.ForeColor = System.Drawing.Color.FromArgb(15, 45, 75);

                if (!esModoVistaXML)
                {
                    BloquearCamposObra(true);
                    btnModificar_VM516.Enabled = true;
                    btnEliminar_VM516.Enabled = true;
                }
                else
                {
                    // Si es XML, solo dejamos que vea los datos en los TextBox, pero mantenemos los botones bloqueados.
                    BloquearBotonesABM(false);
                }
            }
        }

        private void btnSerializar_Click(object sender, EventArgs e)
        {
            try
            {
                // Se toma toda la información visualizada en la matriz (grilla)
                List<BE_Especificacion_Obra_VM516> listaObras = (List<BE_Especificacion_Obra_VM516>)dgvEspecificaciones.DataSource;

                if (listaObras == null || listaObras.Count == 0)
                {
                    throw new Exception("No hay datos en la grilla para serializar.");
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivo XML (*.xml)|*.xml";
                saveFileDialog.Title = "Guardar Archivo XML de Obras";
                saveFileDialog.FileName = "Obras_VanguardiaArte.xml";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    bllObra.SerializarXML_VM516(listaObras, saveFileDialog.FileName);

                    listBox1.Items.Add($"[{DateTime.Now:HH:mm:ss}] {TraducirTexto("msg_LogSerializacionExito")}: {saveFileDialog.FileName}");
                    MessageBox.Show(TraducirTexto("msg_ExitoSerializar"), TraducirTexto("titulo_Exito"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                listBox1.Items.Add($"[{DateTime.Now:HH:mm:ss}] {TraducirTexto("msg_LogErrorSerializacion")}: {TraducirTexto(ex.Message)}");
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Archivo XML (*.xml)|*.xml";
                openFileDialog.Title = "Seleccionar Archivo XML";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    List<BE_Especificacion_Obra_VM516> listaDeserializada = bllObra.DeserializarXML_VM516(openFileDialog.FileName);

                    // Subir el archivo deserializado directamente a la matriz de datos de la pantalla
                    dgvEspecificaciones.DataSource = null;
                    dgvEspecificaciones.DataSource = listaDeserializada;
                    FormatearGrilla();
                    BloquearBotonesABM(false);
                    esModoVistaXML = true;

                    listBox1.Items.Add($"[{DateTime.Now:HH:mm:ss}] {TraducirTexto("msg_LogDeserializacionExito")}");
                    MessageBox.Show(TraducirTexto("msg_ExitoDeserializar"), TraducirTexto("titulo_Exito"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                listBox1.Items.Add($"[{DateTime.Now:HH:mm:ss}] {TraducirTexto("msg_LogErrorDeserializacion")}: {TraducirTexto(ex.Message)}");
                MessageBox.Show(TraducirTexto(ex.Message), TraducirTexto("titulo_Error"), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargarGrilla(); BloquearBotonesABM(true);
            listBox1.Items.Add($"[{DateTime.Now:HH:mm:ss}] {TraducirTexto("msg_LogGrillaActualizada")}");
        }
    }
}

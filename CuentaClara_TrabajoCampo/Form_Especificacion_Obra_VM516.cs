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
    public partial class Form_Especificacion_Obra_VM516 : Form
    {
        public Form_Especificacion_Obra_VM516()
        {
            InitializeComponent();
            bllObra = new BLL_Especificacion_Obra_VM516();
            bllArtista = new BLL_Artista_VM516();
        }
        private BLL_Especificacion_Obra_VM516 bllObra;
        private BLL_Artista_VM516 bllArtista;
        private string dniArtistaVerificado = "";
        private void FormatearGrilla()
        {
            if (dgvEspecificaciones.Columns.Contains("Id_Obra_VM516"))
                dgvEspecificaciones.Columns["Id_Obra_VM516"].HeaderText = "ID";
            if (dgvEspecificaciones.Columns.Contains("DNI_Artista_VM516"))
                dgvEspecificaciones.Columns["DNI_Artista_VM516"].HeaderText = "DNI Artista";
            if (dgvEspecificaciones.Columns.Contains("Titulo_Obra_VM516"))
                dgvEspecificaciones.Columns["Titulo_Obra_VM516"].HeaderText = "Título";
            if (dgvEspecificaciones.Columns.Contains("Tecnica_VM516"))
                dgvEspecificaciones.Columns["Tecnica_VM516"].HeaderText = "Técnica";
            if (dgvEspecificaciones.Columns.Contains("Alto_VM516"))
                dgvEspecificaciones.Columns["Alto_VM516"].HeaderText = "Alto";
            if (dgvEspecificaciones.Columns.Contains("Ancho_VM516"))
                dgvEspecificaciones.Columns["Ancho_VM516"].HeaderText = "Ancho";
            if (dgvEspecificaciones.Columns.Contains("Peso_VM516"))
                dgvEspecificaciones.Columns["Peso_VM516"].HeaderText = "Peso";
            if (dgvEspecificaciones.Columns.Contains("Req_Iluminacion_VM516"))
                dgvEspecificaciones.Columns["Req_Iluminacion_VM516"].HeaderText = "Iluminación";
            if (dgvEspecificaciones.Columns.Contains("Valor_Declarado_Mercado_VM516"))
                dgvEspecificaciones.Columns["Valor_Declarado_Mercado_VM516"].HeaderText = "Valor Mercado";
            if (dgvEspecificaciones.Columns.Contains("Categoria_Seguro_VM516"))
                dgvEspecificaciones.Columns["Categoria_Seguro_VM516"].HeaderText = "Seguro";
            if (dgvEspecificaciones.Columns.Contains("Estado_Asignacion_VM516"))
                dgvEspecificaciones.Columns["Estado_Asignacion_VM516"].HeaderText = "Estado";

            dgvEspecificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void Form_Especificacion_Obra_VM516_Load(object sender, EventArgs e)
        {
            Servicio_Usuario usuario = SessionManager.GetInstancia().GetUsuarioActual();
            BLL_Rol bllRol = new BLL_Rol();
            string nombreLegibleDelRol = bllRol.ObtenerNombreRol(usuario.IdRol);

            lblUsuarioValor.Text = $"{usuario.Login} -  {nombreLegibleDelRol}";

            BloquearCamposObra(false);
            CargarGrilla();

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
                MessageBox.Show("Error al cargar la grilla de especificaciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            
            lblNombreArtista.Text = "Estado del artista: Pendiente";
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

                if (string.IsNullOrWhiteSpace(dni))
                {
                    throw new Exception("Por favor, ingrese el DNI del artista a buscar.");
                }

                var artistasEncontrados = bllArtista.BuscarArtistaPorDNI_VM516(dni);

                if (artistasEncontrados != null && artistasEncontrados.Count > 0)
                {
                    var artista = artistasEncontrados[0];
                    dniArtistaVerificado = artista.DNI_VM516;
                    lblNombreArtista.Text = $"Artista verificado: {artista.Nombre_VM516} {artista.Apellido_VM516}";
                    lblNombreArtista.ForeColor = System.Drawing.Color.FromArgb(18, 120, 50);
                    BloquearCamposObra(true);
                }
                else
                {
                    dniArtistaVerificado = "";
                    lblNombreArtista.Text = "El artista no se encuentra registrado.";
                    lblNombreArtista.ForeColor = System.Drawing.Color.FromArgb(180, 40, 40);
                    BloquearCamposObra(false);
                    MessageBox.Show("El artista no se encuentra registrado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnConfirmarRegistro_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(dniArtistaVerificado))
                {
                    throw new Exception("Debe verificar un artista registrado antes de confirmar la obra.");
                }

                if (!decimal.TryParse(txtAlto.Text.Trim(), out decimal alto) ||
                    !decimal.TryParse(txtAncho.Text.Trim(), out decimal ancho) ||
                    !decimal.TryParse(txtPeso.Text.Trim(), out decimal peso) ||
                    !decimal.TryParse(txtValorMercado.Text.Trim(), out decimal valorMercado))
                {
                    throw new Exception("Los campos de Alto, Ancho, Peso y Valor de Mercado deben ser numéricos.");
                }

                BE_Especificacion_Obra_VM516 nuevaObra = new BE_Especificacion_Obra_VM516
                {
                    DNI_Artista_VM516 = dniArtistaVerificado,
                    Titulo_Obra_VM516 = txtTitulo.Text.Trim(),
                    Tecnica_VM516 = txtTecnica.Text.Trim(),
                    Alto_VM516 = alto,
                    Ancho_VM516 = ancho,
                    Peso_VM516 = peso,
                    Req_Iluminacion_VM516 = comboBox1.Text.Trim(),
                    Valor_Declarado_Mercado_VM516 = valorMercado,
                    Categoria_Seguro_VM516 = comboBox2.Text.Trim(),
                    Estado_Asignacion_VM516 = "Pendiente_Asignacion"
                };

                bllObra.RegistrarEspecificacion_VM516(nuevaObra);

                MessageBox.Show("¡Especificación de obra registrada con éxito bajo el estado [Pendiente_Asignacion]!", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarGrilla();
                LimpiarCamposObra();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validación / Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

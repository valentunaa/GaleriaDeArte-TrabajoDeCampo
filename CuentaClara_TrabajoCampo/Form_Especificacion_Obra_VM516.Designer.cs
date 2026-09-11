namespace IU
{
    partial class Form_Especificacion_Obra_VM516
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelContenedor = new Panel();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            lblTitulo = new Label();
            dgvEspecificaciones = new DataGridView();
            lblDNI = new Label();
            txtDNIBuscar = new TextBox();
            btnBuscarArtista = new Button();
            lblNombreArtista = new Label();
            lblTituloObra = new Label();
            txtTitulo = new TextBox();
            lblTecnica = new Label();
            txtTecnica = new TextBox();
            lblAlto = new Label();
            txtAlto = new TextBox();
            lblAncho = new Label();
            txtAncho = new TextBox();
            lblPeso = new Label();
            txtPeso = new TextBox();
            lblReqIluminacion = new Label();
            lblValorMercado = new Label();
            txtValorMercado = new TextBox();
            lblCategoriaSeguro = new Label();
            btnConfirmarRegistro = new Button();
            btnSalir = new Button();
            panelInferior = new Panel();
            lblUsuarioValor = new Label();
            lblUsuarioActivo = new Label();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEspecificaciones).BeginInit();
            panelInferior.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.Anchor = AnchorStyles.None;
            panelContenedor.BackColor = Color.White;
            panelContenedor.Controls.Add(comboBox2);
            panelContenedor.Controls.Add(comboBox1);
            panelContenedor.Controls.Add(lblTitulo);
            panelContenedor.Controls.Add(dgvEspecificaciones);
            panelContenedor.Controls.Add(lblDNI);
            panelContenedor.Controls.Add(txtDNIBuscar);
            panelContenedor.Controls.Add(btnBuscarArtista);
            panelContenedor.Controls.Add(lblNombreArtista);
            panelContenedor.Controls.Add(lblTituloObra);
            panelContenedor.Controls.Add(txtTitulo);
            panelContenedor.Controls.Add(lblTecnica);
            panelContenedor.Controls.Add(txtTecnica);
            panelContenedor.Controls.Add(lblAlto);
            panelContenedor.Controls.Add(txtAlto);
            panelContenedor.Controls.Add(lblAncho);
            panelContenedor.Controls.Add(txtAncho);
            panelContenedor.Controls.Add(lblPeso);
            panelContenedor.Controls.Add(txtPeso);
            panelContenedor.Controls.Add(lblReqIluminacion);
            panelContenedor.Controls.Add(lblValorMercado);
            panelContenedor.Controls.Add(txtValorMercado);
            panelContenedor.Controls.Add(lblCategoriaSeguro);
            panelContenedor.Controls.Add(btnConfirmarRegistro);
            panelContenedor.Controls.Add(btnSalir);
            panelContenedor.Location = new Point(12, 12);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1316, 745);
            panelContenedor.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Básico", "Estándar", "Premium" });
            comboBox2.Location = new Point(234, 457);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(180, 23);
            comboBox2.TabIndex = 25;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Natural (o Luz natural / Cenital)", "Artificial (o Luz fría / Cálida / LED)", "Mixta (combinación de ambas)" });
            comboBox1.Location = new Point(34, 387);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(380, 23);
            comboBox1.TabIndex = 24;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(20, 70, 120);
            lblTitulo.Location = new Point(30, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(414, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Tag = "titulo_FormEspecificacionObra";
            lblTitulo.Text = "Catalogar Especificaciones de Obra";
            // 
            // dgvEspecificaciones
            // 
            dgvEspecificaciones.AllowUserToAddRows = false;
            dgvEspecificaciones.AllowUserToDeleteRows = false;
            dgvEspecificaciones.AllowUserToResizeRows = false;
            dgvEspecificaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEspecificaciones.BackgroundColor = Color.FromArgb(18, 87, 150);
            dgvEspecificaciones.BorderStyle = BorderStyle.None;
            dgvEspecificaciones.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEspecificaciones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(18, 87, 150);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEspecificaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEspecificaciones.ColumnHeadersHeight = 58;
            dgvEspecificaciones.EnableHeadersVisualStyles = false;
            dgvEspecificaciones.GridColor = Color.FromArgb(220, 220, 220);
            dgvEspecificaciones.Location = new Point(480, 80);
            dgvEspecificaciones.MultiSelect = false;
            dgvEspecificaciones.Name = "dgvEspecificaciones";
            dgvEspecificaciones.ReadOnly = true;
            dgvEspecificaciones.RowHeadersVisible = false;
            dgvEspecificaciones.RowHeadersWidth = 102;
            dgvEspecificaciones.RowTemplate.Height = 28;
            dgvEspecificaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEspecificaciones.Size = new Size(789, 580);
            dgvEspecificaciones.TabIndex = 21;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDNI.ForeColor = Color.FromArgb(15, 45, 75);
            lblDNI.Location = new Point(34, 80);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(82, 19);
            lblDNI.TabIndex = 2;
            lblDNI.Tag = "lbl_DNIArtista";
            lblDNI.Text = "DNI Artista";
            // 
            // txtDNIBuscar
            // 
            txtDNIBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtDNIBuscar.Font = new Font("Segoe UI", 10F);
            txtDNIBuscar.Location = new Point(34, 105);
            txtDNIBuscar.Name = "txtDNIBuscar";
            txtDNIBuscar.Size = new Size(180, 25);
            txtDNIBuscar.TabIndex = 3;
            // 
            // btnBuscarArtista
            // 
            btnBuscarArtista.BackColor = Color.FromArgb(18, 87, 150);
            btnBuscarArtista.FlatAppearance.BorderSize = 0;
            btnBuscarArtista.FlatStyle = FlatStyle.Flat;
            btnBuscarArtista.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBuscarArtista.ForeColor = Color.White;
            btnBuscarArtista.Location = new Point(230, 103);
            btnBuscarArtista.Name = "btnBuscarArtista";
            btnBuscarArtista.Size = new Size(140, 28);
            btnBuscarArtista.TabIndex = 4;
            btnBuscarArtista.Tag = "btn_BuscarArtista";
            btnBuscarArtista.Text = "Buscar Artista";
            btnBuscarArtista.UseVisualStyleBackColor = false;
            btnBuscarArtista.Click += btnBuscarArtista_Click_1;
            // 
            // lblNombreArtista
            // 
            lblNombreArtista.AutoSize = true;
            lblNombreArtista.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblNombreArtista.ForeColor = Color.FromArgb(15, 45, 75);
            lblNombreArtista.Location = new Point(34, 145);
            lblNombreArtista.Name = "lblNombreArtista";
            lblNombreArtista.Size = new Size(185, 17);
            lblNombreArtista.TabIndex = 5;
            lblNombreArtista.Tag = "lbl_EstadoArtistaPendiente";
            lblNombreArtista.Text = "Estado del artista: Pendiente";
            // 
            // lblTituloObra
            // 
            lblTituloObra.AutoSize = true;
            lblTituloObra.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTituloObra.ForeColor = Color.FromArgb(15, 45, 75);
            lblTituloObra.Location = new Point(34, 180);
            lblTituloObra.Name = "lblTituloObra";
            lblTituloObra.Size = new Size(106, 19);
            lblTituloObra.TabIndex = 6;
            lblTituloObra.Tag = "lbl_TituloObra";
            lblTituloObra.Text = "Título de Obra";
            // 
            // txtTitulo
            // 
            txtTitulo.BorderStyle = BorderStyle.FixedSingle;
            txtTitulo.Font = new Font("Segoe UI", 10F);
            txtTitulo.Location = new Point(34, 205);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(380, 25);
            txtTitulo.TabIndex = 7;
            // 
            // lblTecnica
            // 
            lblTecnica.AutoSize = true;
            lblTecnica.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTecnica.ForeColor = Color.FromArgb(15, 45, 75);
            lblTecnica.Location = new Point(34, 240);
            lblTecnica.Name = "lblTecnica";
            lblTecnica.Size = new Size(58, 19);
            lblTecnica.TabIndex = 8;
            lblTecnica.Tag = "lbl_Tecnica";
            lblTecnica.Text = "Técnica";
            // 
            // txtTecnica
            // 
            txtTecnica.BorderStyle = BorderStyle.FixedSingle;
            txtTecnica.Font = new Font("Segoe UI", 10F);
            txtTecnica.Location = new Point(34, 265);
            txtTecnica.Name = "txtTecnica";
            txtTecnica.Size = new Size(380, 25);
            txtTecnica.TabIndex = 9;
            // 
            // lblAlto
            // 
            lblAlto.AutoSize = true;
            lblAlto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAlto.ForeColor = Color.FromArgb(15, 45, 75);
            lblAlto.Location = new Point(34, 300);
            lblAlto.Name = "lblAlto";
            lblAlto.Size = new Size(37, 19);
            lblAlto.TabIndex = 10;
            lblAlto.Tag = "lbl_Alto";
            lblAlto.Text = "Alto";
            // 
            // txtAlto
            // 
            txtAlto.BorderStyle = BorderStyle.FixedSingle;
            txtAlto.Font = new Font("Segoe UI", 10F);
            txtAlto.Location = new Point(34, 325);
            txtAlto.Name = "txtAlto";
            txtAlto.Size = new Size(110, 25);
            txtAlto.TabIndex = 11;
            // 
            // lblAncho
            // 
            lblAncho.AutoSize = true;
            lblAncho.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAncho.ForeColor = Color.FromArgb(15, 45, 75);
            lblAncho.Location = new Point(169, 300);
            lblAncho.Name = "lblAncho";
            lblAncho.Size = new Size(51, 19);
            lblAncho.TabIndex = 12;
            lblAncho.Tag = "lbl_Ancho";
            lblAncho.Text = "Ancho";
            // 
            // txtAncho
            // 
            txtAncho.BorderStyle = BorderStyle.FixedSingle;
            txtAncho.Font = new Font("Segoe UI", 10F);
            txtAncho.Location = new Point(169, 325);
            txtAncho.Name = "txtAncho";
            txtAncho.Size = new Size(110, 25);
            txtAncho.TabIndex = 13;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPeso.ForeColor = Color.FromArgb(15, 45, 75);
            lblPeso.Location = new Point(304, 300);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(41, 19);
            lblPeso.TabIndex = 14;
            lblPeso.Tag = "lbl_Peso";
            lblPeso.Text = "Peso";
            // 
            // txtPeso
            // 
            txtPeso.BorderStyle = BorderStyle.FixedSingle;
            txtPeso.Font = new Font("Segoe UI", 10F);
            txtPeso.Location = new Point(304, 325);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(110, 25);
            txtPeso.TabIndex = 15;
            // 
            // lblReqIluminacion
            // 
            lblReqIluminacion.AutoSize = true;
            lblReqIluminacion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblReqIluminacion.ForeColor = Color.FromArgb(15, 45, 75);
            lblReqIluminacion.Location = new Point(34, 365);
            lblReqIluminacion.Name = "lblReqIluminacion";
            lblReqIluminacion.Size = new Size(173, 19);
            lblReqIluminacion.TabIndex = 16;
            lblReqIluminacion.Tag = "lbl_ReqIluminacion";
            lblReqIluminacion.Text = "Requisito de Iluminación";
            // 
            // lblValorMercado
            // 
            lblValorMercado.AutoSize = true;
            lblValorMercado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblValorMercado.ForeColor = Color.FromArgb(15, 45, 75);
            lblValorMercado.Location = new Point(34, 430);
            lblValorMercado.Name = "lblValorMercado";
            lblValorMercado.Size = new Size(206, 19);
            lblValorMercado.TabIndex = 18;
            lblValorMercado.Tag = "lbl_ValorMercado";
            lblValorMercado.Text = "Valor Declarado del Mercado";
            // 
            // txtValorMercado
            // 
            txtValorMercado.BorderStyle = BorderStyle.FixedSingle;
            txtValorMercado.Font = new Font("Segoe UI", 10F);
            txtValorMercado.Location = new Point(34, 455);
            txtValorMercado.Name = "txtValorMercado";
            txtValorMercado.Size = new Size(180, 25);
            txtValorMercado.TabIndex = 19;
            // 
            // lblCategoriaSeguro
            // 
            lblCategoriaSeguro.AutoSize = true;
            lblCategoriaSeguro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCategoriaSeguro.ForeColor = Color.FromArgb(15, 45, 75);
            lblCategoriaSeguro.Location = new Point(234, 430);
            lblCategoriaSeguro.Name = "lblCategoriaSeguro";
            lblCategoriaSeguro.Size = new Size(148, 19);
            lblCategoriaSeguro.TabIndex = 20;
            lblCategoriaSeguro.Tag = "lbl_CategoriaSeguro";
            lblCategoriaSeguro.Text = "Categoría de Seguro";
            // 
            // btnConfirmarRegistro
            // 
            btnConfirmarRegistro.BackColor = Color.FromArgb(18, 87, 150);
            btnConfirmarRegistro.FlatAppearance.BorderSize = 0;
            btnConfirmarRegistro.FlatStyle = FlatStyle.Flat;
            btnConfirmarRegistro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConfirmarRegistro.ForeColor = Color.White;
            btnConfirmarRegistro.Location = new Point(34, 510);
            btnConfirmarRegistro.Name = "btnConfirmarRegistro";
            btnConfirmarRegistro.Size = new Size(380, 40);
            btnConfirmarRegistro.TabIndex = 22;
            btnConfirmarRegistro.Tag = "btn_ConfirmarRegistroObra";
            btnConfirmarRegistro.Text = "Confirmar Registro";
            btnConfirmarRegistro.UseVisualStyleBackColor = false;
            btnConfirmarRegistro.Click += btnConfirmarRegistro_Click_1;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.White;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(18, 87, 150);
            btnSalir.Location = new Point(1129, 21);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(140, 38);
            btnSalir.TabIndex = 23;
            btnSalir.Tag = "btn_Salir";
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // panelInferior
            // 
            panelInferior.BackColor = Color.FromArgb(18, 87, 150);
            panelInferior.Controls.Add(lblUsuarioValor);
            panelInferior.Controls.Add(lblUsuarioActivo);
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(0, 750);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(1340, 38);
            panelInferior.TabIndex = 0;
            // 
            // lblUsuarioValor
            // 
            lblUsuarioValor.AutoSize = true;
            lblUsuarioValor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuarioValor.ForeColor = Color.White;
            lblUsuarioValor.Location = new Point(114, 10);
            lblUsuarioValor.Name = "lblUsuarioValor";
            lblUsuarioValor.Size = new Size(161, 15);
            lblUsuarioValor.TabIndex = 1;
            lblUsuarioValor.Text = "Maria Lopez -Administrador";
            // 
            // lblUsuarioActivo
            // 
            lblUsuarioActivo.AutoSize = true;
            lblUsuarioActivo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuarioActivo.ForeColor = Color.White;
            lblUsuarioActivo.Location = new Point(20, 10);
            lblUsuarioActivo.Name = "lblUsuarioActivo";
            lblUsuarioActivo.Size = new Size(92, 15);
            lblUsuarioActivo.TabIndex = 0;
            lblUsuarioActivo.Tag = "lbl_Usuario";
            lblUsuarioActivo.Text = "Usuario activo: ";
            // 
            // Form_Especificacion_Obra_VM516
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(1340, 788);
            Controls.Add(panelInferior);
            Controls.Add(panelContenedor);
            Font = new Font("Segoe UI", 9F);
            Name = "Form_Especificacion_Obra_VM516";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Catalogar Especificaciones de Obra";
            FormClosed += Form_Especificacion_Obra_VM516_FormClosed;
            Load += Form_Especificacion_Obra_VM516_Load;
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEspecificaciones).EndInit();
            panelInferior.ResumeLayout(false);
            panelInferior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvEspecificaciones;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtDNIBuscar;
        private System.Windows.Forms.Button btnBuscarArtista;
        private System.Windows.Forms.Label lblNombreArtista;
        private System.Windows.Forms.Label lblTituloObra;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTecnica;
        private System.Windows.Forms.TextBox txtTecnica;
        private System.Windows.Forms.Label lblAlto;
        private System.Windows.Forms.TextBox txtAlto;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblReqIluminacion;
        private System.Windows.Forms.Label lblValorMercado;
        private System.Windows.Forms.TextBox txtValorMercado;
        private System.Windows.Forms.Label lblCategoriaSeguro;
        private System.Windows.Forms.Button btnConfirmarRegistro;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Label lblUsuarioActivo;
        private System.Windows.Forms.Label lblUsuarioValor;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
    }
}
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelContenedor = new Panel();
            button2 = new Button();
            listBox1 = new ListBox();
            button1 = new Button();
            btnSerializar = new Button();
            btnModificar_VM516 = new Button();
            btnEliminar_VM516 = new Button();
            btnLimpiar_VM516 = new Button();
            picLogo = new PictureBox();
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
            toolTipObras = new ToolTip(components);
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEspecificaciones).BeginInit();
            panelInferior.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.Anchor = AnchorStyles.None;
            panelContenedor.BackColor = Color.White;
            panelContenedor.Controls.Add(button2);
            panelContenedor.Controls.Add(listBox1);
            panelContenedor.Controls.Add(button1);
            panelContenedor.Controls.Add(btnSerializar);
            panelContenedor.Controls.Add(btnModificar_VM516);
            panelContenedor.Controls.Add(btnEliminar_VM516);
            panelContenedor.Controls.Add(btnLimpiar_VM516);
            panelContenedor.Controls.Add(picLogo);
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
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(46, 17, 39);
            button2.Location = new Point(969, 506);
            button2.Name = "button2";
            button2.Size = new Size(137, 40);
            button2.TabIndex = 34;
            button2.Tag = "btn_Actualizar";
            button2.Text = "ACTUALIZAR";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(480, 559);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(789, 154);
            listBox1.TabIndex = 33;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(18, 120, 50);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(642, 506);
            button1.Name = "button1";
            button1.Size = new Size(137, 38);
            button1.TabIndex = 32;
            button1.Tag = "btnDeserializar";
            button1.Text = "DES-SERIALIZAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnSerializar
            // 
            btnSerializar.BackColor = Color.FromArgb(18, 120, 50);
            btnSerializar.FlatStyle = FlatStyle.Flat;
            btnSerializar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSerializar.ForeColor = Color.White;
            btnSerializar.Location = new Point(479, 506);
            btnSerializar.Name = "btnSerializar";
            btnSerializar.Size = new Size(137, 38);
            btnSerializar.TabIndex = 31;
            btnSerializar.Tag = "btnSerializar";
            btnSerializar.Text = "SERIALIZAR";
            btnSerializar.UseVisualStyleBackColor = false;
            btnSerializar.Click += btnSerializar_Click;
            // 
            // btnModificar_VM516
            // 
            btnModificar_VM516.BackColor = Color.FromArgb(18, 87, 150);
            btnModificar_VM516.FlatAppearance.BorderSize = 0;
            btnModificar_VM516.FlatStyle = FlatStyle.Flat;
            btnModificar_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnModificar_VM516.ForeColor = Color.White;
            btnModificar_VM516.Location = new Point(35, 605);
            btnModificar_VM516.Name = "btnModificar_VM516";
            btnModificar_VM516.Size = new Size(158, 40);
            btnModificar_VM516.TabIndex = 28;
            btnModificar_VM516.Tag = "btn_ModificarSala";
            btnModificar_VM516.Text = "Modificar";
            btnModificar_VM516.UseVisualStyleBackColor = false;
            btnModificar_VM516.Click += btnModificar_VM516_Click;
            // 
            // btnEliminar_VM516
            // 
            btnEliminar_VM516.BackColor = Color.FromArgb(180, 40, 40);
            btnEliminar_VM516.FlatAppearance.BorderSize = 0;
            btnEliminar_VM516.FlatStyle = FlatStyle.Flat;
            btnEliminar_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEliminar_VM516.ForeColor = Color.White;
            btnEliminar_VM516.Location = new Point(256, 605);
            btnEliminar_VM516.Name = "btnEliminar_VM516";
            btnEliminar_VM516.Size = new Size(158, 40);
            btnEliminar_VM516.TabIndex = 29;
            btnEliminar_VM516.Tag = "btn_EliminarSala";
            btnEliminar_VM516.Text = "Eliminar";
            btnEliminar_VM516.UseVisualStyleBackColor = false;
            btnEliminar_VM516.Click += btnEliminar_VM516_Click;
            // 
            // btnLimpiar_VM516
            // 
            btnLimpiar_VM516.BackColor = Color.White;
            btnLimpiar_VM516.FlatStyle = FlatStyle.Flat;
            btnLimpiar_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLimpiar_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            btnLimpiar_VM516.Location = new Point(806, 506);
            btnLimpiar_VM516.Name = "btnLimpiar_VM516";
            btnLimpiar_VM516.Size = new Size(137, 40);
            btnLimpiar_VM516.TabIndex = 30;
            btnLimpiar_VM516.Tag = "btn_LimpiarSala";
            btnLimpiar_VM516.Text = "Limpiar";
            btnLimpiar_VM516.UseVisualStyleBackColor = false;
            btnLimpiar_VM516.Click += btnLimpiar_VM516_Click;
            // 
            // picLogo
            // 
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Image = Properties.Resources.ImagenLogo;
            picLogo.Location = new Point(34, 10);
            picLogo.Margin = new Padding(0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(63, 60);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 26;
            picLogo.TabStop = false;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Básico", "Estándar", "Premium" });
            comboBox2.Location = new Point(246, 506);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(168, 23);
            comboBox2.TabIndex = 25;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Natural (o Luz natural / Cenital)", "Artificial (o Luz fría / Cálida / LED)", "Mixta (combinación de ambas)" });
            comboBox1.Location = new Point(34, 436);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(380, 23);
            comboBox1.TabIndex = 24;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(46, 17, 39);
            lblTitulo.Location = new Point(102, 20);
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
            dgvEspecificaciones.BackgroundColor = Color.FromArgb(46, 17, 39);
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
            dgvEspecificaciones.Location = new Point(480, 129);
            dgvEspecificaciones.MultiSelect = false;
            dgvEspecificaciones.Name = "dgvEspecificaciones";
            dgvEspecificaciones.ReadOnly = true;
            dgvEspecificaciones.RowHeadersVisible = false;
            dgvEspecificaciones.RowHeadersWidth = 102;
            dgvEspecificaciones.RowTemplate.Height = 28;
            dgvEspecificaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEspecificaciones.Size = new Size(789, 341);
            dgvEspecificaciones.TabIndex = 21;
            dgvEspecificaciones.CellClick += dgvEspecificaciones_CellClick;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDNI.ForeColor = Color.FromArgb(46, 17, 39);
            lblDNI.Location = new Point(34, 129);
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
            txtDNIBuscar.Location = new Point(34, 154);
            txtDNIBuscar.Name = "txtDNIBuscar";
            txtDNIBuscar.Size = new Size(180, 25);
            txtDNIBuscar.TabIndex = 3;
            // 
            // btnBuscarArtista
            // 
            btnBuscarArtista.BackColor = Color.FromArgb(46, 17, 39);
            btnBuscarArtista.FlatAppearance.BorderSize = 0;
            btnBuscarArtista.FlatStyle = FlatStyle.Flat;
            btnBuscarArtista.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBuscarArtista.ForeColor = Color.White;
            btnBuscarArtista.Location = new Point(230, 152);
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
            lblNombreArtista.Location = new Point(34, 194);
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
            lblTituloObra.ForeColor = Color.FromArgb(46, 17, 39);
            lblTituloObra.Location = new Point(34, 229);
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
            txtTitulo.Location = new Point(34, 254);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(380, 25);
            txtTitulo.TabIndex = 7;
            // 
            // lblTecnica
            // 
            lblTecnica.AutoSize = true;
            lblTecnica.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTecnica.ForeColor = Color.FromArgb(46, 17, 39);
            lblTecnica.Location = new Point(34, 289);
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
            txtTecnica.Location = new Point(34, 314);
            txtTecnica.Name = "txtTecnica";
            txtTecnica.Size = new Size(380, 25);
            txtTecnica.TabIndex = 9;
            // 
            // lblAlto
            // 
            lblAlto.AutoSize = true;
            lblAlto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAlto.ForeColor = Color.FromArgb(46, 17, 39);
            lblAlto.Location = new Point(34, 349);
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
            txtAlto.Location = new Point(34, 374);
            txtAlto.Name = "txtAlto";
            txtAlto.Size = new Size(110, 25);
            txtAlto.TabIndex = 11;
            // 
            // lblAncho
            // 
            lblAncho.AutoSize = true;
            lblAncho.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAncho.ForeColor = Color.FromArgb(46, 17, 39);
            lblAncho.Location = new Point(169, 349);
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
            txtAncho.Location = new Point(169, 374);
            txtAncho.Name = "txtAncho";
            txtAncho.Size = new Size(110, 25);
            txtAncho.TabIndex = 13;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPeso.ForeColor = Color.FromArgb(46, 17, 39);
            lblPeso.Location = new Point(304, 349);
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
            txtPeso.Location = new Point(304, 374);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(110, 25);
            txtPeso.TabIndex = 15;
            // 
            // lblReqIluminacion
            // 
            lblReqIluminacion.AutoSize = true;
            lblReqIluminacion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblReqIluminacion.ForeColor = Color.FromArgb(46, 17, 39);
            lblReqIluminacion.Location = new Point(34, 414);
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
            lblValorMercado.ForeColor = Color.FromArgb(46, 17, 39);
            lblValorMercado.Location = new Point(34, 479);
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
            txtValorMercado.Location = new Point(34, 504);
            txtValorMercado.Name = "txtValorMercado";
            txtValorMercado.Size = new Size(180, 25);
            txtValorMercado.TabIndex = 19;
            // 
            // lblCategoriaSeguro
            // 
            lblCategoriaSeguro.AutoSize = true;
            lblCategoriaSeguro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCategoriaSeguro.ForeColor = Color.FromArgb(46, 17, 39);
            lblCategoriaSeguro.Location = new Point(246, 479);
            lblCategoriaSeguro.Name = "lblCategoriaSeguro";
            lblCategoriaSeguro.Size = new Size(148, 19);
            lblCategoriaSeguro.TabIndex = 20;
            lblCategoriaSeguro.Tag = "lbl_CategoriaSeguro";
            lblCategoriaSeguro.Text = "Categoría de Seguro";
            // 
            // btnConfirmarRegistro
            // 
            btnConfirmarRegistro.BackColor = Color.FromArgb(46, 17, 39);
            btnConfirmarRegistro.FlatAppearance.BorderSize = 0;
            btnConfirmarRegistro.FlatStyle = FlatStyle.Flat;
            btnConfirmarRegistro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConfirmarRegistro.ForeColor = Color.White;
            btnConfirmarRegistro.Location = new Point(34, 559);
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
            btnSalir.ForeColor = Color.FromArgb(46, 17, 39);
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
            panelInferior.BackColor = Color.FromArgb(46, 17, 39);
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
            Text = "Vanguardia Arte - Catalogar Especificaciones de Obra";
            FormClosed += Form_Especificacion_Obra_VM516_FormClosed;
            Load += Form_Especificacion_Obra_VM516_Load;
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
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
        private PictureBox picLogo;
        private Button btnModificar_VM516;
        private Button btnEliminar_VM516;
        private Button btnLimpiar_VM516;
        private Button button1;
        private Button btnSerializar;
        private ListBox listBox1;
        private Button button2;
        private ToolTip toolTipObras;
    }
}
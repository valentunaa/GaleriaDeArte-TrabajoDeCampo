namespace IU
{
    partial class Form_Cafeteria_VM516
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelContenedor_VM516 = new Panel();
            picLogo = new PictureBox();
            lblTitulo_VM516 = new Label();
            btnSalir_VM516 = new Button();
            panelCliente_VM516 = new Panel();
            panelAcento1_VM516 = new Panel();
            lblDniCliente_VM516 = new Label();
            txtDniCliente_VM516 = new TextBox();
            btnBuscarCliente_VM516 = new Button();
            lblNombreCliente_VM516 = new Label();
            panelOperacion_VM516 = new Panel();
            panelAcento2_VM516 = new Panel();
            lblCantidad_VM516 = new Label();
            txtCantidad_VM516 = new TextBox();
            btnAgregarCarrito_VM516 = new Button();
            btnQuitarCarrito_VM516 = new Button();
            panelTotalizador_VM516 = new Panel();
            panelAcento3_VM516 = new Panel();
            lblTotalTitulo_VM516 = new Label();
            lblTotalMonto_VM516 = new Label();
            btnConfirmarPedido_VM516 = new Button();
            lblProductosTitulo_VM516 = new Label();
            dgvProductos_VM516 = new DataGridView();
            lblCarritoTitulo_VM516 = new Label();
            dgvCarrito_VM516 = new DataGridView();
            panelInferior_VM516 = new Panel();
            lblUsuarioValor_VM516 = new Label();
            lblUsuarioActivo_VM516 = new Label();
            toolTipPedido = new ToolTip(components);
            panelContenedor_VM516.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelCliente_VM516.SuspendLayout();
            panelOperacion_VM516.SuspendLayout();
            panelTotalizador_VM516.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos_VM516).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito_VM516).BeginInit();
            panelInferior_VM516.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor_VM516
            // 
            panelContenedor_VM516.Anchor = AnchorStyles.None;
            panelContenedor_VM516.BackColor = Color.FromArgb(245, 246, 248);
            panelContenedor_VM516.Controls.Add(picLogo);
            panelContenedor_VM516.Controls.Add(lblTitulo_VM516);
            panelContenedor_VM516.Controls.Add(btnSalir_VM516);
            panelContenedor_VM516.Controls.Add(panelCliente_VM516);
            panelContenedor_VM516.Controls.Add(panelOperacion_VM516);
            panelContenedor_VM516.Controls.Add(panelTotalizador_VM516);
            panelContenedor_VM516.Controls.Add(lblProductosTitulo_VM516);
            panelContenedor_VM516.Controls.Add(dgvProductos_VM516);
            panelContenedor_VM516.Controls.Add(lblCarritoTitulo_VM516);
            panelContenedor_VM516.Controls.Add(dgvCarrito_VM516);
            panelContenedor_VM516.Location = new Point(10, 12);
            panelContenedor_VM516.Name = "panelContenedor_VM516";
            panelContenedor_VM516.Size = new Size(1451, 735);
            panelContenedor_VM516.TabIndex = 1;
            // 
            // picLogo
            // 
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Image = Properties.Resources.ImagenLogo;
            picLogo.Location = new Point(34, 16);
            picLogo.Margin = new Padding(0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(63, 60);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 27;
            picLogo.TabStop = false;
            // 
            // lblTitulo_VM516
            // 
            lblTitulo_VM516.AutoSize = true;
            lblTitulo_VM516.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitulo_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            lblTitulo_VM516.Location = new Point(102, 30);
            lblTitulo_VM516.Name = "lblTitulo_VM516";
            lblTitulo_VM516.Size = new Size(252, 41);
            lblTitulo_VM516.TabIndex = 1;
            lblTitulo_VM516.Tag = "titulo_FormRegistrarPedido";
            lblTitulo_VM516.Text = "Registrar Pedido";
            // 
            // btnSalir_VM516
            // 
            btnSalir_VM516.BackColor = Color.White;
            btnSalir_VM516.FlatAppearance.BorderColor = Color.Black;
            btnSalir_VM516.FlatStyle = FlatStyle.Flat;
            btnSalir_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalir_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            btnSalir_VM516.Location = new Point(1280, 36);
            btnSalir_VM516.Name = "btnSalir_VM516";
            btnSalir_VM516.Size = new Size(140, 40);
            btnSalir_VM516.TabIndex = 2;
            btnSalir_VM516.Tag = "btn_Salir";
            btnSalir_VM516.Text = "Salir";
            btnSalir_VM516.UseVisualStyleBackColor = false;
            btnSalir_VM516.Click += btnSalir_VM516_Click;
            // 
            // panelCliente_VM516
            // 
            panelCliente_VM516.BackColor = Color.White;
            panelCliente_VM516.Controls.Add(panelAcento1_VM516);
            panelCliente_VM516.Controls.Add(lblDniCliente_VM516);
            panelCliente_VM516.Controls.Add(txtDniCliente_VM516);
            panelCliente_VM516.Controls.Add(btnBuscarCliente_VM516);
            panelCliente_VM516.Controls.Add(lblNombreCliente_VM516);
            panelCliente_VM516.Location = new Point(34, 110);
            panelCliente_VM516.Name = "panelCliente_VM516";
            panelCliente_VM516.Size = new Size(420, 150);
            panelCliente_VM516.TabIndex = 2;
            // 
            // panelAcento1_VM516
            // 
            panelAcento1_VM516.BackColor = Color.FromArgb(18, 87, 150);
            panelAcento1_VM516.Dock = DockStyle.Top;
            panelAcento1_VM516.Location = new Point(0, 0);
            panelAcento1_VM516.Name = "panelAcento1_VM516";
            panelAcento1_VM516.Size = new Size(420, 4);
            panelAcento1_VM516.TabIndex = 0;
            // 
            // lblDniCliente_VM516
            // 
            lblDniCliente_VM516.AutoSize = true;
            lblDniCliente_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDniCliente_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            lblDniCliente_VM516.Location = new Point(20, 20);
            lblDniCliente_VM516.Name = "lblDniCliente_VM516";
            lblDniCliente_VM516.Size = new Size(174, 19);
            lblDniCliente_VM516.TabIndex = 1;
            lblDniCliente_VM516.Tag = "lbl_DniCliente";
            lblDniCliente_VM516.Text = "Identificación del Cliente";
            // 
            // txtDniCliente_VM516
            // 
            txtDniCliente_VM516.BorderStyle = BorderStyle.FixedSingle;
            txtDniCliente_VM516.Font = new Font("Segoe UI", 11F);
            txtDniCliente_VM516.Location = new Point(20, 45);
            txtDniCliente_VM516.Name = "txtDniCliente_VM516";
            txtDniCliente_VM516.Size = new Size(200, 27);
            txtDniCliente_VM516.TabIndex = 2;
            // 
            // btnBuscarCliente_VM516
            // 
            btnBuscarCliente_VM516.BackColor = Color.FromArgb(46, 17, 39);
            btnBuscarCliente_VM516.FlatAppearance.BorderSize = 0;
            btnBuscarCliente_VM516.FlatStyle = FlatStyle.Flat;
            btnBuscarCliente_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBuscarCliente_VM516.ForeColor = Color.White;
            btnBuscarCliente_VM516.Location = new Point(235, 45);
            btnBuscarCliente_VM516.Name = "btnBuscarCliente_VM516";
            btnBuscarCliente_VM516.Size = new Size(165, 27);
            btnBuscarCliente_VM516.TabIndex = 3;
            btnBuscarCliente_VM516.Tag = "btn_BuscarCliente";
            btnBuscarCliente_VM516.Text = "Buscar";
            btnBuscarCliente_VM516.UseVisualStyleBackColor = false;
            btnBuscarCliente_VM516.Click += btnBuscarCliente_VM516_Click;
            // 
            // lblNombreCliente_VM516
            // 
            lblNombreCliente_VM516.AutoSize = true;
            lblNombreCliente_VM516.Font = new Font("Segoe UI", 11F);
            lblNombreCliente_VM516.ForeColor = Color.DimGray;
            lblNombreCliente_VM516.Location = new Point(20, 95);
            lblNombreCliente_VM516.Name = "lblNombreCliente_VM516";
            lblNombreCliente_VM516.Size = new Size(182, 20);
            lblNombreCliente_VM516.TabIndex = 4;
            lblNombreCliente_VM516.Tag = "lbl_NombreClienteInfo";
            lblNombreCliente_VM516.Text = "👤 Seleccione un cliente...";
            // 
            // panelOperacion_VM516
            // 
            panelOperacion_VM516.BackColor = Color.White;
            panelOperacion_VM516.Controls.Add(panelAcento2_VM516);
            panelOperacion_VM516.Controls.Add(lblCantidad_VM516);
            panelOperacion_VM516.Controls.Add(txtCantidad_VM516);
            panelOperacion_VM516.Controls.Add(btnAgregarCarrito_VM516);
            panelOperacion_VM516.Controls.Add(btnQuitarCarrito_VM516);
            panelOperacion_VM516.Location = new Point(34, 280);
            panelOperacion_VM516.Name = "panelOperacion_VM516";
            panelOperacion_VM516.Size = new Size(420, 180);
            panelOperacion_VM516.TabIndex = 3;
            // 
            // panelAcento2_VM516
            // 
            panelAcento2_VM516.BackColor = Color.FromArgb(18, 87, 150);
            panelAcento2_VM516.Dock = DockStyle.Top;
            panelAcento2_VM516.Location = new Point(0, 0);
            panelAcento2_VM516.Name = "panelAcento2_VM516";
            panelAcento2_VM516.Size = new Size(420, 4);
            panelAcento2_VM516.TabIndex = 0;
            // 
            // lblCantidad_VM516
            // 
            lblCantidad_VM516.AutoSize = true;
            lblCantidad_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCantidad_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            lblCantidad_VM516.Location = new Point(20, 20);
            lblCantidad_VM516.Name = "lblCantidad_VM516";
            lblCantidad_VM516.Size = new Size(145, 19);
            lblCantidad_VM516.TabIndex = 1;
            lblCantidad_VM516.Tag = "lbl_Cantidad";
            lblCantidad_VM516.Text = "Cantidad a Comprar";
            // 
            // txtCantidad_VM516
            // 
            txtCantidad_VM516.BorderStyle = BorderStyle.FixedSingle;
            txtCantidad_VM516.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            txtCantidad_VM516.ForeColor = Color.FromArgb(18, 87, 150);
            txtCantidad_VM516.Location = new Point(20, 45);
            txtCantidad_VM516.Name = "txtCantidad_VM516";
            txtCantidad_VM516.Size = new Size(120, 36);
            txtCantidad_VM516.TabIndex = 2;
            txtCantidad_VM516.Text = "1";
            txtCantidad_VM516.TextAlign = HorizontalAlignment.Center;
            // 
            // btnAgregarCarrito_VM516
            // 
            btnAgregarCarrito_VM516.BackColor = Color.FromArgb(18, 87, 150);
            btnAgregarCarrito_VM516.FlatAppearance.BorderSize = 0;
            btnAgregarCarrito_VM516.FlatStyle = FlatStyle.Flat;
            btnAgregarCarrito_VM516.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAgregarCarrito_VM516.ForeColor = Color.White;
            btnAgregarCarrito_VM516.Location = new Point(155, 45);
            btnAgregarCarrito_VM516.Name = "btnAgregarCarrito_VM516";
            btnAgregarCarrito_VM516.Size = new Size(245, 36);
            btnAgregarCarrito_VM516.TabIndex = 3;
            btnAgregarCarrito_VM516.Tag = "btn_AgregarCarrito";
            btnAgregarCarrito_VM516.Text = "\U0001f6d2 Agregar al Carrito";
            btnAgregarCarrito_VM516.UseVisualStyleBackColor = false;
            btnAgregarCarrito_VM516.Click += btnAgregarCarrito_VM516_Click;
            // 
            // btnQuitarCarrito_VM516
            // 
            btnQuitarCarrito_VM516.BackColor = Color.White;
            btnQuitarCarrito_VM516.FlatAppearance.BorderColor = Color.Silver;
            btnQuitarCarrito_VM516.FlatStyle = FlatStyle.Flat;
            btnQuitarCarrito_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnQuitarCarrito_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            btnQuitarCarrito_VM516.Location = new Point(20, 110);
            btnQuitarCarrito_VM516.Name = "btnQuitarCarrito_VM516";
            btnQuitarCarrito_VM516.Size = new Size(380, 40);
            btnQuitarCarrito_VM516.TabIndex = 4;
            btnQuitarCarrito_VM516.Tag = "btn_QuitarCarrito";
            btnQuitarCarrito_VM516.Text = "Quitar Artículo Seleccionado";
            btnQuitarCarrito_VM516.UseVisualStyleBackColor = false;
            btnQuitarCarrito_VM516.Click += btnQuitarCarrito_VM516_Click;
            // 
            // panelTotalizador_VM516
            // 
            panelTotalizador_VM516.BackColor = Color.FromArgb(46, 17, 39);
            panelTotalizador_VM516.Controls.Add(panelAcento3_VM516);
            panelTotalizador_VM516.Controls.Add(lblTotalTitulo_VM516);
            panelTotalizador_VM516.Controls.Add(lblTotalMonto_VM516);
            panelTotalizador_VM516.Controls.Add(btnConfirmarPedido_VM516);
            panelTotalizador_VM516.Location = new Point(34, 480);
            panelTotalizador_VM516.Name = "panelTotalizador_VM516";
            panelTotalizador_VM516.Size = new Size(420, 220);
            panelTotalizador_VM516.TabIndex = 4;
            // 
            // panelAcento3_VM516
            // 
            panelAcento3_VM516.BackColor = Color.MediumSeaGreen;
            panelAcento3_VM516.Dock = DockStyle.Top;
            panelAcento3_VM516.Location = new Point(0, 0);
            panelAcento3_VM516.Name = "panelAcento3_VM516";
            panelAcento3_VM516.Size = new Size(420, 4);
            panelAcento3_VM516.TabIndex = 0;
            // 
            // lblTotalTitulo_VM516
            // 
            lblTotalTitulo_VM516.AutoSize = true;
            lblTotalTitulo_VM516.Font = new Font("Segoe UI", 14F);
            lblTotalTitulo_VM516.ForeColor = Color.Silver;
            lblTotalTitulo_VM516.Location = new Point(20, 20);
            lblTotalTitulo_VM516.Name = "lblTotalTitulo_VM516";
            lblTotalTitulo_VM516.Size = new Size(160, 25);
            lblTotalTitulo_VM516.TabIndex = 1;
            lblTotalTitulo_VM516.Tag = "lbl_TotalTitulo";
            lblTotalTitulo_VM516.Text = "TOTAL A ABONAR";
            // 
            // lblTotalMonto_VM516
            // 
            lblTotalMonto_VM516.AutoSize = true;
            lblTotalMonto_VM516.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            lblTotalMonto_VM516.ForeColor = Color.MediumSpringGreen;
            lblTotalMonto_VM516.Location = new Point(15, 45);
            lblTotalMonto_VM516.Name = "lblTotalMonto_VM516";
            lblTotalMonto_VM516.Size = new Size(166, 65);
            lblTotalMonto_VM516.TabIndex = 2;
            lblTotalMonto_VM516.Text = "$ 0.00";
            // 
            // btnConfirmarPedido_VM516
            // 
            btnConfirmarPedido_VM516.BackColor = Color.White;
            btnConfirmarPedido_VM516.FlatAppearance.BorderSize = 0;
            btnConfirmarPedido_VM516.FlatStyle = FlatStyle.Flat;
            btnConfirmarPedido_VM516.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnConfirmarPedido_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            btnConfirmarPedido_VM516.Location = new Point(20, 140);
            btnConfirmarPedido_VM516.Name = "btnConfirmarPedido_VM516";
            btnConfirmarPedido_VM516.Size = new Size(380, 50);
            btnConfirmarPedido_VM516.TabIndex = 3;
            btnConfirmarPedido_VM516.Tag = "btn_ConfirmarPedido";
            btnConfirmarPedido_VM516.Text = "Confirmar y Pasar a Caja";
            btnConfirmarPedido_VM516.UseVisualStyleBackColor = false;
            btnConfirmarPedido_VM516.Click += btnConfirmarPedido_VM516_Click;
            // 
            // lblProductosTitulo_VM516
            // 
            lblProductosTitulo_VM516.AutoSize = true;
            lblProductosTitulo_VM516.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblProductosTitulo_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            lblProductosTitulo_VM516.Location = new Point(480, 80);
            lblProductosTitulo_VM516.Name = "lblProductosTitulo_VM516";
            lblProductosTitulo_VM516.Size = new Size(202, 21);
            lblProductosTitulo_VM516.TabIndex = 5;
            lblProductosTitulo_VM516.Tag = "lbl_CatalogoProductos";
            lblProductosTitulo_VM516.Text = "☕ Catálogo de Cafetería";
            // 
            // dgvProductos_VM516
            // 
            dgvProductos_VM516.AllowUserToAddRows = false;
            dgvProductos_VM516.AllowUserToDeleteRows = false;
            dgvProductos_VM516.AllowUserToResizeRows = false;
            dgvProductos_VM516.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos_VM516.BackgroundColor = Color.White;
            dgvProductos_VM516.BorderStyle = BorderStyle.None;
            dgvProductos_VM516.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProductos_VM516.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 17, 39);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(46, 17, 39);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvProductos_VM516.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos_VM516.ColumnHeadersHeight = 45;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(235, 240, 245);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(18, 87, 150);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProductos_VM516.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos_VM516.EnableHeadersVisualStyles = false;
            dgvProductos_VM516.GridColor = Color.FromArgb(230, 230, 230);
            dgvProductos_VM516.Location = new Point(480, 110);
            dgvProductos_VM516.MultiSelect = false;
            dgvProductos_VM516.Name = "dgvProductos_VM516";
            dgvProductos_VM516.ReadOnly = true;
            dgvProductos_VM516.RowHeadersVisible = false;
            dgvProductos_VM516.RowTemplate.Height = 35;
            dgvProductos_VM516.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos_VM516.Size = new Size(940, 270);
            dgvProductos_VM516.TabIndex = 6;
            dgvProductos_VM516.CellFormatting += dgvProductos_VM516_CellFormatting;
            dgvProductos_VM516.SelectionChanged += dgvProductos_VM516_SelectionChanged;
            // 
            // lblCarritoTitulo_VM516
            // 
            lblCarritoTitulo_VM516.AutoSize = true;
            lblCarritoTitulo_VM516.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCarritoTitulo_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            lblCarritoTitulo_VM516.Location = new Point(480, 400);
            lblCarritoTitulo_VM516.Name = "lblCarritoTitulo_VM516";
            lblCarritoTitulo_VM516.Size = new Size(142, 21);
            lblCarritoTitulo_VM516.TabIndex = 7;
            lblCarritoTitulo_VM516.Tag = "lbl_CarritoCompras";
            lblCarritoTitulo_VM516.Text = "🛍️ Carrito Actual";
            // 
            // dgvCarrito_VM516
            // 
            dgvCarrito_VM516.AllowUserToAddRows = false;
            dgvCarrito_VM516.AllowUserToDeleteRows = false;
            dgvCarrito_VM516.AllowUserToResizeRows = false;
            dgvCarrito_VM516.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrito_VM516.BackgroundColor = Color.White;
            dgvCarrito_VM516.BorderStyle = BorderStyle.None;
            dgvCarrito_VM516.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCarrito_VM516.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(18, 87, 150);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(18, 87, 150);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgvCarrito_VM516.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCarrito_VM516.ColumnHeadersHeight = 45;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 240, 245);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(46, 17, 39);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvCarrito_VM516.DefaultCellStyle = dataGridViewCellStyle4;
            dgvCarrito_VM516.EnableHeadersVisualStyles = false;
            dgvCarrito_VM516.GridColor = Color.FromArgb(230, 230, 230);
            dgvCarrito_VM516.Location = new Point(480, 430);
            dgvCarrito_VM516.MultiSelect = false;
            dgvCarrito_VM516.Name = "dgvCarrito_VM516";
            dgvCarrito_VM516.ReadOnly = true;
            dgvCarrito_VM516.RowHeadersVisible = false;
            dgvCarrito_VM516.RowTemplate.Height = 35;
            dgvCarrito_VM516.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrito_VM516.Size = new Size(940, 270);
            dgvCarrito_VM516.TabIndex = 8;
            // 
            // panelInferior_VM516
            // 
            panelInferior_VM516.BackColor = Color.FromArgb(46, 17, 39);
            panelInferior_VM516.Controls.Add(lblUsuarioValor_VM516);
            panelInferior_VM516.Controls.Add(lblUsuarioActivo_VM516);
            panelInferior_VM516.Dock = DockStyle.Bottom;
            panelInferior_VM516.Location = new Point(0, 750);
            panelInferior_VM516.Name = "panelInferior_VM516";
            panelInferior_VM516.Size = new Size(1464, 38);
            panelInferior_VM516.TabIndex = 0;
            // 
            // lblUsuarioValor_VM516
            // 
            lblUsuarioValor_VM516.AutoSize = true;
            lblUsuarioValor_VM516.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuarioValor_VM516.ForeColor = Color.White;
            lblUsuarioValor_VM516.Location = new Point(114, 10);
            lblUsuarioValor_VM516.Name = "lblUsuarioValor_VM516";
            lblUsuarioValor_VM516.Size = new Size(57, 15);
            lblUsuarioValor_VM516.TabIndex = 0;
            lblUsuarioValor_VM516.Text = "[Usuario]";
            // 
            // lblUsuarioActivo_VM516
            // 
            lblUsuarioActivo_VM516.AutoSize = true;
            lblUsuarioActivo_VM516.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuarioActivo_VM516.ForeColor = Color.White;
            lblUsuarioActivo_VM516.Location = new Point(20, 10);
            lblUsuarioActivo_VM516.Name = "lblUsuarioActivo_VM516";
            lblUsuarioActivo_VM516.Size = new Size(92, 15);
            lblUsuarioActivo_VM516.TabIndex = 1;
            lblUsuarioActivo_VM516.Tag = "lbl_Usuario";
            lblUsuarioActivo_VM516.Text = "Usuario activo: ";
            // 
            // toolTipPedido
            // 
            toolTipPedido.AutoPopDelay = 5000;
            toolTipPedido.InitialDelay = 100;
            toolTipPedido.ReshowDelay = 100;
            // 
            // Form_Cafeteria_VM516
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 238, 242);
            ClientSize = new Size(1464, 788);
            Controls.Add(panelInferior_VM516);
            Controls.Add(panelContenedor_VM516);
            Font = new Font("Segoe UI", 9F);
            Name = "Form_Cafeteria_VM516";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vanguardia Arte - Registrar Pedido de Cafetería";
            FormClosed += Form_Cafeteria_VM516_FormClosed;
            Load += Form_Cafeteria_VM516_Load;
            panelContenedor_VM516.ResumeLayout(false);
            panelContenedor_VM516.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelCliente_VM516.ResumeLayout(false);
            panelCliente_VM516.PerformLayout();
            panelOperacion_VM516.ResumeLayout(false);
            panelOperacion_VM516.PerformLayout();
            panelTotalizador_VM516.ResumeLayout(false);
            panelTotalizador_VM516.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos_VM516).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito_VM516).EndInit();
            panelInferior_VM516.ResumeLayout(false);
            panelInferior_VM516.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor_VM516;
        private System.Windows.Forms.Panel panelCliente_VM516;
        private System.Windows.Forms.Panel panelOperacion_VM516;
        private System.Windows.Forms.Panel panelTotalizador_VM516;
        private System.Windows.Forms.Panel panelAcento1_VM516;
        private System.Windows.Forms.Panel panelAcento2_VM516;
        private System.Windows.Forms.Panel panelAcento3_VM516;
        private System.Windows.Forms.Label lblTitulo_VM516;
        private System.Windows.Forms.Button btnSalir_VM516;

        private System.Windows.Forms.Label lblCantidad_VM516;
        private System.Windows.Forms.TextBox txtCantidad_VM516;
        private System.Windows.Forms.Button btnAgregarCarrito_VM516;
        private System.Windows.Forms.Button btnQuitarCarrito_VM516;

        private System.Windows.Forms.Label lblDniCliente_VM516;
        private System.Windows.Forms.TextBox txtDniCliente_VM516;
        private System.Windows.Forms.Button btnBuscarCliente_VM516;
        private System.Windows.Forms.Label lblNombreCliente_VM516;

        private System.Windows.Forms.Label lblTotalTitulo_VM516;
        private System.Windows.Forms.Label lblTotalMonto_VM516;
        private System.Windows.Forms.Button btnConfirmarPedido_VM516;

        private System.Windows.Forms.Label lblProductosTitulo_VM516;
        private System.Windows.Forms.DataGridView dgvProductos_VM516;
        private System.Windows.Forms.Label lblCarritoTitulo_VM516;
        private System.Windows.Forms.DataGridView dgvCarrito_VM516;

        private System.Windows.Forms.Panel panelInferior_VM516;
        private System.Windows.Forms.Label lblUsuarioActivo_VM516;
        private System.Windows.Forms.Label lblUsuarioValor_VM516;
        private PictureBox picLogo;
        private ToolTip toolTipPedido;
    }
}
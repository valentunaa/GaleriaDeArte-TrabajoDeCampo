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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();

            this.panelContenedor_VM516 = new System.Windows.Forms.Panel();

            // Tarjetas (Cards)
            this.panelCliente_VM516 = new System.Windows.Forms.Panel();
            this.panelOperacion_VM516 = new System.Windows.Forms.Panel();
            this.panelTotalizador_VM516 = new System.Windows.Forms.Panel();

            // Acentos Visuales (Líneas azules)
            this.panelAcento1_VM516 = new System.Windows.Forms.Panel();
            this.panelAcento2_VM516 = new System.Windows.Forms.Panel();
            this.panelAcento3_VM516 = new System.Windows.Forms.Panel();

            this.picLogo_VM516 = new System.Windows.Forms.PictureBox();
            this.lblTitulo_VM516 = new System.Windows.Forms.Label();
            this.btnSalir_VM516 = new System.Windows.Forms.Button();

            // Controles Cliente
            this.lblDniCliente_VM516 = new System.Windows.Forms.Label();
            this.txtDniCliente_VM516 = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente_VM516 = new System.Windows.Forms.Button();
            this.lblNombreCliente_VM516 = new System.Windows.Forms.Label();

            // Controles Operación
            this.lblCantidad_VM516 = new System.Windows.Forms.Label();
            this.txtCantidad_VM516 = new System.Windows.Forms.TextBox();
            this.btnAgregarCarrito_VM516 = new System.Windows.Forms.Button();
            this.btnQuitarCarrito_VM516 = new System.Windows.Forms.Button();

            // Controles Totalizador
            this.lblTotalTitulo_VM516 = new System.Windows.Forms.Label();
            this.lblTotalMonto_VM516 = new System.Windows.Forms.Label();
            this.btnConfirmarPedido_VM516 = new System.Windows.Forms.Button();

            // Grillas
            this.lblProductosTitulo_VM516 = new System.Windows.Forms.Label();
            this.dgvProductos_VM516 = new System.Windows.Forms.DataGridView();
            this.lblCarritoTitulo_VM516 = new System.Windows.Forms.Label();
            this.dgvCarrito_VM516 = new System.Windows.Forms.DataGridView();

            // Barra Inferior
            this.panelInferior_VM516 = new System.Windows.Forms.Panel();
            this.lblUsuarioValor_VM516 = new System.Windows.Forms.Label();
            this.lblUsuarioActivo_VM516 = new System.Windows.Forms.Label();

            this.panelContenedor_VM516.SuspendLayout();
            this.panelCliente_VM516.SuspendLayout();
            this.panelOperacion_VM516.SuspendLayout();
            this.panelTotalizador_VM516.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo_VM516)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos_VM516)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito_VM516)).BeginInit();
            this.panelInferior_VM516.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelContenedor_VM516
            // 
            this.panelContenedor_VM516.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelContenedor_VM516.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.panelContenedor_VM516.Controls.Add(this.picLogo_VM516);
            this.panelContenedor_VM516.Controls.Add(this.lblTitulo_VM516);
            this.panelContenedor_VM516.Controls.Add(this.btnSalir_VM516);
            this.panelContenedor_VM516.Controls.Add(this.panelCliente_VM516);
            this.panelContenedor_VM516.Controls.Add(this.panelOperacion_VM516);
            this.panelContenedor_VM516.Controls.Add(this.panelTotalizador_VM516);
            this.panelContenedor_VM516.Controls.Add(this.lblProductosTitulo_VM516);
            this.panelContenedor_VM516.Controls.Add(this.dgvProductos_VM516);
            this.panelContenedor_VM516.Controls.Add(this.lblCarritoTitulo_VM516);
            this.panelContenedor_VM516.Controls.Add(this.dgvCarrito_VM516);
            this.panelContenedor_VM516.Location = new System.Drawing.Point(12, 12);
            this.panelContenedor_VM516.Name = "panelContenedor_VM516";
            this.panelContenedor_VM516.Size = new System.Drawing.Size(1557, 735);
            this.panelContenedor_VM516.TabIndex = 1;

            // -----------------------------------------------------------
            // TARJETA 1: BÚSQUEDA DE CLIENTE
            // -----------------------------------------------------------
            this.panelCliente_VM516.BackColor = System.Drawing.Color.White;
            this.panelCliente_VM516.Controls.Add(this.panelAcento1_VM516);
            this.panelCliente_VM516.Controls.Add(this.lblDniCliente_VM516);
            this.panelCliente_VM516.Controls.Add(this.txtDniCliente_VM516);
            this.panelCliente_VM516.Controls.Add(this.btnBuscarCliente_VM516);
            this.panelCliente_VM516.Controls.Add(this.lblNombreCliente_VM516);
            this.panelCliente_VM516.Location = new System.Drawing.Point(34, 110);
            this.panelCliente_VM516.Name = "panelCliente_VM516";
            this.panelCliente_VM516.Size = new System.Drawing.Size(420, 150);
            this.panelCliente_VM516.TabIndex = 2;

            this.panelAcento1_VM516.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.panelAcento1_VM516.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAcento1_VM516.Height = 4;

            this.lblDniCliente_VM516.AutoSize = true;
            this.lblDniCliente_VM516.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDniCliente_VM516.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(17)))), ((int)(((byte)(39)))));
            this.lblDniCliente_VM516.Location = new System.Drawing.Point(20, 20);
            this.lblDniCliente_VM516.Text = "Identificación del Cliente";

            this.txtDniCliente_VM516.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDniCliente_VM516.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtDniCliente_VM516.Location = new System.Drawing.Point(20, 45);
            this.txtDniCliente_VM516.Size = new System.Drawing.Size(200, 27);

            this.btnBuscarCliente_VM516.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(17)))), ((int)(((byte)(39)))));
            this.btnBuscarCliente_VM516.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente_VM516.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente_VM516.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscarCliente_VM516.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliente_VM516.Location = new System.Drawing.Point(235, 45);
            this.btnBuscarCliente_VM516.Size = new System.Drawing.Size(165, 27);
            this.btnBuscarCliente_VM516.Text = "Buscar";

            this.lblNombreCliente_VM516.AutoSize = true;
            this.lblNombreCliente_VM516.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular);
            this.lblNombreCliente_VM516.ForeColor = System.Drawing.Color.DimGray;
            this.lblNombreCliente_VM516.Location = new System.Drawing.Point(20, 95);
            this.lblNombreCliente_VM516.Text = "👤 Seleccione un cliente...";

            // -----------------------------------------------------------
            // TARJETA 2: OPERACIÓN (AGREGAR AL CARRITO)
            // -----------------------------------------------------------
            this.panelOperacion_VM516.BackColor = System.Drawing.Color.White;
            this.panelOperacion_VM516.Controls.Add(this.panelAcento2_VM516);
            this.panelOperacion_VM516.Controls.Add(this.lblCantidad_VM516);
            this.panelOperacion_VM516.Controls.Add(this.txtCantidad_VM516);
            this.panelOperacion_VM516.Controls.Add(this.btnAgregarCarrito_VM516);
            this.panelOperacion_VM516.Controls.Add(this.btnQuitarCarrito_VM516);
            this.panelOperacion_VM516.Location = new System.Drawing.Point(34, 280);
            this.panelOperacion_VM516.Name = "panelOperacion_VM516";
            this.panelOperacion_VM516.Size = new System.Drawing.Size(420, 180);
            this.panelOperacion_VM516.TabIndex = 3;

            this.panelAcento2_VM516.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.panelAcento2_VM516.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAcento2_VM516.Height = 4;

            this.lblCantidad_VM516.AutoSize = true;
            this.lblCantidad_VM516.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCantidad_VM516.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(17)))), ((int)(((byte)(39)))));
            this.lblCantidad_VM516.Location = new System.Drawing.Point(20, 20);
            this.lblCantidad_VM516.Text = "Cantidad a Comprar";

            this.txtCantidad_VM516.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad_VM516.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.txtCantidad_VM516.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.txtCantidad_VM516.Location = new System.Drawing.Point(20, 45);
            this.txtCantidad_VM516.Size = new System.Drawing.Size(120, 36);
            this.txtCantidad_VM516.Text = "1";
            this.txtCantidad_VM516.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            this.btnAgregarCarrito_VM516.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.btnAgregarCarrito_VM516.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCarrito_VM516.FlatAppearance.BorderSize = 0;
            this.btnAgregarCarrito_VM516.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAgregarCarrito_VM516.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCarrito_VM516.Location = new System.Drawing.Point(155, 45);
            this.btnAgregarCarrito_VM516.Size = new System.Drawing.Size(245, 36);
            this.btnAgregarCarrito_VM516.Text = "🛒 Agregar al Carrito";

            this.btnQuitarCarrito_VM516.BackColor = System.Drawing.Color.White;
            this.btnQuitarCarrito_VM516.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarCarrito_VM516.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnQuitarCarrito_VM516.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQuitarCarrito_VM516.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(17)))), ((int)(((byte)(39)))));
            this.btnQuitarCarrito_VM516.Location = new System.Drawing.Point(20, 110);
            this.btnQuitarCarrito_VM516.Size = new System.Drawing.Size(380, 40);
            this.btnQuitarCarrito_VM516.Text = "Quitar Artículo Seleccionado";

            // -----------------------------------------------------------
            // TARJETA 3: TOTALIZADOR Y CONFIRMACIÓN (Dark Mode)
            // -----------------------------------------------------------
            this.panelTotalizador_VM516.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(17)))), ((int)(((byte)(39)))));
            this.panelTotalizador_VM516.Controls.Add(this.panelAcento3_VM516);
            this.panelTotalizador_VM516.Controls.Add(this.lblTotalTitulo_VM516);
            this.panelTotalizador_VM516.Controls.Add(this.lblTotalMonto_VM516);
            this.panelTotalizador_VM516.Controls.Add(this.btnConfirmarPedido_VM516);
            this.panelTotalizador_VM516.Location = new System.Drawing.Point(34, 480);
            this.panelTotalizador_VM516.Name = "panelTotalizador_VM516";
            this.panelTotalizador_VM516.Size = new System.Drawing.Size(420, 220);
            this.panelTotalizador_VM516.TabIndex = 4;

            this.panelAcento3_VM516.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelAcento3_VM516.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAcento3_VM516.Height = 4;

            this.lblTotalTitulo_VM516.AutoSize = true;
            this.lblTotalTitulo_VM516.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular);
            this.lblTotalTitulo_VM516.ForeColor = System.Drawing.Color.Silver;
            this.lblTotalTitulo_VM516.Location = new System.Drawing.Point(20, 20);
            this.lblTotalTitulo_VM516.Text = "TOTAL A ABONAR";

            this.lblTotalMonto_VM516.AutoSize = true;
            this.lblTotalMonto_VM516.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.lblTotalMonto_VM516.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.lblTotalMonto_VM516.Location = new System.Drawing.Point(15, 45);
            this.lblTotalMonto_VM516.Text = "$ 0.00";

            this.btnConfirmarPedido_VM516.BackColor = System.Drawing.Color.White;
            this.btnConfirmarPedido_VM516.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarPedido_VM516.FlatAppearance.BorderSize = 0;
            this.btnConfirmarPedido_VM516.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirmarPedido_VM516.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(17)))), ((int)(((byte)(39)))));
            this.btnConfirmarPedido_VM516.Location = new System.Drawing.Point(20, 140);
            this.btnConfirmarPedido_VM516.Size = new System.Drawing.Size(380, 50);
            this.btnConfirmarPedido_VM516.Text = "Confirmar y Pasar a Caja";

            // -----------------------------------------------------------
            // CABECERA GENERAL
            // -----------------------------------------------------------
            this.picLogo_VM516.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.picLogo_VM516.Location = new System.Drawing.Point(34, 20);
            this.picLogo_VM516.Size = new System.Drawing.Size(63, 60);
            this.picLogo_VM516.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            this.lblTitulo_VM516.AutoSize = true;
            this.lblTitulo_VM516.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitulo_VM516.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(17)))), ((int)(((byte)(39)))));
            this.lblTitulo_VM516.Location = new System.Drawing.Point(102, 30);
            this.lblTitulo_VM516.Text = "Registrar Pedido";

            this.btnSalir_VM516.BackColor = System.Drawing.Color.White;
            this.btnSalir_VM516.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir_VM516.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSalir_VM516.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalir_VM516.ForeColor = System.Drawing.Color.DimGray;
            this.btnSalir_VM516.Location = new System.Drawing.Point(1383, 30);
            this.btnSalir_VM516.Size = new System.Drawing.Size(140, 40);
            this.btnSalir_VM516.Text = "Volver";

            // -----------------------------------------------------------
            // GRILLA: CATÁLOGO DE PRODUCTOS
            // -----------------------------------------------------------
            this.lblProductosTitulo_VM516.AutoSize = true;
            this.lblProductosTitulo_VM516.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblProductosTitulo_VM516.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(17)))), ((int)(((byte)(39)))));
            this.lblProductosTitulo_VM516.Location = new System.Drawing.Point(480, 80);
            this.lblProductosTitulo_VM516.Text = "☕ Catálogo de Cafetería";

            this.dgvProductos_VM516.AllowUserToAddRows = false;
            this.dgvProductos_VM516.AllowUserToDeleteRows = false;
            this.dgvProductos_VM516.AllowUserToResizeRows = false;
            this.dgvProductos_VM516.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos_VM516.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductos_VM516.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos_VM516.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductos_VM516.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(17)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(17)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProductos_VM516.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos_VM516.ColumnHeadersHeight = 45;
            this.dgvProductos_VM516.EnableHeadersVisualStyles = false;
            this.dgvProductos_VM516.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));

            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.dgvProductos_VM516.DefaultCellStyle = dataGridViewCellStyle2;

            this.dgvProductos_VM516.Location = new System.Drawing.Point(480, 110);
            this.dgvProductos_VM516.MultiSelect = false;
            this.dgvProductos_VM516.ReadOnly = true;
            this.dgvProductos_VM516.RowHeadersVisible = false;
            this.dgvProductos_VM516.RowTemplate.Height = 35;
            this.dgvProductos_VM516.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos_VM516.Size = new System.Drawing.Size(1043, 270);

            // -----------------------------------------------------------
            // GRILLA: CARRITO DE COMPRAS
            // -----------------------------------------------------------
            this.lblCarritoTitulo_VM516.AutoSize = true;
            this.lblCarritoTitulo_VM516.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblCarritoTitulo_VM516.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(17)))), ((int)(((byte)(39)))));
            this.lblCarritoTitulo_VM516.Location = new System.Drawing.Point(480, 400);
            this.lblCarritoTitulo_VM516.Text = "🛍️ Carrito Actual";

            this.dgvCarrito_VM516.AllowUserToAddRows = false;
            this.dgvCarrito_VM516.AllowUserToDeleteRows = false;
            this.dgvCarrito_VM516.AllowUserToResizeRows = false;
            this.dgvCarrito_VM516.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCarrito_VM516.BackgroundColor = System.Drawing.Color.White;
            this.dgvCarrito_VM516.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCarrito_VM516.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCarrito_VM516.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCarrito_VM516.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCarrito_VM516.ColumnHeadersHeight = 45;
            this.dgvCarrito_VM516.EnableHeadersVisualStyles = false;
            this.dgvCarrito_VM516.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));

            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(17)))), ((int)(((byte)(39)))));
            this.dgvCarrito_VM516.DefaultCellStyle = dataGridViewCellStyle4;

            this.dgvCarrito_VM516.Location = new System.Drawing.Point(480, 430);
            this.dgvCarrito_VM516.MultiSelect = false;
            this.dgvCarrito_VM516.ReadOnly = true;
            this.dgvCarrito_VM516.RowHeadersVisible = false;
            this.dgvCarrito_VM516.RowTemplate.Height = 35;
            this.dgvCarrito_VM516.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCarrito_VM516.Size = new System.Drawing.Size(1043, 270);

            // -----------------------------------------------------------
            // BARRA INFERIOR DE USUARIO
            // -----------------------------------------------------------
            this.panelInferior_VM516.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(17)))), ((int)(((byte)(39)))));
            this.panelInferior_VM516.Controls.Add(this.lblUsuarioValor_VM516);
            this.panelInferior_VM516.Controls.Add(this.lblUsuarioActivo_VM516);
            this.panelInferior_VM516.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior_VM516.Location = new System.Drawing.Point(0, 750);
            this.panelInferior_VM516.Size = new System.Drawing.Size(1581, 38);

            this.lblUsuarioValor_VM516.AutoSize = true;
            this.lblUsuarioValor_VM516.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuarioValor_VM516.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioValor_VM516.Location = new System.Drawing.Point(114, 10);
            this.lblUsuarioValor_VM516.Text = "[Usuario]";

            this.lblUsuarioActivo_VM516.AutoSize = true;
            this.lblUsuarioActivo_VM516.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuarioActivo_VM516.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioActivo_VM516.Location = new System.Drawing.Point(20, 10);
            this.lblUsuarioActivo_VM516.Text = "Usuario activo: ";

            // 
            // Form_Registrar_Pedido_VM516
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1581, 788);
            this.Controls.Add(this.panelInferior_VM516);
            this.Controls.Add(this.panelContenedor_VM516);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "Form_Registrar_Pedido_VM516";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vanguardia Arte - Registrar Pedido de Cafetería";

            this.panelContenedor_VM516.ResumeLayout(false);
            this.panelContenedor_VM516.PerformLayout();
            this.panelCliente_VM516.ResumeLayout(false);
            this.panelCliente_VM516.PerformLayout();
            this.panelOperacion_VM516.ResumeLayout(false);
            this.panelOperacion_VM516.PerformLayout();
            this.panelTotalizador_VM516.ResumeLayout(false);
            this.panelTotalizador_VM516.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo_VM516)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos_VM516)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito_VM516)).EndInit();
            this.panelInferior_VM516.ResumeLayout(false);
            this.panelInferior_VM516.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor_VM516;
        private System.Windows.Forms.Panel panelCliente_VM516;
        private System.Windows.Forms.Panel panelOperacion_VM516;
        private System.Windows.Forms.Panel panelTotalizador_VM516;
        private System.Windows.Forms.Panel panelAcento1_VM516;
        private System.Windows.Forms.Panel panelAcento2_VM516;
        private System.Windows.Forms.Panel panelAcento3_VM516;

        private System.Windows.Forms.PictureBox picLogo_VM516;
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
    }
}
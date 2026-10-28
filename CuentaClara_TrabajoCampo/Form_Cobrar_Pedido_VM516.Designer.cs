namespace IU
{
    partial class Form_Cobrar_Pedido_VM516
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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelContenedor_VM516 = new Panel();
            picLogo_VM516 = new PictureBox();
            cmbMedioPago_VM516 = new ComboBox();
            lblTitulo_VM516 = new Label();
            dgvComprobantes_VM516 = new DataGridView();
            lblNumeroPedido_VM516 = new Label();
            txtNumeroPedido_VM516 = new TextBox();
            lblEstadoPedido_VM516 = new Label();
            lblMontoAbonado_VM516 = new Label();
            txtMontoAbonado_VM516 = new TextBox();
            lblMedioPago_VM516 = new Label();
            btnRegistrarCobro_VM516 = new Button();
            btnSalir_VM516 = new Button();
            panelInferior_VM516 = new Panel();
            lblUsuarioValor_VM516 = new Label();
            lblUsuarioActivo_VM516 = new Label();
            toolTipCobro = new ToolTip(components);
            panelContenedor_VM516.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo_VM516).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvComprobantes_VM516).BeginInit();
            panelInferior_VM516.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor_VM516
            // 
            panelContenedor_VM516.Anchor = AnchorStyles.None;
            panelContenedor_VM516.BackColor = Color.White;
            panelContenedor_VM516.Controls.Add(picLogo_VM516);
            panelContenedor_VM516.Controls.Add(cmbMedioPago_VM516);
            panelContenedor_VM516.Controls.Add(lblTitulo_VM516);
            panelContenedor_VM516.Controls.Add(dgvComprobantes_VM516);
            panelContenedor_VM516.Controls.Add(lblNumeroPedido_VM516);
            panelContenedor_VM516.Controls.Add(txtNumeroPedido_VM516);
            panelContenedor_VM516.Controls.Add(lblEstadoPedido_VM516);
            panelContenedor_VM516.Controls.Add(lblMontoAbonado_VM516);
            panelContenedor_VM516.Controls.Add(txtMontoAbonado_VM516);
            panelContenedor_VM516.Controls.Add(lblMedioPago_VM516);
            panelContenedor_VM516.Controls.Add(btnRegistrarCobro_VM516);
            panelContenedor_VM516.Controls.Add(btnSalir_VM516);
            panelContenedor_VM516.Location = new Point(12, 12);
            panelContenedor_VM516.Name = "panelContenedor_VM516";
            panelContenedor_VM516.Size = new Size(1281, 745);
            panelContenedor_VM516.TabIndex = 1;
            // 
            // picLogo_VM516
            // 
            picLogo_VM516.BorderStyle = BorderStyle.FixedSingle;
            picLogo_VM516.Image = Properties.Resources.ImagenLogo;
            picLogo_VM516.Location = new Point(34, 10);
            picLogo_VM516.Margin = new Padding(0);
            picLogo_VM516.Name = "picLogo_VM516";
            picLogo_VM516.Size = new Size(63, 60);
            picLogo_VM516.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo_VM516.TabIndex = 26;
            picLogo_VM516.TabStop = false;
            // 
            // cmbMedioPago_VM516
            // 
            cmbMedioPago_VM516.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMedioPago_VM516.Font = new Font("Segoe UI", 10F);
            cmbMedioPago_VM516.FormattingEnabled = true;
            cmbMedioPago_VM516.Items.AddRange(new object[] { "Tarjeta de Débito", "Tarjeta de Crédito" });
            cmbMedioPago_VM516.Location = new Point(34, 329);
            cmbMedioPago_VM516.Name = "cmbMedioPago_VM516";
            cmbMedioPago_VM516.Size = new Size(380, 25);
            cmbMedioPago_VM516.TabIndex = 24;
            // 
            // lblTitulo_VM516
            // 
            lblTitulo_VM516.AutoSize = true;
            lblTitulo_VM516.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            lblTitulo_VM516.Location = new Point(102, 20);
            lblTitulo_VM516.Name = "lblTitulo_VM516";
            lblTitulo_VM516.Size = new Size(331, 32);
            lblTitulo_VM516.TabIndex = 0;
            lblTitulo_VM516.Tag = "titulo_FormCobroCafeteria";
            lblTitulo_VM516.Text = "Cobro de Pedido - Cafetería";
            // 
            // dgvComprobantes_VM516
            // 
            dgvComprobantes_VM516.AllowUserToAddRows = false;
            dgvComprobantes_VM516.AllowUserToDeleteRows = false;
            dgvComprobantes_VM516.AllowUserToResizeRows = false;
            dgvComprobantes_VM516.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvComprobantes_VM516.BackgroundColor = Color.FromArgb(46, 17, 39);
            dgvComprobantes_VM516.BorderStyle = BorderStyle.None;
            dgvComprobantes_VM516.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvComprobantes_VM516.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(18, 87, 150);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvComprobantes_VM516.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvComprobantes_VM516.ColumnHeadersHeight = 58;
            dgvComprobantes_VM516.EnableHeadersVisualStyles = false;
            dgvComprobantes_VM516.GridColor = Color.FromArgb(220, 220, 220);
            dgvComprobantes_VM516.Location = new Point(480, 129);
            dgvComprobantes_VM516.MultiSelect = false;
            dgvComprobantes_VM516.Name = "dgvComprobantes_VM516";
            dgvComprobantes_VM516.ReadOnly = true;
            dgvComprobantes_VM516.RowHeadersVisible = false;
            dgvComprobantes_VM516.RowHeadersWidth = 102;
            dgvComprobantes_VM516.RowTemplate.Height = 28;
            dgvComprobantes_VM516.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvComprobantes_VM516.Size = new Size(775, 421);
            dgvComprobantes_VM516.TabIndex = 21;
            // 
            // lblNumeroPedido_VM516
            // 
            lblNumeroPedido_VM516.AutoSize = true;
            lblNumeroPedido_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNumeroPedido_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            lblNumeroPedido_VM516.Location = new Point(34, 129);
            lblNumeroPedido_VM516.Name = "lblNumeroPedido_VM516";
            lblNumeroPedido_VM516.Size = new Size(137, 19);
            lblNumeroPedido_VM516.TabIndex = 2;
            lblNumeroPedido_VM516.Tag = "lbl_NumeroPedidoCobro";
            lblNumeroPedido_VM516.Text = "Número de Pedido";
            // 
            // txtNumeroPedido_VM516
            // 
            txtNumeroPedido_VM516.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroPedido_VM516.Font = new Font("Segoe UI", 10F);
            txtNumeroPedido_VM516.Location = new Point(34, 154);
            txtNumeroPedido_VM516.Name = "txtNumeroPedido_VM516";
            txtNumeroPedido_VM516.ReadOnly = true;
            txtNumeroPedido_VM516.Size = new Size(180, 25);
            txtNumeroPedido_VM516.TabIndex = 3;
            // 
            // lblEstadoPedido_VM516
            // 
            lblEstadoPedido_VM516.AutoSize = true;
            lblEstadoPedido_VM516.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblEstadoPedido_VM516.ForeColor = Color.FromArgb(15, 45, 75);
            lblEstadoPedido_VM516.Location = new Point(34, 194);
            lblEstadoPedido_VM516.Name = "lblEstadoPedido_VM516";
            lblEstadoPedido_VM516.Size = new Size(243, 17);
            lblEstadoPedido_VM516.TabIndex = 5;
            lblEstadoPedido_VM516.Tag = "lbl_EstadoPedidoPendiente";
            lblEstadoPedido_VM516.Text = "Estado del pedido: Pendiente de Pago";
            // 
            // lblMontoAbonado_VM516
            // 
            lblMontoAbonado_VM516.AutoSize = true;
            lblMontoAbonado_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMontoAbonado_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            lblMontoAbonado_VM516.Location = new Point(34, 228);
            lblMontoAbonado_VM516.Name = "lblMontoAbonado_VM516";
            lblMontoAbonado_VM516.Size = new Size(116, 19);
            lblMontoAbonado_VM516.TabIndex = 6;
            lblMontoAbonado_VM516.Tag = "lbl_MontoAbonado";
            lblMontoAbonado_VM516.Text = "Monto a Cobrar";
            // 
            // txtMontoAbonado_VM516
            // 
            txtMontoAbonado_VM516.BorderStyle = BorderStyle.FixedSingle;
            txtMontoAbonado_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            txtMontoAbonado_VM516.Location = new Point(34, 253);
            txtMontoAbonado_VM516.Name = "txtMontoAbonado_VM516";
            txtMontoAbonado_VM516.ReadOnly = true;
            txtMontoAbonado_VM516.Size = new Size(180, 25);
            txtMontoAbonado_VM516.TabIndex = 7;
            // 
            // lblMedioPago_VM516
            // 
            lblMedioPago_VM516.AutoSize = true;
            lblMedioPago_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMedioPago_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            lblMedioPago_VM516.Location = new Point(34, 298);
            lblMedioPago_VM516.Name = "lblMedioPago_VM516";
            lblMedioPago_VM516.Size = new Size(112, 19);
            lblMedioPago_VM516.TabIndex = 8;
            lblMedioPago_VM516.Tag = "lbl_MedioPago";
            lblMedioPago_VM516.Text = "Medio de Pago";
            // 
            // btnRegistrarCobro_VM516
            // 
            btnRegistrarCobro_VM516.BackColor = Color.FromArgb(18, 120, 50);
            btnRegistrarCobro_VM516.FlatAppearance.BorderSize = 0;
            btnRegistrarCobro_VM516.FlatStyle = FlatStyle.Flat;
            btnRegistrarCobro_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegistrarCobro_VM516.ForeColor = Color.White;
            btnRegistrarCobro_VM516.Location = new Point(34, 383);
            btnRegistrarCobro_VM516.Name = "btnRegistrarCobro_VM516";
            btnRegistrarCobro_VM516.Size = new Size(380, 40);
            btnRegistrarCobro_VM516.TabIndex = 24;
            btnRegistrarCobro_VM516.Tag = "btn_RegistrarCobro";
            btnRegistrarCobro_VM516.Text = "Iniciar Cobro y Emitir Comprobante";
            btnRegistrarCobro_VM516.UseVisualStyleBackColor = false;
            btnRegistrarCobro_VM516.Click += btnRegistrarCobro_VM516_Click;
            // 
            // btnSalir_VM516
            // 
            btnSalir_VM516.BackColor = Color.White;
            btnSalir_VM516.FlatStyle = FlatStyle.Flat;
            btnSalir_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalir_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            btnSalir_VM516.Location = new Point(31, 441);
            btnSalir_VM516.Name = "btnSalir_VM516";
            btnSalir_VM516.Size = new Size(383, 38);
            btnSalir_VM516.TabIndex = 23;
            btnSalir_VM516.Tag = "btn_Salir";
            btnSalir_VM516.Text = "Cancelar";
            btnSalir_VM516.UseVisualStyleBackColor = false;
            btnSalir_VM516.Click += btnSalir_VM516_Click;
            // 
            // panelInferior_VM516
            // 
            panelInferior_VM516.BackColor = Color.FromArgb(46, 17, 39);
            panelInferior_VM516.Controls.Add(lblUsuarioValor_VM516);
            panelInferior_VM516.Controls.Add(lblUsuarioActivo_VM516);
            panelInferior_VM516.Dock = DockStyle.Bottom;
            panelInferior_VM516.Location = new Point(0, 750);
            panelInferior_VM516.Name = "panelInferior_VM516";
            panelInferior_VM516.Size = new Size(1313, 38);
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
            lblUsuarioValor_VM516.TabIndex = 1;
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
            lblUsuarioActivo_VM516.TabIndex = 0;
            lblUsuarioActivo_VM516.Tag = "lbl_Usuario";
            lblUsuarioActivo_VM516.Text = "Usuario activo: ";
            // 
            // Form_Cobrar_Pedido_VM516
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(1313, 788);
            Controls.Add(panelInferior_VM516);
            Controls.Add(panelContenedor_VM516);
            Font = new Font("Segoe UI", 9F);
            Name = "Form_Cobrar_Pedido_VM516";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vanguardia Arte - Cobro de Pedido de Cafetería";
            FormClosed += Form_Cobrar_Pedido_VM516_FormClosed;
            Load += Form_Cobrar_Pedido_VM516_Load;
            panelContenedor_VM516.ResumeLayout(false);
            panelContenedor_VM516.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo_VM516).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvComprobantes_VM516).EndInit();
            panelInferior_VM516.ResumeLayout(false);
            panelInferior_VM516.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor_VM516;
        private System.Windows.Forms.Label lblTitulo_VM516;
        private System.Windows.Forms.DataGridView dgvComprobantes_VM516;
        private System.Windows.Forms.Label lblNumeroPedido_VM516;
        private System.Windows.Forms.TextBox txtNumeroPedido_VM516;
        private System.Windows.Forms.Label lblEstadoPedido_VM516;
        private System.Windows.Forms.Label lblMontoAbonado_VM516;
        private System.Windows.Forms.TextBox txtMontoAbonado_VM516;
        private System.Windows.Forms.Label lblMedioPago_VM516;
        private System.Windows.Forms.ComboBox cmbMedioPago_VM516;
        private System.Windows.Forms.Button btnRegistrarCobro_VM516;
        private System.Windows.Forms.Button btnSalir_VM516;
        private System.Windows.Forms.Panel panelInferior_VM516;
        private System.Windows.Forms.Label lblUsuarioActivo_VM516;
        private System.Windows.Forms.Label lblUsuarioValor_VM516;
        private System.Windows.Forms.PictureBox picLogo_VM516;
        private ToolTip toolTipCobro;
    }
}
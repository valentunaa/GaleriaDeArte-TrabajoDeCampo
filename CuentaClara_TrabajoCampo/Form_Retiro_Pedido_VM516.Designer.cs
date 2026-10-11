namespace IU
{
    partial class Form_Retiro_Pedido_VM516
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelContenedor_VM516 = new Panel();
            picLogo_VM516 = new PictureBox();
            lblTitulo_VM516 = new Label();
            lblNumeroPedido_VM516 = new Label();
            txtNumeroPedido_VM516 = new TextBox();
            btnBuscarPedido_VM516 = new Button();
            lblEstadoPedido_VM516 = new Label();
            btnRegistrarEntrega_VM516 = new Button();
            btnSalir_VM516 = new Button();
            lblPedidosPendientes_VM516 = new Label();
            dgvPedidosPendientes_VM516 = new DataGridView();
            lblDetallePedido_VM516 = new Label();
            dgvDetallePedido_VM516 = new DataGridView();
            panelInferior_VM516 = new Panel();
            lblUsuarioValor_VM516 = new Label();
            lblUsuarioActivo_VM516 = new Label();
            panelContenedor_VM516.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo_VM516).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedidosPendientes_VM516).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetallePedido_VM516).BeginInit();
            panelInferior_VM516.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor_VM516
            // 
            panelContenedor_VM516.Anchor = AnchorStyles.None;
            panelContenedor_VM516.BackColor = Color.White;
            panelContenedor_VM516.Controls.Add(picLogo_VM516);
            panelContenedor_VM516.Controls.Add(lblTitulo_VM516);
            panelContenedor_VM516.Controls.Add(lblNumeroPedido_VM516);
            panelContenedor_VM516.Controls.Add(txtNumeroPedido_VM516);
            panelContenedor_VM516.Controls.Add(btnBuscarPedido_VM516);
            panelContenedor_VM516.Controls.Add(lblEstadoPedido_VM516);
            panelContenedor_VM516.Controls.Add(btnRegistrarEntrega_VM516);
            panelContenedor_VM516.Controls.Add(btnSalir_VM516);
            panelContenedor_VM516.Controls.Add(lblPedidosPendientes_VM516);
            panelContenedor_VM516.Controls.Add(dgvPedidosPendientes_VM516);
            panelContenedor_VM516.Controls.Add(lblDetallePedido_VM516);
            panelContenedor_VM516.Controls.Add(dgvDetallePedido_VM516);
            panelContenedor_VM516.Location = new Point(20, 12);
            panelContenedor_VM516.Name = "panelContenedor_VM516";
            panelContenedor_VM516.Size = new Size(1493, 745);
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
            // lblTitulo_VM516
            // 
            lblTitulo_VM516.AutoSize = true;
            lblTitulo_VM516.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            lblTitulo_VM516.Location = new Point(102, 20);
            lblTitulo_VM516.Name = "lblTitulo_VM516";
            lblTitulo_VM516.Size = new Size(341, 32);
            lblTitulo_VM516.TabIndex = 0;
            lblTitulo_VM516.Tag = "titulo_FormRetiroPedido";
            lblTitulo_VM516.Text = "Retiro de Pedidos - Cafetería";
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
            txtNumeroPedido_VM516.Size = new Size(180, 25);
            txtNumeroPedido_VM516.TabIndex = 3;
            // 
            // btnBuscarPedido_VM516
            // 
            btnBuscarPedido_VM516.BackColor = Color.FromArgb(46, 17, 39);
            btnBuscarPedido_VM516.FlatAppearance.BorderSize = 0;
            btnBuscarPedido_VM516.FlatStyle = FlatStyle.Flat;
            btnBuscarPedido_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBuscarPedido_VM516.ForeColor = Color.White;
            btnBuscarPedido_VM516.Location = new Point(230, 152);
            btnBuscarPedido_VM516.Name = "btnBuscarPedido_VM516";
            btnBuscarPedido_VM516.Size = new Size(140, 28);
            btnBuscarPedido_VM516.TabIndex = 4;
            btnBuscarPedido_VM516.Tag = "btn_BuscarPedidoRetiro";
            btnBuscarPedido_VM516.Text = "Buscar Pedido";
            btnBuscarPedido_VM516.UseVisualStyleBackColor = false;
            btnBuscarPedido_VM516.Click += btnBuscarPedido_VM516_Click;
            // 
            // lblEstadoPedido_VM516
            // 
            lblEstadoPedido_VM516.AutoSize = true;
            lblEstadoPedido_VM516.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblEstadoPedido_VM516.ForeColor = Color.FromArgb(15, 45, 75);
            lblEstadoPedido_VM516.Location = new Point(34, 194);
            lblEstadoPedido_VM516.Name = "lblEstadoPedido_VM516";
            lblEstadoPedido_VM516.Size = new Size(186, 17);
            lblEstadoPedido_VM516.TabIndex = 5;
            lblEstadoPedido_VM516.Tag = "lbl_EstadoPedidoEsperaRetiro";
            lblEstadoPedido_VM516.Text = "Estado del pedido: En espera";
            // 
            // btnRegistrarEntrega_VM516
            // 
            btnRegistrarEntrega_VM516.BackColor = Color.FromArgb(18, 120, 50);
            btnRegistrarEntrega_VM516.FlatAppearance.BorderSize = 0;
            btnRegistrarEntrega_VM516.FlatStyle = FlatStyle.Flat;
            btnRegistrarEntrega_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegistrarEntrega_VM516.ForeColor = Color.White;
            btnRegistrarEntrega_VM516.Location = new Point(34, 260);
            btnRegistrarEntrega_VM516.Name = "btnRegistrarEntrega_VM516";
            btnRegistrarEntrega_VM516.Size = new Size(380, 42);
            btnRegistrarEntrega_VM516.TabIndex = 6;
            btnRegistrarEntrega_VM516.Tag = "btn_RegistrarEntrega";
            btnRegistrarEntrega_VM516.Text = "Registrar Entrega";
            btnRegistrarEntrega_VM516.UseVisualStyleBackColor = false;
            btnRegistrarEntrega_VM516.Click += btnRegistrarEntrega_VM516_Click;
            // 
            // btnSalir_VM516
            // 
            btnSalir_VM516.BackColor = Color.White;
            btnSalir_VM516.FlatStyle = FlatStyle.Flat;
            btnSalir_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalir_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            btnSalir_VM516.Location = new Point(1298, 21);
            btnSalir_VM516.Name = "btnSalir_VM516";
            btnSalir_VM516.Size = new Size(140, 38);
            btnSalir_VM516.TabIndex = 23;
            btnSalir_VM516.Tag = "btn_Salir";
            btnSalir_VM516.Text = "Salir";
            btnSalir_VM516.UseVisualStyleBackColor = false;
            btnSalir_VM516.Click += btnSalir_VM516_Click;
            // 
            // lblPedidosPendientes_VM516
            // 
            lblPedidosPendientes_VM516.AutoSize = true;
            lblPedidosPendientes_VM516.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblPedidosPendientes_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            lblPedidosPendientes_VM516.Location = new Point(480, 95);
            lblPedidosPendientes_VM516.Name = "lblPedidosPendientes_VM516";
            lblPedidosPendientes_VM516.Size = new Size(224, 20);
            lblPedidosPendientes_VM516.TabIndex = 20;
            lblPedidosPendientes_VM516.Tag = "lbl_PedidosPendientesEntrega";
            lblPedidosPendientes_VM516.Text = "Pedidos Pendientes de Entrega";
            // 
            // dgvPedidosPendientes_VM516
            // 
            dgvPedidosPendientes_VM516.AllowUserToAddRows = false;
            dgvPedidosPendientes_VM516.AllowUserToDeleteRows = false;
            dgvPedidosPendientes_VM516.AllowUserToResizeRows = false;
            dgvPedidosPendientes_VM516.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidosPendientes_VM516.BackgroundColor = Color.FromArgb(46, 17, 39);
            dgvPedidosPendientes_VM516.BorderStyle = BorderStyle.None;
            dgvPedidosPendientes_VM516.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPedidosPendientes_VM516.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 17, 39);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPedidosPendientes_VM516.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPedidosPendientes_VM516.ColumnHeadersHeight = 45;
            dgvPedidosPendientes_VM516.EnableHeadersVisualStyles = false;
            dgvPedidosPendientes_VM516.GridColor = Color.FromArgb(220, 220, 220);
            dgvPedidosPendientes_VM516.Location = new Point(480, 125);
            dgvPedidosPendientes_VM516.MultiSelect = false;
            dgvPedidosPendientes_VM516.Name = "dgvPedidosPendientes_VM516";
            dgvPedidosPendientes_VM516.ReadOnly = true;
            dgvPedidosPendientes_VM516.RowHeadersVisible = false;
            dgvPedidosPendientes_VM516.RowTemplate.Height = 28;
            dgvPedidosPendientes_VM516.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidosPendientes_VM516.Size = new Size(958, 250);
            dgvPedidosPendientes_VM516.TabIndex = 21;
            // 
            // lblDetallePedido_VM516
            // 
            lblDetallePedido_VM516.AutoSize = true;
            lblDetallePedido_VM516.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDetallePedido_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            lblDetallePedido_VM516.Location = new Point(480, 395);
            lblDetallePedido_VM516.Name = "lblDetallePedido_VM516";
            lblDetallePedido_VM516.Size = new Size(230, 20);
            lblDetallePedido_VM516.TabIndex = 22;
            lblDetallePedido_VM516.Tag = "lbl_DetalleArticulosOrden";
            lblDetallePedido_VM516.Text = "Detalle de Artículos de la Orden";
            // 
            // dgvDetallePedido_VM516
            // 
            dgvDetallePedido_VM516.AllowUserToAddRows = false;
            dgvDetallePedido_VM516.AllowUserToDeleteRows = false;
            dgvDetallePedido_VM516.AllowUserToResizeRows = false;
            dgvDetallePedido_VM516.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetallePedido_VM516.BackgroundColor = Color.FromArgb(46, 17, 39);
            dgvDetallePedido_VM516.BorderStyle = BorderStyle.None;
            dgvDetallePedido_VM516.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDetallePedido_VM516.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(18, 87, 150);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDetallePedido_VM516.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDetallePedido_VM516.ColumnHeadersHeight = 45;
            dgvDetallePedido_VM516.EnableHeadersVisualStyles = false;
            dgvDetallePedido_VM516.GridColor = Color.FromArgb(220, 220, 220);
            dgvDetallePedido_VM516.Location = new Point(480, 425);
            dgvDetallePedido_VM516.MultiSelect = false;
            dgvDetallePedido_VM516.Name = "dgvDetallePedido_VM516";
            dgvDetallePedido_VM516.ReadOnly = true;
            dgvDetallePedido_VM516.RowHeadersVisible = false;
            dgvDetallePedido_VM516.RowTemplate.Height = 28;
            dgvDetallePedido_VM516.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetallePedido_VM516.Size = new Size(958, 250);
            dgvDetallePedido_VM516.TabIndex = 25;
            // 
            // panelInferior_VM516
            // 
            panelInferior_VM516.BackColor = Color.FromArgb(46, 17, 39);
            panelInferior_VM516.Controls.Add(lblUsuarioValor_VM516);
            panelInferior_VM516.Controls.Add(lblUsuarioActivo_VM516);
            panelInferior_VM516.Dock = DockStyle.Bottom;
            panelInferior_VM516.Location = new Point(0, 750);
            panelInferior_VM516.Name = "panelInferior_VM516";
            panelInferior_VM516.Size = new Size(1535, 38);
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
            // Form_Retiro_Pedido_VM516
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(1535, 788);
            Controls.Add(panelInferior_VM516);
            Controls.Add(panelContenedor_VM516);
            Font = new Font("Segoe UI", 9F);
            Name = "Form_Retiro_Pedido_VM516";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vanguardia Arte - Retiro de Pedidos de Cafetería";
            FormClosed += Form_Retiro_Pedido_VM516_FormClosed;
            Load += Form_Retiro_Pedido_VM516_Load;
            panelContenedor_VM516.ResumeLayout(false);
            panelContenedor_VM516.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo_VM516).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedidosPendientes_VM516).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetallePedido_VM516).EndInit();
            panelInferior_VM516.ResumeLayout(false);
            panelInferior_VM516.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor_VM516;
        private System.Windows.Forms.PictureBox picLogo_VM516;
        private System.Windows.Forms.Label lblTitulo_VM516;
        private System.Windows.Forms.Label lblNumeroPedido_VM516;
        private System.Windows.Forms.TextBox txtNumeroPedido_VM516;
        private System.Windows.Forms.Button btnBuscarPedido_VM516;
        private System.Windows.Forms.Label lblEstadoPedido_VM516;
        private System.Windows.Forms.Button btnRegistrarEntrega_VM516;
        private System.Windows.Forms.Button btnSalir_VM516;
        private System.Windows.Forms.Label lblPedidosPendientes_VM516;
        private System.Windows.Forms.DataGridView dgvPedidosPendientes_VM516;
        private System.Windows.Forms.Label lblDetallePedido_VM516;
        private System.Windows.Forms.DataGridView dgvDetallePedido_VM516;
        private System.Windows.Forms.Panel panelInferior_VM516;
        private System.Windows.Forms.Label lblUsuarioActivo_VM516;
        private System.Windows.Forms.Label lblUsuarioValor_VM516;
    }
}
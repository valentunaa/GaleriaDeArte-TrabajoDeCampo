namespace IU
{
    partial class Form_Cobro_VM516
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
            picLogo = new PictureBox();
            cmbMedioPago = new ComboBox();
            lblTitulo = new Label();
            dgvComprobantes = new DataGridView();
            lblCodigoReserva = new Label();
            txtCodigoReserva = new TextBox();
            btnBuscarReserva = new Button();
            lblEstadoReserva = new Label();
            lblMontoAbonado = new Label();
            txtMontoAbonado = new TextBox();
            lblMedioPago = new Label();
            btnRegistrarCobro = new Button();
            btnSalir = new Button();
            panelInferior = new Panel();
            lblUsuarioValor = new Label();
            lblUsuarioActivo = new Label();
            toolTipCobroReserva = new ToolTip(components);
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvComprobantes).BeginInit();
            panelInferior.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.Anchor = AnchorStyles.None;
            panelContenedor.BackColor = Color.White;
            panelContenedor.Controls.Add(picLogo);
            panelContenedor.Controls.Add(cmbMedioPago);
            panelContenedor.Controls.Add(lblTitulo);
            panelContenedor.Controls.Add(dgvComprobantes);
            panelContenedor.Controls.Add(lblCodigoReserva);
            panelContenedor.Controls.Add(txtCodigoReserva);
            panelContenedor.Controls.Add(btnBuscarReserva);
            panelContenedor.Controls.Add(lblEstadoReserva);
            panelContenedor.Controls.Add(lblMontoAbonado);
            panelContenedor.Controls.Add(txtMontoAbonado);
            panelContenedor.Controls.Add(lblMedioPago);
            panelContenedor.Controls.Add(btnRegistrarCobro);
            panelContenedor.Controls.Add(btnSalir);
            panelContenedor.Location = new Point(20, 12);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1566, 745);
            panelContenedor.TabIndex = 1;
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
            // cmbMedioPago
            // 
            cmbMedioPago.FormattingEnabled = true;
            cmbMedioPago.Items.AddRange(new object[] { "Tarjeta de Débito", "Tarjeta de Crédito" });
            cmbMedioPago.Location = new Point(34, 374);
            cmbMedioPago.Name = "cmbMedioPago";
            cmbMedioPago.Size = new Size(380, 23);
            cmbMedioPago.TabIndex = 24;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(46, 17, 39);
            lblTitulo.Location = new Point(102, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(262, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Tag = "titulo_FormCobros";
            lblTitulo.Text = "Gestión de Cobranzas";
            // 
            // dgvComprobantes
            // 
            dgvComprobantes.AllowUserToAddRows = false;
            dgvComprobantes.AllowUserToDeleteRows = false;
            dgvComprobantes.AllowUserToResizeRows = false;
            dgvComprobantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvComprobantes.BackgroundColor = Color.FromArgb(46, 17, 39);
            dgvComprobantes.BorderStyle = BorderStyle.None;
            dgvComprobantes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvComprobantes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(18, 87, 150);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvComprobantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvComprobantes.ColumnHeadersHeight = 58;
            dgvComprobantes.EnableHeadersVisualStyles = false;
            dgvComprobantes.GridColor = Color.FromArgb(220, 220, 220);
            dgvComprobantes.Location = new Point(480, 129);
            dgvComprobantes.MultiSelect = false;
            dgvComprobantes.Name = "dgvComprobantes";
            dgvComprobantes.ReadOnly = true;
            dgvComprobantes.RowHeadersVisible = false;
            dgvComprobantes.RowHeadersWidth = 102;
            dgvComprobantes.RowTemplate.Height = 28;
            dgvComprobantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvComprobantes.Size = new Size(1055, 531);
            dgvComprobantes.TabIndex = 21;
            // 
            // lblCodigoReserva
            // 
            lblCodigoReserva.AutoSize = true;
            lblCodigoReserva.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCodigoReserva.ForeColor = Color.FromArgb(46, 17, 39);
            lblCodigoReserva.Location = new Point(34, 129);
            lblCodigoReserva.Name = "lblCodigoReserva";
            lblCodigoReserva.Size = new Size(116, 19);
            lblCodigoReserva.TabIndex = 2;
            lblCodigoReserva.Tag = "lbl_CodigoReserva";
            lblCodigoReserva.Text = "Código Reserva";
            // 
            // txtCodigoReserva
            // 
            txtCodigoReserva.BorderStyle = BorderStyle.FixedSingle;
            txtCodigoReserva.Font = new Font("Segoe UI", 10F);
            txtCodigoReserva.Location = new Point(34, 154);
            txtCodigoReserva.Name = "txtCodigoReserva";
            txtCodigoReserva.Size = new Size(180, 25);
            txtCodigoReserva.TabIndex = 3;
            // 
            // btnBuscarReserva
            // 
            btnBuscarReserva.BackColor = Color.FromArgb(46, 17, 39);
            btnBuscarReserva.FlatAppearance.BorderSize = 0;
            btnBuscarReserva.FlatStyle = FlatStyle.Flat;
            btnBuscarReserva.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBuscarReserva.ForeColor = Color.White;
            btnBuscarReserva.Location = new Point(230, 152);
            btnBuscarReserva.Name = "btnBuscarReserva";
            btnBuscarReserva.Size = new Size(140, 28);
            btnBuscarReserva.TabIndex = 4;
            btnBuscarReserva.Tag = "btn_BuscarReserva";
            btnBuscarReserva.Text = "Buscar Reserva";
            btnBuscarReserva.UseVisualStyleBackColor = false;
            btnBuscarReserva.Click += btnBuscarReserva_Click;
            // 
            // lblEstadoReserva
            // 
            lblEstadoReserva.AutoSize = true;
            lblEstadoReserva.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblEstadoReserva.ForeColor = Color.FromArgb(15, 45, 75);
            lblEstadoReserva.Location = new Point(34, 194);
            lblEstadoReserva.Name = "lblEstadoReserva";
            lblEstadoReserva.Size = new Size(184, 17);
            lblEstadoReserva.TabIndex = 5;
            lblEstadoReserva.Tag = "lbl_EstadoReservaPendiente";
            lblEstadoReserva.Text = "Estado de reserva: En espera";
            // 
            // lblMontoAbonado
            // 
            lblMontoAbonado.AutoSize = true;
            lblMontoAbonado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMontoAbonado.ForeColor = Color.FromArgb(46, 17, 39);
            lblMontoAbonado.Location = new Point(34, 279);
            lblMontoAbonado.Name = "lblMontoAbonado";
            lblMontoAbonado.Size = new Size(116, 19);
            lblMontoAbonado.TabIndex = 6;
            lblMontoAbonado.Tag = "lbl_MontoAbonado";
            lblMontoAbonado.Text = "Monto a Cobrar";
            // 
            // txtMontoAbonado
            // 
            txtMontoAbonado.BorderStyle = BorderStyle.FixedSingle;
            txtMontoAbonado.Font = new Font("Segoe UI", 10F);
            txtMontoAbonado.Location = new Point(34, 304);
            txtMontoAbonado.Name = "txtMontoAbonado";
            txtMontoAbonado.ReadOnly = true;
            txtMontoAbonado.Size = new Size(180, 25);
            txtMontoAbonado.TabIndex = 7;
            // 
            // lblMedioPago
            // 
            lblMedioPago.AutoSize = true;
            lblMedioPago.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMedioPago.ForeColor = Color.FromArgb(46, 17, 39);
            lblMedioPago.Location = new Point(34, 349);
            lblMedioPago.Name = "lblMedioPago";
            lblMedioPago.Size = new Size(112, 19);
            lblMedioPago.TabIndex = 8;
            lblMedioPago.Tag = "lbl_MedioPago";
            lblMedioPago.Text = "Medio de Pago";
            // 
            // btnRegistrarCobro
            // 
            btnRegistrarCobro.BackColor = Color.FromArgb(18, 120, 50);
            btnRegistrarCobro.FlatAppearance.BorderSize = 0;
            btnRegistrarCobro.FlatStyle = FlatStyle.Flat;
            btnRegistrarCobro.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegistrarCobro.ForeColor = Color.White;
            btnRegistrarCobro.Location = new Point(34, 447);
            btnRegistrarCobro.Name = "btnRegistrarCobro";
            btnRegistrarCobro.Size = new Size(380, 40);
            btnRegistrarCobro.TabIndex = 24;
            btnRegistrarCobro.Tag = "btn_RegistrarCobro";
            btnRegistrarCobro.Text = "Iniciar Cobro y Emitir Comprobante";
            btnRegistrarCobro.UseVisualStyleBackColor = false;
            btnRegistrarCobro.Click += btnRegistrarCobro_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.White;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(46, 17, 39);
            btnSalir.Location = new Point(1395, 20);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(140, 38);
            btnSalir.TabIndex = 23;
            btnSalir.Tag = "btn_Salir";
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // panelInferior
            // 
            panelInferior.BackColor = Color.FromArgb(46, 17, 39);
            panelInferior.Controls.Add(lblUsuarioValor);
            panelInferior.Controls.Add(lblUsuarioActivo);
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(0, 750);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(1598, 38);
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
            // Form_Cobro_VM516
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(1598, 788);
            Controls.Add(panelInferior);
            Controls.Add(panelContenedor);
            Font = new Font("Segoe UI", 9F);
            Name = "Form_Cobro_VM516";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vanguardia Arte - Gestión de Cobranzas";
            FormClosed += Form_Cobro_VM516_FormClosed;
            Load += Form_Cobro_VM516_Load;
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvComprobantes).EndInit();
            panelInferior.ResumeLayout(false);
            panelInferior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvComprobantes;
        private System.Windows.Forms.Label lblCodigoReserva;
        private System.Windows.Forms.TextBox txtCodigoReserva;
        private System.Windows.Forms.Button btnBuscarReserva;
        private System.Windows.Forms.Label lblEstadoReserva;
        private System.Windows.Forms.Label lblMontoAbonado;
        private System.Windows.Forms.TextBox txtMontoAbonado;
        private System.Windows.Forms.Label lblMedioPago;
        private System.Windows.Forms.ComboBox cmbMedioPago;
        private System.Windows.Forms.Button btnRegistrarCobro;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Label lblUsuarioActivo;
        private System.Windows.Forms.Label lblUsuarioValor;
        private System.Windows.Forms.PictureBox picLogo;
        private ToolTip toolTipCobroReserva;
    }
}
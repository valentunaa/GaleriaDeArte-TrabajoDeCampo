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
            panelContenedor = new Panel();
            btnConfirmarPago = new Button();
            txtMontoSena = new TextBox();
            lblMonto = new Label();
            txtCVV = new TextBox();
            lblCVV = new Label();
            txtTitular = new TextBox();
            lblTitular = new Label();
            txtNumeroTarjeta = new TextBox();
            lblNumeroTarjeta = new Label();
            cmbMedioPago = new ComboBox();
            lblMedioPago = new Label();
            btnSalir = new Button();
            lblTitulo = new Label();
            panelInferior = new Panel();
            lblUsuarioValor = new Label();
            lblUsuarioActivo = new Label();
            panelContenedor.SuspendLayout();
            panelInferior.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.Anchor = AnchorStyles.None;
            panelContenedor.BackColor = Color.White;
            panelContenedor.Controls.Add(btnConfirmarPago);
            panelContenedor.Controls.Add(txtMontoSena);
            panelContenedor.Controls.Add(lblMonto);
            panelContenedor.Controls.Add(txtCVV);
            panelContenedor.Controls.Add(lblCVV);
            panelContenedor.Controls.Add(txtTitular);
            panelContenedor.Controls.Add(lblTitular);
            panelContenedor.Controls.Add(txtNumeroTarjeta);
            panelContenedor.Controls.Add(lblNumeroTarjeta);
            panelContenedor.Controls.Add(cmbMedioPago);
            panelContenedor.Controls.Add(lblMedioPago);
            panelContenedor.Controls.Add(btnSalir);
            panelContenedor.Controls.Add(lblTitulo);
            panelContenedor.Location = new Point(12, 12);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(600, 420);
            panelContenedor.TabIndex = 1;
            // 
            // btnConfirmarPago
            // 
            btnConfirmarPago.BackColor = Color.FromArgb(18, 87, 150);
            btnConfirmarPago.FlatAppearance.BorderSize = 0;
            btnConfirmarPago.FlatStyle = FlatStyle.Flat;
            btnConfirmarPago.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConfirmarPago.ForeColor = Color.White;
            btnConfirmarPago.Location = new Point(370, 310);
            btnConfirmarPago.Name = "btnConfirmarPago";
            btnConfirmarPago.Size = new Size(200, 45);
            btnConfirmarPago.TabIndex = 12;
            btnConfirmarPago.Text = "Confirmar y Pagar";
            btnConfirmarPago.UseVisualStyleBackColor = false;
            // 
            // txtMontoSena
            // 
            txtMontoSena.BorderStyle = BorderStyle.FixedSingle;
            txtMontoSena.Font = new Font("Segoe UI", 10F);
            txtMontoSena.Location = new Point(320, 235);
            txtMontoSena.Name = "txtMontoSena";
            txtMontoSena.ReadOnly = true;
            txtMontoSena.Size = new Size(250, 25);
            txtMontoSena.TabIndex = 11;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMonto.ForeColor = Color.FromArgb(15, 45, 75);
            lblMonto.Location = new Point(320, 210);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(116, 19);
            lblMonto.TabIndex = 10;
            lblMonto.Text = "Monto a Cobrar";
            // 
            // txtCVV
            // 
            txtCVV.BorderStyle = BorderStyle.FixedSingle;
            txtCVV.Font = new Font("Segoe UI", 10F);
            txtCVV.Location = new Point(28, 235);
            txtCVV.Name = "txtCVV";
            txtCVV.Size = new Size(120, 25);
            txtCVV.TabIndex = 9;
            // 
            // lblCVV
            // 
            lblCVV.AutoSize = true;
            lblCVV.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCVV.ForeColor = Color.FromArgb(15, 45, 75);
            lblCVV.Location = new Point(28, 210);
            lblCVV.Name = "lblCVV";
            lblCVV.Size = new Size(89, 19);
            lblCVV.TabIndex = 8;
            lblCVV.Text = "Código CVV";
            // 
            // txtTitular
            // 
            txtTitular.BorderStyle = BorderStyle.FixedSingle;
            txtTitular.Font = new Font("Segoe UI", 10F);
            txtTitular.Location = new Point(320, 170);
            txtTitular.Name = "txtTitular";
            txtTitular.Size = new Size(250, 25);
            txtTitular.TabIndex = 7;
            // 
            // lblTitular
            // 
            lblTitular.AutoSize = true;
            lblTitular.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTitular.ForeColor = Color.FromArgb(15, 45, 75);
            lblTitular.Location = new Point(320, 145);
            lblTitular.Name = "lblTitular";
            lblTitular.Size = new Size(137, 19);
            lblTitular.TabIndex = 6;
            lblTitular.Text = "Nombre del Titular";
            // 
            // txtNumeroTarjeta
            // 
            txtNumeroTarjeta.BorderStyle = BorderStyle.FixedSingle;
            txtNumeroTarjeta.Font = new Font("Segoe UI", 10F);
            txtNumeroTarjeta.Location = new Point(28, 170);
            txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            txtNumeroTarjeta.Size = new Size(250, 25);
            txtNumeroTarjeta.TabIndex = 5;
            // 
            // lblNumeroTarjeta
            // 
            lblNumeroTarjeta.AutoSize = true;
            lblNumeroTarjeta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNumeroTarjeta.ForeColor = Color.FromArgb(15, 45, 75);
            lblNumeroTarjeta.Location = new Point(28, 145);
            lblNumeroTarjeta.Name = "lblNumeroTarjeta";
            lblNumeroTarjeta.Size = new Size(135, 19);
            lblNumeroTarjeta.TabIndex = 4;
            lblNumeroTarjeta.Text = "Número de Tarjeta";
            // 
            // cmbMedioPago
            // 
            cmbMedioPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMedioPago.Font = new Font("Segoe UI", 10F);
            cmbMedioPago.FormattingEnabled = true;
            cmbMedioPago.Location = new Point(28, 105);
            cmbMedioPago.Name = "cmbMedioPago";
            cmbMedioPago.Size = new Size(250, 25);
            cmbMedioPago.TabIndex = 3;
            // 
            // lblMedioPago
            // 
            lblMedioPago.AutoSize = true;
            lblMedioPago.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMedioPago.ForeColor = Color.FromArgb(15, 45, 75);
            lblMedioPago.Location = new Point(28, 80);
            lblMedioPago.Name = "lblMedioPago";
            lblMedioPago.Size = new Size(112, 19);
            lblMedioPago.TabIndex = 2;
            lblMedioPago.Text = "Medio de Pago";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.White;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(18, 87, 150);
            btnSalir.Location = new Point(475, 20);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 35);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(20, 70, 120);
            lblTitulo.Location = new Point(25, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(306, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Cobro de Seña y Facturación";
            // 
            // panelInferior
            // 
            panelInferior.BackColor = Color.FromArgb(18, 87, 150);
            panelInferior.Controls.Add(lblUsuarioValor);
            panelInferior.Controls.Add(lblUsuarioActivo);
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(0, 444);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(624, 35);
            panelInferior.TabIndex = 0;
            // 
            // lblUsuarioValor
            // 
            lblUsuarioValor.AutoSize = true;
            lblUsuarioValor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuarioValor.ForeColor = Color.White;
            lblUsuarioValor.Location = new Point(110, 10);
            lblUsuarioValor.Name = "lblUsuarioValor";
            lblUsuarioValor.Size = new Size(78, 15);
            lblUsuarioValor.TabIndex = 1;
            lblUsuarioValor.Text = "Usuario - Rol";
            // 
            // lblUsuarioActivo
            // 
            lblUsuarioActivo.AutoSize = true;
            lblUsuarioActivo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuarioActivo.ForeColor = Color.White;
            lblUsuarioActivo.Location = new Point(15, 10);
            lblUsuarioActivo.Name = "lblUsuarioActivo";
            lblUsuarioActivo.Size = new Size(92, 15);
            lblUsuarioActivo.TabIndex = 0;
            lblUsuarioActivo.Text = "Usuario activo: ";
            // 
            // Form_Cobro_VM516
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(624, 479);
            Controls.Add(panelInferior);
            Controls.Add(panelContenedor);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form_Cobro_VM516";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CuentaClara - Procesar Pago de Seña";
            Load += this.Form_Cobro_VM516_Load;
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            panelInferior.ResumeLayout(false);
            panelInferior.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblMedioPago;
        private System.Windows.Forms.ComboBox cmbMedioPago;
        private System.Windows.Forms.Label lblNumeroTarjeta;
        private System.Windows.Forms.TextBox txtNumeroTarjeta;
        private System.Windows.Forms.Label lblTitular;
        private System.Windows.Forms.TextBox txtTitular;
        private System.Windows.Forms.Label lblCVV;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox txtMontoSena;
        private System.Windows.Forms.Button btnConfirmarPago;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Label lblUsuarioActivo;
        private System.Windows.Forms.Label lblUsuarioValor;
    }
}
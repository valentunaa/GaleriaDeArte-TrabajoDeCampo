namespace IU
{
    partial class Form_Cobro
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
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblMedioPago = new System.Windows.Forms.Label();
            this.cmbMedioPago = new System.Windows.Forms.ComboBox();
            this.lblNumeroTarjeta = new System.Windows.Forms.Label();
            this.txtNumeroTarjeta = new System.Windows.Forms.TextBox();
            this.lblTitular = new System.Windows.Forms.Label();
            this.txtTitular = new System.Windows.Forms.TextBox();
            this.lblCVV = new System.Windows.Forms.Label();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtMontoSena = new System.Windows.Forms.TextBox();
            this.btnConfirmarPago = new System.Windows.Forms.Button();
            this.panelInferior = new System.Windows.Forms.Panel();
            this.lblUsuarioActivo = new System.Windows.Forms.Label();
            this.lblUsuarioValor = new System.Windows.Forms.Label();
            this.panelContenedor.SuspendLayout();
            this.panelInferior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelContenedor.BackColor = System.Drawing.Color.White;
            this.panelContenedor.Controls.Add(this.btnConfirmarPago);
            this.panelContenedor.Controls.Add(this.txtMontoSena);
            this.panelContenedor.Controls.Add(this.lblMonto);
            this.panelContenedor.Controls.Add(this.txtCVV);
            this.panelContenedor.Controls.Add(this.lblCVV);
            this.panelContenedor.Controls.Add(this.txtTitular);
            this.panelContenedor.Controls.Add(this.lblTitular);
            this.panelContenedor.Controls.Add(this.txtNumeroTarjeta);
            this.panelContenedor.Controls.Add(this.lblNumeroTarjeta);
            this.panelContenedor.Controls.Add(this.cmbMedioPago);
            this.panelContenedor.Controls.Add(this.lblMedioPago);
            this.panelContenedor.Controls.Add(this.btnSalir);
            this.panelContenedor.Controls.Add(this.lblTitulo);
            this.panelContenedor.Location = new System.Drawing.Point(12, 12);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(600, 420);
            this.panelContenedor.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            this.lblTitulo.Location = new System.Drawing.Point(25, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(315, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cobro de Seña y Facturación";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.btnSalir.Location = new System.Drawing.Point(475, 20);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 35);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;

            // 
            // lblMedioPago
            // 
            this.lblMedioPago.AutoSize = true;
            this.lblMedioPago.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMedioPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(45)))), ((int)(((byte)(75)))));
            this.lblMedioPago.Location = new System.Drawing.Point(28, 80);
            this.lblMedioPago.Name = "lblMedioPago";
            this.lblMedioPago.Size = new System.Drawing.Size(107, 19);
            this.lblMedioPago.TabIndex = 2;
            this.lblMedioPago.Text = "Medio de Pago";
            // 
            // cmbMedioPago
            // 
            this.cmbMedioPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedioPago.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMedioPago.FormattingEnabled = true;
            this.cmbMedioPago.Location = new System.Drawing.Point(28, 105);
            this.cmbMedioPago.Name = "cmbMedioPago";
            this.cmbMedioPago.Size = new System.Drawing.Size(250, 25);
            this.cmbMedioPago.TabIndex = 3;
            // 
            // lblNumeroTarjeta
            // 
            this.lblNumeroTarjeta.AutoSize = true;
            this.lblNumeroTarjeta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblNumeroTarjeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(45)))), ((int)(((byte)(75)))));
            this.lblNumeroTarjeta.Location = new System.Drawing.Point(28, 145);
            this.lblNumeroTarjeta.Name = "lblNumeroTarjeta";
            this.lblNumeroTarjeta.Size = new System.Drawing.Size(144, 19);
            this.lblNumeroTarjeta.TabIndex = 4;
            this.lblNumeroTarjeta.Text = "Número de Tarjeta";
            // 
            // txtNumeroTarjeta
            // 
            this.txtNumeroTarjeta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroTarjeta.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNumeroTarjeta.Location = new System.Drawing.Point(28, 170);
            this.txtNumeroTarjeta.Name = "txtNumeroTarjeta";
            this.txtNumeroTarjeta.Size = new System.Drawing.Size(250, 25);
            this.txtNumeroTarjeta.TabIndex = 5;
            // 
            // lblTitular
            // 
            this.lblTitular.AutoSize = true;
            this.lblTitular.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTitular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(45)))), ((int)(((byte)(75)))));
            this.lblTitular.Location = new System.Drawing.Point(320, 145);
            this.lblTitular.Name = "lblTitular";
            this.lblTitular.Size = new System.Drawing.Size(135, 19);
            this.lblTitular.TabIndex = 6;
            this.lblTitular.Text = "Nombre del Titular";
            // 
            // txtTitular
            // 
            this.txtTitular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitular.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtTitular.Location = new System.Drawing.Point(320, 170);
            this.txtTitular.Name = "txtTitular";
            this.txtTitular.Size = new System.Drawing.Size(250, 25);
            this.txtTitular.TabIndex = 7;
            // 
            // lblCVV
            // 
            this.lblCVV.AutoSize = true;
            this.lblCVV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCVV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(45)))), ((int)(((byte)(75)))));
            this.lblCVV.Location = new System.Drawing.Point(28, 210);
            this.lblCVV.Name = "lblCVV";
            this.lblCVV.Size = new System.Drawing.Size(89, 19);
            this.lblCVV.TabIndex = 8;
            this.lblCVV.Text = "Código CVV";
            // 
            // txtCVV
            // 
            this.txtCVV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCVV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCVV.Location = new System.Drawing.Point(28, 235);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(120, 25);
            this.txtCVV.TabIndex = 9;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(45)))), ((int)(((byte)(75)))));
            this.lblMonto.Location = new System.Drawing.Point(320, 210);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(117, 19);
            this.lblMonto.TabIndex = 10;
            this.lblMonto.Text = "Monto a Cobrar";
            // 
            // txtMontoSena
            // 
            this.txtMontoSena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontoSena.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMontoSena.Location = new System.Drawing.Point(320, 235);
            this.txtMontoSena.Name = "txtMontoSena";
            this.txtMontoSena.ReadOnly = true;
            this.txtMontoSena.Size = new System.Drawing.Size(250, 25);
            this.txtMontoSena.TabIndex = 11;
            // 
            // btnConfirmarPago
            // 
            this.btnConfirmarPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.btnConfirmarPago.FlatAppearance.BorderSize = 0;
            this.btnConfirmarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarPago.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirmarPago.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarPago.Location = new System.Drawing.Point(370, 310);
            this.btnConfirmarPago.Name = "btnConfirmarPago";
            this.btnConfirmarPago.Size = new System.Drawing.Size(200, 45);
            this.btnConfirmarPago.TabIndex = 12;
            this.btnConfirmarPago.Text = "Confirmar y Pagar";
            this.btnConfirmarPago.UseVisualStyleBackColor = false;

            // 
            // panelInferior
            // 
            this.panelInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(87)))), ((int)(((byte)(150)))));
            this.panelInferior.Controls.Add(this.lblUsuarioValor);
            this.panelInferior.Controls.Add(this.lblUsuarioActivo);
            this.panelInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInferior.Location = new System.Drawing.Point(0, 444);
            this.panelInferior.Name = "panelInferior";
            this.panelInferior.Size = new System.Drawing.Size(624, 35);
            this.panelInferior.TabIndex = 0;
            // 
            // lblUsuarioActivo
            // 
            this.lblUsuarioActivo.AutoSize = true;
            this.lblUsuarioActivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuarioActivo.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioActivo.Location = new System.Drawing.Point(15, 10);
            this.lblUsuarioActivo.Name = "lblUsuarioActivo";
            this.lblUsuarioActivo.Size = new System.Drawing.Size(92, 15);
            this.lblUsuarioActivo.TabIndex = 0;
            this.lblUsuarioActivo.Text = "Usuario activo: ";
            // 
            // lblUsuarioValor
            // 
            this.lblUsuarioValor.AutoSize = true;
            this.lblUsuarioValor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblUsuarioValor.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioValor.Location = new System.Drawing.Point(110, 10);
            this.lblUsuarioValor.Name = "lblUsuarioValor";
            this.lblUsuarioValor.Size = new System.Drawing.Size(90, 15);
            this.lblUsuarioValor.TabIndex = 1;
            this.lblUsuarioValor.Text = "Usuario - Rol";
            // 
            // Form_RegistrarPago_VM516
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(624, 479);
            this.Controls.Add(this.panelInferior);
            this.Controls.Add(this.panelContenedor);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form_RegistrarPago_VM516";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CuentaClara - Procesar Pago de Seña";
  
            this.panelContenedor.ResumeLayout(false);
            this.panelContenedor.PerformLayout();
            this.panelInferior.ResumeLayout(false);
            this.panelInferior.PerformLayout();
            this.ResumeLayout(false);

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
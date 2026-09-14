namespace CuentaClara_TrabajoCampo
{
    partial class FormCambiarClave
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
            lblTitulo = new Label();
            lblClaveActual = new Label();
            txtClaveActual = new TextBox();
            lblNuevaClave = new Label();
            txtNuevaClave = new TextBox();
            btnGuardar = new Button();
            panelInferior = new Panel();
            lblUsuarioValor = new Label();
            lblUsuarioActivo = new Label();
            picLogo = new PictureBox();
            panelContenedor.SuspendLayout();
            panelInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.White;
            panelContenedor.Controls.Add(picLogo);
            panelContenedor.Controls.Add(lblTitulo);
            panelContenedor.Controls.Add(lblClaveActual);
            panelContenedor.Controls.Add(txtClaveActual);
            panelContenedor.Controls.Add(lblNuevaClave);
            panelContenedor.Controls.Add(txtNuevaClave);
            panelContenedor.Controls.Add(btnGuardar);
            panelContenedor.Location = new Point(40, 30);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(520, 320);
            panelContenedor.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(46, 17, 39);
            lblTitulo.Location = new Point(129, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(245, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Tag = "lbl_TituloCambiarContraseña";
            lblTitulo.Text = "Cambiar Contraseña";
            // 
            // lblClaveActual
            // 
            lblClaveActual.AutoSize = true;
            lblClaveActual.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblClaveActual.ForeColor = Color.FromArgb(46, 17, 39);
            lblClaveActual.Location = new Point(40, 95);
            lblClaveActual.Name = "lblClaveActual";
            lblClaveActual.Size = new Size(106, 19);
            lblClaveActual.TabIndex = 1;
            lblClaveActual.Tag = "lbl_ClaveAnterior";
            lblClaveActual.Text = "Clave Anterior";
            // 
            // txtClaveActual
            // 
            txtClaveActual.BorderStyle = BorderStyle.FixedSingle;
            txtClaveActual.Font = new Font("Segoe UI", 10F);
            txtClaveActual.Location = new Point(44, 120);
            txtClaveActual.Name = "txtClaveActual";
            txtClaveActual.PasswordChar = '●';
            txtClaveActual.Size = new Size(420, 25);
            txtClaveActual.TabIndex = 2;
            // 
            // lblNuevaClave
            // 
            lblNuevaClave.AutoSize = true;
            lblNuevaClave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNuevaClave.ForeColor = Color.FromArgb(46, 17, 39);
            lblNuevaClave.Location = new Point(40, 170);
            lblNuevaClave.Name = "lblNuevaClave";
            lblNuevaClave.Size = new Size(93, 19);
            lblNuevaClave.TabIndex = 3;
            lblNuevaClave.Tag = "lbl_NuevaClave";
            lblNuevaClave.Text = "Nueva Clave";
            // 
            // txtNuevaClave
            // 
            txtNuevaClave.BorderStyle = BorderStyle.FixedSingle;
            txtNuevaClave.Font = new Font("Segoe UI", 10F);
            txtNuevaClave.Location = new Point(44, 195);
            txtNuevaClave.Name = "txtNuevaClave";
            txtNuevaClave.PasswordChar = '●';
            txtNuevaClave.Size = new Size(420, 25);
            txtNuevaClave.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(46, 17, 39);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(323, 252);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(140, 40);
            btnGuardar.TabIndex = 5;
            btnGuardar.Tag = "btn_Guardar";
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // panelInferior
            // 
            panelInferior.BackColor = Color.FromArgb(46, 17, 39);
            panelInferior.Controls.Add(lblUsuarioValor);
            panelInferior.Controls.Add(lblUsuarioActivo);
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(0, 348);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(638, 40);
            panelInferior.TabIndex = 1;
            // 
            // lblUsuarioValor
            // 
            lblUsuarioValor.AutoSize = true;
            lblUsuarioValor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuarioValor.ForeColor = Color.White;
            lblUsuarioValor.Location = new Point(123, 12);
            lblUsuarioValor.Name = "lblUsuarioValor";
            lblUsuarioValor.Size = new Size(180, 15);
            lblUsuarioValor.TabIndex = 2;
            lblUsuarioValor.Tag = "";
            lblUsuarioValor.Text = "Maria Lopez-Usuario Operativo";
            // 
            // lblUsuarioActivo
            // 
            lblUsuarioActivo.AutoSize = true;
            lblUsuarioActivo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuarioActivo.ForeColor = Color.White;
            lblUsuarioActivo.Location = new Point(20, 12);
            lblUsuarioActivo.Name = "lblUsuarioActivo";
            lblUsuarioActivo.Size = new Size(92, 15);
            lblUsuarioActivo.TabIndex = 0;
            lblUsuarioActivo.Tag = "lbl_Usuario";
            lblUsuarioActivo.Text = "Usuario activo: ";
            // 
            // picLogo
            // 
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Image = IU.Properties.Resources.ImagenLogo;
            picLogo.Location = new Point(44, 9);
            picLogo.Margin = new Padding(0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(67, 62);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 19;
            picLogo.TabStop = false;
            // 
            // FormCambiarClave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(638, 388);
            Controls.Add(panelInferior);
            Controls.Add(panelContenedor);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormCambiarClave";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "lbl_FormCambiarClave";
            Text = "Vanguardia Arte - Cambiar Contraseña";
            FormClosed += FormCambiarClave_FormClosed;
            Load += FormCambiarClave_Load_1;
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            panelInferior.ResumeLayout(false);
            panelInferior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblClaveActual;
        private System.Windows.Forms.TextBox txtClaveActual;
        private System.Windows.Forms.Label lblNuevaClave;
        private System.Windows.Forms.TextBox txtNuevaClave;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Label lblUsuarioActivo;
        private Label lblUsuarioValor;
        private PictureBox picLogo;
    }
}
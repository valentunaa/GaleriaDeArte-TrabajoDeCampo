namespace IU
{
    partial class FormGestionRespaldo
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
            btnAplicar = new Button();
            button1 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            textBox1 = new TextBox();
            progresoBackup = new ProgressBar();
            btnSeleccionar = new Button();
            btn_RecalcularDv = new Button();
            picLogo = new PictureBox();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // btnAplicar
            // 
            btnAplicar.BackColor = Color.FromArgb(46, 17, 39);
            btnAplicar.FlatAppearance.BorderSize = 0;
            btnAplicar.FlatStyle = FlatStyle.Flat;
            btnAplicar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAplicar.ForeColor = Color.White;
            btnAplicar.Location = new Point(40, 204);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(192, 42);
            btnAplicar.TabIndex = 7;
            btnAplicar.Tag = "btn_Restaurar";
            btnAplicar.Text = "Restaurar\r\n";
            btnAplicar.UseVisualStyleBackColor = false;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(46, 17, 39);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(275, 204);
            button1.Name = "button1";
            button1.Size = new Size(191, 42);
            button1.TabIndex = 8;
            button1.Tag = "btn_BackUp";
            button1.Text = "BackUp\r\n";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(40, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(426, 23);
            textBox1.TabIndex = 9;
            // 
            // progresoBackup
            // 
            progresoBackup.Location = new Point(40, 150);
            progresoBackup.Name = "progresoBackup";
            progresoBackup.Size = new Size(426, 23);
            progresoBackup.TabIndex = 10;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.BackColor = Color.White;
            btnSeleccionar.FlatStyle = FlatStyle.Flat;
            btnSeleccionar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSeleccionar.ForeColor = Color.FromArgb(46, 17, 39);
            btnSeleccionar.Location = new Point(40, 269);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(192, 52);
            btnSeleccionar.TabIndex = 11;
            btnSeleccionar.Tag = "btn_Seleccionar";
            btnSeleccionar.Text = "Seleccionar\r\n";
            btnSeleccionar.UseVisualStyleBackColor = false;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // btn_RecalcularDv
            // 
            btn_RecalcularDv.BackColor = Color.FromArgb(46, 17, 39);
            btn_RecalcularDv.FlatAppearance.BorderSize = 0;
            btn_RecalcularDv.FlatStyle = FlatStyle.Flat;
            btn_RecalcularDv.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_RecalcularDv.ForeColor = Color.White;
            btn_RecalcularDv.Location = new Point(274, 269);
            btn_RecalcularDv.Name = "btn_RecalcularDv";
            btn_RecalcularDv.Size = new Size(192, 52);
            btn_RecalcularDv.TabIndex = 12;
            btn_RecalcularDv.Tag = "btn_RecalcularDigitosVerificadores";
            btn_RecalcularDv.Text = "Recalcular Digitos Verificadores";
            btn_RecalcularDv.UseVisualStyleBackColor = false;
            btn_RecalcularDv.Click += btn_RecalcularDv_Click;
            // 
            // picLogo
            // 
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Image = Properties.Resources.ImagenLogo;
            picLogo.Location = new Point(40, 20);
            picLogo.Margin = new Padding(0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(71, 63);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 13;
            picLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(46, 17, 39);
            lblTitulo.Location = new Point(123, 32);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(279, 37);
            lblTitulo.TabIndex = 14;
            lblTitulo.Tag = "lbl_GestionDeRespaldo";
            lblTitulo.Text = "Gestión de Respaldo";
            // 
            // FormGestionRespaldo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(515, 373);
            Controls.Add(lblTitulo);
            Controls.Add(picLogo);
            Controls.Add(btn_RecalcularDv);
            Controls.Add(btnSeleccionar);
            Controls.Add(progresoBackup);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(btnAplicar);
            MaximizeBox = false;
            Name = "FormGestionRespaldo";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "lbl_FormRespaldo";
            Text = "Form Gestion Respaldo";
            FormClosed += FormGestionRespaldo_FormClosed;
            Load += FormGestionRespaldo_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAplicar;
        private Button button1;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox textBox1;
        private ProgressBar progresoBackup;
        private Button btnSeleccionar;
        private Button btn_RecalcularDv;
        private PictureBox picLogo;
        private Label lblTitulo;
    }
}
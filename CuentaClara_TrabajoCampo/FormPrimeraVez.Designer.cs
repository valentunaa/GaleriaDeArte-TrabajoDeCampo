namespace IU
{
    partial class FormPrimeraVez
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
            btnBuscar = new Button();
            listaServidores = new ComboBox();
            btnGuardar = new Button();
            label1 = new Label();
            lblNombre = new Label();
            picLogo = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnBuscar.BackColor = Color.White;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderColor = Color.FromArgb(46, 17, 39);
            btnBuscar.FlatAppearance.BorderSize = 2;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.FromArgb(46, 17, 39);
            btnBuscar.Location = new Point(135, 275);
            btnBuscar.Margin = new Padding(0);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(150, 45);
            btnBuscar.TabIndex = 43;
            btnBuscar.Tag = "";
            btnBuscar.Text = "Buscar en Red";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // listaServidores
            // 
            listaServidores.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listaServidores.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listaServidores.FormattingEnabled = true;
            listaServidores.Location = new Point(35, 205);
            listaServidores.Margin = new Padding(0);
            listaServidores.Name = "listaServidores";
            listaServidores.Size = new Size(410, 28);
            listaServidores.TabIndex = 42;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardar.BackColor = Color.FromArgb(46, 17, 39);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(295, 275);
            btnGuardar.Margin = new Padding(0);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 45);
            btnGuardar.TabIndex = 41;
            btnGuardar.Tag = "";
            btnGuardar.Text = "Conectar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.FromArgb(80, 80, 80);
            label1.Location = new Point(35, 145);
            label1.Name = "label1";
            label1.Size = new Size(377, 38);
            label1.TabIndex = 44;
            label1.Tag = "lbl_Nombre";
            label1.Text = "Para comenzar, necesitamos preparar tu entorno. \r\nPor favor, selecciona o escribe el nombre de tu servidor SQL.";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(40, 40, 40);
            lblNombre.Location = new Point(35, 115);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(113, 21);
            lblNombre.TabIndex = 46;
            lblNombre.Tag = "lbl_Nombre";
            lblNombre.Text = "Bienvenida/o";
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.ImagenLogo;
            picLogo.Location = new Point(35, 25);
            picLogo.Margin = new Padding(0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(65, 65);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 47;
            picLogo.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(46, 17, 39);
            label2.Location = new Point(110, 38);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(201, 32);
            label2.TabIndex = 48;
            label2.Tag = "lbl_TituloVanguardiaArte";
            label2.Text = "Vanguardia Arte";
            // 
            // FormPrimeraVez
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(480, 350);
            Controls.Add(label2);
            Controls.Add(picLogo);
            Controls.Add(lblNombre);
            Controls.Add(label1);
            Controls.Add(btnBuscar);
            Controls.Add(listaServidores);
            Controls.Add(btnGuardar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPrimeraVez";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "";
            Text = "Configuración Inicial - Vanguardia Arte";
            Load += FormPrimeraVez_Load;
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private ComboBox listaServidores; // Cambiado para escritura manual
        private Button btnGuardar;
        private Label label1;
        private Label lblNombre;
        private PictureBox picLogo;
        private Label label2;
    }
}
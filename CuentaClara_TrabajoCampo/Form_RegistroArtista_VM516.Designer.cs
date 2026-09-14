namespace IU
{
    partial class Form_RegistroArtista_VM516
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
            lblTitulo = new Label();
            lblDNI = new Label();
            txtDNI = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnGuardar = new Button();
            dgvArtistas = new DataGridView();
            textBox1 = new TextBox();
            picLogo = new PictureBox();
            button1 = new Button();
            lblNombreArtista = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvArtistas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(46, 17, 39);
            lblTitulo.Location = new Point(116, 39);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(239, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Tag = "lbl_TituloRegistroArtista";
            lblTitulo.Text = "Registro de Artistas";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDNI.ForeColor = Color.FromArgb(30, 30, 30);
            lblDNI.Location = new Point(37, 122);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(41, 20);
            lblDNI.TabIndex = 1;
            lblDNI.Tag = "lbl_DNI";
            lblDNI.Text = "DNI:";
            // 
            // txtDNI
            // 
            txtDNI.Font = new Font("Segoe UI", 11F);
            txtDNI.Location = new Point(37, 147);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(240, 27);
            txtDNI.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(30, 30, 30);
            lblNombre.Location = new Point(37, 187);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 20);
            lblNombre.TabIndex = 3;
            lblNombre.Tag = "lbl_Nombre";
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11F);
            txtNombre.Location = new Point(37, 212);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(240, 27);
            txtNombre.TabIndex = 4;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblApellido.ForeColor = Color.FromArgb(30, 30, 30);
            lblApellido.Location = new Point(37, 252);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(71, 20);
            lblApellido.TabIndex = 5;
            lblApellido.Tag = "lbl_Apellido";
            lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            txtApellido.Font = new Font("Segoe UI", 11F);
            txtApellido.Location = new Point(37, 277);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(240, 27);
            txtApellido.TabIndex = 6;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTelefono.ForeColor = Color.FromArgb(30, 30, 30);
            lblTelefono.Location = new Point(37, 317);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(74, 20);
            lblTelefono.TabIndex = 7;
            lblTelefono.Tag = "lbl_Telefono";
            lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 11F);
            txtTelefono.Location = new Point(37, 342);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(240, 27);
            txtTelefono.TabIndex = 8;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(30, 30, 30);
            lblEmail.Location = new Point(37, 382);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 20);
            lblEmail.TabIndex = 9;
            lblEmail.Tag = "lbl_Email";
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(37, 407);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(240, 27);
            txtEmail.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(46, 17, 39);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(37, 467);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(240, 42);
            btnGuardar.TabIndex = 11;
            btnGuardar.Tag = "btn_RegistrarArtista";
            btnGuardar.Text = "Registrar Artista";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // dgvArtistas
            // 
            dgvArtistas.AllowUserToAddRows = false;
            dgvArtistas.AllowUserToDeleteRows = false;
            dgvArtistas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvArtistas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvArtistas.BackgroundColor = Color.FromArgb(46, 17, 39);
            dgvArtistas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArtistas.Location = new Point(313, 122);
            dgvArtistas.Name = "dgvArtistas";
            dgvArtistas.ReadOnly = true;
            dgvArtistas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArtistas.Size = new Size(990, 396);
            dgvArtistas.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(582, 550);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 27);
            textBox1.TabIndex = 13;
            // 
            // picLogo
            // 
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Image = Properties.Resources.ImagenLogo;
            picLogo.Location = new Point(37, 24);
            picLogo.Margin = new Padding(0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(63, 60);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 15;
            picLogo.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(46, 17, 39);
            button1.Location = new Point(313, 542);
            button1.Name = "button1";
            button1.Size = new Size(240, 42);
            button1.TabIndex = 16;
            button1.Tag = "btn_BuscarArtista_R";
            button1.Text = "Buscar Artista por DNI";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblNombreArtista
            // 
            lblNombreArtista.AutoSize = true;
            lblNombreArtista.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombreArtista.Location = new Point(856, 557);
            lblNombreArtista.Name = "lblNombreArtista";
            lblNombreArtista.Size = new Size(69, 19);
            lblNombreArtista.TabIndex = 17;
            lblNombreArtista.Text = "Artista ...";
            // 
            // Form_RegistroArtista_VM516
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(1329, 615);
            Controls.Add(lblNombreArtista);
            Controls.Add(button1);
            Controls.Add(picLogo);
            Controls.Add(textBox1);
            Controls.Add(dgvArtistas);
            Controls.Add(btnGuardar);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtDNI);
            Controls.Add(lblDNI);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form_RegistroArtista_VM516";
            Tag = "titulo_FormRegistroArtista";
            Text = "Varguardia Arte - Registrar Artista";
            FormClosed += Form_RegistroArtista_VM516_FormClosed;
            Load += Form_RegistroArtista_VM516_Load;
            ((System.ComponentModel.ISupportInitialize)dgvArtistas).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgvArtistas;
        private TextBox textBox1;
        private PictureBox picLogo;
        private Button button1;
        private Label lblNombreArtista;
        //private Button button1;
    }
}
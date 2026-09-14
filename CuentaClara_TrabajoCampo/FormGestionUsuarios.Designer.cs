namespace CuentaClara_TrabajoCampo
{
    partial class FormGestionUsuarios
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
            panelContenedor = new Panel();
            cmbRol = new ComboBox();
            radioBtnTodosUser = new RadioButton();
            radioBtnUserActivos = new RadioButton();
            lblDNI = new Label();
            txtDNI = new TextBox();
            lblRol = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            lblLogin = new Label();
            txtLogin = new TextBox();
            chkActivo = new CheckBox();
            lblTitulo = new Label();
            dgvUsuarios = new DataGridView();
            btnCrear = new Button();
            btnDesbloquear = new Button();
            btnModificar = new Button();
            btnActivarDesactivar = new Button();
            btnAplicar = new Button();
            btnCancelar = new Button();
            btnSalir = new Button();
            lblCantidadUsuarios = new Label();
            lblTotalUsuarios = new Label();
            lstMensajes = new ListBox();
            panelInferior = new Panel();
            label1 = new Label();
            lblUsuarioActivo = new Label();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            panelInferior.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.Anchor = AnchorStyles.None;
            panelContenedor.BackColor = Color.White;
            panelContenedor.Controls.Add(cmbRol);
            panelContenedor.Controls.Add(radioBtnTodosUser);
            panelContenedor.Controls.Add(radioBtnUserActivos);
            panelContenedor.Controls.Add(lblDNI);
            panelContenedor.Controls.Add(txtDNI);
            panelContenedor.Controls.Add(lblRol);
            panelContenedor.Controls.Add(lblNombre);
            panelContenedor.Controls.Add(txtNombre);
            panelContenedor.Controls.Add(lblApellido);
            panelContenedor.Controls.Add(txtApellido);
            panelContenedor.Controls.Add(lblCorreo);
            panelContenedor.Controls.Add(txtCorreo);
            panelContenedor.Controls.Add(lblLogin);
            panelContenedor.Controls.Add(txtLogin);
            panelContenedor.Controls.Add(chkActivo);
            panelContenedor.Controls.Add(lblTitulo);
            panelContenedor.Controls.Add(dgvUsuarios);
            panelContenedor.Controls.Add(btnCrear);
            panelContenedor.Controls.Add(btnDesbloquear);
            panelContenedor.Controls.Add(btnModificar);
            panelContenedor.Controls.Add(btnActivarDesactivar);
            panelContenedor.Controls.Add(btnAplicar);
            panelContenedor.Controls.Add(btnCancelar);
            panelContenedor.Controls.Add(btnSalir);
            panelContenedor.Controls.Add(lblCantidadUsuarios);
            panelContenedor.Controls.Add(lblTotalUsuarios);
            panelContenedor.Controls.Add(lstMensajes);
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1258, 736);
            panelContenedor.TabIndex = 0;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(185, 661);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(209, 23);
            cmbRol.TabIndex = 34;
            // 
            // radioBtnTodosUser
            // 
            radioBtnTodosUser.AutoSize = true;
            radioBtnTodosUser.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            radioBtnTodosUser.ForeColor = Color.FromArgb(15, 45, 75);
            radioBtnTodosUser.Location = new Point(216, 68);
            radioBtnTodosUser.Name = "radioBtnTodosUser";
            radioBtnTodosUser.Size = new Size(128, 23);
            radioBtnTodosUser.TabIndex = 33;
            radioBtnTodosUser.TabStop = true;
            radioBtnTodosUser.Tag = "btn_TodosUsuarios";
            radioBtnTodosUser.Text = "Todos Usuarios";
            radioBtnTodosUser.UseVisualStyleBackColor = true;
            radioBtnTodosUser.CheckedChanged += radioBtnTodosUser_CheckedChanged;
            // 
            // radioBtnUserActivos
            // 
            radioBtnUserActivos.AutoSize = true;
            radioBtnUserActivos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            radioBtnUserActivos.ForeColor = Color.FromArgb(15, 45, 75);
            radioBtnUserActivos.Location = new Point(39, 68);
            radioBtnUserActivos.Name = "radioBtnUserActivos";
            radioBtnUserActivos.Size = new Size(137, 23);
            radioBtnUserActivos.TabIndex = 32;
            radioBtnUserActivos.TabStop = true;
            radioBtnUserActivos.Tag = "btn_UsuarioActivos";
            radioBtnUserActivos.Text = "Usuarios Activos";
            radioBtnUserActivos.UseVisualStyleBackColor = true;
            radioBtnUserActivos.CheckedChanged += radioBtnUserActivos_CheckedChanged;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDNI.Location = new Point(35, 447);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(34, 19);
            lblDNI.TabIndex = 16;
            lblDNI.Tag = "lbl_DNI";
            lblDNI.Text = "DNI";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(185, 447);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(209, 23);
            txtDNI.TabIndex = 17;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblRol.Location = new Point(40, 665);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(98, 19);
            lblRol.TabIndex = 18;
            lblRol.Tag = "lbl_RolAsignado";
            lblRol.Text = "Rol Asignado";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombre.Location = new Point(35, 486);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 19);
            lblNombre.TabIndex = 20;
            lblNombre.Tag = "lbl_Nombre";
            lblNombre.Text = "Nombres";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(185, 486);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(209, 23);
            txtNombre.TabIndex = 21;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblApellido.Location = new Point(35, 525);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(72, 19);
            lblApellido.TabIndex = 22;
            lblApellido.Tag = "lbl_Apellido";
            lblApellido.Text = "Apellidos";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(185, 525);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(209, 23);
            txtApellido.TabIndex = 23;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCorreo.Location = new Point(37, 571);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(134, 19);
            lblCorreo.TabIndex = 24;
            lblCorreo.Tag = "lbl_Correo";
            lblCorreo.Text = "Correo Electrónico";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(185, 567);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(209, 23);
            txtCorreo.TabIndex = 25;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLogin.Location = new Point(40, 611);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(127, 19);
            lblLogin.TabIndex = 26;
            lblLogin.Tag = "lbl_NomdeLogin";
            lblLogin.Text = "Nombre de Login";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(185, 616);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(209, 23);
            txtLogin.TabIndex = 27;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            chkActivo.ForeColor = Color.FromArgb(46, 17, 39);
            chkActivo.Location = new Point(185, 694);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(195, 23);
            chkActivo.TabIndex = 30;
            chkActivo.Tag = "chk_Activo";
            chkActivo.Text = "Habilitar Acceso (Activo)";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(46, 17, 39);
            lblTitulo.Location = new Point(30, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(272, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Tag = "lbl_GestionDeUsuarios";
            lblTitulo.Text = "Gestión de Usuarios";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AllowUserToResizeRows = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.BackgroundColor = Color.FromArgb(46, 17, 39);
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dgvUsuarios.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(18, 87, 150);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(18, 87, 150);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.ColumnHeadersHeight = 58;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(220, 230, 240);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.GridColor = Color.FromArgb(230, 230, 230);
            dgvUsuarios.Location = new Point(35, 105);
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowHeadersWidth = 102;
            dgvUsuarios.RowTemplate.Height = 32;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(974, 320);
            dgvUsuarios.TabIndex = 1;
            dgvUsuarios.SelectionChanged += dgvUsuarios_SelectionChanged;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.FromArgb(18, 87, 150);
            btnCrear.FlatAppearance.BorderSize = 0;
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCrear.ForeColor = Color.White;
            btnCrear.Location = new Point(1068, 133);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(140, 42);
            btnCrear.TabIndex = 2;
            btnCrear.Tag = "btn_Crear";
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnDesbloquear
            // 
            btnDesbloquear.BackColor = Color.White;
            btnDesbloquear.FlatStyle = FlatStyle.Flat;
            btnDesbloquear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDesbloquear.ForeColor = Color.FromArgb(18, 87, 150);
            btnDesbloquear.Location = new Point(1068, 204);
            btnDesbloquear.Name = "btnDesbloquear";
            btnDesbloquear.Size = new Size(140, 42);
            btnDesbloquear.TabIndex = 3;
            btnDesbloquear.Tag = "btn_Desbloquear";
            btnDesbloquear.Text = "Desbloquear";
            btnDesbloquear.UseVisualStyleBackColor = false;
            btnDesbloquear.Click += btnDesbloquear_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.White;
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnModificar.ForeColor = Color.FromArgb(18, 87, 150);
            btnModificar.Location = new Point(1068, 274);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(140, 42);
            btnModificar.TabIndex = 4;
            btnModificar.Tag = "btn_Modificar";
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnActivarDesactivar
            // 
            btnActivarDesactivar.BackColor = Color.White;
            btnActivarDesactivar.FlatStyle = FlatStyle.Flat;
            btnActivarDesactivar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnActivarDesactivar.ForeColor = Color.FromArgb(18, 87, 150);
            btnActivarDesactivar.Location = new Point(1068, 338);
            btnActivarDesactivar.Name = "btnActivarDesactivar";
            btnActivarDesactivar.Size = new Size(140, 51);
            btnActivarDesactivar.TabIndex = 5;
            btnActivarDesactivar.Tag = "btn_Activar/Desactivar";
            btnActivarDesactivar.Text = "Activar / Desactivar";
            btnActivarDesactivar.UseVisualStyleBackColor = false;
            btnActivarDesactivar.Click += btnActivarDesactivar_Click;
            // 
            // btnAplicar
            // 
            btnAplicar.BackColor = Color.FromArgb(46, 17, 39);
            btnAplicar.FlatAppearance.BorderSize = 0;
            btnAplicar.FlatStyle = FlatStyle.Flat;
            btnAplicar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAplicar.ForeColor = Color.White;
            btnAplicar.Location = new Point(562, 665);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(140, 42);
            btnAplicar.TabIndex = 6;
            btnAplicar.Tag = "btn_Aplicar";
            btnAplicar.Text = "Aplicar";
            btnAplicar.UseVisualStyleBackColor = false;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(46, 17, 39);
            btnCancelar.Location = new Point(825, 665);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 42);
            btnCancelar.TabIndex = 7;
            btnCancelar.Tag = "btn_Cancelar";
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.White;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(18, 87, 150);
            btnSalir.Location = new Point(1078, 665);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(140, 42);
            btnSalir.TabIndex = 8;
            btnSalir.Tag = "btn_Salir";
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblCantidadUsuarios
            // 
            lblCantidadUsuarios.AutoSize = true;
            lblCantidadUsuarios.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCantidadUsuarios.ForeColor = Color.FromArgb(15, 45, 75);
            lblCantidadUsuarios.Location = new Point(781, 74);
            lblCantidadUsuarios.Name = "lblCantidadUsuarios";
            lblCantidadUsuarios.Size = new Size(128, 19);
            lblCantidadUsuarios.TabIndex = 4;
            lblCantidadUsuarios.Tag = "lbl_TotalDeUsuarios";
            lblCantidadUsuarios.Text = "Total de Usuarios:";
            // 
            // lblTotalUsuarios
            // 
            lblTotalUsuarios.AutoSize = true;
            lblTotalUsuarios.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalUsuarios.ForeColor = Color.FromArgb(46, 17, 39);
            lblTotalUsuarios.Location = new Point(940, 74);
            lblTotalUsuarios.Name = "lblTotalUsuarios";
            lblTotalUsuarios.Size = new Size(25, 19);
            lblTotalUsuarios.TabIndex = 5;
            lblTotalUsuarios.Text = "15";
            // 
            // lstMensajes
            // 
            lstMensajes.BorderStyle = BorderStyle.FixedSingle;
            lstMensajes.Font = new Font("Segoe UI", 9F);
            lstMensajes.FormattingEnabled = true;
            lstMensajes.ItemHeight = 15;
            lstMensajes.Location = new Point(553, 457);
            lstMensajes.Name = "lstMensajes";
            lstMensajes.Size = new Size(665, 182);
            lstMensajes.TabIndex = 6;
            // 
            // panelInferior
            // 
            panelInferior.BackColor = Color.FromArgb(46, 17, 39);
            panelInferior.Controls.Add(label1);
            panelInferior.Controls.Add(lblUsuarioActivo);
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(0, 776);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(1305, 40);
            panelInferior.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(115, 12);
            label1.Name = "label1";
            label1.Size = new Size(158, 15);
            label1.TabIndex = 1;
            label1.Tag = "";
            label1.Text = "Maria Lopez-Administrador";
            // 
            // lblUsuarioActivo
            // 
            lblUsuarioActivo.AutoSize = true;
            lblUsuarioActivo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuarioActivo.ForeColor = Color.White;
            lblUsuarioActivo.Location = new Point(20, 12);
            lblUsuarioActivo.Name = "lblUsuarioActivo";
            lblUsuarioActivo.Size = new Size(89, 15);
            lblUsuarioActivo.TabIndex = 0;
            lblUsuarioActivo.Tag = "lbl_Usuario";
            lblUsuarioActivo.Text = "Usuario activo:";
            // 
            // FormGestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(1305, 816);
            Controls.Add(panelInferior);
            Controls.Add(panelContenedor);
            Font = new Font("Segoe UI", 9F);
            Name = "FormGestionUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CuentaClara - Gestión de Usuarios";
            FormClosed += FormGestionUsuarios_FormClosed;
            Load += FormGestionUsuarios_Load_1;
            Resize += FormGestionUsuarios_Resize;
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            panelInferior.ResumeLayout(false);
            panelInferior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvUsuarios;

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnDesbloquear;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnActivarDesactivar;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalir;

        private System.Windows.Forms.Label lblCantidadUsuarios;
        private System.Windows.Forms.Label lblTotalUsuarios;

        private System.Windows.Forms.ListBox lstMensajes;

        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Label lblUsuarioActivo;
        private Label lblDNI;
        private TextBox txtDNI;
        private Label lblRol;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private Label lblLogin;
        private TextBox txtLogin;
        private CheckBox chkActivo;
        private RadioButton radioBtnUserActivos;
        private RadioButton radioBtnTodosUser;
        private ComboBox cmbRol;
        private Label label1;
    }
}
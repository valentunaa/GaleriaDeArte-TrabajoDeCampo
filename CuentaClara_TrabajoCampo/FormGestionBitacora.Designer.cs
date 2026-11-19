namespace CuentaClara_TrabajoCampo
{
    partial class FormGestionBitacora
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
            button1 = new Button();
            button8 = new Button();
            label2 = new Label();
            label1 = new Label();
            lblTitulo = new Label();
            dgvBitacora = new DataGridView();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblLogin = new Label();
            cboLogin = new ComboBox();
            lblFechaInicio = new Label();
            dtpFechaInicio = new DateTimePicker();
            lblFechaFin = new Label();
            dtpFechaFin = new DateTimePicker();
            lblModulo = new Label();
            cboModulo = new ComboBox();
            lblEvento = new Label();
            cboEvento = new ComboBox();
            lblCriticidad = new Label();
            cboCriticidad = new ComboBox();
            lstMensajes = new ListBox();
            btnLimpiar = new Button();
            btnAplicar = new Button();
            btnImprimir = new Button();
            btnSalir = new Button();
            panelInferior = new Panel();
            lblUsuarioValor = new Label();
            lblUsuarioActivo = new Label();
            toolTipBitacora = new ToolTip(components);
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBitacora).BeginInit();
            panelInferior.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.Anchor = AnchorStyles.None;
            panelContenedor.BackColor = Color.White;
            panelContenedor.Controls.Add(button1);
            panelContenedor.Controls.Add(button8);
            panelContenedor.Controls.Add(label2);
            panelContenedor.Controls.Add(label1);
            panelContenedor.Controls.Add(lblTitulo);
            panelContenedor.Controls.Add(dgvBitacora);
            panelContenedor.Controls.Add(lblNombre);
            panelContenedor.Controls.Add(txtNombre);
            panelContenedor.Controls.Add(lblApellido);
            panelContenedor.Controls.Add(txtApellido);
            panelContenedor.Controls.Add(lblLogin);
            panelContenedor.Controls.Add(cboLogin);
            panelContenedor.Controls.Add(lblFechaInicio);
            panelContenedor.Controls.Add(dtpFechaInicio);
            panelContenedor.Controls.Add(lblFechaFin);
            panelContenedor.Controls.Add(dtpFechaFin);
            panelContenedor.Controls.Add(lblModulo);
            panelContenedor.Controls.Add(cboModulo);
            panelContenedor.Controls.Add(lblEvento);
            panelContenedor.Controls.Add(cboEvento);
            panelContenedor.Controls.Add(lblCriticidad);
            panelContenedor.Controls.Add(cboCriticidad);
            panelContenedor.Controls.Add(lstMensajes);
            panelContenedor.Controls.Add(btnLimpiar);
            panelContenedor.Controls.Add(btnAplicar);
            panelContenedor.Controls.Add(btnImprimir);
            panelContenedor.Controls.Add(btnSalir);
            panelContenedor.Location = new Point(12, 24);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1506, 844);
            panelContenedor.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(46, 17, 39);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 28, 62);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(235, 170, 200);
            button1.Location = new Point(1356, 681);
            button1.Name = "button1";
            button1.Size = new Size(122, 42);
            button1.TabIndex = 51;
            button1.Tag = "btn_Ayuda";
            button1.Text = "AYUDA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(46, 17, 39);
            button8.Cursor = Cursors.Hand;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.MouseOverBackColor = Color.FromArgb(72, 28, 62);
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button8.ForeColor = Color.FromArgb(235, 170, 200);
            button8.Location = new Point(1388, 779);
            button8.Name = "button8";
            button8.Size = new Size(122, 42);
            button8.TabIndex = 50;
            button8.Tag = "btn_Ayuda";
            button8.Text = "AYUDA";
            button8.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(15, 45, 75);
            label2.Location = new Point(773, 457);
            label2.Name = "label2";
            label2.Size = new Size(17, 19);
            label2.TabIndex = 24;
            label2.Tag = "";
            label2.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(46, 17, 39);
            label1.Location = new Point(600, 457);
            label1.Name = "label1";
            label1.Size = new Size(145, 19);
            label1.TabIndex = 23;
            label1.Tag = "lbl_CantEventos";
            label1.Text = "Cantidad de Eventos";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(46, 17, 39);
            lblTitulo.Location = new Point(38, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(239, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Tag = "lbl_TituloBitacoradeEventos";
            lblTitulo.Text = "Bitácora de Eventos";
            // 
            // dgvBitacora
            // 
            dgvBitacora.AllowUserToAddRows = false;
            dgvBitacora.AllowUserToDeleteRows = false;
            dgvBitacora.AllowUserToResizeRows = false;
            dgvBitacora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBitacora.BackgroundColor = Color.FromArgb(46, 17, 39);
            dgvBitacora.BorderStyle = BorderStyle.None;
            dgvBitacora.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBitacora.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(18, 87, 150);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBitacora.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBitacora.ColumnHeadersHeight = 58;
            dgvBitacora.EnableHeadersVisualStyles = false;
            dgvBitacora.GridColor = Color.FromArgb(220, 220, 220);
            dgvBitacora.Location = new Point(38, 66);
            dgvBitacora.MultiSelect = false;
            dgvBitacora.Name = "dgvBitacora";
            dgvBitacora.ReadOnly = true;
            dgvBitacora.RowHeadersVisible = false;
            dgvBitacora.RowHeadersWidth = 102;
            dgvBitacora.RowTemplate.Height = 28;
            dgvBitacora.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBitacora.Size = new Size(1440, 360);
            dgvBitacora.TabIndex = 1;
            dgvBitacora.SelectionChanged += dgvBitacora_SelectionChanged;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(46, 17, 39);
            lblNombre.Location = new Point(36, 457);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(65, 19);
            lblNombre.TabIndex = 2;
            lblNombre.Tag = "lbl_Nombre";
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.Location = new Point(36, 482);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(180, 25);
            txtNombre.TabIndex = 3;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblApellido.ForeColor = Color.FromArgb(46, 17, 39);
            lblApellido.Location = new Point(256, 457);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 19);
            lblApellido.TabIndex = 4;
            lblApellido.Tag = "lbl_Apellido";
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.BorderStyle = BorderStyle.FixedSingle;
            txtApellido.Font = new Font("Segoe UI", 10F);
            txtApellido.Location = new Point(256, 482);
            txtApellido.Name = "txtApellido";
            txtApellido.ReadOnly = true;
            txtApellido.Size = new Size(180, 25);
            txtApellido.TabIndex = 5;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLogin.ForeColor = Color.FromArgb(46, 17, 39);
            lblLogin.Location = new Point(32, 528);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(46, 19);
            lblLogin.TabIndex = 6;
            lblLogin.Tag = "lbl_NomdeLogin";
            lblLogin.Text = "Login";
            // 
            // cboLogin
            // 
            cboLogin.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLogin.Font = new Font("Segoe UI", 10F);
            cboLogin.Location = new Point(32, 553);
            cboLogin.Name = "cboLogin";
            cboLogin.Size = new Size(184, 25);
            cboLogin.TabIndex = 7;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFechaInicio.ForeColor = Color.FromArgb(46, 17, 39);
            lblFechaInicio.Location = new Point(255, 528);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(87, 19);
            lblFechaInicio.TabIndex = 8;
            lblFechaInicio.Tag = "lbl_FechaInicio";
            lblFechaInicio.Text = "Fecha Inicio";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Font = new Font("Segoe UI", 10F);
            dtpFechaInicio.Location = new Point(255, 553);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(180, 25);
            dtpFechaInicio.TabIndex = 9;
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFechaFin.ForeColor = Color.FromArgb(46, 17, 39);
            lblFechaFin.Location = new Point(465, 528);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(70, 19);
            lblFechaFin.TabIndex = 10;
            lblFechaFin.Tag = "lbl_FechaFin";
            lblFechaFin.Text = "Fecha Fin";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Font = new Font("Segoe UI", 10F);
            dtpFechaFin.Location = new Point(465, 553);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(180, 25);
            dtpFechaFin.TabIndex = 11;
            // 
            // lblModulo
            // 
            lblModulo.AutoSize = true;
            lblModulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblModulo.ForeColor = Color.FromArgb(46, 17, 39);
            lblModulo.Location = new Point(675, 528);
            lblModulo.Name = "lblModulo";
            lblModulo.Size = new Size(61, 19);
            lblModulo.TabIndex = 12;
            lblModulo.Tag = "lbl_Modulo";
            lblModulo.Text = "Módulo";
            // 
            // cboModulo
            // 
            cboModulo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboModulo.Font = new Font("Segoe UI", 10F);
            cboModulo.Items.AddRange(new object[] { "Administración", "Seguridad", "Gestión de Perfiles y Autorización", "Negocio - Tesorería" });
            cboModulo.Location = new Point(675, 553);
            cboModulo.Name = "cboModulo";
            cboModulo.Size = new Size(240, 25);
            cboModulo.TabIndex = 13;
            // 
            // lblEvento
            // 
            lblEvento.AutoSize = true;
            lblEvento.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEvento.ForeColor = Color.FromArgb(46, 17, 39);
            lblEvento.Location = new Point(939, 528);
            lblEvento.Name = "lblEvento";
            lblEvento.Size = new Size(54, 19);
            lblEvento.TabIndex = 14;
            lblEvento.Tag = "lbl_Evento";
            lblEvento.Text = "Evento";
            // 
            // cboEvento
            // 
            cboEvento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEvento.Font = new Font("Segoe UI", 10F);
            cboEvento.Items.AddRange(new object[] { "Login Correcto", "Login Incorrecto", "Logout", "Usuario Desbloqueado", "Intento de login bloqueado", "Usuario Bloqueado o Inactivo", "Usuario Modificado", "Usuario Creado", "Modificar Usuario", "Activar Usuario", "Desactivar Usuario", "Impresión/Exportación de Bitácora", "Cambio Clave", "Asignación familia a rol", "Asignación familia a familia", "Asignación permiso a rol", "Asignación permiso a familia", "Permiso asignado a Familia", "Permiso desasignado de Familia", "Subfamilia desasignada de Familia", "Modificación Familia", "Baja Familia", "Alta Familia", "Desasignación en Perfiles", "Cambio de Idioma en Sesión", "Actualización de Idioma", "Violación de integridad detectada", "Recalculo de Dígitos Verificadores de Usuario", "Acceso de emergencia por violación de integridad", "Violación de integridad en la tabla", "Violación de integridad crítica" });
            cboEvento.Location = new Point(939, 553);
            cboEvento.Name = "cboEvento";
            cboEvento.Size = new Size(388, 25);
            cboEvento.TabIndex = 15;
 
            // 
            // lblCriticidad
            // 
            lblCriticidad.AutoSize = true;
            lblCriticidad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCriticidad.ForeColor = Color.FromArgb(46, 17, 39);
            lblCriticidad.Location = new Point(1388, 531);
            lblCriticidad.Name = "lblCriticidad";
            lblCriticidad.Size = new Size(74, 19);
            lblCriticidad.TabIndex = 16;
            lblCriticidad.Tag = "lbl_Criticidad";
            lblCriticidad.Text = "Criticidad";
            // 
            // cboCriticidad
            // 
            cboCriticidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCriticidad.Font = new Font("Segoe UI", 10F);
            cboCriticidad.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cboCriticidad.Location = new Point(1388, 553);
            cboCriticidad.Name = "cboCriticidad";
            cboCriticidad.Size = new Size(84, 25);
            cboCriticidad.TabIndex = 17;
            // 
            // lstMensajes
            // 
            lstMensajes.BorderStyle = BorderStyle.FixedSingle;
            lstMensajes.Font = new Font("Segoe UI", 9F);
            lstMensajes.ItemHeight = 15;
            lstMensajes.Location = new Point(36, 612);
            lstMensajes.Name = "lstMensajes";
            lstMensajes.Size = new Size(1440, 47);
            lstMensajes.TabIndex = 18;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.FromArgb(46, 17, 39);
            btnLimpiar.Location = new Point(570, 681);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(120, 38);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.Tag = "btn_Limpiar";
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAplicar
            // 
            btnAplicar.BackColor = Color.FromArgb(46, 17, 39);
            btnAplicar.FlatAppearance.BorderSize = 0;
            btnAplicar.FlatStyle = FlatStyle.Flat;
            btnAplicar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAplicar.ForeColor = Color.White;
            btnAplicar.Location = new Point(710, 681);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(120, 38);
            btnAplicar.TabIndex = 20;
            btnAplicar.Tag = "btn_Aplicar";
            btnAplicar.Text = "Aplicar";
            btnAplicar.UseVisualStyleBackColor = false;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.White;
            btnImprimir.FlatStyle = FlatStyle.Flat;
            btnImprimir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnImprimir.ForeColor = Color.FromArgb(46, 17, 39);
            btnImprimir.Location = new Point(850, 681);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(120, 38);
            btnImprimir.TabIndex = 21;
            btnImprimir.Tag = "btn_Imprimir";
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.White;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(46, 17, 39);
            btnSalir.Location = new Point(1338, 21);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(140, 38);
            btnSalir.TabIndex = 22;
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
            panelInferior.Location = new Point(0, 765);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(1539, 38);
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
            // FormGestionBitacora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(1539, 803);
            Controls.Add(panelInferior);
            Controls.Add(panelContenedor);
            Font = new Font("Segoe UI", 9F);
            Name = "FormGestionBitacora";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "lbl_FormBitacora";
            Text = "Vanguardia Arte - Gestión de Bitácora de Eventos";
            FormClosed += FormGestionBitacora_FormClosed;
            Load += FormGestionBitacora_Load_1;
            Resize += FormGestionBitacora_Resize;
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBitacora).EndInit();
            panelInferior.ResumeLayout(false);
            panelInferior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;

        private System.Windows.Forms.Label lblTitulo;

        private System.Windows.Forms.DataGridView dgvBitacora;

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;

        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.ComboBox cboLogin;

        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;

        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;

        private System.Windows.Forms.Label lblModulo;
        private System.Windows.Forms.ComboBox cboModulo;

        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.ComboBox cboEvento;

        private System.Windows.Forms.Label lblCriticidad;
        private System.Windows.Forms.ComboBox cboCriticidad;

        private System.Windows.Forms.ListBox lstMensajes;

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnSalir;

        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Label lblUsuarioActivo;
        private Label lblUsuarioValor;
        private Label label2;
        private Label label1;
        private ToolTip toolTipBitacora;
        private Button button8;
        private Button button1;
    }
}
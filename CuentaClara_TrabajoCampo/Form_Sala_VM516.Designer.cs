namespace IU
{
    partial class Form_Sala_VM516
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
            panelContenedor = new Panel();
            btn_Modificar = new Button();
            lblTitulo = new Label();
            dgvSalas = new DataGridView();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblAlto = new Label();
            txtAlto = new TextBox();
            lblAncho = new Label();
            txtAncho = new TextBox();
            lblPeso = new Label();
            txtPeso = new TextBox();
            lblIluminacion = new Label();
            btnGuardar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            panelInferior = new Panel();
            lblUsuarioValor = new Label();
            lblUsuarioActivo = new Label();
            comboBox1 = new ComboBox();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSalas).BeginInit();
            panelInferior.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.Anchor = AnchorStyles.None;
            panelContenedor.BackColor = Color.White;
            panelContenedor.Controls.Add(comboBox1);
            panelContenedor.Controls.Add(btn_Modificar);
            panelContenedor.Controls.Add(lblTitulo);
            panelContenedor.Controls.Add(dgvSalas);
            panelContenedor.Controls.Add(lblCodigo);
            panelContenedor.Controls.Add(txtCodigo);
            panelContenedor.Controls.Add(lblNombre);
            panelContenedor.Controls.Add(txtNombre);
            panelContenedor.Controls.Add(lblAlto);
            panelContenedor.Controls.Add(txtAlto);
            panelContenedor.Controls.Add(lblAncho);
            panelContenedor.Controls.Add(txtAncho);
            panelContenedor.Controls.Add(lblPeso);
            panelContenedor.Controls.Add(txtPeso);
            panelContenedor.Controls.Add(lblIluminacion);
            panelContenedor.Controls.Add(btnGuardar);
            panelContenedor.Controls.Add(btnEliminar);
            panelContenedor.Controls.Add(btnLimpiar);
            panelContenedor.Controls.Add(btnSalir);
            panelContenedor.Location = new Point(12, 12);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1316, 745);
            panelContenedor.TabIndex = 1;
            // 
            // btn_Modificar
            // 
            btn_Modificar.BackColor = Color.FromArgb(18, 87, 150);
            btn_Modificar.FlatAppearance.BorderSize = 0;
            btn_Modificar.FlatStyle = FlatStyle.Flat;
            btn_Modificar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_Modificar.ForeColor = Color.White;
            btn_Modificar.Location = new Point(234, 310);
            btn_Modificar.Name = "btn_Modificar";
            btn_Modificar.Size = new Size(180, 40);
            btn_Modificar.TabIndex = 22;
            btn_Modificar.Text = "Modificar";
            btn_Modificar.UseVisualStyleBackColor = false;
            btn_Modificar.Click += btn_Modificar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(20, 70, 120);
            lblTitulo.Location = new Point(30, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(280, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Salas Físicas";
            // 
            // dgvSalas
            // 
            dgvSalas.AllowUserToAddRows = false;
            dgvSalas.AllowUserToDeleteRows = false;
            dgvSalas.AllowUserToResizeRows = false;
            dgvSalas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSalas.BackgroundColor = Color.FromArgb(18, 87, 150);
            dgvSalas.BorderStyle = BorderStyle.None;
            dgvSalas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSalas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(18, 87, 150);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSalas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSalas.ColumnHeadersHeight = 58;
            dgvSalas.EnableHeadersVisualStyles = false;
            dgvSalas.GridColor = Color.FromArgb(220, 220, 220);
            dgvSalas.Location = new Point(480, 80);
            dgvSalas.MultiSelect = false;
            dgvSalas.Name = "dgvSalas";
            dgvSalas.ReadOnly = true;
            dgvSalas.RowHeadersVisible = false;
            dgvSalas.RowHeadersWidth = 102;
            dgvSalas.RowTemplate.Height = 28;
            dgvSalas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSalas.Size = new Size(789, 580);
            dgvSalas.TabIndex = 21;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCodigo.ForeColor = Color.FromArgb(15, 45, 75);
            lblCodigo.Location = new Point(34, 80);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(90, 19);
            lblCodigo.TabIndex = 2;
            lblCodigo.Text = "Código Sala";
            // 
            // txtCodigo
            // 
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Segoe UI", 10F);
            txtCodigo.Location = new Point(34, 105);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(180, 25);
            txtCodigo.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombre.ForeColor = Color.FromArgb(15, 45, 75);
            lblNombre.Location = new Point(234, 80);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(97, 19);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre Sala";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.Location = new Point(234, 105);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(180, 25);
            txtNombre.TabIndex = 5;
            // 
            // lblAlto
            // 
            lblAlto.AutoSize = true;
            lblAlto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAlto.ForeColor = Color.FromArgb(15, 45, 75);
            lblAlto.Location = new Point(34, 150);
            lblAlto.Name = "lblAlto";
            lblAlto.Size = new Size(96, 19);
            lblAlto.TabIndex = 6;
            lblAlto.Text = "Alto Máximo";
            // 
            // txtAlto
            // 
            txtAlto.BorderStyle = BorderStyle.FixedSingle;
            txtAlto.Font = new Font("Segoe UI", 10F);
            txtAlto.Location = new Point(34, 175);
            txtAlto.Name = "txtAlto";
            txtAlto.Size = new Size(110, 25);
            txtAlto.TabIndex = 7;
            // 
            // lblAncho
            // 
            lblAncho.AutoSize = true;
            lblAncho.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAncho.ForeColor = Color.FromArgb(15, 45, 75);
            lblAncho.Location = new Point(169, 150);
            lblAncho.Name = "lblAncho";
            lblAncho.Size = new Size(110, 19);
            lblAncho.TabIndex = 8;
            lblAncho.Text = "Ancho Máximo";
            // 
            // txtAncho
            // 
            txtAncho.BorderStyle = BorderStyle.FixedSingle;
            txtAncho.Font = new Font("Segoe UI", 10F);
            txtAncho.Location = new Point(169, 175);
            txtAncho.Name = "txtAncho";
            txtAncho.Size = new Size(110, 25);
            txtAncho.TabIndex = 9;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPeso.ForeColor = Color.FromArgb(15, 45, 75);
            lblPeso.Location = new Point(304, 150);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(100, 19);
            lblPeso.TabIndex = 10;
            lblPeso.Text = "Peso Máximo";
            // 
            // txtPeso
            // 
            txtPeso.BorderStyle = BorderStyle.FixedSingle;
            txtPeso.Font = new Font("Segoe UI", 10F);
            txtPeso.Location = new Point(304, 175);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(110, 25);
            txtPeso.TabIndex = 11;
            // 
            // lblIluminacion
            // 
            lblIluminacion.AutoSize = true;
            lblIluminacion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblIluminacion.ForeColor = Color.FromArgb(15, 45, 75);
            lblIluminacion.Location = new Point(34, 220);
            lblIluminacion.Name = "lblIluminacion";
            lblIluminacion.Size = new Size(161, 19);
            lblIluminacion.TabIndex = 12;
            lblIluminacion.Text = "Iluminación Disponible";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(18, 87, 150);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(34, 310);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(180, 40);
            btnGuardar.TabIndex = 14;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(180, 40, 40);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(34, 365);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(180, 40);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.FromArgb(18, 87, 150);
            btnLimpiar.Location = new Point(234, 365);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(180, 40);
            btnLimpiar.TabIndex = 17;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.White;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(18, 87, 150);
            btnSalir.Location = new Point(1129, 21);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(140, 38);
            btnSalir.TabIndex = 18;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // panelInferior
            // 
            panelInferior.BackColor = Color.FromArgb(18, 87, 150);
            panelInferior.Controls.Add(lblUsuarioValor);
            panelInferior.Controls.Add(lblUsuarioActivo);
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(0, 750);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(1340, 38);
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
            lblUsuarioActivo.Text = "Usuario activo: ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Natural (o Luz natural / Cenital)", "Artificial (o Luz fría / Cálida / LED)", "Mixta (combinación de ambas)" });
            comboBox1.Location = new Point(34, 254);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(380, 23);
            comboBox1.TabIndex = 23;
            // 
            // Form_Sala_VM516
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(1340, 788);
            Controls.Add(panelInferior);
            Controls.Add(panelContenedor);
            Font = new Font("Segoe UI", 9F);
            Name = "Form_Sala_VM516";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CuentaClara - Gestión de Salas Físicas";
            Load += Form_Sala_VM516_Load;
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSalas).EndInit();
            panelInferior.ResumeLayout(false);
            panelInferior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvSalas;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblAlto;
        private System.Windows.Forms.TextBox txtAlto;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lblIluminacion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Label lblUsuarioActivo;
        private System.Windows.Forms.Label lblUsuarioValor;
        private Button btn_Modificar;
        private ComboBox comboBox1;
    }
}
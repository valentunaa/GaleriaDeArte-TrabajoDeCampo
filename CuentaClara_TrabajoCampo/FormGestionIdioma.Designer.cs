//namespace IU
//{
//    partial class FormGestionIdioma
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
//            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
//            lblTitulo = new Label();
//            lblSeccionIdioma = new Label();
//            cboIdiomas = new ComboBox();
//            dgvEtiquetas = new DataGridView();
//            lblClave = new Label();
//            txtClave = new TextBox();
//            lblTexto = new Label();
//            txtTexto = new TextBox();
//            panelInferior = new Panel();
//            lblUsuarioValor = new Label();
//            lblUsuario = new Label();
//            btnNuevoIdioma = new Button();
//            btnAgregarEtiqueta = new Button();
//            btnModificarEtiqueta = new Button();
//            btnSalir = new Button();
//            btnAplicar = new Button();
//            listBox1 = new ListBox();
//            btnCancelar = new Button();
//            ((System.ComponentModel.ISupportInitialize)dgvEtiquetas).BeginInit();
//            panelInferior.SuspendLayout();
//            SuspendLayout();
//            // 
//            // lblTitulo
//            // 
//            lblTitulo.AutoSize = true;
//            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
//            lblTitulo.ForeColor = Color.FromArgb(12, 74, 144);
//            lblTitulo.Location = new Point(51, 69);
//            lblTitulo.Name = "lblTitulo";
//            lblTitulo.Size = new Size(288, 41);
//            lblTitulo.TabIndex = 0;
//            lblTitulo.Tag = "lbl_TituloGestiondeIdiomas";
//            lblTitulo.Text = "Gestión de Idiomas";
//            // 
//            // lblSeccionIdioma
//            // 
//            lblSeccionIdioma.AutoSize = true;
//            lblSeccionIdioma.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
//            lblSeccionIdioma.ForeColor = Color.FromArgb(12, 74, 144);
//            lblSeccionIdioma.Location = new Point(54, 144);
//            lblSeccionIdioma.Name = "lblSeccionIdioma";
//            lblSeccionIdioma.Size = new Size(154, 20);
//            lblSeccionIdioma.TabIndex = 1;
//            lblSeccionIdioma.Tag = "lbl_SeleccioneElIdioma";
//            lblSeccionIdioma.Text = "Seleccione el Idioma:";
//            // 
//            // cboIdiomas
//            // 
//            cboIdiomas.DropDownStyle = ComboBoxStyle.DropDownList;
//            cboIdiomas.Font = new Font("Segoe UI", 11F);
//            cboIdiomas.FormattingEnabled = true;
//            cboIdiomas.Location = new Point(249, 140);
//            cboIdiomas.Name = "cboIdiomas";
//            cboIdiomas.Size = new Size(256, 28);
//            cboIdiomas.TabIndex = 2;
//            cboIdiomas.SelectedIndexChanged += cboIdiomas_SelectedIndexChanged;
//            // 
//            // dgvEtiquetas
//            // 
//            dgvEtiquetas.AllowUserToAddRows = false;
//            dgvEtiquetas.AllowUserToDeleteRows = false;
//            dgvEtiquetas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
//            dgvEtiquetas.BackgroundColor = Color.FromArgb(12, 74, 144);
//            dgvEtiquetas.BorderStyle = BorderStyle.None;
//            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
//            dataGridViewCellStyle1.BackColor = Color.FromArgb(12, 74, 144);
//            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
//            dataGridViewCellStyle1.ForeColor = Color.White;
//            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
//            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
//            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
//            dgvEtiquetas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
//            dgvEtiquetas.ColumnHeadersHeight = 30;
//            dgvEtiquetas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
//            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
//            dataGridViewCellStyle2.BackColor = Color.White;
//            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
//            dataGridViewCellStyle2.ForeColor = Color.Black;
//            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(220, 230, 242);
//            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
//            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
//            dgvEtiquetas.DefaultCellStyle = dataGridViewCellStyle2;
//            dgvEtiquetas.EnableHeadersVisualStyles = false;
//            dgvEtiquetas.Location = new Point(55, 201);
//            dgvEtiquetas.MultiSelect = false;
//            dgvEtiquetas.Name = "dgvEtiquetas";
//            dgvEtiquetas.ReadOnly = true;
//            dgvEtiquetas.RowHeadersVisible = false;
//            dgvEtiquetas.RowHeadersWidth = 102;
//            dgvEtiquetas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
//            dgvEtiquetas.Size = new Size(875, 323);
//            dgvEtiquetas.TabIndex = 3;
//            // 
//            // lblClave
//            // 
//            lblClave.AutoSize = true;
//            lblClave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
//            lblClave.Location = new Point(51, 553);
//            lblClave.Name = "lblClave";
//            lblClave.Size = new Size(50, 19);
//            lblClave.TabIndex = 4;
//            lblClave.Tag = "Clave";
//            lblClave.Text = "Clave:";
//            // 
//            // txtClave
//            // 
//            txtClave.Font = new Font("Segoe UI", 10F);
//            txtClave.Location = new Point(55, 579);
//            txtClave.Name = "txtClave";
//            txtClave.Size = new Size(349, 25);
//            txtClave.TabIndex = 5;
//            // 
//            // lblTexto
//            // 
//            lblTexto.AutoSize = true;
//            lblTexto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
//            lblTexto.Location = new Point(51, 628);
//            lblTexto.Name = "lblTexto";
//            lblTexto.Size = new Size(50, 19);
//            lblTexto.TabIndex = 6;
//            lblTexto.Tag = "Texto";
//            lblTexto.Text = "Texto:";
//            // 
//            // txtTexto
//            // 
//            txtTexto.Font = new Font("Segoe UI", 10F);
//            txtTexto.Location = new Point(55, 654);
//            txtTexto.Name = "txtTexto";
//            txtTexto.Size = new Size(349, 25);
//            txtTexto.TabIndex = 7;
//            // 
//            // panelInferior
//            // 
//            panelInferior.BackColor = Color.FromArgb(12, 74, 144);
//            panelInferior.Controls.Add(lblUsuarioValor);
//            panelInferior.Controls.Add(lblUsuario);
//            panelInferior.Dock = DockStyle.Bottom;
//            panelInferior.Location = new Point(0, 788);
//            panelInferior.Name = "panelInferior";
//            panelInferior.Size = new Size(1314, 46);
//            panelInferior.TabIndex = 13;
//            // 
//            // lblUsuarioValor
//            // 
//            lblUsuarioValor.AutoSize = true;
//            lblUsuarioValor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
//            lblUsuarioValor.ForeColor = Color.White;
//            lblUsuarioValor.Location = new Point(133, 12);
//            lblUsuarioValor.Name = "lblUsuarioValor";
//            lblUsuarioValor.Size = new Size(199, 19);
//            lblUsuarioValor.TabIndex = 16;
//            lblUsuarioValor.Text = "Maria Lopez- Administrador";
//            // 
//            // lblUsuario
//            // 
//            lblUsuario.AutoSize = true;
//            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
//            lblUsuario.ForeColor = Color.White;
//            lblUsuario.Location = new Point(17, 12);
//            lblUsuario.Name = "lblUsuario";
//            lblUsuario.Size = new Size(113, 19);
//            lblUsuario.TabIndex = 0;
//            lblUsuario.Tag = "lbl_Usuario";
//            lblUsuario.Text = "Usuario activo: ";
//            // 
//            // btnNuevoIdioma
//            // 
//            btnNuevoIdioma.BackColor = Color.FromArgb(12, 74, 144);
//            btnNuevoIdioma.FlatStyle = FlatStyle.Flat;
//            btnNuevoIdioma.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
//            btnNuevoIdioma.ForeColor = Color.White;
//            btnNuevoIdioma.Location = new Point(955, 196);
//            btnNuevoIdioma.Name = "btnNuevoIdioma";
//            btnNuevoIdioma.Size = new Size(163, 52);
//            btnNuevoIdioma.TabIndex = 8;
//            btnNuevoIdioma.Tag = "btn_NuevoIdioma";
//            btnNuevoIdioma.Text = "Nuevo Idioma";
//            btnNuevoIdioma.UseVisualStyleBackColor = false;
//            btnNuevoIdioma.Click += btnNuevoIdioma_Click;
//            // 
//            // btnAgregarEtiqueta
//            // 
//            btnAgregarEtiqueta.BackColor = Color.White;
//            btnAgregarEtiqueta.FlatStyle = FlatStyle.Flat;
//            btnAgregarEtiqueta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
//            btnAgregarEtiqueta.ForeColor = Color.FromArgb(12, 74, 144);
//            btnAgregarEtiqueta.Location = new Point(955, 271);
//            btnAgregarEtiqueta.Name = "btnAgregarEtiqueta";
//            btnAgregarEtiqueta.Size = new Size(163, 52);
//            btnAgregarEtiqueta.TabIndex = 9;
//            btnAgregarEtiqueta.Tag = "btn_AgregarEtiqueta";
//            btnAgregarEtiqueta.Text = "Agregar Etiqueta";
//            btnAgregarEtiqueta.UseVisualStyleBackColor = false;
//            btnAgregarEtiqueta.Click += btnAgregarEtiqueta_Click;
//            // 
//            // btnModificarEtiqueta
//            // 
//            btnModificarEtiqueta.BackColor = Color.White;
//            btnModificarEtiqueta.FlatStyle = FlatStyle.Flat;
//            btnModificarEtiqueta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
//            btnModificarEtiqueta.ForeColor = Color.FromArgb(12, 74, 144);
//            btnModificarEtiqueta.Location = new Point(955, 346);
//            btnModificarEtiqueta.Name = "btnModificarEtiqueta";
//            btnModificarEtiqueta.Size = new Size(163, 52);
//            btnModificarEtiqueta.TabIndex = 10;
//            btnModificarEtiqueta.Tag = "btn_ModificarEtiqueta";
//            btnModificarEtiqueta.Text = "Modificar Etiqueta";
//            btnModificarEtiqueta.UseVisualStyleBackColor = false;
//            btnModificarEtiqueta.Click += btnModificarEtiqueta_Click;
//            // 
//            // btnSalir
//            // 
//            btnSalir.BackColor = Color.White;
//            btnSalir.FlatStyle = FlatStyle.Flat;
//            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
//            btnSalir.ForeColor = Color.FromArgb(12, 74, 144);
//            btnSalir.Location = new Point(984, 641);
//            btnSalir.Name = "btnSalir";
//            btnSalir.Size = new Size(128, 44);
//            btnSalir.TabIndex = 12;
//            btnSalir.Tag = "btn_Salir";
//            btnSalir.Text = "Salir";
//            btnSalir.UseVisualStyleBackColor = false;
//            btnSalir.Click += btnSalir_Click;
//            // 
//            // btnAplicar
//            // 
//            btnAplicar.BackColor = Color.White;
//            btnAplicar.FlatStyle = FlatStyle.Flat;
//            btnAplicar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
//            btnAplicar.ForeColor = Color.FromArgb(12, 74, 144);
//            btnAplicar.Location = new Point(512, 640);
//            btnAplicar.Name = "btnAplicar";
//            btnAplicar.Size = new Size(128, 44);
//            btnAplicar.TabIndex = 11;
//            btnAplicar.Tag = "btn_Aplicar";
//            btnAplicar.Text = "Aplicar";
//            btnAplicar.UseVisualStyleBackColor = false;
//            btnAplicar.Click += btnAplicar_Click;
//            // 
//            // listBox1
//            // 
//            listBox1.FormattingEnabled = true;
//            listBox1.ItemHeight = 15;
//            listBox1.Location = new Point(505, 545);
//            listBox1.Margin = new Padding(1);
//            listBox1.Name = "listBox1";
//            listBox1.Size = new Size(427, 79);
//            listBox1.TabIndex = 14;
//            // 
//            // btnCancelar
//            // 
//            btnCancelar.BackColor = Color.White;
//            btnCancelar.FlatStyle = FlatStyle.Flat;
//            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
//            btnCancelar.ForeColor = Color.FromArgb(12, 74, 144);
//            btnCancelar.Location = new Point(655, 640);
//            btnCancelar.Name = "btnCancelar";
//            btnCancelar.Size = new Size(128, 44);
//            btnCancelar.TabIndex = 15;
//            btnCancelar.Tag = "btn_Cancelar";
//            btnCancelar.Text = "Cancelar";
//            btnCancelar.UseVisualStyleBackColor = false;
//            // 
//            // FormGestionIdioma
//            // 
//            AutoScaleDimensions = new SizeF(7F, 15F);
//            AutoScaleMode = AutoScaleMode.Font;
//            BackColor = Color.White;
//            MaximizeBox = true;
//            ClientSize = new Size(1314, 834);
//            Controls.Add(btnCancelar);
//            Controls.Add(listBox1);
//            Controls.Add(panelInferior);
//            Controls.Add(btnSalir);
//            Controls.Add(btnAplicar);
//            Controls.Add(btnModificarEtiqueta);
//            Controls.Add(btnAgregarEtiqueta);
//            Controls.Add(btnNuevoIdioma);
//            Controls.Add(txtTexto);
//            Controls.Add(lblTexto);
//            Controls.Add(txtClave);
//            Controls.Add(lblClave);
//            Controls.Add(dgvEtiquetas);
//            Controls.Add(cboIdiomas);
//            Controls.Add(lblSeccionIdioma);
//            Controls.Add(lblTitulo);
//            FormBorderStyle = FormBorderStyle.FixedSingle;
//            MaximizeBox = false;
//            Name = "FormGestionIdioma";
//            StartPosition = FormStartPosition.CenterScreen;
//            Text = "CuentaClara - Gestión de Idioma";
//            FormClosed += FormGestionIdioma_FormClosed;
//            Load += FormGestionIdioma_Load;
//            ((System.ComponentModel.ISupportInitialize)dgvEtiquetas).EndInit();
//            panelInferior.ResumeLayout(false);
//            panelInferior.PerformLayout();
//            ResumeLayout(false);
//            PerformLayout();
//        }

//        #endregion
//        private System.Windows.Forms.Label lblTitulo;
//        private System.Windows.Forms.Label lblSeccionIdioma;
//        private System.Windows.Forms.ComboBox cboIdiomas;
//        private System.Windows.Forms.DataGridView dgvEtiquetas;
//        private System.Windows.Forms.Label lblClave;
//        private System.Windows.Forms.TextBox txtClave;
//        private System.Windows.Forms.Label lblTexto;
//        private System.Windows.Forms.TextBox txtTexto;
//        private System.Windows.Forms.Button btnNuevoIdioma;
//        private System.Windows.Forms.Button btnAgregarEtiqueta;
//        private System.Windows.Forms.Button btnModificarEtiqueta;
//        private System.Windows.Forms.Button btnAplicar;
//        private System.Windows.Forms.Button btnSalir;
//        private System.Windows.Forms.Panel panelInferior;
//        private System.Windows.Forms.Label lblUsuario;
//        private ListBox listBox1;
//        private Button btnCancelar;
//        private Label lblUsuarioValor;
//    }
//}
namespace IU
{
    partial class FormGestionIdioma
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
            lblTitulo = new Label();
            lblSeccionIdioma = new Label();
            cboIdiomas = new ComboBox();
            dgvEtiquetas = new DataGridView();
            lblClave = new Label();
            txtClave = new TextBox();
            lblTexto = new Label();
            txtTexto = new TextBox();
            panelInferior = new Panel();
            lblUsuarioValor = new Label();
            lblUsuario = new Label();
            btnNuevoIdioma = new Button();
            btnAgregarEtiqueta = new Button();
            btnModificarEtiqueta = new Button();
            btnSalir = new Button();
            btnAplicar = new Button();
            listBox1 = new ListBox();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEtiquetas).BeginInit();
            panelInferior.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(46, 17, 39);
            lblTitulo.Location = new Point(51, 69);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(288, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Tag = "lbl_TituloGestiondeIdiomas";
            lblTitulo.Text = "Gestión de Idiomas";
            // 
            // lblSeccionIdioma
            // 
            lblSeccionIdioma.AutoSize = true;
            lblSeccionIdioma.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblSeccionIdioma.ForeColor = Color.FromArgb(46, 17, 39);
            lblSeccionIdioma.Location = new Point(54, 144);
            lblSeccionIdioma.Name = "lblSeccionIdioma";
            lblSeccionIdioma.Size = new Size(154, 20);
            lblSeccionIdioma.TabIndex = 1;
            lblSeccionIdioma.Tag = "lbl_SeleccioneElIdioma";
            lblSeccionIdioma.Text = "Seleccione el Idioma:";
            // 
            // cboIdiomas
            // 
            cboIdiomas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboIdiomas.Font = new Font("Segoe UI", 11F);
            cboIdiomas.FormattingEnabled = true;
            cboIdiomas.Location = new Point(249, 140);
            cboIdiomas.Name = "cboIdiomas";
            cboIdiomas.Size = new Size(256, 28);
            cboIdiomas.TabIndex = 2;
            cboIdiomas.SelectedIndexChanged += cboIdiomas_SelectedIndexChanged;
            // 
            // dgvEtiquetas
            // 
            dgvEtiquetas.AllowUserToAddRows = false;
            dgvEtiquetas.AllowUserToDeleteRows = false;
            dgvEtiquetas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEtiquetas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEtiquetas.BackgroundColor = Color.FromArgb(46, 17, 39);
            dgvEtiquetas.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(12, 74, 144);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEtiquetas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEtiquetas.ColumnHeadersHeight = 30;
            dgvEtiquetas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(220, 230, 242);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEtiquetas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEtiquetas.EnableHeadersVisualStyles = false;
            dgvEtiquetas.Location = new Point(55, 201);
            dgvEtiquetas.MultiSelect = false;
            dgvEtiquetas.Name = "dgvEtiquetas";
            dgvEtiquetas.ReadOnly = true;
            dgvEtiquetas.RowHeadersVisible = false;
            dgvEtiquetas.RowHeadersWidth = 102;
            dgvEtiquetas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEtiquetas.Size = new Size(875, 323);
            dgvEtiquetas.TabIndex = 3;
            // 
            // lblClave
            // 
            lblClave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblClave.AutoSize = true;
            lblClave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblClave.Location = new Point(51, 553);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(50, 19);
            lblClave.TabIndex = 4;
            lblClave.Tag = "Clave";
            lblClave.Text = "Clave:";
            // 
            // txtClave
            // 
            txtClave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtClave.Font = new Font("Segoe UI", 10F);
            txtClave.Location = new Point(55, 579);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(349, 25);
            txtClave.TabIndex = 5;
            // 
            // lblTexto
            // 
            lblTexto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTexto.AutoSize = true;
            lblTexto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTexto.Location = new Point(51, 628);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(50, 19);
            lblTexto.TabIndex = 6;
            lblTexto.Tag = "Texto";
            lblTexto.Text = "Texto:";
            // 
            // txtTexto
            // 
            txtTexto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtTexto.Font = new Font("Segoe UI", 10F);
            txtTexto.Location = new Point(55, 654);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(349, 25);
            txtTexto.TabIndex = 7;
            // 
            // panelInferior
            // 
            panelInferior.BackColor = Color.FromArgb(46, 17, 39);
            panelInferior.Controls.Add(lblUsuarioValor);
            panelInferior.Controls.Add(lblUsuario);
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(0, 788);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(1314, 46);
            panelInferior.TabIndex = 13;
            // 
            // lblUsuarioValor
            // 
            lblUsuarioValor.AutoSize = true;
            lblUsuarioValor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsuarioValor.ForeColor = Color.White;
            lblUsuarioValor.Location = new Point(133, 12);
            lblUsuarioValor.Name = "lblUsuarioValor";
            lblUsuarioValor.Size = new Size(199, 19);
            lblUsuarioValor.TabIndex = 16;
            lblUsuarioValor.Text = "Maria Lopez- Administrador";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(17, 12);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(113, 19);
            lblUsuario.TabIndex = 0;
            lblUsuario.Tag = "lbl_Usuario";
            lblUsuario.Text = "Usuario activo: ";
            // 
            // btnNuevoIdioma
            // 
            btnNuevoIdioma.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevoIdioma.BackColor = Color.FromArgb(46, 17, 39);
            btnNuevoIdioma.FlatStyle = FlatStyle.Flat;
            btnNuevoIdioma.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNuevoIdioma.ForeColor = Color.White;
            btnNuevoIdioma.Location = new Point(955, 196);
            btnNuevoIdioma.Name = "btnNuevoIdioma";
            btnNuevoIdioma.Size = new Size(163, 52);
            btnNuevoIdioma.TabIndex = 8;
            btnNuevoIdioma.Tag = "btn_NuevoIdioma";
            btnNuevoIdioma.Text = "Nuevo Idioma";
            btnNuevoIdioma.UseVisualStyleBackColor = false;
            btnNuevoIdioma.Click += btnNuevoIdioma_Click;
            // 
            // btnAgregarEtiqueta
            // 
            btnAgregarEtiqueta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAgregarEtiqueta.BackColor = Color.White;
            btnAgregarEtiqueta.FlatStyle = FlatStyle.Flat;
            btnAgregarEtiqueta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAgregarEtiqueta.ForeColor = Color.FromArgb(46, 17, 39);
            btnAgregarEtiqueta.Location = new Point(955, 271);
            btnAgregarEtiqueta.Name = "btnAgregarEtiqueta";
            btnAgregarEtiqueta.Size = new Size(163, 52);
            btnAgregarEtiqueta.TabIndex = 9;
            btnAgregarEtiqueta.Tag = "btn_AgregarEtiqueta";
            btnAgregarEtiqueta.Text = "Agregar Etiqueta";
            btnAgregarEtiqueta.UseVisualStyleBackColor = false;
            btnAgregarEtiqueta.Click += btnAgregarEtiqueta_Click;
            // 
            // btnModificarEtiqueta
            // 
            btnModificarEtiqueta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnModificarEtiqueta.BackColor = Color.White;
            btnModificarEtiqueta.FlatStyle = FlatStyle.Flat;
            btnModificarEtiqueta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnModificarEtiqueta.ForeColor = Color.FromArgb(46, 17, 39);
            btnModificarEtiqueta.Location = new Point(955, 346);
            btnModificarEtiqueta.Name = "btnModificarEtiqueta";
            btnModificarEtiqueta.Size = new Size(163, 52);
            btnModificarEtiqueta.TabIndex = 10;
            btnModificarEtiqueta.Tag = "btn_ModificarEtiqueta";
            btnModificarEtiqueta.Text = "Modificar Etiqueta";
            btnModificarEtiqueta.UseVisualStyleBackColor = false;
            btnModificarEtiqueta.Click += btnModificarEtiqueta_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.BackColor = Color.White;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(46, 17, 39);
            btnSalir.Location = new Point(984, 641);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(128, 44);
            btnSalir.TabIndex = 12;
            btnSalir.Tag = "btn_Salir";
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAplicar
            // 
            btnAplicar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAplicar.BackColor = Color.White;
            btnAplicar.FlatStyle = FlatStyle.Flat;
            btnAplicar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAplicar.ForeColor = Color.FromArgb(46, 17, 39);
            btnAplicar.Location = new Point(512, 640);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(128, 44);
            btnAplicar.TabIndex = 11;
            btnAplicar.Tag = "btn_Aplicar";
            btnAplicar.Text = "Aplicar";
            btnAplicar.UseVisualStyleBackColor = false;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(505, 545);
            listBox1.Margin = new Padding(1);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(427, 79);
            listBox1.TabIndex = 14;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelar.BackColor = Color.White;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.FromArgb(46, 17, 39);
            btnCancelar.Location = new Point(655, 640);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(128, 44);
            btnCancelar.TabIndex = 15;
            btnCancelar.Tag = "btn_Cancelar";
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // FormGestionIdioma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1314, 834);
            Controls.Add(btnCancelar);
            Controls.Add(listBox1);
            Controls.Add(panelInferior);
            Controls.Add(btnSalir);
            Controls.Add(btnAplicar);
            Controls.Add(btnModificarEtiqueta);
            Controls.Add(btnAgregarEtiqueta);
            Controls.Add(btnNuevoIdioma);
            Controls.Add(txtTexto);
            Controls.Add(lblTexto);
            Controls.Add(txtClave);
            Controls.Add(lblClave);
            Controls.Add(dgvEtiquetas);
            Controls.Add(cboIdiomas);
            Controls.Add(lblSeccionIdioma);
            Controls.Add(lblTitulo);
            Name = "FormGestionIdioma";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "lbl_FormGestionIdioma";
            Text = "CuentaClara - Gestión de Idioma";
            FormClosed += FormGestionIdioma_FormClosed;
            Load += FormGestionIdioma_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEtiquetas).EndInit();
            panelInferior.ResumeLayout(false);
            panelInferior.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSeccionIdioma;
        private System.Windows.Forms.ComboBox cboIdiomas;
        private System.Windows.Forms.DataGridView dgvEtiquetas;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button btnNuevoIdioma;
        private System.Windows.Forms.Button btnAgregarEtiqueta;
        private System.Windows.Forms.Button btnModificarEtiqueta;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Label lblUsuario;
        private ListBox listBox1;
        private Button btnCancelar;
        private Label lblUsuarioValor;
    }
}
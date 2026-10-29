namespace IU
{
    partial class Form_Auditoria_Especificacion_Obra_VM516
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
            lblCantRegistrosValor = new Label();
            lblCantRegistrosEtiqueta = new Label();
            lblTitulo = new Label();
            dgvBitacoraObra = new DataGridView();
            lblIdObra = new Label();
            txtIdObra = new TextBox();
            lblTituloObra = new Label();
            txtTituloObra = new TextBox();
            lblFechaInicio = new Label();
            dtpFechaInicio = new DateTimePicker();
            lblFechaFin = new Label();
            dtpFechaFin = new DateTimePicker();
            btnLimpiar = new Button();
            btnAplicar = new Button();
            btnActivar = new Button();
            btnSalir = new Button();
            panelInferior = new Panel();
            lblUsuarioValor = new Label();
            lblUsuarioActivo = new Label();
            toolTipAudit = new ToolTip(components);
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBitacoraObra).BeginInit();
            panelInferior.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.Anchor = AnchorStyles.None;
            panelContenedor.AutoScroll = true;
            panelContenedor.BackColor = Color.White;
            panelContenedor.Controls.Add(lblCantRegistrosValor);
            panelContenedor.Controls.Add(lblCantRegistrosEtiqueta);
            panelContenedor.Controls.Add(lblTitulo);
            panelContenedor.Controls.Add(dgvBitacoraObra);
            panelContenedor.Controls.Add(lblIdObra);
            panelContenedor.Controls.Add(txtIdObra);
            panelContenedor.Controls.Add(lblTituloObra);
            panelContenedor.Controls.Add(txtTituloObra);
            panelContenedor.Controls.Add(lblFechaInicio);
            panelContenedor.Controls.Add(dtpFechaInicio);
            panelContenedor.Controls.Add(lblFechaFin);
            panelContenedor.Controls.Add(dtpFechaFin);
            panelContenedor.Controls.Add(btnLimpiar);
            panelContenedor.Controls.Add(btnAplicar);
            panelContenedor.Controls.Add(btnActivar);
            panelContenedor.Controls.Add(btnSalir);
            panelContenedor.Location = new Point(31, 29);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1265, 743);
            panelContenedor.TabIndex = 1;
            // 
            // lblCantRegistrosValor
            // 
            lblCantRegistrosValor.AutoSize = true;
            lblCantRegistrosValor.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCantRegistrosValor.ForeColor = Color.FromArgb(15, 45, 75);
            lblCantRegistrosValor.Location = new Point(230, 435);
            lblCantRegistrosValor.Name = "lblCantRegistrosValor";
            lblCantRegistrosValor.Size = new Size(17, 19);
            lblCantRegistrosValor.TabIndex = 24;
            lblCantRegistrosValor.Text = "0";
            // 
            // lblCantRegistrosEtiqueta
            // 
            lblCantRegistrosEtiqueta.AutoSize = true;
            lblCantRegistrosEtiqueta.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCantRegistrosEtiqueta.ForeColor = Color.FromArgb(46, 17, 39);
            lblCantRegistrosEtiqueta.Location = new Point(50, 435);
            lblCantRegistrosEtiqueta.Name = "lblCantRegistrosEtiqueta";
            lblCantRegistrosEtiqueta.Size = new Size(160, 19);
            lblCantRegistrosEtiqueta.TabIndex = 25;
            lblCantRegistrosEtiqueta.Tag = "lbl_CantRegistros";
            lblCantRegistrosEtiqueta.Text = "Cantidad de Registros:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(46, 17, 39);
            lblTitulo.Location = new Point(50, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(357, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Tag = "lbl_TituloBitacoraObra";
            lblTitulo.Text = "Bitácora de Cambios de Obras";
            // 
            // dgvBitacoraObra
            // 
            dgvBitacoraObra.AllowUserToAddRows = false;
            dgvBitacoraObra.AllowUserToDeleteRows = false;
            dgvBitacoraObra.AllowUserToResizeRows = false;
            dgvBitacoraObra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBitacoraObra.BackgroundColor = Color.FromArgb(46, 17, 39);
            dgvBitacoraObra.BorderStyle = BorderStyle.None;
            dgvBitacoraObra.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBitacoraObra.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(18, 87, 150);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBitacoraObra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBitacoraObra.ColumnHeadersHeight = 45;
            dgvBitacoraObra.EnableHeadersVisualStyles = false;
            dgvBitacoraObra.GridColor = Color.FromArgb(220, 220, 220);
            dgvBitacoraObra.Location = new Point(50, 70);
            dgvBitacoraObra.MultiSelect = false;
            dgvBitacoraObra.Name = "dgvBitacoraObra";
            dgvBitacoraObra.ReadOnly = true;
            dgvBitacoraObra.RowHeadersVisible = false;
            dgvBitacoraObra.RowTemplate.Height = 28;
            dgvBitacoraObra.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBitacoraObra.Size = new Size(1140, 350);
            dgvBitacoraObra.TabIndex = 1;
            // 
            // lblIdObra
            // 
            lblIdObra.AutoSize = true;
            lblIdObra.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblIdObra.ForeColor = Color.FromArgb(46, 17, 39);
            lblIdObra.Location = new Point(50, 485);
            lblIdObra.Name = "lblIdObra";
            lblIdObra.Size = new Size(65, 19);
            lblIdObra.TabIndex = 2;
            lblIdObra.Tag = "lbl_IdObra";
            lblIdObra.Text = "ID Obra:";
            // 
            // txtIdObra
            // 
            txtIdObra.BorderStyle = BorderStyle.FixedSingle;
            txtIdObra.Font = new Font("Segoe UI", 10F);
            txtIdObra.Location = new Point(50, 510);
            txtIdObra.Name = "txtIdObra";
            txtIdObra.Size = new Size(220, 25);
            txtIdObra.TabIndex = 3;
            // 
            // lblTituloObra
            // 
            lblTituloObra.AutoSize = true;
            lblTituloObra.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTituloObra.ForeColor = Color.FromArgb(46, 17, 39);
            lblTituloObra.Location = new Point(300, 485);
            lblTituloObra.Name = "lblTituloObra";
            lblTituloObra.Size = new Size(89, 19);
            lblTituloObra.TabIndex = 4;
            lblTituloObra.Tag = "lbl_TituloObraFiltro";
            lblTituloObra.Text = "Título Obra:";
            // 
            // txtTituloObra
            // 
            txtTituloObra.BorderStyle = BorderStyle.FixedSingle;
            txtTituloObra.Font = new Font("Segoe UI", 10F);
            txtTituloObra.Location = new Point(300, 510);
            txtTituloObra.Name = "txtTituloObra";
            txtTituloObra.Size = new Size(220, 25);
            txtTituloObra.TabIndex = 5;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFechaInicio.ForeColor = Color.FromArgb(46, 17, 39);
            lblFechaInicio.Location = new Point(550, 485);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(95, 19);
            lblFechaInicio.TabIndex = 8;
            lblFechaInicio.Tag = "lbl_FechaDesde";
            lblFechaInicio.Text = "Fecha desde:";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Font = new Font("Segoe UI", 10F);
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(550, 510);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(180, 25);
            dtpFechaInicio.TabIndex = 9;
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFechaFin.ForeColor = Color.FromArgb(46, 17, 39);
            lblFechaFin.Location = new Point(750, 485);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(90, 19);
            lblFechaFin.TabIndex = 10;
            lblFechaFin.Tag = "lbl_FechaHasta";
            lblFechaFin.Text = "Fecha hasta:";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Font = new Font("Segoe UI", 10F);
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(750, 510);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(180, 25);
            dtpFechaFin.TabIndex = 11;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.White;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.FromArgb(46, 17, 39);
            btnLimpiar.Location = new Point(180, 575);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(110, 38);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.Tag = "btn_Limpiar";
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // btnAplicar
            // 
            btnAplicar.BackColor = Color.FromArgb(46, 17, 39);
            btnAplicar.FlatAppearance.BorderSize = 0;
            btnAplicar.FlatStyle = FlatStyle.Flat;
            btnAplicar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAplicar.ForeColor = Color.White;
            btnAplicar.Location = new Point(50, 575);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(110, 38);
            btnAplicar.TabIndex = 20;
            btnAplicar.Tag = "btn_Aplicar";
            btnAplicar.Text = "Aplicar";
            btnAplicar.UseVisualStyleBackColor = false;
            btnAplicar.Click += btnAplicar_Click_1;
            // 
            // btnActivar
            // 
            btnActivar.BackColor = Color.FromArgb(18, 120, 50);
            btnActivar.FlatStyle = FlatStyle.Flat;
            btnActivar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnActivar.ForeColor = Color.White;
            btnActivar.Location = new Point(329, 575);
            btnActivar.Name = "btnActivar";
            btnActivar.Size = new Size(121, 38);
            btnActivar.TabIndex = 21;
            btnActivar.Tag = "btn_Activar";
            btnActivar.Text = "Activar";
            btnActivar.UseVisualStyleBackColor = false;
            btnActivar.Click += btnActivar_Click_1;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.White;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(46, 17, 39);
            btnSalir.Location = new Point(1050, 20);
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
            panelInferior.Size = new Size(1325, 38);
            panelInferior.TabIndex = 0;
            // 
            // lblUsuarioValor
            // 
            lblUsuarioValor.AutoSize = true;
            lblUsuarioValor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuarioValor.ForeColor = Color.White;
            lblUsuarioValor.Location = new Point(114, 10);
            lblUsuarioValor.Name = "lblUsuarioValor";
            lblUsuarioValor.Size = new Size(164, 15);
            lblUsuarioValor.TabIndex = 1;
            lblUsuarioValor.Text = "Maria Lopez - Administrador";
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
            // toolTipAudit
            // 
            toolTipAudit.AutoPopDelay = 5000;
            toolTipAudit.InitialDelay = 100;
            toolTipAudit.ReshowDelay = 100;
            // 
            // Form_Auditoria_Especificacion_Obra_VM516
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(1325, 803);
            Controls.Add(panelInferior);
            Controls.Add(panelContenedor);
            Font = new Font("Segoe UI", 9F);
            Name = "Form_Auditoria_Especificacion_Obra_VM516";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "lbl_FormBitacoraObra";
            Text = "Vanguardia Arte - Auditoría de Cambios de Obras";
            FormClosed += Form_Auditoria_Especificacion_Obra_VM516_FormClosed;
            Load += Form_Auditoria_Especificacion_Obra_VM516_Load;
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBitacoraObra).EndInit();
            panelInferior.ResumeLayout(false);
            panelInferior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvBitacoraObra;
        private System.Windows.Forms.Label lblIdObra;
        private System.Windows.Forms.TextBox txtIdObra;
        private System.Windows.Forms.Label lblTituloObra;
        private System.Windows.Forms.TextBox txtTituloObra;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Label lblUsuarioActivo;
        private System.Windows.Forms.Label lblUsuarioValor;
        private System.Windows.Forms.Label lblCantRegistrosValor;
        private System.Windows.Forms.Label lblCantRegistrosEtiqueta;
        private ToolTip toolTipAudit;
    }
}
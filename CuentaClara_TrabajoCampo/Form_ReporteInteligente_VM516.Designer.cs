namespace IU
{
    partial class Form_ReporteInteligente_VM516
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelContenedor_VM516 = new Panel();
            picLogo = new PictureBox();
            lblTitulo_VM516 = new Label();
            btnSalir_VM516 = new Button();
            panelFiltros_VM516 = new Panel();
            panelAcento1_VM516 = new Panel();
            lblSeleccionarReporte_VM516 = new Label();
            cmbTipoReporte_VM516 = new ComboBox();
            btnExportarPdf_VM516 = new Button();
            dgvReporteInteligente_VM516 = new DataGridView();
            panelInferior_VM516 = new Panel();
            lblUsuarioValor_VM516 = new Label();
            lblUsuarioActivo_VM516 = new Label();
            toolTipReporte = new ToolTip(components);
            panelContenedor_VM516.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelFiltros_VM516.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporteInteligente_VM516).BeginInit();
            panelInferior_VM516.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor_VM516
            // 
            panelContenedor_VM516.Anchor = AnchorStyles.None;
            panelContenedor_VM516.BackColor = Color.FromArgb(245, 246, 248);
            panelContenedor_VM516.Controls.Add(picLogo);
            panelContenedor_VM516.Controls.Add(lblTitulo_VM516);
            panelContenedor_VM516.Controls.Add(btnSalir_VM516);
            panelContenedor_VM516.Controls.Add(panelFiltros_VM516);
            panelContenedor_VM516.Controls.Add(dgvReporteInteligente_VM516);
            panelContenedor_VM516.Location = new Point(10, 12);
            panelContenedor_VM516.Name = "panelContenedor_VM516";
            panelContenedor_VM516.Size = new Size(1451, 735);
            panelContenedor_VM516.TabIndex = 1;
            // 
            // picLogo
            // 
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Image = Properties.Resources.ImagenLogo;
            picLogo.Location = new Point(34, 16);
            picLogo.Margin = new Padding(0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(63, 60);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 27;
            picLogo.TabStop = false;
            // 
            // lblTitulo_VM516
            // 
            lblTitulo_VM516.AutoSize = true;
            lblTitulo_VM516.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitulo_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            lblTitulo_VM516.Location = new Point(102, 30);
            lblTitulo_VM516.Name = "lblTitulo_VM516";
            lblTitulo_VM516.Size = new Size(294, 41);
            lblTitulo_VM516.TabIndex = 1;
            lblTitulo_VM516.Tag = "titulo_FormReporteInteligente";
            lblTitulo_VM516.Text = "Reporte Inteligente";
            // 
            // btnSalir_VM516
            // 
            btnSalir_VM516.BackColor = Color.White;
            btnSalir_VM516.FlatAppearance.BorderColor = Color.Black;
            btnSalir_VM516.FlatStyle = FlatStyle.Flat;
            btnSalir_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalir_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            btnSalir_VM516.Location = new Point(1280, 36);
            btnSalir_VM516.Name = "btnSalir_VM516";
            btnSalir_VM516.Size = new Size(140, 40);
            btnSalir_VM516.TabIndex = 2;
            btnSalir_VM516.Tag = "btn_Salir";
            btnSalir_VM516.Text = "Salir";
            toolTipReporte.SetToolTip(btnSalir_VM516, "Cierra la ventana actual del reporte inteligente");
            btnSalir_VM516.UseVisualStyleBackColor = false;
            btnSalir_VM516.Click += btnSalir_VM516_Click;
            // 
            // panelFiltros_VM516
            // 
            panelFiltros_VM516.BackColor = Color.White;
            panelFiltros_VM516.Controls.Add(panelAcento1_VM516);
            panelFiltros_VM516.Controls.Add(lblSeleccionarReporte_VM516);
            panelFiltros_VM516.Controls.Add(cmbTipoReporte_VM516);
            panelFiltros_VM516.Controls.Add(btnExportarPdf_VM516);
            panelFiltros_VM516.Location = new Point(34, 110);
            panelFiltros_VM516.Name = "panelFiltros_VM516";
            panelFiltros_VM516.Size = new Size(1386, 110);
            panelFiltros_VM516.TabIndex = 2;
            // 
            // panelAcento1_VM516
            // 
            panelAcento1_VM516.BackColor = Color.FromArgb(18, 87, 150);
            panelAcento1_VM516.Dock = DockStyle.Top;
            panelAcento1_VM516.Location = new Point(0, 0);
            panelAcento1_VM516.Name = "panelAcento1_VM516";
            panelAcento1_VM516.Size = new Size(1386, 4);
            panelAcento1_VM516.TabIndex = 0;
            // 
            // lblSeleccionarReporte_VM516
            // 
            lblSeleccionarReporte_VM516.AutoSize = true;
            lblSeleccionarReporte_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSeleccionarReporte_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            lblSeleccionarReporte_VM516.Location = new Point(20, 22);
            lblSeleccionarReporte_VM516.Name = "lblSeleccionarReporte_VM516";
            lblSeleccionarReporte_VM516.Size = new Size(197, 19);
            lblSeleccionarReporte_VM516.TabIndex = 1;
            lblSeleccionarReporte_VM516.Tag = "lbl_SeleccionarReporte";
            lblSeleccionarReporte_VM516.Text = "Seleccione Tipo de Reporte:";
            // 
            // cmbTipoReporte_VM516
            // 
            cmbTipoReporte_VM516.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoReporte_VM516.Font = new Font("Segoe UI", 11F);
            cmbTipoReporte_VM516.FormattingEnabled = true;
            cmbTipoReporte_VM516.Location = new Point(20, 48);
            cmbTipoReporte_VM516.Name = "cmbTipoReporte_VM516";
            cmbTipoReporte_VM516.Size = new Size(400, 28);
            cmbTipoReporte_VM516.TabIndex = 2;
            toolTipReporte.SetToolTip(cmbTipoReporte_VM516, "Seleccione el proceso de negocio a analizar en el reporte inteligente");
            cmbTipoReporte_VM516.SelectedIndexChanged += cmbTipoReporte_VM516_SelectedIndexChanged;
            // 
            // btnExportarPdf_VM516
            // 
            btnExportarPdf_VM516.BackColor = Color.FromArgb(18, 87, 150);
            btnExportarPdf_VM516.FlatAppearance.BorderSize = 0;
            btnExportarPdf_VM516.FlatStyle = FlatStyle.Flat;
            btnExportarPdf_VM516.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnExportarPdf_VM516.ForeColor = Color.White;
            btnExportarPdf_VM516.Location = new Point(440, 43);
            btnExportarPdf_VM516.Name = "btnExportarPdf_VM516";
            btnExportarPdf_VM516.Size = new Size(220, 36);
            btnExportarPdf_VM516.TabIndex = 3;
            btnExportarPdf_VM516.Tag = "btn_ExportarPdf";
            btnExportarPdf_VM516.Text = "📄 Exportar a PDF";
            toolTipReporte.SetToolTip(btnExportarPdf_VM516, "Genera y exporta el informe analítico de las tablas integradas a formato PDF");
            btnExportarPdf_VM516.UseVisualStyleBackColor = false;
            btnExportarPdf_VM516.Click += btnExportarPdf_VM516_Click;
            // 
            // dgvReporteInteligente_VM516
            // 
            dgvReporteInteligente_VM516.AllowUserToAddRows = false;
            dgvReporteInteligente_VM516.AllowUserToDeleteRows = false;
            dgvReporteInteligente_VM516.AllowUserToResizeRows = false;
            dgvReporteInteligente_VM516.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReporteInteligente_VM516.BackgroundColor = Color.White;
            dgvReporteInteligente_VM516.BorderStyle = BorderStyle.None;
            dgvReporteInteligente_VM516.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReporteInteligente_VM516.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(46, 17, 39);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(46, 17, 39);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgvReporteInteligente_VM516.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvReporteInteligente_VM516.ColumnHeadersHeight = 45;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(235, 240, 245);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(18, 87, 150);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvReporteInteligente_VM516.DefaultCellStyle = dataGridViewCellStyle4;
            dgvReporteInteligente_VM516.EnableHeadersVisualStyles = false;
            dgvReporteInteligente_VM516.GridColor = Color.FromArgb(230, 230, 230);
            dgvReporteInteligente_VM516.Location = new Point(34, 245);
            dgvReporteInteligente_VM516.MultiSelect = false;
            dgvReporteInteligente_VM516.Name = "dgvReporteInteligente_VM516";
            dgvReporteInteligente_VM516.ReadOnly = true;
            dgvReporteInteligente_VM516.RowHeadersVisible = false;
            dgvReporteInteligente_VM516.RowTemplate.Height = 35;
            dgvReporteInteligente_VM516.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReporteInteligente_VM516.Size = new Size(1386, 455);
            dgvReporteInteligente_VM516.TabIndex = 6;
            toolTipReporte.SetToolTip(dgvReporteInteligente_VM516, "Listado consolidado de indicadores extraídos de las tablas integradas de la BD");
            // 
            // panelInferior_VM516
            // 
            panelInferior_VM516.BackColor = Color.FromArgb(46, 17, 39);
            panelInferior_VM516.Controls.Add(lblUsuarioValor_VM516);
            panelInferior_VM516.Controls.Add(lblUsuarioActivo_VM516);
            panelInferior_VM516.Dock = DockStyle.Bottom;
            panelInferior_VM516.Location = new Point(0, 750);
            panelInferior_VM516.Name = "panelInferior_VM516";
            panelInferior_VM516.Size = new Size(1464, 38);
            panelInferior_VM516.TabIndex = 0;
            // 
            // lblUsuarioValor_VM516
            // 
            lblUsuarioValor_VM516.AutoSize = true;
            lblUsuarioValor_VM516.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuarioValor_VM516.ForeColor = Color.White;
            lblUsuarioValor_VM516.Location = new Point(114, 10);
            lblUsuarioValor_VM516.Name = "lblUsuarioValor_VM516";
            lblUsuarioValor_VM516.Size = new Size(57, 15);
            lblUsuarioValor_VM516.TabIndex = 0;
            lblUsuarioValor_VM516.Text = "[Usuario]";
            // 
            // lblUsuarioActivo_VM516
            // 
            lblUsuarioActivo_VM516.AutoSize = true;
            lblUsuarioActivo_VM516.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuarioActivo_VM516.ForeColor = Color.White;
            lblUsuarioActivo_VM516.Location = new Point(20, 10);
            lblUsuarioActivo_VM516.Name = "lblUsuarioActivo_VM516";
            lblUsuarioActivo_VM516.Size = new Size(92, 15);
            lblUsuarioActivo_VM516.TabIndex = 1;
            lblUsuarioActivo_VM516.Tag = "lbl_Usuario";
            lblUsuarioActivo_VM516.Text = "Usuario activo: ";
            // 
            // toolTipReporte
            // 
            toolTipReporte.AutoPopDelay = 5000;
            toolTipReporte.InitialDelay = 100;
            toolTipReporte.ReshowDelay = 100;
            // 
            // Form_ReporteInteligente_VM516
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 238, 242);
            ClientSize = new Size(1464, 788);
            Controls.Add(panelInferior_VM516);
            Controls.Add(panelContenedor_VM516);
            Font = new Font("Segoe UI", 9F);
            Name = "Form_ReporteInteligente_VM516";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vanguardia Arte - Reporte Inteligente de Negocio";
            Load += Form_ReporteInteligente_VM516_Load;
            panelContenedor_VM516.ResumeLayout(false);
            panelContenedor_VM516.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelFiltros_VM516.ResumeLayout(false);
            panelFiltros_VM516.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporteInteligente_VM516).EndInit();
            panelInferior_VM516.ResumeLayout(false);
            panelInferior_VM516.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor_VM516;
        private System.Windows.Forms.Panel panelFiltros_VM516;
        private System.Windows.Forms.Panel panelAcento1_VM516;
        private System.Windows.Forms.Label lblTitulo_VM516;
        private System.Windows.Forms.Button btnSalir_VM516;
        private System.Windows.Forms.Label lblSeleccionarReporte_VM516;
        private System.Windows.Forms.ComboBox cmbTipoReporte_VM516;
        private System.Windows.Forms.Button btnExportarPdf_VM516;
        private System.Windows.Forms.DataGridView dgvReporteInteligente_VM516;
        private System.Windows.Forms.Panel panelInferior_VM516;
        private System.Windows.Forms.Label lblUsuarioActivo_VM516;
        private System.Windows.Forms.Label lblUsuarioValor_VM516;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.ToolTip toolTipReporte;
    }
}
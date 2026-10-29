namespace IU
{
    partial class Form_Historial_Entregados_VM516
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
            panelContenedor_VM516 = new Panel();
            picLogo_VM516 = new PictureBox();
            lblTitulo_VM516 = new Label();
            lblFiltro_VM516 = new Label();
            txtFiltro_VM516 = new TextBox();
            btnFiltrar_VM516 = new Button();
            btnLimpiar_VM516 = new Button();
            btnSalir_VM516 = new Button();
            dgvEntregados_VM516 = new DataGridView();
            toolTipHistorialEntregados = new ToolTip(components);
            panelContenedor_VM516.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo_VM516).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEntregados_VM516).BeginInit();
            SuspendLayout();
            // 
            // panelContenedor_VM516
            // 
            panelContenedor_VM516.Anchor = AnchorStyles.None;
            panelContenedor_VM516.BackColor = Color.White;
            panelContenedor_VM516.Controls.Add(picLogo_VM516);
            panelContenedor_VM516.Controls.Add(lblTitulo_VM516);
            panelContenedor_VM516.Controls.Add(lblFiltro_VM516);
            panelContenedor_VM516.Controls.Add(txtFiltro_VM516);
            panelContenedor_VM516.Controls.Add(btnFiltrar_VM516);
            panelContenedor_VM516.Controls.Add(btnLimpiar_VM516);
            panelContenedor_VM516.Controls.Add(btnSalir_VM516);
            panelContenedor_VM516.Controls.Add(dgvEntregados_VM516);
            panelContenedor_VM516.Location = new Point(20, 20);
            panelContenedor_VM516.Name = "panelContenedor_VM516";
            panelContenedor_VM516.Size = new Size(1020, 610);
            panelContenedor_VM516.TabIndex = 0;
            // 
            // picLogo_VM516
            // 
            picLogo_VM516.BorderStyle = BorderStyle.FixedSingle;
            picLogo_VM516.Image = Properties.Resources.ImagenLogo;
            picLogo_VM516.Location = new Point(34, 20);
            picLogo_VM516.Margin = new Padding(0);
            picLogo_VM516.Name = "picLogo_VM516";
            picLogo_VM516.Size = new Size(63, 60);
            picLogo_VM516.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo_VM516.TabIndex = 10;
            picLogo_VM516.TabStop = false;
            // 
            // lblTitulo_VM516
            // 
            lblTitulo_VM516.AutoSize = true;
            lblTitulo_VM516.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            lblTitulo_VM516.Location = new Point(108, 32);
            lblTitulo_VM516.Name = "lblTitulo_VM516";
            lblTitulo_VM516.Size = new Size(379, 32);
            lblTitulo_VM516.TabIndex = 0;
            lblTitulo_VM516.Tag = "titulo_FormHistorialEntregados";
            lblTitulo_VM516.Text = "Historial de Pedidos Entregados";
            // 
            // lblFiltro_VM516
            // 
            lblFiltro_VM516.AutoSize = true;
            lblFiltro_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFiltro_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            lblFiltro_VM516.Location = new Point(34, 105);
            lblFiltro_VM516.Name = "lblFiltro_VM516";
            lblFiltro_VM516.Size = new Size(266, 19);
            lblFiltro_VM516.TabIndex = 1;
            lblFiltro_VM516.Tag = "lbl_FiltroEntregados";
            lblFiltro_VM516.Text = "Filtrar por N° de Pedido o DNI Cliente:";
            lblFiltro_VM516.TextChanged += lblFiltro_VM516_TextChanged;
            // 
            // txtFiltro_VM516
            // 
            txtFiltro_VM516.BorderStyle = BorderStyle.FixedSingle;
            txtFiltro_VM516.Font = new Font("Segoe UI", 10F);
            txtFiltro_VM516.Location = new Point(34, 130);
            txtFiltro_VM516.Name = "txtFiltro_VM516";
            txtFiltro_VM516.Size = new Size(280, 25);
            txtFiltro_VM516.TabIndex = 2;
            // 
            // btnFiltrar_VM516
            // 
            btnFiltrar_VM516.BackColor = Color.FromArgb(46, 17, 39);
            btnFiltrar_VM516.FlatAppearance.BorderSize = 0;
            btnFiltrar_VM516.FlatStyle = FlatStyle.Flat;
            btnFiltrar_VM516.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnFiltrar_VM516.ForeColor = Color.White;
            btnFiltrar_VM516.Location = new Point(328, 128);
            btnFiltrar_VM516.Name = "btnFiltrar_VM516";
            btnFiltrar_VM516.Size = new Size(120, 29);
            btnFiltrar_VM516.TabIndex = 3;
            btnFiltrar_VM516.Tag = "btn_Filtrar";
            btnFiltrar_VM516.Text = "Filtrar";
            btnFiltrar_VM516.UseVisualStyleBackColor = false;
            btnFiltrar_VM516.Click += btnFiltrar_VM516_Click;
            // 
            // btnLimpiar_VM516
            // 
            btnLimpiar_VM516.BackColor = Color.FromArgb(18, 87, 150);
            btnLimpiar_VM516.FlatAppearance.BorderSize = 0;
            btnLimpiar_VM516.FlatStyle = FlatStyle.Flat;
            btnLimpiar_VM516.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLimpiar_VM516.ForeColor = Color.White;
            btnLimpiar_VM516.Location = new Point(460, 128);
            btnLimpiar_VM516.Name = "btnLimpiar_VM516";
            btnLimpiar_VM516.Size = new Size(120, 29);
            btnLimpiar_VM516.TabIndex = 4;
            btnLimpiar_VM516.Tag = "btn_LimpiarFiltro";
            btnLimpiar_VM516.Text = "Ver Todos";
            btnLimpiar_VM516.UseVisualStyleBackColor = false;
            btnLimpiar_VM516.Click += btnLimpiar_VM516_Click;
            // 
            // btnSalir_VM516
            // 
            btnSalir_VM516.BackColor = Color.White;
            btnSalir_VM516.FlatStyle = FlatStyle.Flat;
            btnSalir_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalir_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            btnSalir_VM516.Location = new Point(846, 28);
            btnSalir_VM516.Name = "btnSalir_VM516";
            btnSalir_VM516.Size = new Size(140, 38);
            btnSalir_VM516.TabIndex = 5;
            btnSalir_VM516.Tag = "btn_Salir";
            btnSalir_VM516.Text = "Salir";
            btnSalir_VM516.UseVisualStyleBackColor = false;
            btnSalir_VM516.Click += btnSalir_VM516_Click;
            // 
            // dgvEntregados_VM516
            // 
            dgvEntregados_VM516.AllowUserToAddRows = false;
            dgvEntregados_VM516.AllowUserToDeleteRows = false;
            dgvEntregados_VM516.AllowUserToResizeRows = false;
            dgvEntregados_VM516.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEntregados_VM516.BackgroundColor = Color.FromArgb(46, 17, 39);
            dgvEntregados_VM516.BorderStyle = BorderStyle.None;
            dgvEntregados_VM516.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEntregados_VM516.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 17, 39);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEntregados_VM516.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEntregados_VM516.ColumnHeadersHeight = 45;
            dgvEntregados_VM516.EnableHeadersVisualStyles = false;
            dgvEntregados_VM516.GridColor = Color.FromArgb(220, 220, 220);
            dgvEntregados_VM516.Location = new Point(34, 175);
            dgvEntregados_VM516.MultiSelect = false;
            dgvEntregados_VM516.Name = "dgvEntregados_VM516";
            dgvEntregados_VM516.ReadOnly = true;
            dgvEntregados_VM516.RowHeadersVisible = false;
            dgvEntregados_VM516.RowTemplate.Height = 28;
            dgvEntregados_VM516.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEntregados_VM516.Size = new Size(952, 405);
            dgvEntregados_VM516.TabIndex = 6;
            // 
            // toolTipHistorialEntregados
            // 
            toolTipHistorialEntregados.AutoPopDelay = 5000;
            toolTipHistorialEntregados.InitialDelay = 100;
            toolTipHistorialEntregados.ReshowDelay = 100;
            // 
            // Form_Historial_Entregados_VM516
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(1060, 650);
            Controls.Add(panelContenedor_VM516);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form_Historial_Entregados_VM516";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Historial de Pedidos Entregados";
            FormClosed += Form_Historial_Entregados_VM516_FormClosed;
            Load += Form_Historial_Entregados_VM516_Load;
            panelContenedor_VM516.ResumeLayout(false);
            panelContenedor_VM516.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo_VM516).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEntregados_VM516).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor_VM516;
        private System.Windows.Forms.PictureBox picLogo_VM516;
        private System.Windows.Forms.Label lblTitulo_VM516;
        private System.Windows.Forms.Label lblFiltro_VM516;
        private System.Windows.Forms.TextBox txtFiltro_VM516;
        private System.Windows.Forms.Button btnFiltrar_VM516;
        private System.Windows.Forms.Button btnLimpiar_VM516;
        private System.Windows.Forms.Button btnSalir_VM516;
        private System.Windows.Forms.DataGridView dgvEntregados_VM516;
        private ToolTip toolTipHistorialEntregados;
    }
}
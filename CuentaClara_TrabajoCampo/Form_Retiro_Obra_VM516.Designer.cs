namespace IU
{
    partial class Form_Retiro_Obra_VM516
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
            picLogo = new PictureBox();
            lblTitulo = new Label();
            dgvRetiros = new DataGridView();
            lblCodigoReserva = new Label();
            txtCodigoReserva = new TextBox();
            btnBuscarReserva = new Button();
            lblInfoReserva = new Label();
            lblDniResponsable = new Label();
            txtDniResponsable = new TextBox();
            btnRegistrarDesmontaje = new Button();
            btnSalir = new Button();
            panelInferior = new Panel();
            lblUsuarioValor = new Label();
            lblUsuarioActivo = new Label();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRetiros).BeginInit();
            panelInferior.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.Anchor = AnchorStyles.None;
            panelContenedor.BackColor = Color.White;
            panelContenedor.Controls.Add(picLogo);
            panelContenedor.Controls.Add(lblTitulo);
            panelContenedor.Controls.Add(dgvRetiros);
            panelContenedor.Controls.Add(lblCodigoReserva);
            panelContenedor.Controls.Add(txtCodigoReserva);
            panelContenedor.Controls.Add(btnBuscarReserva);
            panelContenedor.Controls.Add(lblInfoReserva);
            panelContenedor.Controls.Add(lblDniResponsable);
            panelContenedor.Controls.Add(txtDniResponsable);
            panelContenedor.Controls.Add(btnRegistrarDesmontaje);
            panelContenedor.Controls.Add(btnSalir);
            panelContenedor.Location = new Point(12, 12);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1316, 745);
            panelContenedor.TabIndex = 1;
            // 
            // picLogo
            // 
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Image = Properties.Resources.ImagenLogo;
            picLogo.Location = new Point(34, 10);
            picLogo.Margin = new Padding(0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(63, 60);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 26;
            picLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(46, 17, 39);
            lblTitulo.Location = new Point(102, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(358, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Tag = "titulo_FormRetiroObra";
            lblTitulo.Text = "Registrar Desmontaje de Obra";
            // 
            // dgvRetiros
            // 
            dgvRetiros.AllowUserToAddRows = false;
            dgvRetiros.AllowUserToDeleteRows = false;
            dgvRetiros.AllowUserToResizeRows = false;
            dgvRetiros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRetiros.BackgroundColor = Color.FromArgb(46, 17, 39);
            dgvRetiros.BorderStyle = BorderStyle.None;
            dgvRetiros.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRetiros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(18, 87, 150);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRetiros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRetiros.ColumnHeadersHeight = 58;
            dgvRetiros.EnableHeadersVisualStyles = false;
            dgvRetiros.GridColor = Color.FromArgb(220, 220, 220);
            dgvRetiros.Location = new Point(480, 129);
            dgvRetiros.MultiSelect = false;
            dgvRetiros.Name = "dgvRetiros";
            dgvRetiros.ReadOnly = true;
            dgvRetiros.RowHeadersVisible = false;
            dgvRetiros.RowHeadersWidth = 102;
            dgvRetiros.RowTemplate.Height = 28;
            dgvRetiros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRetiros.Size = new Size(789, 531);
            dgvRetiros.TabIndex = 21;
            // 
            // lblCodigoReserva
            // 
            lblCodigoReserva.AutoSize = true;
            lblCodigoReserva.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCodigoReserva.ForeColor = Color.FromArgb(46, 17, 39);
            lblCodigoReserva.Location = new Point(34, 129);
            lblCodigoReserva.Name = "lblCodigoReserva";
            lblCodigoReserva.Size = new Size(116, 19);
            lblCodigoReserva.TabIndex = 2;
            lblCodigoReserva.Tag = "lbl_CodigoReserva";
            lblCodigoReserva.Text = "Código Reserva";
            // 
            // txtCodigoReserva
            // 
            txtCodigoReserva.BorderStyle = BorderStyle.FixedSingle;
            txtCodigoReserva.Font = new Font("Segoe UI", 10F);
            txtCodigoReserva.Location = new Point(34, 154);
            txtCodigoReserva.Name = "txtCodigoReserva";
            txtCodigoReserva.Size = new Size(180, 25);
            txtCodigoReserva.TabIndex = 3;
            // 
            // btnBuscarReserva
            // 
            btnBuscarReserva.BackColor = Color.FromArgb(46, 17, 39);
            btnBuscarReserva.FlatAppearance.BorderSize = 0;
            btnBuscarReserva.FlatStyle = FlatStyle.Flat;
            btnBuscarReserva.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBuscarReserva.ForeColor = Color.White;
            btnBuscarReserva.Location = new Point(230, 152);
            btnBuscarReserva.Name = "btnBuscarReserva";
            btnBuscarReserva.Size = new Size(140, 28);
            btnBuscarReserva.TabIndex = 4;
            btnBuscarReserva.Tag = "btn_BuscarReserva";
            btnBuscarReserva.Text = "Buscar Reserva";
            btnBuscarReserva.UseVisualStyleBackColor = false;
            btnBuscarReserva.Click += btnBuscarReserva_Click;
            // 
            // lblInfoReserva
            // 
            lblInfoReserva.AutoSize = true;
            lblInfoReserva.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblInfoReserva.ForeColor = Color.FromArgb(15, 45, 75);
            lblInfoReserva.Location = new Point(34, 194);
            lblInfoReserva.Name = "lblInfoReserva";
            lblInfoReserva.Size = new Size(231, 17);
            lblInfoReserva.TabIndex = 5;
            lblInfoReserva.Tag = "lbl_InfoReservaPendiente";
            lblInfoReserva.Text = "Información de reserva: [Pendiente]";
            // 
            // lblDniResponsable
            // 
            lblDniResponsable.AutoSize = true;
            lblDniResponsable.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDniResponsable.ForeColor = Color.FromArgb(46, 17, 39);
            lblDniResponsable.Location = new Point(34, 250);
            lblDniResponsable.Name = "lblDniResponsable";
            lblDniResponsable.Size = new Size(205, 19);
            lblDniResponsable.TabIndex = 6;
            lblDniResponsable.Tag = "lbl_DniResponsableDesmontaje";
            lblDniResponsable.Text = "DNI Responsable Desmontaje";
            // 
            // txtDniResponsable
            // 
            txtDniResponsable.BorderStyle = BorderStyle.FixedSingle;
            txtDniResponsable.Font = new Font("Segoe UI", 10F);
            txtDniResponsable.Location = new Point(34, 275);
            txtDniResponsable.Name = "txtDniResponsable";
            txtDniResponsable.Size = new Size(336, 25);
            txtDniResponsable.TabIndex = 7;
            // 
            // btnRegistrarDesmontaje
            // 
            btnRegistrarDesmontaje.BackColor = Color.FromArgb(46, 17, 39);
            btnRegistrarDesmontaje.FlatAppearance.BorderSize = 0;
            btnRegistrarDesmontaje.FlatStyle = FlatStyle.Flat;
            btnRegistrarDesmontaje.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegistrarDesmontaje.ForeColor = Color.White;
            btnRegistrarDesmontaje.Location = new Point(34, 340);
            btnRegistrarDesmontaje.Name = "btnRegistrarDesmontaje";
            btnRegistrarDesmontaje.Size = new Size(336, 40);
            btnRegistrarDesmontaje.TabIndex = 22;
            btnRegistrarDesmontaje.Tag = "btn_RegistrarDesmontaje";
            btnRegistrarDesmontaje.Text = "Registrar Desmontaje y Liberar Espacio";
            btnRegistrarDesmontaje.UseVisualStyleBackColor = false;
            btnRegistrarDesmontaje.Click += btnRegistrarDesmontaje_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.White;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(46, 17, 39);
            btnSalir.Location = new Point(1129, 21);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(140, 38);
            btnSalir.TabIndex = 23;
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
            // Form_Retiro_Obra_VM516
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(1340, 788);
            Controls.Add(panelInferior);
            Controls.Add(panelContenedor);
            Font = new Font("Segoe UI", 9F);
            Name = "Form_Retiro_Obra_VM516";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vanguardia Arte - Registrar Desmontaje de Obra";
            FormClosed += Form_Retiro_Obra_VM516_FormClosed;
            Load += Form_Retiro_Obra_VM516_Load;
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRetiros).EndInit();
            panelInferior.ResumeLayout(false);
            panelInferior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvRetiros;
        private System.Windows.Forms.Label lblCodigoReserva;
        private System.Windows.Forms.TextBox txtCodigoReserva;
        private System.Windows.Forms.Button btnBuscarReserva;
        private System.Windows.Forms.Label lblInfoReserva;
        private System.Windows.Forms.Label lblDniResponsable;
        private System.Windows.Forms.TextBox txtDniResponsable;
        private System.Windows.Forms.Button btnRegistrarDesmontaje;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Label lblUsuarioActivo;
        private System.Windows.Forms.Label lblUsuarioValor;
        private System.Windows.Forms.PictureBox picLogo;
    }
}
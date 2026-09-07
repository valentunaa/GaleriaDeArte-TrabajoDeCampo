namespace IU
{
    partial class Form_Reserva_Sala_VM516
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
            button1 = new Button();
            lblTitulo = new Label();
            dgvSalas = new DataGridView();
            lblIdObra = new Label();
            txtIdObra = new TextBox();
            lblFechaInicio = new Label();
            dtpFechaInicio = new DateTimePicker();
            lblFechaFin = new Label();
            dtpFechaFin = new DateTimePicker();
            btnConsultarDisponibilidad = new Button();
            lblMontoTotal = new Label();
            txtMontoTotal = new TextBox();
            lblPorcentajeSena = new Label();
            txtPorcentajeSena = new TextBox();
            btnConfirmarReserva = new Button();
            btnSalir = new Button();
            panelInferior = new Panel();
            lblUsuarioValor = new Label();
            lblUsuarioActivo = new Label();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSalas).BeginInit();
            panelInferior.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.Anchor = AnchorStyles.None;
            panelContenedor.BackColor = Color.White;
            panelContenedor.Controls.Add(button1);
            panelContenedor.Controls.Add(lblTitulo);
            panelContenedor.Controls.Add(dgvSalas);
            panelContenedor.Controls.Add(lblIdObra);
            panelContenedor.Controls.Add(txtIdObra);
            panelContenedor.Controls.Add(lblFechaInicio);
            panelContenedor.Controls.Add(dtpFechaInicio);
            panelContenedor.Controls.Add(lblFechaFin);
            panelContenedor.Controls.Add(dtpFechaFin);
            panelContenedor.Controls.Add(btnConsultarDisponibilidad);
            panelContenedor.Controls.Add(lblMontoTotal);
            panelContenedor.Controls.Add(txtMontoTotal);
            panelContenedor.Controls.Add(lblPorcentajeSena);
            panelContenedor.Controls.Add(txtPorcentajeSena);
            panelContenedor.Controls.Add(btnConfirmarReserva);
            panelContenedor.Controls.Add(btnSalir);
            panelContenedor.Location = new Point(12, 12);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1557, 745);
            panelContenedor.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(18, 87, 150);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(34, 465);
            button1.Name = "button1";
            button1.Size = new Size(380, 40);
            button1.TabIndex = 22;
            button1.Text = "Ver Historial de Reservas";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(20, 70, 120);
            lblTitulo.Location = new Point(30, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(213, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registrar Reserva";
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
            dgvSalas.Size = new Size(1063, 580);
            dgvSalas.TabIndex = 21;
            // 
            // lblIdObra
            // 
            lblIdObra.AutoSize = true;
            lblIdObra.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblIdObra.ForeColor = Color.FromArgb(15, 45, 75);
            lblIdObra.Location = new Point(34, 80);
            lblIdObra.Name = "lblIdObra";
            lblIdObra.Size = new Size(61, 19);
            lblIdObra.TabIndex = 2;
            lblIdObra.Text = "ID Obra";
            // 
            // txtIdObra
            // 
            txtIdObra.BorderStyle = BorderStyle.FixedSingle;
            txtIdObra.Font = new Font("Segoe UI", 10F);
            txtIdObra.Location = new Point(34, 105);
            txtIdObra.Name = "txtIdObra";
            txtIdObra.Size = new Size(180, 25);
            txtIdObra.TabIndex = 3;
            txtIdObra.TextChanged += txtIdObra_TextChanged;
            // 
            // lblFechaInicio
            // 
            lblFechaInicio.AutoSize = true;
            lblFechaInicio.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFechaInicio.ForeColor = Color.FromArgb(15, 45, 75);
            lblFechaInicio.Location = new Point(34, 150);
            lblFechaInicio.Name = "lblFechaInicio";
            lblFechaInicio.Size = new Size(87, 19);
            lblFechaInicio.TabIndex = 4;
            lblFechaInicio.Text = "Fecha Inicio";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Font = new Font("Segoe UI", 10F);
            dtpFechaInicio.Format = DateTimePickerFormat.Short;
            dtpFechaInicio.Location = new Point(34, 175);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(180, 25);
            dtpFechaInicio.TabIndex = 5;
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFechaFin.ForeColor = Color.FromArgb(15, 45, 75);
            lblFechaFin.Location = new Point(234, 150);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(70, 19);
            lblFechaFin.TabIndex = 6;
            lblFechaFin.Text = "Fecha Fin";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Font = new Font("Segoe UI", 10F);
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(234, 175);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(180, 25);
            dtpFechaFin.TabIndex = 7;
            // 
            // btnConsultarDisponibilidad
            // 
            btnConsultarDisponibilidad.BackColor = Color.FromArgb(18, 87, 150);
            btnConsultarDisponibilidad.FlatAppearance.BorderSize = 0;
            btnConsultarDisponibilidad.FlatStyle = FlatStyle.Flat;
            btnConsultarDisponibilidad.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConsultarDisponibilidad.ForeColor = Color.White;
            btnConsultarDisponibilidad.Location = new Point(34, 225);
            btnConsultarDisponibilidad.Name = "btnConsultarDisponibilidad";
            btnConsultarDisponibilidad.Size = new Size(380, 38);
            btnConsultarDisponibilidad.TabIndex = 8;
            btnConsultarDisponibilidad.Text = "Consultar Disponibilidad de Salas";
            btnConsultarDisponibilidad.UseVisualStyleBackColor = false;
            btnConsultarDisponibilidad.Click += btnConsultarDisponibilidad_Click;
            // 
            // lblMontoTotal
            // 
            lblMontoTotal.AutoSize = true;
            lblMontoTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMontoTotal.ForeColor = Color.FromArgb(15, 45, 75);
            lblMontoTotal.Location = new Point(34, 300);
            lblMontoTotal.Name = "lblMontoTotal";
            lblMontoTotal.Size = new Size(147, 19);
            lblMontoTotal.TabIndex = 9;
            lblMontoTotal.Text = "Monto Total Alquiler";
            // 
            // txtMontoTotal
            // 
            txtMontoTotal.BorderStyle = BorderStyle.FixedSingle;
            txtMontoTotal.Font = new Font("Segoe UI", 10F);
            txtMontoTotal.Location = new Point(34, 325);
            txtMontoTotal.Name = "txtMontoTotal";
            txtMontoTotal.Size = new Size(180, 25);
            txtMontoTotal.TabIndex = 10;
            // 
            // lblPorcentajeSena
            // 
            lblPorcentajeSena.AutoSize = true;
            lblPorcentajeSena.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPorcentajeSena.ForeColor = Color.FromArgb(15, 45, 75);
            lblPorcentajeSena.Location = new Point(234, 300);
            lblPorcentajeSena.Name = "lblPorcentajeSena";
            lblPorcentajeSena.Size = new Size(117, 19);
            lblPorcentajeSena.TabIndex = 11;
            lblPorcentajeSena.Text = "Porcentaje Seña";
            // 
            // txtPorcentajeSena
            // 
            txtPorcentajeSena.BorderStyle = BorderStyle.FixedSingle;
            txtPorcentajeSena.Font = new Font("Segoe UI", 10F);
            txtPorcentajeSena.Location = new Point(234, 325);
            txtPorcentajeSena.Name = "txtPorcentajeSena";
            txtPorcentajeSena.Size = new Size(180, 25);
            txtPorcentajeSena.TabIndex = 12;
            // 
            // btnConfirmarReserva
            // 
            btnConfirmarReserva.BackColor = Color.FromArgb(18, 87, 150);
            btnConfirmarReserva.FlatAppearance.BorderSize = 0;
            btnConfirmarReserva.FlatStyle = FlatStyle.Flat;
            btnConfirmarReserva.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConfirmarReserva.ForeColor = Color.White;
            btnConfirmarReserva.Location = new Point(34, 390);
            btnConfirmarReserva.Name = "btnConfirmarReserva";
            btnConfirmarReserva.Size = new Size(380, 40);
            btnConfirmarReserva.TabIndex = 13;
            btnConfirmarReserva.Text = "Confirmar Reserva";
            btnConfirmarReserva.UseVisualStyleBackColor = false;
            btnConfirmarReserva.Click += btnConfirmarReserva_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.White;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalir.ForeColor = Color.FromArgb(18, 87, 150);
            btnSalir.Location = new Point(1339, 20);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(140, 38);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // panelInferior
            // 
            panelInferior.BackColor = Color.FromArgb(18, 87, 150);
            panelInferior.Controls.Add(lblUsuarioValor);
            panelInferior.Controls.Add(lblUsuarioActivo);
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(0, 750);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(1581, 38);
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
            // Form_Reserva_Sala_VM516
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(1581, 788);
            Controls.Add(panelInferior);
            Controls.Add(panelContenedor);
            Font = new Font("Segoe UI", 9F);
            Name = "Form_Reserva_Sala_VM516";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CuentaClara - Registrar Reserva";
            Load += Form_Reserva_Sala_VM516_Load;
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
        private System.Windows.Forms.Label lblIdObra;
        private System.Windows.Forms.TextBox txtIdObra;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.Button btnConsultarDisponibilidad;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Label lblPorcentajeSena;
        private System.Windows.Forms.TextBox txtPorcentajeSena;
        private System.Windows.Forms.Button btnConfirmarReserva;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Label lblUsuarioActivo;
        private System.Windows.Forms.Label lblUsuarioValor;
        private Button button1;
    }
}
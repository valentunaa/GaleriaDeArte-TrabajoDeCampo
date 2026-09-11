namespace IU
{
    partial class Form_Inspeccion_Obra_VM516
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
            dgvInspecciones = new DataGridView();
            btnConfirmarPeritaje = new Button();
            txtObservaciones = new TextBox();
            lblObservaciones = new Label();
            cboEstadoExhibicion = new ComboBox();
            lblEstadoExhibicion = new Label();
            lblInfoReserva = new Label();
            btnBuscarReserva = new Button();
            txtCodigoReserva = new TextBox();
            lblCodigoReserva = new Label();
            btnSalir = new Button();
            lblTitulo = new Label();
            panelInferior = new Panel();
            lblUsuarioValor = new Label();
            lblUsuarioActivo = new Label();
            panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInspecciones).BeginInit();
            panelInferior.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.Anchor = AnchorStyles.None;
            panelContenedor.BackColor = Color.White;
            panelContenedor.Controls.Add(dgvInspecciones);
            panelContenedor.Controls.Add(btnConfirmarPeritaje);
            panelContenedor.Controls.Add(txtObservaciones);
            panelContenedor.Controls.Add(lblObservaciones);
            panelContenedor.Controls.Add(cboEstadoExhibicion);
            panelContenedor.Controls.Add(lblEstadoExhibicion);
            panelContenedor.Controls.Add(lblInfoReserva);
            panelContenedor.Controls.Add(btnBuscarReserva);
            panelContenedor.Controls.Add(txtCodigoReserva);
            panelContenedor.Controls.Add(lblCodigoReserva);
            panelContenedor.Controls.Add(btnSalir);
            panelContenedor.Controls.Add(lblTitulo);
            panelContenedor.Location = new Point(12, 12);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1316, 745);
            panelContenedor.TabIndex = 1;
            // 
            // dgvInspecciones
            // 
            dgvInspecciones.AllowUserToAddRows = false;
            dgvInspecciones.AllowUserToDeleteRows = false;
            dgvInspecciones.AllowUserToResizeRows = false;
            dgvInspecciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInspecciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInspecciones.BackgroundColor = Color.FromArgb(18, 87, 150);
            dgvInspecciones.BorderStyle = BorderStyle.None;
            dgvInspecciones.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvInspecciones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(18, 87, 150);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInspecciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInspecciones.ColumnHeadersHeight = 45;
            dgvInspecciones.EnableHeadersVisualStyles = false;
            dgvInspecciones.GridColor = Color.FromArgb(220, 220, 220);
            dgvInspecciones.Location = new Point(34, 380);
            dgvInspecciones.MultiSelect = false;
            dgvInspecciones.Name = "dgvInspecciones";
            dgvInspecciones.ReadOnly = true;
            dgvInspecciones.RowHeadersVisible = false;
            dgvInspecciones.RowTemplate.Height = 28;
            dgvInspecciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInspecciones.Size = new Size(1235, 335);
            dgvInspecciones.TabIndex = 11;
            // 
            // btnConfirmarPeritaje
            // 
            btnConfirmarPeritaje.BackColor = Color.FromArgb(18, 87, 150);
            btnConfirmarPeritaje.Enabled = false;
            btnConfirmarPeritaje.FlatAppearance.BorderSize = 0;
            btnConfirmarPeritaje.FlatStyle = FlatStyle.Flat;
            btnConfirmarPeritaje.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConfirmarPeritaje.ForeColor = Color.White;
            btnConfirmarPeritaje.Location = new Point(1079, 320);
            btnConfirmarPeritaje.Name = "btnConfirmarPeritaje";
            btnConfirmarPeritaje.Size = new Size(190, 40);
            btnConfirmarPeritaje.TabIndex = 10;
            btnConfirmarPeritaje.Text = "Confirmar Peritaje";
            btnConfirmarPeritaje.UseVisualStyleBackColor = false;
            btnConfirmarPeritaje.Click += btnConfirmarPeritaje_Click;
            // 
            // txtObservaciones
            // 
            txtObservaciones.BorderStyle = BorderStyle.FixedSingle;
            txtObservaciones.Enabled = false;
            txtObservaciones.Font = new Font("Segoe UI", 10F);
            txtObservaciones.Location = new Point(270, 220);
            txtObservaciones.Multiline = true;
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(999, 85);
            txtObservaciones.TabIndex = 9;
            // 
            // lblObservaciones
            // 
            lblObservaciones.AutoSize = true;
            lblObservaciones.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblObservaciones.ForeColor = Color.FromArgb(15, 45, 75);
            lblObservaciones.Location = new Point(270, 195);
            lblObservaciones.Name = "lblObservaciones";
            lblObservaciones.Size = new Size(154, 19);
            lblObservaciones.TabIndex = 8;
            lblObservaciones.Text = "Observaciones Físicas";
            // 
            // cboEstadoExhibicion
            // 
            cboEstadoExhibicion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstadoExhibicion.Enabled = false;
            cboEstadoExhibicion.Font = new Font("Segoe UI", 10F);
            cboEstadoExhibicion.Items.AddRange(new object[] { "Intacto", "Dañado" });
            cboEstadoExhibicion.Location = new Point(34, 220);
            cboEstadoExhibicion.Name = "cboEstadoExhibicion";
            cboEstadoExhibicion.Size = new Size(220, 25);
            cboEstadoExhibicion.TabIndex = 7;
            // 
            // lblEstadoExhibicion
            // 
            lblEstadoExhibicion.AutoSize = true;
            lblEstadoExhibicion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEstadoExhibicion.ForeColor = Color.FromArgb(15, 45, 75);
            lblEstadoExhibicion.Location = new Point(34, 195);
            lblEstadoExhibicion.Name = "lblEstadoExhibicion";
            lblEstadoExhibicion.Size = new Size(159, 19);
            lblEstadoExhibicion.TabIndex = 6;
            lblEstadoExhibicion.Text = "Estado Post-Exhibición";
            // 
            // lblInfoReserva
            // 
            lblInfoReserva.AutoSize = true;
            lblInfoReserva.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            lblInfoReserva.ForeColor = Color.FromArgb(50, 50, 50);
            lblInfoReserva.Location = new Point(34, 150);
            lblInfoReserva.Name = "lblInfoReserva";
            lblInfoReserva.Size = new Size(245, 19);
            lblInfoReserva.TabIndex = 5;
            lblInfoReserva.Text = "Información de la reserva: [Pendiente]";
            // 
            // btnBuscarReserva
            // 
            btnBuscarReserva.BackColor = Color.FromArgb(18, 87, 150);
            btnBuscarReserva.FlatAppearance.BorderSize = 0;
            btnBuscarReserva.FlatStyle = FlatStyle.Flat;
            btnBuscarReserva.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBuscarReserva.ForeColor = Color.White;
            btnBuscarReserva.Location = new Point(270, 98);
            btnBuscarReserva.Name = "btnBuscarReserva";
            btnBuscarReserva.Size = new Size(130, 35);
            btnBuscarReserva.TabIndex = 4;
            btnBuscarReserva.Text = "Buscar Reserva";
            btnBuscarReserva.UseVisualStyleBackColor = false;
            btnBuscarReserva.Click += btnBuscarReserva_Click;
            // 
            // txtCodigoReserva
            // 
            txtCodigoReserva.BorderStyle = BorderStyle.FixedSingle;
            txtCodigoReserva.Font = new Font("Segoe UI", 10F);
            txtCodigoReserva.Location = new Point(34, 105);
            txtCodigoReserva.Name = "txtCodigoReserva";
            txtCodigoReserva.Size = new Size(220, 25);
            txtCodigoReserva.TabIndex = 3;
            // 
            // lblCodigoReserva
            // 
            lblCodigoReserva.AutoSize = true;
            lblCodigoReserva.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCodigoReserva.ForeColor = Color.FromArgb(15, 45, 75);
            lblCodigoReserva.Location = new Point(34, 80);
            lblCodigoReserva.Name = "lblCodigoReserva";
            lblCodigoReserva.Size = new Size(137, 19);
            lblCodigoReserva.TabIndex = 2;
            lblCodigoReserva.Text = "Código de Reserva";
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
            btnSalir.TabIndex = 22;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(20, 70, 120);
            lblTitulo.Location = new Point(30, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(292, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Registro Post-Exhibición";
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
            lblUsuarioValor.Size = new Size(78, 15);
            lblUsuarioValor.TabIndex = 1;
            lblUsuarioValor.Text = "Usuario - Rol";
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
            // Form_Inspeccion_Obra_VM516
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(1340, 788);
            Controls.Add(panelInferior);
            Controls.Add(panelContenedor);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form_Inspeccion_Obra_VM516";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Peritaje Post-Exhibición";
            Load += Form_Inspeccion_Obra_VM516_Load;
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInspecciones).EndInit();
            panelInferior.ResumeLayout(false);
            panelInferior.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblCodigoReserva;
        private System.Windows.Forms.TextBox txtCodigoReserva;
        private System.Windows.Forms.Button btnBuscarReserva;
        private System.Windows.Forms.Label lblInfoReserva;
        private System.Windows.Forms.Label lblEstadoExhibicion;
        private System.Windows.Forms.ComboBox cboEstadoExhibicion;
        private System.Windows.Forms.Label lblObservaciones;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnConfirmarPeritaje;
        private System.Windows.Forms.DataGridView dgvInspecciones;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Label lblUsuarioActivo;
        private System.Windows.Forms.Label lblUsuarioValor;
    }
}
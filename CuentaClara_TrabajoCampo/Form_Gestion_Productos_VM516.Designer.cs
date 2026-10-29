namespace IU
{
    partial class Form_Gestion_Productos_VM516
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
            lblCodigoProducto_VM516 = new Label();
            txtCodigoProducto_VM516 = new TextBox();
            lblDescripcion_VM516 = new Label();
            txtDescripcion_VM516 = new TextBox();
            lblStockDisponible_VM516 = new Label();
            txtStockDisponible_VM516 = new TextBox();
            lblPrecioVigente_VM516 = new Label();
            txtPrecioVigente_VM516 = new TextBox();
            btnGuardar_VM516 = new Button();
            btnModificar_VM516 = new Button();
            btnEliminar_VM516 = new Button();
            btnLimpiar_VM516 = new Button();
            btnSalir_VM516 = new Button();
            dgvProductos_VM516 = new DataGridView();
            panelInferior_VM516 = new Panel();
            lblUsuarioValor_VM516 = new Label();
            lblUsuarioActivo_VM516 = new Label();
            toolTipGestionProd = new ToolTip(components);
            panelContenedor_VM516.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo_VM516).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos_VM516).BeginInit();
            panelInferior_VM516.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor_VM516
            // 
            panelContenedor_VM516.Anchor = AnchorStyles.None;
            panelContenedor_VM516.BackColor = Color.White;
            panelContenedor_VM516.Controls.Add(picLogo_VM516);
            panelContenedor_VM516.Controls.Add(lblTitulo_VM516);
            panelContenedor_VM516.Controls.Add(lblCodigoProducto_VM516);
            panelContenedor_VM516.Controls.Add(txtCodigoProducto_VM516);
            panelContenedor_VM516.Controls.Add(lblDescripcion_VM516);
            panelContenedor_VM516.Controls.Add(txtDescripcion_VM516);
            panelContenedor_VM516.Controls.Add(lblStockDisponible_VM516);
            panelContenedor_VM516.Controls.Add(txtStockDisponible_VM516);
            panelContenedor_VM516.Controls.Add(lblPrecioVigente_VM516);
            panelContenedor_VM516.Controls.Add(txtPrecioVigente_VM516);
            panelContenedor_VM516.Controls.Add(btnGuardar_VM516);
            panelContenedor_VM516.Controls.Add(btnModificar_VM516);
            panelContenedor_VM516.Controls.Add(btnEliminar_VM516);
            panelContenedor_VM516.Controls.Add(btnLimpiar_VM516);
            panelContenedor_VM516.Controls.Add(btnSalir_VM516);
            panelContenedor_VM516.Controls.Add(dgvProductos_VM516);
            panelContenedor_VM516.Location = new Point(20, 12);
            panelContenedor_VM516.Name = "panelContenedor_VM516";
            panelContenedor_VM516.Size = new Size(1566, 745);
            panelContenedor_VM516.TabIndex = 1;
            // 
            // picLogo_VM516
            // 
            picLogo_VM516.BorderStyle = BorderStyle.FixedSingle;
            picLogo_VM516.Image = Properties.Resources.ImagenLogo;
            picLogo_VM516.Location = new Point(34, 15);
            picLogo_VM516.Margin = new Padding(0);
            picLogo_VM516.Name = "picLogo_VM516";
            picLogo_VM516.Size = new Size(63, 60);
            picLogo_VM516.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo_VM516.TabIndex = 20;
            picLogo_VM516.TabStop = false;
            // 
            // lblTitulo_VM516
            // 
            lblTitulo_VM516.AutoSize = true;
            lblTitulo_VM516.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            lblTitulo_VM516.Location = new Point(108, 25);
            lblTitulo_VM516.Name = "lblTitulo_VM516";
            lblTitulo_VM516.Size = new Size(404, 32);
            lblTitulo_VM516.TabIndex = 0;
            lblTitulo_VM516.Tag = "titulo_FormGestionProductos";
            lblTitulo_VM516.Text = "Gestión de Productos de Cafetería";
            // 
            // lblCodigoProducto_VM516
            // 
            lblCodigoProducto_VM516.AutoSize = true;
            lblCodigoProducto_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCodigoProducto_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            lblCodigoProducto_VM516.Location = new Point(34, 115);
            lblCodigoProducto_VM516.Name = "lblCodigoProducto_VM516";
            lblCodigoProducto_VM516.Size = new Size(145, 19);
            lblCodigoProducto_VM516.TabIndex = 1;
            lblCodigoProducto_VM516.Tag = "lbl_CodigoProducto";
            lblCodigoProducto_VM516.Text = "Código de Producto";
            // 
            // txtCodigoProducto_VM516
            // 
            txtCodigoProducto_VM516.BorderStyle = BorderStyle.FixedSingle;
            txtCodigoProducto_VM516.Font = new Font("Segoe UI", 10F);
            txtCodigoProducto_VM516.Location = new Point(34, 140);
            txtCodigoProducto_VM516.Name = "txtCodigoProducto_VM516";
            txtCodigoProducto_VM516.Size = new Size(380, 25);
            txtCodigoProducto_VM516.TabIndex = 2;
            // 
            // lblDescripcion_VM516
            // 
            lblDescripcion_VM516.AutoSize = true;
            lblDescripcion_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDescripcion_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            lblDescripcion_VM516.Location = new Point(34, 185);
            lblDescripcion_VM516.Name = "lblDescripcion_VM516";
            lblDescripcion_VM516.Size = new Size(178, 19);
            lblDescripcion_VM516.TabIndex = 3;
            lblDescripcion_VM516.Tag = "lbl_DescripcionProducto";
            lblDescripcion_VM516.Text = "Descripción del Producto";
            // 
            // txtDescripcion_VM516
            // 
            txtDescripcion_VM516.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion_VM516.Font = new Font("Segoe UI", 10F);
            txtDescripcion_VM516.Location = new Point(34, 210);
            txtDescripcion_VM516.Name = "txtDescripcion_VM516";
            txtDescripcion_VM516.Size = new Size(380, 25);
            txtDescripcion_VM516.TabIndex = 4;
            // 
            // lblStockDisponible_VM516
            // 
            lblStockDisponible_VM516.AutoSize = true;
            lblStockDisponible_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStockDisponible_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            lblStockDisponible_VM516.Location = new Point(34, 255);
            lblStockDisponible_VM516.Name = "lblStockDisponible_VM516";
            lblStockDisponible_VM516.Size = new Size(121, 19);
            lblStockDisponible_VM516.TabIndex = 5;
            lblStockDisponible_VM516.Tag = "StockDisponible_VM516";
            lblStockDisponible_VM516.Text = "Stock Disponible";
            // 
            // txtStockDisponible_VM516
            // 
            txtStockDisponible_VM516.BorderStyle = BorderStyle.FixedSingle;
            txtStockDisponible_VM516.Font = new Font("Segoe UI", 10F);
            txtStockDisponible_VM516.Location = new Point(34, 280);
            txtStockDisponible_VM516.Name = "txtStockDisponible_VM516";
            txtStockDisponible_VM516.Size = new Size(380, 25);
            txtStockDisponible_VM516.TabIndex = 6;
            // 
            // lblPrecioVigente_VM516
            // 
            lblPrecioVigente_VM516.AutoSize = true;
            lblPrecioVigente_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPrecioVigente_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            lblPrecioVigente_VM516.Location = new Point(34, 325);
            lblPrecioVigente_VM516.Name = "lblPrecioVigente_VM516";
            lblPrecioVigente_VM516.Size = new Size(107, 19);
            lblPrecioVigente_VM516.TabIndex = 7;
            lblPrecioVigente_VM516.Tag = "PrecioVigente_VM516";
            lblPrecioVigente_VM516.Text = "Precio Vigente";
            // 
            // txtPrecioVigente_VM516
            // 
            txtPrecioVigente_VM516.BorderStyle = BorderStyle.FixedSingle;
            txtPrecioVigente_VM516.Font = new Font("Segoe UI", 10F);
            txtPrecioVigente_VM516.Location = new Point(34, 350);
            txtPrecioVigente_VM516.Name = "txtPrecioVigente_VM516";
            txtPrecioVigente_VM516.Size = new Size(380, 25);
            txtPrecioVigente_VM516.TabIndex = 8;
            // 
            // btnGuardar_VM516
            // 
            btnGuardar_VM516.BackColor = Color.FromArgb(46, 17, 39);
            btnGuardar_VM516.FlatAppearance.BorderSize = 0;
            btnGuardar_VM516.FlatStyle = FlatStyle.Flat;
            btnGuardar_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardar_VM516.ForeColor = Color.White;
            btnGuardar_VM516.Location = new Point(34, 415);
            btnGuardar_VM516.Name = "btnGuardar_VM516";
            btnGuardar_VM516.Size = new Size(185, 40);
            btnGuardar_VM516.TabIndex = 9;
            btnGuardar_VM516.Tag = "btn_GuardarSala";
            btnGuardar_VM516.Text = "Guardar";
            btnGuardar_VM516.UseVisualStyleBackColor = false;
            btnGuardar_VM516.Click += btnGuardar_VM516_Click;
            // 
            // btnModificar_VM516
            // 
            btnModificar_VM516.BackColor = Color.FromArgb(18, 87, 150);
            btnModificar_VM516.FlatAppearance.BorderSize = 0;
            btnModificar_VM516.FlatStyle = FlatStyle.Flat;
            btnModificar_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnModificar_VM516.ForeColor = Color.White;
            btnModificar_VM516.Location = new Point(229, 415);
            btnModificar_VM516.Name = "btnModificar_VM516";
            btnModificar_VM516.Size = new Size(185, 40);
            btnModificar_VM516.TabIndex = 10;
            btnModificar_VM516.Tag = "btn_ModificarSala";
            btnModificar_VM516.Text = "Modificar";
            btnModificar_VM516.UseVisualStyleBackColor = false;
            btnModificar_VM516.Click += btnModificar_VM516_Click;
            // 
            // btnEliminar_VM516
            // 
            btnEliminar_VM516.BackColor = Color.FromArgb(180, 40, 40);
            btnEliminar_VM516.FlatAppearance.BorderSize = 0;
            btnEliminar_VM516.FlatStyle = FlatStyle.Flat;
            btnEliminar_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEliminar_VM516.ForeColor = Color.White;
            btnEliminar_VM516.Location = new Point(34, 470);
            btnEliminar_VM516.Name = "btnEliminar_VM516";
            btnEliminar_VM516.Size = new Size(185, 40);
            btnEliminar_VM516.TabIndex = 11;
            btnEliminar_VM516.Tag = "btn_EliminarSala";
            btnEliminar_VM516.Text = "Eliminar";
            btnEliminar_VM516.UseVisualStyleBackColor = false;
            btnEliminar_VM516.Click += btnEliminar_VM516_Click;
            // 
            // btnLimpiar_VM516
            // 
            btnLimpiar_VM516.BackColor = Color.White;
            btnLimpiar_VM516.FlatStyle = FlatStyle.Flat;
            btnLimpiar_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLimpiar_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            btnLimpiar_VM516.Location = new Point(229, 470);
            btnLimpiar_VM516.Name = "btnLimpiar_VM516";
            btnLimpiar_VM516.Size = new Size(185, 40);
            btnLimpiar_VM516.TabIndex = 12;
            btnLimpiar_VM516.Tag = "btn_LimpiarSala";
            btnLimpiar_VM516.Text = "Limpiar";
            btnLimpiar_VM516.UseVisualStyleBackColor = false;
            btnLimpiar_VM516.Click += btnLimpiar_VM516_Click;
            // 
            // btnSalir_VM516
            // 
            btnSalir_VM516.BackColor = Color.White;
            btnSalir_VM516.FlatStyle = FlatStyle.Flat;
            btnSalir_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalir_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            btnSalir_VM516.Location = new Point(1395, 25);
            btnSalir_VM516.Name = "btnSalir_VM516";
            btnSalir_VM516.Size = new Size(140, 38);
            btnSalir_VM516.TabIndex = 13;
            btnSalir_VM516.Tag = "btn_Salir";
            btnSalir_VM516.Text = "Salir";
            btnSalir_VM516.UseVisualStyleBackColor = false;
            btnSalir_VM516.Click += btnSalir_VM516_Click;
            // 
            // dgvProductos_VM516
            // 
            dgvProductos_VM516.AllowUserToAddRows = false;
            dgvProductos_VM516.AllowUserToDeleteRows = false;
            dgvProductos_VM516.AllowUserToResizeRows = false;
            dgvProductos_VM516.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos_VM516.BackgroundColor = Color.FromArgb(46, 17, 39);
            dgvProductos_VM516.BorderStyle = BorderStyle.None;
            dgvProductos_VM516.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProductos_VM516.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 17, 39);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductos_VM516.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos_VM516.ColumnHeadersHeight = 45;
            dgvProductos_VM516.EnableHeadersVisualStyles = false;
            dgvProductos_VM516.GridColor = Color.FromArgb(220, 220, 220);
            dgvProductos_VM516.Location = new Point(460, 115);
            dgvProductos_VM516.MultiSelect = false;
            dgvProductos_VM516.Name = "dgvProductos_VM516";
            dgvProductos_VM516.ReadOnly = true;
            dgvProductos_VM516.RowHeadersVisible = false;
            dgvProductos_VM516.RowTemplate.Height = 32;
            dgvProductos_VM516.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos_VM516.Size = new Size(981, 463);
            dgvProductos_VM516.TabIndex = 14;
            dgvProductos_VM516.CellClick += dgvProductos_VM516_CellClick_1;
            dgvProductos_VM516.CellFormatting += dgvProductos_VM516_CellFormatting;
            // 
            // panelInferior_VM516
            // 
            panelInferior_VM516.BackColor = Color.FromArgb(46, 17, 39);
            panelInferior_VM516.Controls.Add(lblUsuarioValor_VM516);
            panelInferior_VM516.Controls.Add(lblUsuarioActivo_VM516);
            panelInferior_VM516.Dock = DockStyle.Bottom;
            panelInferior_VM516.Location = new Point(0, 750);
            panelInferior_VM516.Name = "panelInferior_VM516";
            panelInferior_VM516.Size = new Size(1609, 38);
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
            lblUsuarioValor_VM516.TabIndex = 1;
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
            lblUsuarioActivo_VM516.TabIndex = 0;
            lblUsuarioActivo_VM516.Tag = "lbl_Usuario";
            lblUsuarioActivo_VM516.Text = "Usuario activo: ";
            // 
            // toolTipGestionProd
            // 
            toolTipGestionProd.AutoPopDelay = 5000;
            toolTipGestionProd.InitialDelay = 100;
            toolTipGestionProd.ReshowDelay = 100;
            // 
            // Form_Gestion_Productos_VM516
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(1609, 788);
            Controls.Add(panelInferior_VM516);
            Controls.Add(panelContenedor_VM516);
            Font = new Font("Segoe UI", 9F);
            Name = "Form_Gestion_Productos_VM516";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vanguardia Arte - Gestión de Productos de Cafetería";
            FormClosed += Form_Gestion_Productos_VM516_FormClosed;
            Load += Form_Gestion_Productos_VM516_Load;
            panelContenedor_VM516.ResumeLayout(false);
            panelContenedor_VM516.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo_VM516).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos_VM516).EndInit();
            panelInferior_VM516.ResumeLayout(false);
            panelInferior_VM516.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor_VM516;
        private System.Windows.Forms.PictureBox picLogo_VM516;
        private System.Windows.Forms.Label lblTitulo_VM516;
        private System.Windows.Forms.Label lblCodigoProducto_VM516;
        private System.Windows.Forms.TextBox txtCodigoProducto_VM516;
        private System.Windows.Forms.Label lblDescripcion_VM516;
        private System.Windows.Forms.TextBox txtDescripcion_VM516;
        private System.Windows.Forms.Label lblStockDisponible_VM516;
        private System.Windows.Forms.TextBox txtStockDisponible_VM516;
        private System.Windows.Forms.Label lblPrecioVigente_VM516;
        private System.Windows.Forms.TextBox txtPrecioVigente_VM516;
        private System.Windows.Forms.Button btnGuardar_VM516;
        private System.Windows.Forms.Button btnModificar_VM516;
        private System.Windows.Forms.Button btnEliminar_VM516;
        private System.Windows.Forms.Button btnLimpiar_VM516;
        private System.Windows.Forms.Button btnSalir_VM516;
        private System.Windows.Forms.DataGridView dgvProductos_VM516;
        private System.Windows.Forms.Panel panelInferior_VM516;
        private System.Windows.Forms.Label lblUsuarioActivo_VM516;
        private System.Windows.Forms.Label lblUsuarioValor_VM516;
        private ToolTip toolTipGestionProd;
    }
}
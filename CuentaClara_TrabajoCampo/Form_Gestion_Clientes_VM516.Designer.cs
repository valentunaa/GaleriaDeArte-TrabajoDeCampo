namespace IU
{
    partial class Form_Gestion_Clientes_VM516
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
            lblBuscarTitulo_VM516 = new Label();
            txtBuscarDni_VM516 = new TextBox();
            btnBuscarCliente_VM516 = new Button();
            lblResultadoBusqueda_VM516 = new Label();
            lblDni_VM516 = new Label();
            txtDni_VM516 = new TextBox();
            lblNombre_VM516 = new Label();
            txtNombre_VM516 = new TextBox();
            lblApellido_VM516 = new Label();
            txtApellido_VM516 = new TextBox();
            lblTelefono_VM516 = new Label();
            txtTelefono_VM516 = new TextBox();
            lblEmail_VM516 = new Label();
            txtEmail_VM516 = new TextBox();
            btnModificar_VM516 = new Button();
            btnLimpiar_VM516 = new Button();
            btnSalir_VM516 = new Button();
            dgvClientes_VM516 = new DataGridView();
            panelInferior_VM516 = new Panel();
            lblUsuarioValor_VM516 = new Label();
            lblUsuarioActivo_VM516 = new Label();
            toolTipClientes = new ToolTip(components);
            panelContenedor_VM516.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo_VM516).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes_VM516).BeginInit();
            panelInferior_VM516.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor_VM516
            // 
            panelContenedor_VM516.Anchor = AnchorStyles.None;
            panelContenedor_VM516.BackColor = Color.White;
            panelContenedor_VM516.Controls.Add(picLogo_VM516);
            panelContenedor_VM516.Controls.Add(lblTitulo_VM516);
            panelContenedor_VM516.Controls.Add(lblBuscarTitulo_VM516);
            panelContenedor_VM516.Controls.Add(txtBuscarDni_VM516);
            panelContenedor_VM516.Controls.Add(btnBuscarCliente_VM516);
            panelContenedor_VM516.Controls.Add(lblResultadoBusqueda_VM516);
            panelContenedor_VM516.Controls.Add(lblDni_VM516);
            panelContenedor_VM516.Controls.Add(txtDni_VM516);
            panelContenedor_VM516.Controls.Add(lblNombre_VM516);
            panelContenedor_VM516.Controls.Add(txtNombre_VM516);
            panelContenedor_VM516.Controls.Add(lblApellido_VM516);
            panelContenedor_VM516.Controls.Add(txtApellido_VM516);
            panelContenedor_VM516.Controls.Add(lblTelefono_VM516);
            panelContenedor_VM516.Controls.Add(txtTelefono_VM516);
            panelContenedor_VM516.Controls.Add(lblEmail_VM516);
            panelContenedor_VM516.Controls.Add(txtEmail_VM516);
            panelContenedor_VM516.Controls.Add(btnModificar_VM516);
            panelContenedor_VM516.Controls.Add(btnLimpiar_VM516);
            panelContenedor_VM516.Controls.Add(btnSalir_VM516);
            panelContenedor_VM516.Controls.Add(dgvClientes_VM516);
            panelContenedor_VM516.Location = new Point(20, 12);
            panelContenedor_VM516.Name = "panelContenedor_VM516";
            panelContenedor_VM516.Size = new Size(1489, 745);
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
            picLogo_VM516.TabIndex = 25;
            picLogo_VM516.TabStop = false;
            // 
            // lblTitulo_VM516
            // 
            lblTitulo_VM516.AutoSize = true;
            lblTitulo_VM516.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            lblTitulo_VM516.Location = new Point(108, 25);
            lblTitulo_VM516.Name = "lblTitulo_VM516";
            lblTitulo_VM516.Size = new Size(104, 32);
            lblTitulo_VM516.TabIndex = 0;
            lblTitulo_VM516.Tag = "titulo_FormGestionClientes";
            lblTitulo_VM516.Text = "Clientes";
            // 
            // lblBuscarTitulo_VM516
            // 
            lblBuscarTitulo_VM516.AutoSize = true;
            lblBuscarTitulo_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBuscarTitulo_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            lblBuscarTitulo_VM516.Location = new Point(34, 95);
            lblBuscarTitulo_VM516.Name = "lblBuscarTitulo_VM516";
            lblBuscarTitulo_VM516.Size = new Size(183, 19);
            lblBuscarTitulo_VM516.TabIndex = 1;
            lblBuscarTitulo_VM516.Tag = "lbl_BuscarClienteDNI";
            lblBuscarTitulo_VM516.Text = "BUSCAR CLIENTE POR DNI";
            // 
            // txtBuscarDni_VM516
            // 
            txtBuscarDni_VM516.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarDni_VM516.Font = new Font("Segoe UI", 10F);
            txtBuscarDni_VM516.Location = new Point(34, 120);
            txtBuscarDni_VM516.Name = "txtBuscarDni_VM516";
            txtBuscarDni_VM516.Size = new Size(380, 25);
            txtBuscarDni_VM516.TabIndex = 2;
            // 
            // btnBuscarCliente_VM516
            // 
            btnBuscarCliente_VM516.BackColor = Color.FromArgb(46, 17, 39);
            btnBuscarCliente_VM516.FlatAppearance.BorderSize = 0;
            btnBuscarCliente_VM516.FlatStyle = FlatStyle.Flat;
            btnBuscarCliente_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBuscarCliente_VM516.ForeColor = Color.White;
            btnBuscarCliente_VM516.Location = new Point(34, 155);
            btnBuscarCliente_VM516.Name = "btnBuscarCliente_VM516";
            btnBuscarCliente_VM516.Size = new Size(380, 38);
            btnBuscarCliente_VM516.TabIndex = 3;
            btnBuscarCliente_VM516.Tag = "btn_BuscarCliente_R";
            btnBuscarCliente_VM516.Text = "Buscar Cliente por DNI";
            btnBuscarCliente_VM516.UseVisualStyleBackColor = false;
            btnBuscarCliente_VM516.Click += btnBuscarCliente_VM516_Click;
            // 
            // lblResultadoBusqueda_VM516
            // 
            lblResultadoBusqueda_VM516.AutoSize = true;
            lblResultadoBusqueda_VM516.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblResultadoBusqueda_VM516.ForeColor = Color.DimGray;
            lblResultadoBusqueda_VM516.Location = new Point(34, 203);
            lblResultadoBusqueda_VM516.Name = "lblResultadoBusqueda_VM516";
            lblResultadoBusqueda_VM516.Size = new Size(67, 17);
            lblResultadoBusqueda_VM516.TabIndex = 4;
            lblResultadoBusqueda_VM516.Tag = "lbl_ResultadoCliente";
            lblResultadoBusqueda_VM516.Text = "Cliente ...";
            // 
            // lblDni_VM516
            // 
            lblDni_VM516.AutoSize = true;
            lblDni_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDni_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            lblDni_VM516.Location = new Point(34, 245);
            lblDni_VM516.Name = "lblDni_VM516";
            lblDni_VM516.Size = new Size(34, 19);
            lblDni_VM516.TabIndex = 5;
            lblDni_VM516.Tag = "lbl_DNI";
            lblDni_VM516.Text = "DNI";
            // 
            // txtDni_VM516
            // 
            txtDni_VM516.BackColor = Color.FromArgb(240, 240, 240);
            txtDni_VM516.BorderStyle = BorderStyle.FixedSingle;
            txtDni_VM516.Font = new Font("Segoe UI", 10F);
            txtDni_VM516.Location = new Point(34, 268);
            txtDni_VM516.Name = "txtDni_VM516";
            txtDni_VM516.ReadOnly = true;
            txtDni_VM516.Size = new Size(380, 25);
            txtDni_VM516.TabIndex = 6;
            // 
            // lblNombre_VM516
            // 
            lblNombre_VM516.AutoSize = true;
            lblNombre_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNombre_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            lblNombre_VM516.Location = new Point(34, 305);
            lblNombre_VM516.Name = "lblNombre_VM516";
            lblNombre_VM516.Size = new Size(65, 19);
            lblNombre_VM516.TabIndex = 7;
            lblNombre_VM516.Tag = "lbl_Nombre";
            lblNombre_VM516.Text = "Nombre";
            // 
            // txtNombre_VM516
            // 
            txtNombre_VM516.BorderStyle = BorderStyle.FixedSingle;
            txtNombre_VM516.Font = new Font("Segoe UI", 10F);
            txtNombre_VM516.Location = new Point(34, 328);
            txtNombre_VM516.Name = "txtNombre_VM516";
            txtNombre_VM516.Size = new Size(380, 25);
            txtNombre_VM516.TabIndex = 8;
            // 
            // lblApellido_VM516
            // 
            lblApellido_VM516.AutoSize = true;
            lblApellido_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblApellido_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            lblApellido_VM516.Location = new Point(34, 365);
            lblApellido_VM516.Name = "lblApellido_VM516";
            lblApellido_VM516.Size = new Size(66, 19);
            lblApellido_VM516.TabIndex = 9;
            lblApellido_VM516.Tag = "lbl_Apellido";
            lblApellido_VM516.Text = "Apellido";
            // 
            // txtApellido_VM516
            // 
            txtApellido_VM516.BorderStyle = BorderStyle.FixedSingle;
            txtApellido_VM516.Font = new Font("Segoe UI", 10F);
            txtApellido_VM516.Location = new Point(34, 388);
            txtApellido_VM516.Name = "txtApellido_VM516";
            txtApellido_VM516.Size = new Size(380, 25);
            txtApellido_VM516.TabIndex = 10;
            // 
            // lblTelefono_VM516
            // 
            lblTelefono_VM516.AutoSize = true;
            lblTelefono_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTelefono_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            lblTelefono_VM516.Location = new Point(34, 425);
            lblTelefono_VM516.Name = "lblTelefono_VM516";
            lblTelefono_VM516.Size = new Size(71, 19);
            lblTelefono_VM516.TabIndex = 11;
            lblTelefono_VM516.Tag = "lbl_Telefono";
            lblTelefono_VM516.Text = "Teléfono:";
            // 
            // txtTelefono_VM516
            // 
            txtTelefono_VM516.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono_VM516.Font = new Font("Segoe UI", 10F);
            txtTelefono_VM516.Location = new Point(34, 448);
            txtTelefono_VM516.Name = "txtTelefono_VM516";
            txtTelefono_VM516.Size = new Size(380, 25);
            txtTelefono_VM516.TabIndex = 12;
            // 
            // lblEmail_VM516
            // 
            lblEmail_VM516.AutoSize = true;
            lblEmail_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmail_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            lblEmail_VM516.Location = new Point(34, 485);
            lblEmail_VM516.Name = "lblEmail_VM516";
            lblEmail_VM516.Size = new Size(139, 19);
            lblEmail_VM516.TabIndex = 13;
            lblEmail_VM516.Tag = "lbl_Email";
            lblEmail_VM516.Text = "Correo electrónico:";
            // 
            // txtEmail_VM516
            // 
            txtEmail_VM516.BorderStyle = BorderStyle.FixedSingle;
            txtEmail_VM516.Font = new Font("Segoe UI", 10F);
            txtEmail_VM516.Location = new Point(34, 508);
            txtEmail_VM516.Name = "txtEmail_VM516";
            txtEmail_VM516.Size = new Size(380, 25);
            txtEmail_VM516.TabIndex = 14;
            // 
            // btnModificar_VM516
            // 
            btnModificar_VM516.BackColor = Color.FromArgb(18, 87, 150);
            btnModificar_VM516.FlatAppearance.BorderSize = 0;
            btnModificar_VM516.FlatStyle = FlatStyle.Flat;
            btnModificar_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnModificar_VM516.ForeColor = Color.White;
            btnModificar_VM516.Location = new Point(34, 555);
            btnModificar_VM516.Name = "btnModificar_VM516";
            btnModificar_VM516.Size = new Size(185, 40);
            btnModificar_VM516.TabIndex = 15;
            btnModificar_VM516.Tag = "btn_Modificar";
            btnModificar_VM516.Text = "Modificar";
            btnModificar_VM516.UseVisualStyleBackColor = false;
            btnModificar_VM516.Click += btnModificar_VM516_Click;
            // 
            // btnLimpiar_VM516
            // 
            btnLimpiar_VM516.BackColor = Color.White;
            btnLimpiar_VM516.FlatStyle = FlatStyle.Flat;
            btnLimpiar_VM516.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLimpiar_VM516.ForeColor = Color.FromArgb(46, 17, 39);
            btnLimpiar_VM516.Location = new Point(229, 555);
            btnLimpiar_VM516.Name = "btnLimpiar_VM516";
            btnLimpiar_VM516.Size = new Size(185, 40);
            btnLimpiar_VM516.TabIndex = 16;
            btnLimpiar_VM516.Tag = "btn_Limpiar";
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
            btnSalir_VM516.Location = new Point(1287, 25);
            btnSalir_VM516.Name = "btnSalir_VM516";
            btnSalir_VM516.Size = new Size(140, 38);
            btnSalir_VM516.TabIndex = 18;
            btnSalir_VM516.Tag = "btn_Salir";
            btnSalir_VM516.Text = "Salir";
            btnSalir_VM516.UseVisualStyleBackColor = false;
            btnSalir_VM516.Click += btnSalir_VM516_Click;
            // 
            // dgvClientes_VM516
            // 
            dgvClientes_VM516.AllowUserToAddRows = false;
            dgvClientes_VM516.AllowUserToDeleteRows = false;
            dgvClientes_VM516.AllowUserToResizeRows = false;
            dgvClientes_VM516.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes_VM516.BackgroundColor = Color.FromArgb(46, 17, 39);
            dgvClientes_VM516.BorderStyle = BorderStyle.None;
            dgvClientes_VM516.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClientes_VM516.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(46, 17, 39);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClientes_VM516.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes_VM516.ColumnHeadersHeight = 45;
            dgvClientes_VM516.EnableHeadersVisualStyles = false;
            dgvClientes_VM516.GridColor = Color.FromArgb(220, 220, 220);
            dgvClientes_VM516.Location = new Point(460, 95);
            dgvClientes_VM516.MultiSelect = false;
            dgvClientes_VM516.Name = "dgvClientes_VM516";
            dgvClientes_VM516.ReadOnly = true;
            dgvClientes_VM516.RowHeadersVisible = false;
            dgvClientes_VM516.RowTemplate.Height = 30;
            dgvClientes_VM516.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes_VM516.Size = new Size(967, 500);
            dgvClientes_VM516.TabIndex = 19;
            dgvClientes_VM516.CellClick += dgvClientes_VM516_CellClick;
            // 
            // panelInferior_VM516
            // 
            panelInferior_VM516.BackColor = Color.FromArgb(46, 17, 39);
            panelInferior_VM516.Controls.Add(lblUsuarioValor_VM516);
            panelInferior_VM516.Controls.Add(lblUsuarioActivo_VM516);
            panelInferior_VM516.Dock = DockStyle.Bottom;
            panelInferior_VM516.Location = new Point(0, 750);
            panelInferior_VM516.Name = "panelInferior_VM516";
            panelInferior_VM516.Size = new Size(1534, 38);
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
            // toolTipClientes
            // 
            toolTipClientes.AutoPopDelay = 5000;
            toolTipClientes.InitialDelay = 100;
            toolTipClientes.ReshowDelay = 100;
            // 
            // Form_Gestion_Clientes_VM516
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(1534, 788);
            Controls.Add(panelInferior_VM516);
            Controls.Add(panelContenedor_VM516);
            Font = new Font("Segoe UI", 9F);
            Name = "Form_Gestion_Clientes_VM516";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vanguardia Arte - Clientes";
            Load += Form_Gestion_Clientes_VM516_Load;
            panelContenedor_VM516.ResumeLayout(false);
            panelContenedor_VM516.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo_VM516).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvClientes_VM516).EndInit();
            panelInferior_VM516.ResumeLayout(false);
            panelInferior_VM516.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor_VM516;
        private System.Windows.Forms.PictureBox picLogo_VM516;
        private System.Windows.Forms.Label lblTitulo_VM516;
        private System.Windows.Forms.Label lblBuscarTitulo_VM516;
        private System.Windows.Forms.TextBox txtBuscarDni_VM516;
        private System.Windows.Forms.Button btnBuscarCliente_VM516;
        private System.Windows.Forms.Label lblResultadoBusqueda_VM516;
        private System.Windows.Forms.Label lblDni_VM516;
        private System.Windows.Forms.TextBox txtDni_VM516;
        private System.Windows.Forms.Label lblNombre_VM516;
        private System.Windows.Forms.TextBox txtNombre_VM516;
        private System.Windows.Forms.Label lblApellido_VM516;
        private System.Windows.Forms.TextBox txtApellido_VM516;
        private System.Windows.Forms.Label lblTelefono_VM516;
        private System.Windows.Forms.TextBox txtTelefono_VM516;
        private System.Windows.Forms.Label lblEmail_VM516;
        private System.Windows.Forms.TextBox txtEmail_VM516;
        private System.Windows.Forms.Button btnModificar_VM516;
        private System.Windows.Forms.Button btnLimpiar_VM516;
        private System.Windows.Forms.Button btnSalir_VM516;
        private System.Windows.Forms.DataGridView dgvClientes_VM516;
        private System.Windows.Forms.Panel panelInferior_VM516;
        private System.Windows.Forms.Label lblUsuarioActivo_VM516;
        private System.Windows.Forms.Label lblUsuarioValor_VM516;
        private ToolTip toolTipClientes;
    }
}
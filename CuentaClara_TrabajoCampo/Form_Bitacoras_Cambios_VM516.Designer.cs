using Servicio;

namespace IU
{
    partial class Form_Bitacoras_Cambios_VM516
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
            panelContenedor = new Panel();
            lblTitulo = new Label();
            btnBitacoraProductos = new Button();
            btnBitacoraObras = new Button();
            panelInferior = new Panel();
            lblUsuarioValor = new Label();
            lblUsuarioActivo = new Label();
            toolTipMenuBitacoras = new ToolTip(components);
            panelContenedor.SuspendLayout();
            panelInferior.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.Anchor = AnchorStyles.None;
            panelContenedor.BackColor = Color.White;
            panelContenedor.Controls.Add(lblTitulo);
            panelContenedor.Controls.Add(btnBitacoraProductos);
            panelContenedor.Controls.Add(btnBitacoraObras);
            panelContenedor.Location = new Point(33, 14);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(529, 349);
            panelContenedor.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(46, 17, 39);
            lblTitulo.Location = new Point(50, 40);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(268, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Tag = "lbl_TituloMenuBitacoras";
            lblTitulo.Text = "Selección de Bitácoras";
            // 
            // btnBitacoraProductos
            // 
            btnBitacoraProductos.BackColor = Color.FromArgb(46, 17, 39);
            btnBitacoraProductos.FlatAppearance.BorderSize = 0;
            btnBitacoraProductos.FlatStyle = FlatStyle.Flat;
            btnBitacoraProductos.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBitacoraProductos.ForeColor = Color.White;
            btnBitacoraProductos.Location = new Point(61, 129);
            btnBitacoraProductos.Name = "btnBitacoraProductos";
            btnBitacoraProductos.Size = new Size(400, 50);
            btnBitacoraProductos.TabIndex = 1;
            btnBitacoraProductos.Tag = "btn_BitacoraProductos";
            btnBitacoraProductos.Text = "Producto";
            btnBitacoraProductos.UseVisualStyleBackColor = false;
            btnBitacoraProductos.Click += btnBitacoraProductos_Click;
            // 
            // btnBitacoraObras
            // 
            btnBitacoraObras.BackColor = Color.FromArgb(18, 87, 150);
            btnBitacoraObras.FlatAppearance.BorderSize = 0;
            btnBitacoraObras.FlatStyle = FlatStyle.Flat;
            btnBitacoraObras.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnBitacoraObras.ForeColor = Color.White;
            btnBitacoraObras.Location = new Point(61, 203);
            btnBitacoraObras.Name = "btnBitacoraObras";
            btnBitacoraObras.Size = new Size(400, 50);
            btnBitacoraObras.TabIndex = 2;
            btnBitacoraObras.Tag = "btn_BitacoraObras";
            btnBitacoraObras.Text = "Especificación de Obra";
            btnBitacoraObras.UseVisualStyleBackColor = false;
            btnBitacoraObras.Click += btnBitacoraObras_Click;
            // 
            // panelInferior
            // 
            panelInferior.BackColor = Color.FromArgb(46, 17, 39);
            panelInferior.Controls.Add(lblUsuarioValor);
            panelInferior.Controls.Add(lblUsuarioActivo);
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(0, 349);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(597, 38);
            panelInferior.TabIndex = 1;
            // 
            // lblUsuarioValor
            // 
            lblUsuarioValor.AutoSize = true;
            lblUsuarioValor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuarioValor.ForeColor = Color.White;
            lblUsuarioValor.Location = new Point(114, 10);
            lblUsuarioValor.Name = "lblUsuarioValor";
            lblUsuarioValor.Size = new Size(0, 15);
            lblUsuarioValor.TabIndex = 1;
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
            // Form_Bitacoras_Cambios_VM516
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(597, 387);
            Controls.Add(panelInferior);
            Controls.Add(panelContenedor);
            Font = new Font("Segoe UI", 9F);
            Name = "Form_Bitacoras_Cambios_VM516";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "lbl_FormMenuBitacoras";
            Text = "Vanguardia Arte - Menú de Bitácoras";
            FormClosed += Form_Bitacoras_Cambios_VM516_FormClosed;
            Load += Form_Bitacoras_Cambios_VM516_Load;
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            panelInferior.ResumeLayout(false);
            panelInferior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnBitacoraProductos;
        private System.Windows.Forms.Button btnBitacoraObras;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Label lblUsuarioActivo;
        private System.Windows.Forms.Label lblUsuarioValor;
        private ToolTip toolTipMenuBitacoras;
    }
}
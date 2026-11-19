namespace IU
{
    partial class FormReinstalacionBD_VM516
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
            panelHeader = new Panel();
            lblTitulo = new Label();
            lblSubtitulo = new Label();
            grpOpciones = new GroupBox();
            lblRutaBackup = new Label();
            txtRutaBackup = new TextBox();
            btnExaminar = new Button();
            panelFooter = new Panel();
            btnContinuar = new Button();
            btnCancelar = new Button();
            panelHeader.SuspendLayout();
            grpOpciones.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(42, 15, 42);
            panelHeader.Controls.Add(lblTitulo);
            panelHeader.Controls.Add(lblSubtitulo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(563, 58);
            panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(18, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(251, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Reinstalación - Vanguardia Arte";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9F);
            lblSubtitulo.ForeColor = Color.FromArgb(230, 220, 230);
            lblSubtitulo.Location = new Point(18, 32);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(273, 15);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Elegí el archivo .bak para continuar la reinstalación";
            // 
            // grpOpciones
            // 
            grpOpciones.Controls.Add(lblRutaBackup);
            grpOpciones.Controls.Add(txtRutaBackup);
            grpOpciones.Controls.Add(btnExaminar);
            grpOpciones.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpOpciones.Location = new Point(18, 66);
            grpOpciones.Name = "grpOpciones";
            grpOpciones.Size = new Size(496, 156);
            grpOpciones.TabIndex = 1;
            grpOpciones.TabStop = false;
            grpOpciones.Enabled = true;
            grpOpciones.Text = "Opciones de base de datos";
            // 
            // lblRutaBackup
            // 
            lblRutaBackup.AutoSize = true;
            lblRutaBackup.Font = new Font("Segoe UI", 9F);
            lblRutaBackup.Location = new Point(6, 29);
            lblRutaBackup.Name = "lblRutaBackup";
            lblRutaBackup.Size = new Size(115, 15);
            lblRutaBackup.TabIndex = 2;
            lblRutaBackup.Text = "Archivo de respaldo:";
            // 
            // txtRutaBackup
            // 
            txtRutaBackup.Font = new Font("Segoe UI", 9.5F);
            txtRutaBackup.Location = new Point(6, 61);
            txtRutaBackup.Name = "txtRutaBackup";
            txtRutaBackup.Size = new Size(442, 24);
            txtRutaBackup.TabIndex = 3;
            // 
            // btnExaminar
            // 
            btnExaminar.Font = new Font("Segoe UI", 9F);
            btnExaminar.Location = new Point(348, 101);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(100, 26);
            btnExaminar.TabIndex = 4;
            btnExaminar.Text = "Examinar...";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(245, 245, 247);
            panelFooter.Controls.Add(btnContinuar);
            panelFooter.Controls.Add(btnCancelar);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 232);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(563, 50);
            panelFooter.TabIndex = 2;
            // 
            // btnContinuar
            // 
            btnContinuar.BackColor = Color.FromArgb(42, 15, 42);
            btnContinuar.FlatAppearance.BorderSize = 0;
            btnContinuar.FlatStyle = FlatStyle.Flat;
            btnContinuar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnContinuar.ForeColor = Color.White;
            btnContinuar.Location = new Point(243, 8);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(110, 30);
            btnContinuar.TabIndex = 0;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = false;
            btnContinuar.Click += btnContinuar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Segoe UI", 9.5F);
            btnCancelar.Location = new Point(414, 8);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 30);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormReinstalacionBD_VM516
            // 
            AcceptButton = btnContinuar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnCancelar;
            ClientSize = new Size(563, 282);
            Controls.Add(grpOpciones);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormReinstalacionBD_VM516";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vanguardia Arte - Reinstalación";
            Load += FormReinstalacionBD_VM516_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            grpOpciones.ResumeLayout(false);
            grpOpciones.PerformLayout();
            panelFooter.ResumeLayout(false);
            ResumeLayout(false);
        }
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.GroupBox grpOpciones;
        private System.Windows.Forms.Label lblRutaBackup;
        private System.Windows.Forms.TextBox txtRutaBackup;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnCancelar;
        #endregion
    }
}
namespace IU
{
    partial class FormBackupInstalacion_VM516
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
            grpBackup = new GroupBox();
            lblInfo = new Label();
            lblDestino = new Label();
            txtRutaDestinoBak = new TextBox();
            btnExaminarBak = new Button();
            btnHacerBackup = new Button();
            panelFooter = new Panel();
            btnContinuar = new Button();
            btnCancelar = new Button();
            panelHeader.SuspendLayout();
            grpBackup.SuspendLayout();
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
            panelHeader.Size = new Size(640, 58);
            panelHeader.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(18, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(351, 21);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Respaldo de Base de Datos - Vanguardia Arte";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Segoe UI", 9F);
            lblSubtitulo.ForeColor = Color.FromArgb(230, 220, 230);
            lblSubtitulo.Location = new Point(18, 32);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(491, 15);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Generá un respaldo (.bak) de la base actual antes de continuar con la instalación desde cero.";
            // 
            // grpBackup
            // 
            grpBackup.Controls.Add(lblInfo);
            grpBackup.Controls.Add(lblDestino);
            grpBackup.Controls.Add(txtRutaDestinoBak);
            grpBackup.Controls.Add(btnExaminarBak);
            grpBackup.Controls.Add(btnHacerBackup);
            grpBackup.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpBackup.Location = new Point(18, 66);
            grpBackup.Name = "grpBackup";
            grpBackup.Size = new Size(604, 156);
            grpBackup.TabIndex = 1;
            grpBackup.TabStop = false;
            grpBackup.Text = "Respaldo de base de datos existente";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI", 9F);
            lblInfo.Location = new Point(16, 22);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(427, 15);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "La instalación desde cero reemplazará la base de datos si ya existe en el servidor.";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Font = new Font("Segoe UI", 9F);
            lblDestino.Location = new Point(16, 46);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(135, 15);
            lblDestino.TabIndex = 1;
            lblDestino.Text = "Guardar archivo .bak en:";
            // 
            // txtRutaDestinoBak
            // 
            txtRutaDestinoBak.Font = new Font("Segoe UI", 9.5F);
            txtRutaDestinoBak.Location = new Point(16, 66);
            txtRutaDestinoBak.Name = "txtRutaDestinoBak";
            txtRutaDestinoBak.Size = new Size(462, 24);
            txtRutaDestinoBak.TabIndex = 2;
            // 
            // btnExaminarBak
            // 
            btnExaminarBak.Font = new Font("Segoe UI", 9F);
            btnExaminarBak.Location = new Point(486, 65);
            btnExaminarBak.Name = "btnExaminarBak";
            btnExaminarBak.Size = new Size(100, 26);
            btnExaminarBak.TabIndex = 3;
            btnExaminarBak.Text = "Examinar...";
            btnExaminarBak.UseVisualStyleBackColor = true;
            btnExaminarBak.Click += btnExaminarBak_Click;
            // 
            // btnHacerBackup
            // 
            btnHacerBackup.BackColor = Color.FromArgb(42, 15, 42);
            btnHacerBackup.FlatAppearance.BorderSize = 0;
            btnHacerBackup.FlatStyle = FlatStyle.Flat;
            btnHacerBackup.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnHacerBackup.ForeColor = Color.White;
            btnHacerBackup.Location = new Point(16, 102);
            btnHacerBackup.Name = "btnHacerBackup";
            btnHacerBackup.Size = new Size(150, 32);
            btnHacerBackup.TabIndex = 4;
            btnHacerBackup.Text = "Hacer backup";
            btnHacerBackup.UseVisualStyleBackColor = false;
            btnHacerBackup.Click += btnHacerBackup_Click;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.FromArgb(245, 245, 247);
            panelFooter.Controls.Add(btnContinuar);
            panelFooter.Controls.Add(btnCancelar);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 232);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(640, 50);
            panelFooter.TabIndex = 2;
            // 
            // btnContinuar
            // 
            btnContinuar.BackColor = Color.FromArgb(42, 15, 42);
            btnContinuar.FlatAppearance.BorderSize = 0;
            btnContinuar.FlatStyle = FlatStyle.Flat;
            btnContinuar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnContinuar.ForeColor = Color.White;
            btnContinuar.Location = new Point(404, 10);
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
            btnCancelar.Location = new Point(522, 10);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 30);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormBackupInstalacion_VM516
            // 
            AcceptButton = btnContinuar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = btnCancelar;
            ClientSize = new Size(640, 282);
            Controls.Add(grpBackup);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormBackupInstalacion_VM516";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vanguardia Arte - Backup previo a instalación";
            Load += FormBackupInstalacion_VM516_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            grpBackup.ResumeLayout(false);
            grpBackup.PerformLayout();
            panelFooter.ResumeLayout(false);
            ResumeLayout(false);
        }
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.GroupBox grpBackup;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.TextBox txtRutaDestinoBak;
        private System.Windows.Forms.Button btnExaminarBak;
        private System.Windows.Forms.Button btnHacerBackup;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Button btnCancelar;
        #endregion
    }
}
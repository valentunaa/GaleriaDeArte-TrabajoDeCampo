namespace IU
{
    partial class FormConfiguracion
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
            cmbIdioma = new ComboBox();
            btnGuardarr = new Button();
            button1 = new Button();
            panelLogin = new Panel();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // cmbIdioma
            // 
            cmbIdioma.FormattingEnabled = true;
            cmbIdioma.Location = new Point(30, 43);
            cmbIdioma.Margin = new Padding(1);
            cmbIdioma.Name = "cmbIdioma";
            cmbIdioma.Size = new Size(121, 23);
            cmbIdioma.TabIndex = 8;
            cmbIdioma.SelectedIndexChanged += cmbIdioma_SelectedIndexChanged;
            // 
            // btnGuardarr
            // 
            btnGuardarr.BackColor = Color.White;
            btnGuardarr.FlatAppearance.BorderColor = Color.FromArgb(18, 87, 150);
            btnGuardarr.FlatStyle = FlatStyle.Flat;
            btnGuardarr.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardarr.ForeColor = Color.FromArgb(46, 17, 39);
            btnGuardarr.Location = new Point(180, 34);
            btnGuardarr.Margin = new Padding(1);
            btnGuardarr.Name = "btnGuardarr";
            btnGuardarr.Size = new Size(107, 37);
            btnGuardarr.TabIndex = 9;
            btnGuardarr.Tag = "btn_Guardar";
            btnGuardarr.Text = "Guardar";
            btnGuardarr.UseVisualStyleBackColor = false;
            btnGuardarr.Click += btnGuardarr_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.FromArgb(18, 87, 150);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(46, 17, 39);
            button1.Location = new Point(180, 99);
            button1.Margin = new Padding(1);
            button1.Name = "button1";
            button1.Size = new Size(107, 37);
            button1.TabIndex = 10;
            button1.Tag = "btn_Salir";
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panelLogin
            // 
            panelLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelLogin.BackColor = Color.White;
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(button1);
            panelLogin.Controls.Add(btnGuardarr);
            panelLogin.Controls.Add(cmbIdioma);
            panelLogin.Dock = DockStyle.Fill;
            panelLogin.Location = new Point(0, 0);
            panelLogin.Margin = new Padding(1);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(326, 174);
            panelLogin.TabIndex = 1;
            panelLogin.Paint += panelLogin_Paint;
            // 
            // FormConfiguracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 174);
            Controls.Add(panelLogin);
            Margin = new Padding(1);
            Name = "FormConfiguracion";
            Tag = "lbl_FormConfIdioma";
            Text = "Vanguardia Arte - Configuración Idioma";
            FormClosed += FormConfiguracion_FormClosed;
            Load += FormConfiguracion_Load;
            panelLogin.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbIdioma;
        private Button btnGuardarr;
        private Button button1;
        private Panel panelLogin;
    }
}
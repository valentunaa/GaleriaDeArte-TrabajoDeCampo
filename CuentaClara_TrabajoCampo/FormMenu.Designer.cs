namespace CuentaClara_TrabajoCampo
{
    partial class FormMenu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelMenu = new Panel();
            pictureBox1 = new PictureBox();
            lblSeccionSistema = new Label();
            lblSeccionOperacion = new Label();
            button9 = new Button();
            btn_Estado_PostExhibicion = new Button();
            btn_Salas_Calendario = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            lblTitulo = new Label();
            button2 = new Button();
            button5 = new Button();
            button4 = new Button();
            btnCerrarSesion = new Button();
            btnTesoreria_Cobros = new Button();
            btnArtista = new Button();
            btnReserva = new Button();
            button3 = new Button();
            btnCatalogo = new Button();
            button1 = new Button();
            panelUsuario = new Panel();
            label1 = new Label();
            lblUsuarioActivo = new Label();
            lblUsuarioValor = new Label();
            lblUsuario = new Label();
            lblBD = new Label();
            panelMovimientos = new Panel();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(46, 17, 39);
            panelMenu.Controls.Add(pictureBox1);
            panelMenu.Controls.Add(lblSeccionSistema);
            panelMenu.Controls.Add(lblSeccionOperacion);
            panelMenu.Controls.Add(button9);
            panelMenu.Controls.Add(btn_Estado_PostExhibicion);
            panelMenu.Controls.Add(btn_Salas_Calendario);
            panelMenu.Controls.Add(button8);
            panelMenu.Controls.Add(button7);
            panelMenu.Controls.Add(button6);
            panelMenu.Controls.Add(lblTitulo);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(button5);
            panelMenu.Controls.Add(button4);
            panelMenu.Controls.Add(btnCerrarSesion);
            panelMenu.Controls.Add(btnTesoreria_Cobros);
            panelMenu.Controls.Add(btnArtista);
            panelMenu.Controls.Add(btnReserva);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(btnCatalogo);
            panelMenu.Controls.Add(button1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(245, 913);
            panelMenu.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = IU.Properties.Resources.ImagenLogo;
            pictureBox1.Location = new Point(12, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // lblSeccionSistema
            // 
            lblSeccionSistema.AutoSize = true;
            lblSeccionSistema.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSeccionSistema.ForeColor = Color.FromArgb(210, 150, 180);
            lblSeccionSistema.Location = new Point(18, 474);
            lblSeccionSistema.Name = "lblSeccionSistema";
            lblSeccionSistema.Size = new Size(57, 15);
            lblSeccionSistema.TabIndex = 22;
            lblSeccionSistema.Tag = "lbl_SeccionSistema";
            lblSeccionSistema.Text = "SISTEMA";
            // 
            // lblSeccionOperacion
            // 
            lblSeccionOperacion.AutoSize = true;
            lblSeccionOperacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSeccionOperacion.ForeColor = Color.FromArgb(210, 150, 180);
            lblSeccionOperacion.Location = new Point(18, 186);
            lblSeccionOperacion.Name = "lblSeccionOperacion";
            lblSeccionOperacion.Size = new Size(74, 15);
            lblSeccionOperacion.TabIndex = 21;
            lblSeccionOperacion.Tag = "lbl_SeccionOperacion";
            lblSeccionOperacion.Text = "OPERACIÓN";
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(46, 17, 39);
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button9.ForeColor = Color.FromArgb(245, 235, 240);
            button9.Location = new Point(18, 404);
            button9.Margin = new Padding(1);
            button9.Name = "button9";
            button9.Size = new Size(210, 30);
            button9.TabIndex = 20;
            button9.Tag = "btn_Salas";
            button9.Text = "SALAS";
            button9.TextAlign = ContentAlignment.MiddleLeft;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // btn_Estado_PostExhibicion
            // 
            btn_Estado_PostExhibicion.BackColor = Color.FromArgb(46, 17, 39);
            btn_Estado_PostExhibicion.FlatAppearance.BorderSize = 0;
            btn_Estado_PostExhibicion.FlatStyle = FlatStyle.Flat;
            btn_Estado_PostExhibicion.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btn_Estado_PostExhibicion.ForeColor = Color.FromArgb(245, 235, 240);
            btn_Estado_PostExhibicion.Location = new Point(18, 334);
            btn_Estado_PostExhibicion.Margin = new Padding(1);
            btn_Estado_PostExhibicion.Name = "btn_Estado_PostExhibicion";
            btn_Estado_PostExhibicion.Size = new Size(210, 36);
            btn_Estado_PostExhibicion.TabIndex = 19;
            btn_Estado_PostExhibicion.Tag = "btn_EstadoPostExhibicion";
            btn_Estado_PostExhibicion.Text = "ESTADO POST-EXHIBICIÓN";
            btn_Estado_PostExhibicion.TextAlign = ContentAlignment.MiddleLeft;
            btn_Estado_PostExhibicion.UseVisualStyleBackColor = false;
            btn_Estado_PostExhibicion.Click += btn_Estado_PostExhibicion_Click;
            // 
            // btn_Salas_Calendario
            // 
            btn_Salas_Calendario.BackColor = Color.FromArgb(46, 17, 39);
            btn_Salas_Calendario.FlatAppearance.BorderSize = 0;
            btn_Salas_Calendario.FlatStyle = FlatStyle.Flat;
            btn_Salas_Calendario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_Salas_Calendario.ForeColor = Color.FromArgb(245, 235, 240);
            btn_Salas_Calendario.Location = new Point(18, 372);
            btn_Salas_Calendario.Margin = new Padding(1);
            btn_Salas_Calendario.Name = "btn_Salas_Calendario";
            btn_Salas_Calendario.Size = new Size(210, 30);
            btn_Salas_Calendario.TabIndex = 18;
            btn_Salas_Calendario.Tag = "btn_SalasCalendario";
            btn_Salas_Calendario.Text = "RETIRO DE OBRA";
            btn_Salas_Calendario.TextAlign = ContentAlignment.MiddleLeft;
            btn_Salas_Calendario.UseVisualStyleBackColor = false;
            btn_Salas_Calendario.Click += btn_Salas_Calendario_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(46, 17, 39);
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button8.ForeColor = Color.FromArgb(235, 170, 200);
            button8.Location = new Point(18, 848);
            button8.Margin = new Padding(0);
            button8.Name = "button8";
            button8.Size = new Size(210, 30);
            button8.TabIndex = 16;
            button8.Tag = "btn_Ayuda";
            button8.Text = "AYUDA";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(46, 17, 39);
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button7.ForeColor = Color.FromArgb(245, 235, 240);
            button7.Location = new Point(18, 714);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Size = new Size(210, 30);
            button7.TabIndex = 15;
            button7.Tag = "btn_GestionDeRespaldo";
            button7.Text = "Gestión de Respaldo";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(46, 17, 39);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button6.ForeColor = Color.FromArgb(245, 235, 240);
            button6.Location = new Point(18, 675);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(210, 30);
            button6.TabIndex = 14;
            button6.Tag = "btn_CambiarIdioma";
            button6.Text = "Cambiar Idioma Actual";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(235, 170, 200);
            lblTitulo.Location = new Point(87, 32);
            lblTitulo.Margin = new Padding(1, 0, 1, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(131, 60);
            lblTitulo.TabIndex = 1;
            lblTitulo.Tag = "lbl_TituloVanguardiaArte";
            lblTitulo.Text = "Vanguardia\r\nArte";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(46, 17, 39);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = Color.FromArgb(245, 235, 240);
            button2.Location = new Point(18, 606);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(210, 30);
            button2.TabIndex = 9;
            button2.Tag = "btn_GestionDeBitacora";
            button2.Text = "Gestión de Bitácora";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(46, 17, 39);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button5.ForeColor = Color.FromArgb(245, 235, 240);
            button5.Location = new Point(18, 642);
            button5.Margin = new Padding(2, 3, 2, 3);
            button5.Name = "button5";
            button5.Size = new Size(210, 30);
            button5.TabIndex = 13;
            button5.Tag = "btn_GestionDeIdioma";
            button5.Text = "Gestión de Idioma";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(46, 17, 39);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button4.ForeColor = Color.FromArgb(245, 235, 240);
            button4.Location = new Point(18, 500);
            button4.Margin = new Padding(1);
            button4.Name = "button4";
            button4.Size = new Size(210, 30);
            button4.TabIndex = 12;
            button4.Tag = "btn_CambiarClave";
            button4.Text = "CAMBIAR CLAVE";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(46, 17, 39);
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCerrarSesion.ForeColor = Color.FromArgb(255, 140, 140);
            btnCerrarSesion.Location = new Point(18, 814);
            btnCerrarSesion.Margin = new Padding(1);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(210, 30);
            btnCerrarSesion.TabIndex = 10;
            btnCerrarSesion.Tag = "btn_CerrarSesion";
            btnCerrarSesion.Text = "CERRAR SESIÓN";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnTesoreria_Cobros
            // 
            btnTesoreria_Cobros.BackColor = Color.FromArgb(46, 17, 39);
            btnTesoreria_Cobros.FlatAppearance.BorderSize = 0;
            btnTesoreria_Cobros.FlatStyle = FlatStyle.Flat;
            btnTesoreria_Cobros.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTesoreria_Cobros.ForeColor = Color.FromArgb(245, 235, 240);
            btnTesoreria_Cobros.Location = new Point(18, 302);
            btnTesoreria_Cobros.Margin = new Padding(1);
            btnTesoreria_Cobros.Name = "btnTesoreria_Cobros";
            btnTesoreria_Cobros.Size = new Size(210, 30);
            btnTesoreria_Cobros.TabIndex = 6;
            btnTesoreria_Cobros.Tag = "btn_TesoreriaCobros";
            btnTesoreria_Cobros.Text = "TESORERÍA/COBROS";
            btnTesoreria_Cobros.TextAlign = ContentAlignment.MiddleLeft;
            btnTesoreria_Cobros.UseVisualStyleBackColor = false;
            btnTesoreria_Cobros.Click += btnTesoreria_Cobros_Click;
            // 
            // btnArtista
            // 
            btnArtista.BackColor = Color.FromArgb(46, 17, 39);
            btnArtista.FlatAppearance.BorderSize = 0;
            btnArtista.FlatStyle = FlatStyle.Flat;
            btnArtista.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnArtista.ForeColor = Color.FromArgb(245, 235, 240);
            btnArtista.Location = new Point(18, 204);
            btnArtista.Margin = new Padding(2, 3, 2, 3);
            btnArtista.Name = "btnArtista";
            btnArtista.Size = new Size(210, 30);
            btnArtista.TabIndex = 3;
            btnArtista.Tag = "btn_Artistas";
            btnArtista.Text = "ARTISTAS";
            btnArtista.TextAlign = ContentAlignment.MiddleLeft;
            btnArtista.UseVisualStyleBackColor = false;
            btnArtista.Click += btnTransacciones_Click;
            // 
            // btnReserva
            // 
            btnReserva.BackColor = Color.FromArgb(46, 17, 39);
            btnReserva.FlatAppearance.BorderSize = 0;
            btnReserva.FlatStyle = FlatStyle.Flat;
            btnReserva.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReserva.ForeColor = Color.FromArgb(245, 235, 240);
            btnReserva.Location = new Point(18, 270);
            btnReserva.Margin = new Padding(1);
            btnReserva.Name = "btnReserva";
            btnReserva.Size = new Size(210, 30);
            btnReserva.TabIndex = 5;
            btnReserva.Tag = "btn_Reservas";
            btnReserva.Text = "RESERVAS";
            btnReserva.TextAlign = ContentAlignment.MiddleLeft;
            btnReserva.UseVisualStyleBackColor = false;
            btnReserva.Click += btnVencimientos_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(46, 17, 39);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.ForeColor = Color.FromArgb(245, 235, 240);
            button3.Location = new Point(18, 570);
            button3.Margin = new Padding(2, 3, 2, 3);
            button3.Name = "button3";
            button3.Size = new Size(210, 30);
            button3.TabIndex = 11;
            button3.Tag = "btn_GestionPerfiles";
            button3.Text = "Gestión Perfiles";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnCatalogo
            // 
            btnCatalogo.BackColor = Color.FromArgb(46, 17, 39);
            btnCatalogo.FlatAppearance.BorderSize = 0;
            btnCatalogo.FlatStyle = FlatStyle.Flat;
            btnCatalogo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCatalogo.ForeColor = Color.FromArgb(245, 235, 240);
            btnCatalogo.Location = new Point(18, 238);
            btnCatalogo.Margin = new Padding(1);
            btnCatalogo.Name = "btnCatalogo";
            btnCatalogo.Size = new Size(210, 30);
            btnCatalogo.TabIndex = 7;
            btnCatalogo.Tag = "btn_CatalogoObras";
            btnCatalogo.Text = "CATÁLOGO DE OBRAS";
            btnCatalogo.TextAlign = ContentAlignment.MiddleLeft;
            btnCatalogo.UseVisualStyleBackColor = false;
            btnCatalogo.Click += btnCatalogo_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(46, 17, 39);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.FromArgb(245, 235, 240);
            button1.Location = new Point(18, 534);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(210, 30);
            button1.TabIndex = 8;
            button1.Tag = "btn_GestionUsuarios";
            button1.Text = "Gestión de Usuarios";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panelUsuario
            // 
            panelUsuario.BackColor = Color.FromArgb(46, 17, 39);
            panelUsuario.Controls.Add(label1);
            panelUsuario.Controls.Add(lblUsuarioActivo);
            panelUsuario.Controls.Add(lblUsuarioValor);
            panelUsuario.Controls.Add(lblUsuario);
            panelUsuario.Controls.Add(lblBD);
            panelUsuario.Dock = DockStyle.Bottom;
            panelUsuario.Location = new Point(245, 873);
            panelUsuario.Margin = new Padding(0);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Size = new Size(999, 40);
            panelUsuario.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(104, 10);
            label1.Name = "label1";
            label1.Size = new Size(161, 15);
            label1.TabIndex = 4;
            label1.Text = "Maria Lopez -Administrador";
            // 
            // lblUsuarioActivo
            // 
            lblUsuarioActivo.AutoSize = true;
            lblUsuarioActivo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuarioActivo.ForeColor = Color.White;
            lblUsuarioActivo.Location = new Point(13, 10);
            lblUsuarioActivo.Name = "lblUsuarioActivo";
            lblUsuarioActivo.Size = new Size(89, 15);
            lblUsuarioActivo.TabIndex = 3;
            lblUsuarioActivo.Tag = "lbl_Usuario";
            lblUsuarioActivo.Text = "Usuario activo:";
            // 
            // lblUsuarioValor
            // 
            lblUsuarioValor.AutoSize = true;
            lblUsuarioValor.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUsuarioValor.ForeColor = Color.White;
            lblUsuarioValor.Location = new Point(333, 53);
            lblUsuarioValor.Name = "lblUsuarioValor";
            lblUsuarioValor.Size = new Size(0, 21);
            lblUsuarioValor.TabIndex = 2;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(49, 55);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 21);
            lblUsuario.TabIndex = 0;
            lblUsuario.Tag = "lbl_Usuario";
            // 
            // lblBD
            // 
            lblBD.Location = new Point(431, 46);
            lblBD.Name = "lblBD";
            lblBD.Size = new Size(243, 63);
            lblBD.TabIndex = 1;
            // 
            // panelMovimientos
            // 
            panelMovimientos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMovimientos.BackColor = Color.White;
            panelMovimientos.Location = new Point(245, 0);
            panelMovimientos.Margin = new Padding(0);
            panelMovimientos.Name = "panelMovimientos";
            panelMovimientos.Size = new Size(999, 872);
            panelMovimientos.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Concepto";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Descripción";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Valor";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 250;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(1244, 913);
            Controls.Add(panelUsuario);
            Controls.Add(panelMovimientos);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(0);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "lbl_Usuario";
            Text = "Vanguardia Arte - Sistema de Gestión de Galería";
            FormClosed += FormMenu_FormClosed;
            Load += FormMenu_Load;
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelUsuario.ResumeLayout(false);
            panelUsuario.PerformLayout();
            ResumeLayout(false);
        }


        private Panel panelMenu;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Label lblTitulo;
        private Button btnArtista;
        private Button btnReserva;
        private Button btnTesoreria_Cobros;
        private Button btnCatalogo;
        private Panel panelUsuario;
        private Panel panelMovimientos;
        private Button button2;
        private Button button1;
        private Button btnCerrarSesion;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label lblUsuarioValor;
        private Label lblUsuario;
        private Label lblBD;
        private Button button7;
        private Label lblUsuarioActivo;
        private Label label1;
        private Button button8;
        private Button btn_Salas_Calendario;
        private Button btn_Estado_PostExhibicion;
        private Button button9;
        private Label lblSeccionOperacion;
        private Label lblSeccionSistema;
        private PictureBox pictureBox1;
    }
}
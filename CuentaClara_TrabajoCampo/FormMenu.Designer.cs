namespace CuentaClara_TrabajoCampo
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelMenu = new Panel();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            lblTitulo = new Label();
            button2 = new Button();
            picLogo = new PictureBox();
            button5 = new Button();
            button4 = new Button();
            btnCerrarSesion = new Button();
            btnSaldos = new Button();
            btnInicio = new Button();
            btnTransacciones = new Button();
            btnCategorias = new Button();
            btnVencimientos = new Button();
            button3 = new Button();
            btnGraficos = new Button();
            button1 = new Button();
            panelUsuario = new Panel();
            label1 = new Label();
            lblUsuarioActivo = new Label();
            lblUsuarioValor = new Label();
            lblUsuario = new Label();
            lblBD = new Label();
            panelMovimientos = new Panel();
            dgvMovimientos = new DataGridView();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            btnNuevoIngreso = new Button();
            lblSaldoGeneral = new Label();
            lblEstadoSaldos = new Label();
            btnNuevoEgreso = new Button();
            lblHistorial = new Label();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panelUsuario.SuspendLayout();
            panelMovimientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.White;
            panelMenu.Controls.Add(button8);
            panelMenu.Controls.Add(button7);
            panelMenu.Controls.Add(button6);
            panelMenu.Controls.Add(lblTitulo);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(picLogo);
            panelMenu.Controls.Add(button5);
            panelMenu.Controls.Add(button4);
            panelMenu.Controls.Add(btnCerrarSesion);
            panelMenu.Controls.Add(btnSaldos);
            panelMenu.Controls.Add(btnInicio);
            panelMenu.Controls.Add(btnTransacciones);
            panelMenu.Controls.Add(btnCategorias);
            panelMenu.Controls.Add(btnVencimientos);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(btnGraficos);
            panelMenu.Controls.Add(button1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(204, 849);
            panelMenu.TabIndex = 2;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button8.ForeColor = Color.FromArgb(18, 87, 150);
            button8.Location = new Point(20, 762);
            button8.Margin = new Padding(0);
            button8.Name = "button8";
            button8.Size = new Size(159, 34);
            button8.TabIndex = 16;
            button8.Tag = "btn_Ayuda";
            button8.Text = "AYUDA";
            button8.TextAlign = ContentAlignment.MiddleLeft;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button7.Location = new Point(11, 604);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Size = new Size(180, 34);
            button7.TabIndex = 15;
            button7.Tag = "btn_GestionDeRespaldo";
            button7.Text = "Gestión de Respaldo\r\n";
            button7.TextAlign = ContentAlignment.MiddleLeft;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button6.BackColor = Color.White;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button6.Location = new Point(11, 638);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(170, 52);
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
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(20, 70, 120);
            lblTitulo.Location = new Point(10, 74);
            lblTitulo.Margin = new Padding(1, 0, 1, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(152, 32);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "CuentaClara";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(11, 528);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(180, 30);
            button2.TabIndex = 9;
            button2.Tag = "btn_GestionDeBitacora";
            button2.Text = "Gestión de Bitácora";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // picLogo
            // 
            picLogo.BorderStyle = BorderStyle.FixedSingle;
            picLogo.Image = IU.Properties.Resources.logo;
            picLogo.Location = new Point(15, 9);
            picLogo.Margin = new Padding(0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(71, 57);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button5.Location = new Point(10, 564);
            button5.Margin = new Padding(2, 3, 2, 3);
            button5.Name = "button5";
            button5.Size = new Size(175, 37);
            button5.TabIndex = 13;
            button5.Tag = "btn_GestionDeIdioma";
            button5.Text = "Gestión de Idioma";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button4.Location = new Point(12, 377);
            button4.Margin = new Padding(1);
            button4.Name = "button4";
            button4.Size = new Size(181, 46);
            button4.TabIndex = 12;
            button4.Tag = "btn_CambiarClave";
            button4.Text = "CAMBIAR CLAVE";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.White;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCerrarSesion.Location = new Point(20, 706);
            btnCerrarSesion.Margin = new Padding(1);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(153, 31);
            btnCerrarSesion.TabIndex = 10;
            btnCerrarSesion.Tag = "btn_CerrarSesion";
            btnCerrarSesion.Text = "CERRAR SESIÓN";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnSaldos
            // 
            btnSaldos.BackColor = Color.White;
            btnSaldos.FlatAppearance.BorderSize = 0;
            btnSaldos.FlatStyle = FlatStyle.Flat;
            btnSaldos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSaldos.Location = new Point(15, 305);
            btnSaldos.Margin = new Padding(1);
            btnSaldos.Name = "btnSaldos";
            btnSaldos.Size = new Size(158, 29);
            btnSaldos.TabIndex = 6;
            btnSaldos.Tag = "btn_SaldosCruzados";
            btnSaldos.Text = "SALDOS CRUZADOS";
            btnSaldos.TextAlign = ContentAlignment.MiddleLeft;
            btnSaldos.UseVisualStyleBackColor = false;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.White;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnInicio.Location = new Point(15, 147);
            btnInicio.Margin = new Padding(2, 3, 2, 3);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(143, 32);
            btnInicio.TabIndex = 2;
            btnInicio.Tag = "btn_Inicio";
            btnInicio.Text = "INICIO";
            btnInicio.TextAlign = ContentAlignment.MiddleLeft;
            btnInicio.UseVisualStyleBackColor = false;
            // 
            // btnTransacciones
            // 
            btnTransacciones.BackColor = Color.White;
            btnTransacciones.FlatAppearance.BorderSize = 0;
            btnTransacciones.FlatStyle = FlatStyle.Flat;
            btnTransacciones.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTransacciones.Location = new Point(15, 185);
            btnTransacciones.Margin = new Padding(2, 3, 2, 3);
            btnTransacciones.Name = "btnTransacciones";
            btnTransacciones.Size = new Size(164, 33);
            btnTransacciones.TabIndex = 3;
            btnTransacciones.Tag = "btn_Transacciones";
            btnTransacciones.Text = "TRANSACCIONES";
            btnTransacciones.TextAlign = ContentAlignment.MiddleLeft;
            btnTransacciones.UseVisualStyleBackColor = false;
            // 
            // btnCategorias
            // 
            btnCategorias.BackColor = Color.White;
            btnCategorias.FlatAppearance.BorderSize = 0;
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCategorias.Location = new Point(12, 338);
            btnCategorias.Margin = new Padding(2, 3, 2, 3);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(152, 35);
            btnCategorias.TabIndex = 4;
            btnCategorias.Tag = "btn_Categorias";
            btnCategorias.Text = "CATEGORÍAS";
            btnCategorias.TextAlign = ContentAlignment.MiddleLeft;
            btnCategorias.UseVisualStyleBackColor = false;
            // 
            // btnVencimientos
            // 
            btnVencimientos.BackColor = Color.White;
            btnVencimientos.FlatAppearance.BorderSize = 0;
            btnVencimientos.FlatStyle = FlatStyle.Flat;
            btnVencimientos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnVencimientos.Location = new Point(15, 265);
            btnVencimientos.Margin = new Padding(1);
            btnVencimientos.Name = "btnVencimientos";
            btnVencimientos.Size = new Size(164, 28);
            btnVencimientos.TabIndex = 5;
            btnVencimientos.Tag = "btn_Vencimientos";
            btnVencimientos.Text = "VENCIMIENTOS";
            btnVencimientos.TextAlign = ContentAlignment.MiddleLeft;
            btnVencimientos.UseVisualStyleBackColor = false;
            btnVencimientos.Click += btnVencimientos_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button3.Location = new Point(10, 494);
            button3.Margin = new Padding(2, 3, 2, 3);
            button3.Name = "button3";
            button3.Size = new Size(163, 28);
            button3.TabIndex = 11;
            button3.Tag = "btn_GestionPerfiles";
            button3.Text = "Gestión Perfiles";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnGraficos
            // 
            btnGraficos.BackColor = Color.White;
            btnGraficos.FlatAppearance.BorderSize = 0;
            btnGraficos.FlatStyle = FlatStyle.Flat;
            btnGraficos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGraficos.Location = new Point(15, 222);
            btnGraficos.Margin = new Padding(1);
            btnGraficos.Name = "btnGraficos";
            btnGraficos.Size = new Size(164, 31);
            btnGraficos.TabIndex = 7;
            btnGraficos.Tag = "btn_Graficos";
            btnGraficos.Text = "GRÁFICOS";
            btnGraficos.TextAlign = ContentAlignment.MiddleLeft;
            btnGraficos.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button1.Location = new Point(11, 451);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(190, 37);
            button1.TabIndex = 8;
            button1.Tag = "btn_GestionUsuarios";
            button1.Text = "Gestión de Usuarios";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panelUsuario
            // 
            panelUsuario.BackColor = Color.FromArgb(18, 87, 150);
            panelUsuario.Controls.Add(label1);
            panelUsuario.Controls.Add(lblUsuarioActivo);
            panelUsuario.Controls.Add(lblUsuarioValor);
            panelUsuario.Controls.Add(lblUsuario);
            panelUsuario.Controls.Add(lblBD);
            panelUsuario.Dock = DockStyle.Bottom;
            panelUsuario.Location = new Point(204, 809);
            panelUsuario.Margin = new Padding(0);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Size = new Size(1059, 40);
            panelUsuario.TabIndex = 3;
            panelUsuario.Paint += panelUsuario_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(114, 10);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(161, 15);
            label1.TabIndex = 4;
            label1.Tag = "";
            label1.Text = "Maria Lopez -Administrador";
            // 
            // lblUsuarioActivo
            // 
            lblUsuarioActivo.AutoSize = true;
            lblUsuarioActivo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUsuarioActivo.ForeColor = Color.White;
            lblUsuarioActivo.Location = new Point(14, 10);
            lblUsuarioActivo.Margin = new Padding(1, 0, 1, 0);
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
            lblUsuarioValor.Margin = new Padding(7, 0, 7, 0);
            lblUsuarioValor.Name = "lblUsuarioValor";
            lblUsuarioValor.Size = new Size(0, 21);
            lblUsuarioValor.TabIndex = 2;
            lblUsuarioValor.Tag = "";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(49, 55);
            lblUsuario.Margin = new Padding(7, 0, 7, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(0, 21);
            lblUsuario.TabIndex = 0;
            lblUsuario.Tag = "lbl_Usuario";
            // 
            // lblBD
            // 
            lblBD.Location = new Point(431, 46);
            lblBD.Margin = new Padding(7, 0, 7, 0);
            lblBD.Name = "lblBD";
            lblBD.Size = new Size(243, 63);
            lblBD.TabIndex = 1;
            lblBD.Click += lblBD_Click;
            // 
            // panelMovimientos
            // 
            panelMovimientos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMovimientos.BackColor = Color.White;
            panelMovimientos.Controls.Add(dgvMovimientos);
            panelMovimientos.Controls.Add(btnNuevoIngreso);
            panelMovimientos.Controls.Add(lblSaldoGeneral);
            panelMovimientos.Controls.Add(lblEstadoSaldos);
            panelMovimientos.Controls.Add(btnNuevoEgreso);
            panelMovimientos.Location = new Point(218, 104);
            panelMovimientos.Margin = new Padding(0);
            panelMovimientos.Name = "panelMovimientos";
            panelMovimientos.Size = new Size(1025, 730);
            panelMovimientos.TabIndex = 0;
            panelMovimientos.Paint += panelMovimientos_Paint;
            // 
            // dgvMovimientos
            // 
            dgvMovimientos.AllowUserToAddRows = false;
            dgvMovimientos.AllowUserToDeleteRows = false;
            dgvMovimientos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMovimientos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMovimientos.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMovimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvMovimientos.ColumnHeadersHeight = 30;
            dgvMovimientos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvMovimientos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvMovimientos.Location = new Point(35, 92);
            dgvMovimientos.Margin = new Padding(0);
            dgvMovimientos.Name = "dgvMovimientos";
            dgvMovimientos.ReadOnly = true;
            dgvMovimientos.RowHeadersVisible = false;
            dgvMovimientos.RowHeadersWidth = 102;
            dgvMovimientos.Size = new Size(913, 428);
            dgvMovimientos.TabIndex = 1;
            dgvMovimientos.Tag = "dgv_Menu";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Concepto";
            dataGridViewTextBoxColumn4.MinimumWidth = 12;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Descripción";
            dataGridViewTextBoxColumn5.MinimumWidth = 12;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Valor";
            dataGridViewTextBoxColumn6.MinimumWidth = 12;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // btnNuevoIngreso
            // 
            btnNuevoIngreso.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNuevoIngreso.FlatStyle = FlatStyle.Flat;
            btnNuevoIngreso.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNuevoIngreso.Location = new Point(758, 579);
            btnNuevoIngreso.Margin = new Padding(0);
            btnNuevoIngreso.Name = "btnNuevoIngreso";
            btnNuevoIngreso.Size = new Size(190, 45);
            btnNuevoIngreso.TabIndex = 2;
            btnNuevoIngreso.Tag = "btn_RegistrarNuevoIngreso";
            btnNuevoIngreso.Text = "Registrar Nuevo Ingreso +";
            // 
            // lblSaldoGeneral
            // 
            lblSaldoGeneral.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSaldoGeneral.AutoSize = true;
            lblSaldoGeneral.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblSaldoGeneral.ForeColor = Color.FromArgb(15, 45, 75);
            lblSaldoGeneral.Location = new Point(12, 25);
            lblSaldoGeneral.Margin = new Padding(1, 0, 1, 0);
            lblSaldoGeneral.Name = "lblSaldoGeneral";
            lblSaldoGeneral.Size = new Size(400, 32);
            lblSaldoGeneral.TabIndex = 1;
            lblSaldoGeneral.Tag = "lbl_SaldoGeneral";
            lblSaldoGeneral.Text = "Saldo Líquido General del Hogar: \r\n";
            // 
            // lblEstadoSaldos
            // 
            lblEstadoSaldos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblEstadoSaldos.AutoSize = true;
            lblEstadoSaldos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEstadoSaldos.Location = new Point(12, 605);
            lblEstadoSaldos.Margin = new Padding(0);
            lblEstadoSaldos.Name = "lblEstadoSaldos";
            lblEstadoSaldos.Size = new Size(393, 21);
            lblEstadoSaldos.TabIndex = 4;
            lblEstadoSaldos.Tag = "lbl_SaldosConciliados:HogarenEquilibrioyArmonia";
            lblEstadoSaldos.Text = "Saldos Conciliados: Hogar en Equilibrio y Armonía";
            // 
            // btnNuevoEgreso
            // 
            btnNuevoEgreso.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNuevoEgreso.FlatStyle = FlatStyle.Flat;
            btnNuevoEgreso.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNuevoEgreso.Location = new Point(525, 579);
            btnNuevoEgreso.Margin = new Padding(0);
            btnNuevoEgreso.Name = "btnNuevoEgreso";
            btnNuevoEgreso.Size = new Size(190, 45);
            btnNuevoEgreso.TabIndex = 3;
            btnNuevoEgreso.Tag = "btn_RegistrarNuevoEgreso";
            btnNuevoEgreso.Text = "Registrar Nuevo Egreso -";
            // 
            // lblHistorial
            // 
            lblHistorial.AutoSize = true;
            lblHistorial.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblHistorial.Location = new Point(218, 31);
            lblHistorial.Margin = new Padding(0);
            lblHistorial.Name = "lblHistorial";
            lblHistorial.Size = new Size(368, 30);
            lblHistorial.TabIndex = 0;
            lblHistorial.Tag = "lbl_Historial";
            lblHistorial.Text = "Historial Reciente de Movimientos";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Concepto";
            dataGridViewTextBoxColumn1.MinimumWidth = 12;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Descripción";
            dataGridViewTextBoxColumn2.MinimumWidth = 12;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Valor";
            dataGridViewTextBoxColumn3.MinimumWidth = 12;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 250;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(1263, 849);
            Controls.Add(lblHistorial);
            Controls.Add(panelUsuario);
            Controls.Add(panelMovimientos);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(0);
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "lbl_Usuario";
            Text = "CuentaClara - Gestión Financiera Familiar";
            FormClosed += FormMenu_FormClosed;
            Load += FormMenu_Load;
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panelUsuario.ResumeLayout(false);
            panelUsuario.PerformLayout();
            panelMovimientos.ResumeLayout(false);
            panelMovimientos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMovimientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panelMenu;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;

        private PictureBox picLogo;
        private Label lblTitulo;

        private Button btnInicio;
        private Button btnTransacciones;
        private Button btnCategorias;
        private Button btnVencimientos;
        private Button btnSaldos;
        private Button btnGraficos;

        private Panel panelUsuario;

        private Panel panelMovimientos;
        private Label lblHistorial;

        private DataGridView dgvMovimientos;

        private Button btnNuevoIngreso;
        private Button btnNuevoEgreso;

        private Label lblEstadoSaldos;
        private Label lblSaldoGeneral;
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
    }
}
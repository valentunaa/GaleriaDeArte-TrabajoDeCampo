using BLL;
using IU;
using Servicio;
using System.Diagnostics;

namespace CuentaClara_TrabajoCampo
{
    public partial class FormMenu : Form, IObserverIdioma
    {

        private BLL_Usuario bllUsuario = new BLL_Usuario();
        private BLL_Rol bllRol = new BLL_Rol();
        public FormMenu()
        {
            InitializeComponent();
            ConfigurarToolTips();
            GestorIdioma.GetInstancia().Suscribir(this);

        }


        private void ConfigurarToolTips()
        {
            // Módulo Operación
            toolTipMenu.SetToolTip(btnArtista, TraducirTexto("Menu_Tip_Artistas"));
            toolTipMenu.SetToolTip(btnCatalogo, TraducirTexto("Menu_Tip_CatalogoObras"));
            toolTipMenu.SetToolTip(btnReserva, TraducirTexto("Menu_Tip_Reservas"));
            toolTipMenu.SetToolTip(btnTesoreria_Cobros, TraducirTexto("Menu_Tip_Tesoreria"));
            toolTipMenu.SetToolTip(btn_Estado_PostExhibicion, TraducirTexto("Menu_Tip_EstadoPostExhibicion"));
            toolTipMenu.SetToolTip(btn_Salas_Calendario, TraducirTexto("Menu_Tip_RetiroObra")); 

            toolTipMenu.SetToolTip(button11, TraducirTexto("Menu_Tip_RegistrarPedido"));
            toolTipMenu.SetToolTip(button12, TraducirTexto("Menu_Tip_RetiroPedido"));
            toolTipMenu.SetToolTip(button10, TraducirTexto("Menu_Tip_ProductosCafeteria"));
            toolTipMenu.SetToolTip(button13, TraducirTexto("Menu_Tip_ClientesCafeteria"));

            // Módulo Sistema
            toolTipMenu.SetToolTip(button1, TraducirTexto("Menu_Tip_GestionUsuarios"));
            toolTipMenu.SetToolTip(button7, TraducirTexto("Menu_Tip_GestionRespaldo"));
            toolTipMenu.SetToolTip(button4, TraducirTexto("Menu_Tip_CambiarContrasenia"));
            toolTipMenu.SetToolTip(button3, TraducirTexto("Menu_Tip_GestionPerfiles"));
            toolTipMenu.SetToolTip(button2, TraducirTexto("Menu_Tip_GestionBitacora"));
            toolTipMenu.SetToolTip(button5, TraducirTexto("Menu_Tip_GestionIdioma"));
            toolTipMenu.SetToolTip(button6, TraducirTexto("Menu_Tip_CambiarIdioma"));
            toolTipMenu.SetToolTip(button14, TraducirTexto("Menu_Tip_BitacoraCambios"));

            toolTipMenu.SetToolTip(btnCerrarSesion, TraducirTexto("Menu_Tip_CerrarSesion"));
            toolTipMenu.SetToolTip(button8, TraducirTexto("Menu_Tip_Ayuda"));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FormGestionBitacora frm = new FormGestionBitacora();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormGestionUsuarios frm = new FormGestionUsuarios();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            bllUsuario.CerrarSesion();
            this.Hide();
            frmLogIn login = new frmLogIn();
            login.ShowDialog();

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormGestionPerfil frm = new FormGestionPerfil();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormCambiarClave frm = new FormCambiarClave();
            this.Hide();
            frm.ShowDialog();
            this.Show();

        }

        private void DeshabilitarTodosLosBotones()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

            btnCatalogo.Enabled = false;
            btnReserva.Enabled = false;
            btnArtista.Enabled = false;
            btnTesoreria_Cobros.Enabled = false;
            button7.Enabled = false;
        }

        private bool ValidarPermisoEnArbol(Servicio_Rol componente, string idPermisoBuscado)
        {
            if (componente == null) return false;


            if (componente.IdRol == idPermisoBuscado)
                return true;


            if (componente is Servicio_Familia familia)
            {
                foreach (Servicio_Rol hijo in familia.ObtenerHijos())
                {

                    if (ValidarPermisoEnArbol(hijo, idPermisoBuscado))
                    {
                        return true;
                    }
                }
            }


            return false;
        }
        private void Bloquear(Servicio_Usuario usuarioActual)
        {
            if (usuarioActual == null || usuarioActual.Permisos == null)
            {
                DeshabilitarTodosLosBotones();
                return;
            }

            button1.Enabled = bllRol.ValidarPermisoEnArbol(usuarioActual.Permisos, "P41");
            button3.Enabled = bllRol.ValidarPermisoEnArbol(usuarioActual.Permisos, "P42");
            button2.Enabled = bllRol.ValidarPermisoEnArbol(usuarioActual.Permisos, "P43");
            button5.Enabled = bllRol.ValidarPermisoEnArbol(usuarioActual.Permisos, "P44");
            btnArtista.Enabled = bllRol.ValidarPermisoEnArbol(usuarioActual.Permisos, "Artista");
            btnCatalogo.Enabled = bllRol.ValidarPermisoEnArbol(usuarioActual.Permisos, "Catalogo_Obras");
            btn_Estado_PostExhibicion.Enabled = bllRol.ValidarPermisoEnArbol(usuarioActual.Permisos, "P46");
            btnReserva.Enabled = bllRol.ValidarPermisoEnArbol(usuarioActual.Permisos, "Reserva");
            btnTesoreria_Cobros.Enabled = bllRol.ValidarPermisoEnArbol(usuarioActual.Permisos, "Tesoreria_Cobro");
            btn_Salas_Calendario.Enabled = bllRol.ValidarPermisoEnArbol(usuarioActual.Permisos, "P45");
            button7.Enabled = bllRol.ValidarPermisoEnArbol(usuarioActual.Permisos, "P36");
            button9.Enabled = bllRol.ValidarPermisoEnArbol(usuarioActual.Permisos, "P47");
            button11.Enabled = bllRol.ValidarPermisoEnArbol(usuarioActual.Permisos, "P48");
            button12.Enabled = bllRol.ValidarPermisoEnArbol(usuarioActual.Permisos, "P49");
            button14.Enabled = bllRol.ValidarPermisoEnArbol(usuarioActual.Permisos, "P50");
            button10.Enabled = bllRol.ValidarPermisoEnArbol(usuarioActual.Permisos, "P53");
            button13.Enabled = bllRol.ValidarPermisoEnArbol(usuarioActual.Permisos, "P54");

        }

        public void ActualizarIdioma()
        {
            string idIdioma = SessionManager.GetInstancia().GetUsuarioActual().Id_Idioma;

            BLL_Idioma bllIdioma = new BLL_Idioma();

            Servicio_Idioma idioma = bllIdioma.ObtenerIdiomaPorId(idIdioma);

            if (idioma == null)
                return;


            TraducirControles(this.Controls, idioma);
            this.Text = TraducirTexto("titulo_FormMenu");
            ConfigurarToolTips();

        }


        private void TraducirControles(Control.ControlCollection controles, Servicio_Idioma idioma)
        {
            foreach (Control c in controles)
            {
                if (c.Tag != null)
                {
                    string clave = c.Tag.ToString();

                    var etiqueta = idioma.Etiquetas.FirstOrDefault(x => x.Clave == clave);
                    if (etiqueta != null) c.Text = etiqueta.Texto;

                }

                if (c is DataGridView dgv)
                {
                    foreach (DataGridViewColumn col in dgv.Columns)
                    {
                        string clave = col.Name;

                        var etiqueta = idioma.Etiquetas.FirstOrDefault(x => x.Clave == clave);

                        if (etiqueta != null) col.HeaderText = etiqueta.Texto;

                    }
                }

                if (c.HasChildren)
                    TraducirControles(c.Controls, idioma);
            }
        }


        private string TraducirTexto(string clave)
        {
            string idIdioma = SessionManager.GetInstancia().GetUsuarioActual().Id_Idioma;

            BLL_Idioma bllIdioma = new BLL_Idioma();

            Servicio_Idioma idioma = bllIdioma.ObtenerIdiomaPorId(idIdioma);

            if (idioma == null)
                return clave;

            var etiqueta = idioma.Etiquetas.FirstOrDefault(x => x.Clave == clave);

            return etiqueta != null ? etiqueta.Texto : clave;
        }



        private void FormMenu_Load(object sender, EventArgs e)
        {

            var usuarioActual = SessionManager.GetInstancia().GetUsuarioActual();
            BLL_Rol bllRol = new BLL_Rol();
            string nombreLegibleDelRol = bllRol.ObtenerNombreRol(usuarioActual.IdRol);

            lblUsuario.Text = $"Usuario:";
            label1.Text = $"{usuarioActual.Login}-{nombreLegibleDelRol}";

            Bloquear(usuarioActual);
            ActualizarIdioma();
        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            GestorIdioma.GetInstancia().Desuscribir(this);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormGestionIdioma frm = new FormGestionIdioma();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)//cambiar idioma
        {
            FormConfiguracion frm = new FormConfiguracion();
            frm.ShowDialog();
        }

        private void btnVencimientos_Click(object sender, EventArgs e)
        {
            Form_Reserva_Sala_VM516 frm = new Form_Reserva_Sala_VM516();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormGestionRespaldo frm = new FormGestionRespaldo();
            frm.ShowDialog();
        }


        private void button8_Click(object sender, EventArgs e)//boton de ayuda
        {
            string ruta = Path.Combine(Application.StartupPath, "Manual_de_Usuario_e_Instalacion.pdf");

            if (File.Exists(ruta))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = ruta,
                    UseShellExecute = true
                });
            }
            else
            {
                MessageBox.Show(
                    TraducirTexto("err_ManualNoEncontrado"),
                    TraducirTexto("Ayuda"),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnTransacciones_Click(object sender, EventArgs e)
        {
            Form_RegistroArtista_VM516 frm = new Form_RegistroArtista_VM516();
            frm.ShowDialog();
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            Form_Especificacion_Obra_VM516 frm = new Form_Especificacion_Obra_VM516();
            frm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form_Sala_VM516 frm = new Form_Sala_VM516();
            frm.ShowDialog();
        }

        private void btn_Estado_PostExhibicion_Click(object sender, EventArgs e)
        {
            Form_Inspeccion_Obra_VM516 frm = new Form_Inspeccion_Obra_VM516();
            frm.ShowDialog();
        }

        private void btnTesoreria_Cobros_Click(object sender, EventArgs e)
        {
            Form_Cobro_VM516 frm = new Form_Cobro_VM516();
            frm.ShowDialog();
        }

        private void btn_Salas_Calendario_Click(object sender, EventArgs e)
        {
            Form_Retiro_Obra_VM516 frm = new Form_Retiro_Obra_VM516();
            frm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form_Cafeteria_VM516 frm = new Form_Cafeteria_VM516();
            frm.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form_Retiro_Pedido_VM516 frm = new Form_Retiro_Pedido_VM516();
            frm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form_Gestion_Productos_VM516 frm = new Form_Gestion_Productos_VM516();
            frm.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form_Gestion_Clientes_VM516 frm = new Form_Gestion_Clientes_VM516();
            frm.ShowDialog();
        }

        private void FormMenu_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void panelMenu_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form_Bitacoras_Cambios_VM516 frm = new Form_Bitacoras_Cambios_VM516();
            frm.ShowDialog();
        }

        
    }
}


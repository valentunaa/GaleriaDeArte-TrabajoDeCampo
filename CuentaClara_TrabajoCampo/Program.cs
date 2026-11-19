using IU;
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CuentaClara_TrabajoCampo
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
        
            ApplicationConfiguration.Initialize();

            BLL.BLL_Instalador gestorInstalacion = new BLL.BLL_Instalador();

            // 1. Instalación desde cero: si pidió hacer backup previo, abre FormBackupInstalacion_VM516
            if (gestorInstalacion.DebeHacerBackupInstalacion())
            {
                using FormBackupInstalacion_VM516 frmBackupPrevio = new FormBackupInstalacion_VM516();
                if (frmBackupPrevio.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show(
                        "La instalación desde cero fue cancelada antes de modificar la base de datos.",
                        "Instalación Cancelada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
            }

            // 2. Configuración inicial (instalación limpia) vs. reinstalación con .bak
            if (gestorInstalacion.EsNecesarioInstalar())
            {
                FormPrimeraVez frmConfig = new FormPrimeraVez();

                if (frmConfig.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show(
                        "La configuración inicial es obligatoria para iniciar el sistema.",
                        "Instalación Cancelada",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
            }
            if (gestorInstalacion.DebeCargarBackupReinstalacion())
            {
                using FormReinstalacionBD_VM516 frmBackupReinstalar = new FormReinstalacionBD_VM516();
                if (frmBackupReinstalar.ShowDialog() != DialogResult.OK)
                {
                    MessageBox.Show(
                        "Debe seleccionar y restaurar el archivo de respaldo (.bak) para continuar.",
                        "Respaldo Pendiente",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }
            }
            
            else
            {
                gestorInstalacion.LimpiarFlagsReinstalacion();
            }

            // 3. Si no hay usuarios en la base, crea el primer usuario
            if (!gestorInstalacion.ExistenUsuariosEnBase("BD_VanguardiaArte"))
            {
                using (FormCrearPrimerUsuario frmPrimerUsuario = new FormCrearPrimerUsuario())
                {
                    if (frmPrimerUsuario.ShowDialog() != DialogResult.OK)
                    {
                        MessageBox.Show(
                            "Debe registrar el primer usuario para continuar al inicio de sesión.",
                            "Registro Pendiente",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        return;
                    }
                }
            }
            Application.Run(new frmLogIn());
        }
    }
}
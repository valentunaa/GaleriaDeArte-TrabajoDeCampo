using DAL;
using Microsoft.Data.SqlClient;
using Servicio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Respaldo
    {
        private DAL_Respaldo dal;
        private BLL_BitacoraEvento _bitacora;
        private BLL_DigitoVerificador bllDV = new BLL_DigitoVerificador();
        public  BLL_Respaldo()
        {
             dal = new DAL_Respaldo();
            _bitacora = new BLL_BitacoraEvento();
        }


        public void HacerBackup(string carpetaDestino)
        {
            string nombreArchivo = $"Backup_CuentaClara_{DateTime.Now:yyyyMMdd_HHmmss}.bak";
            string rutaCompleta = System.IO.Path.Combine(carpetaDestino, nombreArchivo);

            dal.EjecutarBackup(rutaCompleta);
            string loginActual = SessionManager.GetInstancia().GetUsuarioActual().ToString();

            _bitacora.RegistrarBitacora("Backup exitoso", loginActual, "Administración", 4);
        }

        public void HacerRestore(string rutaArchivo)
        {
            if (!System.IO.File.Exists(rutaArchivo))
                throw new Exception("err_ArchivoNoExiste");

            if (System.IO.Path.GetExtension(rutaArchivo).ToLower() != ".bak")
                throw new Exception("err_ExtensionBackupInvalida");

            dal.EjecutarRestore(rutaArchivo);
            string loginActual = SessionManager.GetInstancia().GetUsuarioActual().ToString();
            _bitacora.RegistrarBitacora("Restauración de base de datos", loginActual, "Administración", 1);
        }

        public void RecalcularDigitos()
        {
            BLL_DigitoVerificador bllDV = new BLL_DigitoVerificador();
            bllDV.RecalcularDigitos();
        }
    }
}

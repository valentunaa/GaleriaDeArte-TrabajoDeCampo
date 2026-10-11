using BE;
using BLL;
using DAL;
using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL_Negocio
{
    public class BLL_Cliente_VM516
    {
        private DAL_Cliente_VM516 dalCliente_VM516;
        private BLL_DigitoVerificador bllDigito_VM516;
        private BLL_BitacoraEvento bllBitacora_VM516;

        public BLL_Cliente_VM516()
        {
            dalCliente_VM516 = new DAL_Cliente_VM516();
            bllDigito_VM516 = new BLL_DigitoVerificador();
            bllBitacora_VM516 = new BLL_BitacoraEvento();
        }

        public void RegistrarCliente_VM516(string dni_VM516, string nombre_VM516, string apellido_VM516, string telefono_VM516, string email_VM516)
        {
            if (string.IsNullOrWhiteSpace(dni_VM516) ||
                string.IsNullOrWhiteSpace(nombre_VM516) ||
                string.IsNullOrWhiteSpace(apellido_VM516) ||
                string.IsNullOrWhiteSpace(telefono_VM516) ||
                string.IsNullOrWhiteSpace(email_VM516))
            {
                throw new Exception("err_CamposIncompletosCliente");
            }

            if (!Regex.IsMatch(dni_VM516.Trim(), @"^\d{7,8}$"))
            {
                throw new Exception("err_DNIInvalidoCliente");
            }

            if (!Regex.IsMatch(telefono_VM516.Trim(), @"^\d{7,15}$"))
            {
                throw new Exception("err_TelefonoInvalidoCliente");
            }

            if (!Regex.IsMatch(email_VM516.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                throw new Exception("err_EmailInvalidoCliente");
            }

            if (dalCliente_VM516.BuscarClientePorDNI_VM516(dni_VM516.Trim()) != null)
            {
                throw new Exception("err_ClienteDuplicado");
            }

            BE_Cliente_VM516 cliente_VM516 = new BE_Cliente_VM516(
                dni_VM516.Trim(),
                nombre_VM516.Trim(),
                apellido_VM516.Trim(),
                telefono_VM516.Trim(),
                email_VM516.Trim()
            );

            dalCliente_VM516.GuardarCliente_VM516(cliente_VM516);

            // Actualizar Dígitos Verificadores (DVH y DVV)
            List<BE_Cliente_VM516> listaBE_VM516 = dalCliente_VM516.ListarClientes_VM516();
            bllDigito_VM516.ActualizarDigitos(cliente_VM516, listaBE_VM516.Cast<IVerificable>().ToList(), "Cliente_VM516");

            // Registrar en Bitácora
            string loginActual_VM516 = SessionManager.GetInstancia().GetUsuarioActual().Login;
            string detalleEvento_VM516 = $"Alta Cliente: {dni_VM516.Trim()}";
            bllBitacora_VM516.RegistrarBitacora(detalleEvento_VM516, loginActual_VM516, "Negocio - Cafetería", 3);
        }

        public BE_Cliente_VM516 BuscarClientePorDNI_VM516(string dni_VM516)
        {
            if (string.IsNullOrWhiteSpace(dni_VM516))
                throw new Exception("err_DniVacioCliente");

            if (!Regex.IsMatch(dni_VM516.Trim(), @"^\d{7,8}$"))
                throw new Exception("err_DNIInvalidoCliente");

            BE_Cliente_VM516 cliente_VM516 = dalCliente_VM516.BuscarClientePorDNI_VM516(dni_VM516.Trim());

            // Flujo Alternativo 4.1: Cliente No Registrado
            if (cliente_VM516 == null)
                throw new Exception("err_ClienteNoRegistrado");

            return cliente_VM516;
        }

        public List<BE_Cliente_VM516> ListarClientes_VM516()
        {
            return dalCliente_VM516.ListarClientes_VM516();
        }
    }
}
    

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Servicio;
namespace BLL
{
    public class BLL_PDF
    {
        private Servicio_PDF servicioPdf = new Servicio_PDF();
        private BLL_BitacoraEvento bllBitacora = new BLL_BitacoraEvento();
        private DataTable ConvertirListaADateTable(List<Servicio_Bitacora> lista)
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("idEvento");
            tabla.Columns.Add("Evento");
            tabla.Columns.Add("Login");
            tabla.Columns.Add("Modulo");
            tabla.Columns.Add("Criticidad", typeof(int));
            tabla.Columns.Add("Fecha", typeof(DateTime));
            tabla.Columns.Add("Hora");

            foreach (var item in lista)
            {
                tabla.Rows.Add(item.id_Evento, item.Evento, item.Login, item.Modulo, item.Criticidad, item.Fecha, item.Hora);
            }
            return tabla;
        }
        public void ExportarBitacora(List<Servicio_Bitacora> listaEventos, string ruta, string login)
        {
            DataTable tabla = ConvertirListaADateTable(listaEventos);
            servicioPdf.GenerarBitacoraPDF(tabla, ruta);

            bllBitacora.RegistrarBitacora("Impresión/Exportación de Bitácora", login,"Administración",4);  
                
        }
        public void GenerarComprobante_VM516(string nroComprobante, DateTime fechaPago, decimal montoAbonado, string dni, string nombre, string apellido, string medioPago, decimal porcentajeSena, string codigoReserva, string ruta, bool esPagoFinal)
        {

            servicioPdf.GenerarComprobantePDF_VM516(nroComprobante, fechaPago, montoAbonado, dni, nombre, apellido, medioPago, porcentajeSena, codigoReserva, ruta, esPagoFinal);
            string loginActual = SessionManager.GetInstancia().GetUsuarioActual()?.Login;
            string tipoDoc = esPagoFinal ? "Factura Final" : "Comprobante de Seña";

            bllBitacora.RegistrarBitacora($"Impresión/Exportación de {tipoDoc} Nro: {nroComprobante}", loginActual, "Negocio - Tesorería", 4);
        }

        public void GenerarConstanciaLibreDeuda_VM516(string codigoReserva, string dniResponsable, DateTime fechaRetiro, string ruta)
        {

            servicioPdf.GenerarConstanciaLibreDeudaPDF(codigoReserva, dniResponsable, fechaRetiro, ruta);


            string loginActual = SessionManager.GetInstancia().GetUsuarioActual()?.Login;

            bllBitacora.RegistrarBitacora($"Impresión/Exportación de Constancia Libre Deuda - Reserva: {codigoReserva}", loginActual, "Negocio - Tesorería", 4);
        }
    }
}


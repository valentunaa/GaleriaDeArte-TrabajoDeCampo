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

        public void GenerarConstanciaLibreDeuda_VM516(string codigoReserva, int idObra, string tituloObra, string dniArtista, string dniResponsable, DateTime fechaRetiro, string ruta)
        {
            // Llamada al servicio de PDF de QuestPDF que actualizamos antes
            servicioPdf.GenerarConstanciaLibreDeudaPDF(
                codigoReserva,
                idObra,
                tituloObra,
                dniArtista,
                dniResponsable,
                fechaRetiro,
                ruta
            );

            string loginActual = SessionManager.GetInstancia().GetUsuarioActual()?.Login;
            bllBitacora.RegistrarBitacora($"Impresión/Exportación de Constancia Libre Deuda - Reserva: {codigoReserva}", loginActual, "Negocio - Tesorería", 4);
        }
        public void GenerarTicketCafeteria_VM516(
            int numeroTicket_VM516,
            DateTime fechaHora_VM516,
            decimal montoAbonado_VM516,
            string medioPago_VM516,
            int numeroPedido_VM516,
            string dniCliente_VM516,
            string nombreCliente_VM516,
            string apellidoCliente_VM516,
            DataTable detalleItems_VM516,
            string ruta_VM516)
        {
            string loginActual_VM516 = SessionManager.GetInstancia().GetUsuarioActual()?.Login ?? "Cajero";

            servicioPdf.GenerarTicketCafeteriaPDF_VM516(
                numeroTicket_VM516,
                fechaHora_VM516,
                montoAbonado_VM516,
                medioPago_VM516,
                numeroPedido_VM516,
                dniCliente_VM516,
                nombreCliente_VM516,
                apellidoCliente_VM516,
                loginActual_VM516,
                detalleItems_VM516,
                ruta_VM516
            );

            bllBitacora.RegistrarBitacora(
                $"Impresión/Exportación de Ticket de Cafetería Nro: {numeroTicket_VM516}",
                loginActual_VM516,
                "Negocio - Cafetería",
                4
            );
        }
        public void GenerarReporteInteligenteCafeteria_VM516(DataTable dtDatos, string ruta)
        {
            // Llama al diseñador PDF de QuestPDF
            servicioPdf.GenerarReporteInteligenteCafeteriaPDF_VM516(dtDatos, ruta);

            // Registra en bitácora
            string loginActual = SessionManager.GetInstancia().GetUsuarioActual()?.Login ?? "Admin";
            bllBitacora.RegistrarBitacora("Exportación PDF - Reporte Inteligente: Consumos de Cafetería", loginActual, "Negocio - Reportes", 4);
        }

        public void GenerarReporteInteligenteSalas_VM516(DataTable dtDatos, string ruta)
        {
            // Llama al diseñador PDF de QuestPDF
            servicioPdf.GenerarReporteInteligenteSalasPDF_VM516(dtDatos, ruta);

            // Registra en bitácora
            string loginActual = SessionManager.GetInstancia().GetUsuarioActual()?.Login ?? "Admin";
            bllBitacora.RegistrarBitacora("Exportación PDF - Reporte Inteligente: Ocupación de Salas", loginActual, "Negocio - Reportes", 4);
        }
    }
}


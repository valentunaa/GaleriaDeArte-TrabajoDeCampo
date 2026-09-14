using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class Servicio_PDF
    {
        public void GenerarBitacoraPDF(DataTable tabla, string ruta)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Margin(20);

                    page.Header()
                        .Text("Bitácora de Eventos")
                        .FontSize(20)
                        .Bold();

                    page.Content().Table(table =>
                    {
                        table.ColumnsDefinition(columns =>
                        {
                            columns.RelativeColumn();
                            columns.RelativeColumn();
                            columns.RelativeColumn();
                            columns.RelativeColumn();
                            columns.RelativeColumn();
                            columns.RelativeColumn();
                        });

                        table.Cell().Text("Login").Bold();
                        table.Cell().Text("Fecha").Bold();
                        table.Cell().Text("Hora").Bold();
                        table.Cell().Text("Modulo").Bold();
                        table.Cell().Text("Evento").Bold();
                        table.Cell().Text("Criticidad").Bold();

                        foreach (DataRow fila in tabla.Rows)
                        {
                            table.Cell().Text(fila["Login"].ToString());

                            table.Cell().Text(
                                Convert.ToDateTime(fila["Fecha"])
                                .ToString("dd/MM/yyyy")
                            );

                            table.Cell().Text(fila["Hora"].ToString());
                            table.Cell().Text(fila["Modulo"].ToString());
                            table.Cell().Text(fila["Evento"].ToString());
                            table.Cell().Text(fila["Criticidad"].ToString());
                        }
                    });
                });
            })
            .GeneratePdf(ruta);
        }

        public void GenerarComprobantePDF_VM516(string nroComprobante, DateTime fechaPago, decimal montoAbonado, string dni, string nombre, string apellido, string medioPago, decimal porcentajeSena, string codigoReserva, string ruta, bool esPagoFinal)
        {


            QuestPDF.Settings.License = LicenseType.Community;

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(40);
                    page.PageColor(Colors.White);

                    // Encabezado moderno, colorido y elegante con paleta institucional (Tonos Púrpura y Azul)
                    page.Header().Row(row =>
                    {
                        row.RelativeItem().Column(col =>
                        {
                            col.Item().Text("VANGUARDIA ARTE")
                                .FontSize(24)
                                .Bold()
                                .FontColor(Colors.Purple.Darken3);

                            col.Item().Text("Galería Internacional de Arte Contemporáneo")
                                .FontSize(10)
                                .FontColor(Colors.Grey.Medium);
                        });

                        row.ConstantItem(180).AlignRight().Column(col =>
                        {
                            string tituloComprobante = esPagoFinal ? "FACTURA FINAL DE ALQUILER" : "COMPROBANTE DE SEÑA";
                            col.Item().Text(tituloComprobante)
                                .FontSize(11)
                                .Bold()
                                .FontColor(esPagoFinal ? Colors.Green.Darken3 : Colors.Blue.Darken3);

                            col.Item().Text($"Nro: {nroComprobante}")
                                .FontSize(9)
                                .Bold()
                                .FontColor(Colors.Grey.Darken2);

                            col.Item().Text($"Fecha: {fechaPago:dd/MM/yyyy HH:mm}")
                                .FontSize(9)
                                .FontColor(Colors.Grey.Darken1);
                        });
                    });

                     page.Content().PaddingVertical(20).Column(col =>
                    {
                        col.Spacing(15);

                       
                        col.Item().LineHorizontal(2f).LineColor(Colors.Purple.Darken2);

                      
                        col.Item().Background(Colors.Purple.Lighten5).Padding(15).Column(card =>
                        {
                            card.Spacing(6);
                            card.Item().Text("DATOS DEL RESPONSABLE").Bold().FontSize(11).FontColor(Colors.Purple.Darken4);
                            card.Item().LineHorizontal(1).LineColor(Colors.Purple.Lighten3);
                            card.Item().Text($"• Nombre y Apellido: {nombre} {apellido}").FontSize(10).Bold();
                            card.Item().Text($"• Documento (DNI): {dni}").FontSize(10);
                        });

                      
                        col.Item().Background(Colors.Grey.Lighten4).Padding(15).Column(card =>
                        {
                            card.Spacing(6);
                            card.Item().Text("DETALLES DE LA TRANSACCIÓN").Bold().FontSize(11).FontColor(Colors.Blue.Darken3);
                            card.Item().LineHorizontal(1).LineColor(Colors.Grey.Lighten2);
                            card.Item().Text($"• Código de Reserva: {codigoReserva}").FontSize(10).Bold();
                            card.Item().Text($"• Medio de Pago: {medioPago}").FontSize(10);
                            card.Item().Text($"• Tipo de Transacción: {(esPagoFinal ? "Pago Final de Alquiler" : "Anticipo / Seña")}").FontSize(10);
                            card.Item().Text($"• Porcentaje Aplicado: {porcentajeSena}%").FontSize(10);
                        });

                     
                        col.Item().Background(Colors.Green.Lighten5).Border(1).BorderColor(Colors.Green.Lighten2).Padding(15).Row(row =>
                        {
                            row.RelativeItem().Column(c =>
                            {
                                c.Item().Text("MONTO TOTAL ABONADO").Bold().FontSize(11).FontColor(Colors.Green.Darken4);
                                c.Item().Text("Transacción procesada y validada por la entidad financiera.").FontSize(8).FontColor(Colors.Grey.Darken2);
                            });

                            row.ConstantItem(150).AlignRight().AlignMiddle().Text($"$ {montoAbonado:N2}")
                                .FontSize(16)
                                .Bold()
                                .FontColor(Colors.Green.Darken4);
                        });

                    
                        col.Item().PaddingTop(10).Text("Este comprobante es válido como recibo oficial de caja para la gestión de espacios y muestras en la galería. Gracias por confiar en Vanguardia Arte.")
                            .FontSize(9)
                            .Italic()
                            .FontColor(Colors.Grey.Darken2);

                     
                        col.Item().PaddingTop(30).Row(row =>
                        {
                            row.RelativeItem().Column(firma =>
                            {
                                firma.Item().LineHorizontal(1).LineColor(Colors.Grey.Medium);
                                firma.Item().PaddingTop(5).AlignCenter().Text("Firma Tesorería / Caja").FontSize(9).Bold();
                            });

                            row.ConstantItem(50);

                            row.RelativeItem().Column(firma =>
                            {
                                firma.Item().LineHorizontal(1).LineColor(Colors.Grey.Medium);
                                firma.Item().PaddingTop(5).AlignCenter().Text("Firma Conformidad Cliente").FontSize(9).Bold();
                            });
                        });
                    });

                 
                    page.Footer().AlignCenter().Text(text =>
                    {
                        text.Span("Vanguardia Arte - Sistema de Gestión de Galerías | Comprobante Oficial | Página ")
                            .FontSize(8)
                            .FontColor(Colors.Grey.Medium);
                        text.CurrentPageNumber()
                            .FontSize(8)
                            .FontColor(Colors.Grey.Medium);
                    });
                });
            })
            .GeneratePdf(ruta);
        }
    
    public void GenerarConstanciaLibreDeudaPDF(string codigoReserva, string dniResponsable, DateTime fechaRetiro, string ruta)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(40);
                    page.PageColor(Colors.White);

                    // Encabezado con estilo corporativo y color institucional (Gótico / Elegante)
                    page.Header().Row(row =>
                    {
                        row.RelativeItem().Column(col =>
                        {
                            col.Item().Text("VANGUARDIA ARTE")
                                .FontSize(22)
                                .Bold()
                                .FontColor(Colors.Purple.Darken3);

                            col.Item().Text("Galería Internacional de Arte Contemporáneo")
                                .FontSize(10)
                                .FontColor(Colors.Grey.Medium);
                        });

                        row.ConstantItem(150).AlignRight().Column(col =>
                        {
                            col.Item().Text("CONSTANCIA DE RETIRO")
                                .FontSize(11)
                                .Bold()
                                .FontColor(Colors.Blue.Darken3);

                            col.Item().Text($"Fecha: {fechaRetiro:dd/MM/yyyy HH:mm}")
                                .FontSize(9)
                                .FontColor(Colors.Grey.Darken1);
                        });
                    });

                    // Contenido Principal
                    page.Content().PaddingVertical(20).Column(col =>
                    {
                        col.Spacing(15);

                        // Línea divisoria elegante
                        col.Item().LineHorizontal(1.5f).LineColor(Colors.Purple.Darken3);

                        col.Item().PaddingTop(10).Text("CERTIFICADO DE LIBRE DEUDA Y DESMONTAJE")
                            .FontSize(16)
                            .Bold()
                            .FontColor(Colors.Purple.Darken4);

                        col.Item().Text("Por medio del presente documento, la administración de la galería certifica que la reserva detallada a continuación se encuentra formalmente saldada y que se ha completado de manera exitosa el peritaje de egreso. Se autoriza el retiro definitivo de la pieza de arte.")
                            .FontSize(10)
                            .FontColor(Colors.Grey.Darken3);

                        // Tarjeta de Detalles de la Operación
                        col.Item().Background(Colors.Grey.Lighten4).Padding(15).Column(card =>
                        {
                            card.Spacing(8);
                            card.Item().Text("DETALLES DE LA OPERACIÓN").Bold().FontSize(12).FontColor(Colors.Purple.Darken3);
                            card.Item().LineHorizontal(1).LineColor(Colors.Grey.Lighten2);
                            card.Item().Text($"• Código de Reserva: {codigoReserva}").FontSize(10).Bold();
                            card.Item().Text($"• DNI del Responsable Autorizado: {dniResponsable}").FontSize(10);
                            card.Item().Text($"• Estado Financiero: SALDADO [Libre Deuda Emitido]").FontSize(10).FontColor(Colors.Green.Darken2);
                            card.Item().Text($"• Estado Físico de la Sala: LIBERADA / DISPONIBLE").FontSize(10).FontColor(Colors.Blue.Darken2);
                        });

                        col.Item().PaddingTop(15).Text("Condiciones de Retiro:")
                            .Bold()
                            .FontSize(10)
                            .FontColor(Colors.Purple.Darken3);

                        col.Item().Text("El firmante o comisionado acredita la recepción en conformidad de la obra y la liberación total de responsabilidades contractuales sobre el espacio de exhibición asignado.")
                            .FontSize(9)
                            .FontColor(Colors.Grey.Darken2);

                        // Bloque de Firmas
                        col.Item().PaddingTop(40).Row(row =>
                        {
                            row.RelativeItem().Column(firma =>
                            {
                                firma.Item().LineHorizontal(1).LineColor(Colors.Grey.Medium);
                                firma.Item().PaddingTop(5).AlignCenter().Text("Firma Encargado de Sala").FontSize(9).Bold();
                            });

                            row.ConstantItem(50); // Espacio entre firmas

                            row.RelativeItem().Column(firma =>
                            {
                                firma.Item().LineHorizontal(1).LineColor(Colors.Grey.Medium);
                                firma.Item().PaddingTop(5).AlignCenter().Text("Firma Responsable / Artista").FontSize(9).Bold();
                            });
                        });
                    });

                    // Pie de página
                    page.Footer().AlignCenter().Text(text =>
                    {
                        text.Span("Vanguardia Arte - Sistema de Gestión de Galerías | Página ")
                            .FontSize(8)
                            .FontColor(Colors.Grey.Medium);
                        text.CurrentPageNumber()
                            .FontSize(8)
                            .FontColor(Colors.Grey.Medium);
                    });
                });
            })
            .GeneratePdf(ruta);
        }
    }

}
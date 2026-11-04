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
        public void GenerarTicketCafeteriaPDF_VM516(
            int numeroTicket_VM516,
            DateTime fechaHora_VM516,
            decimal montoAbonado_VM516,
            string medioPago_VM516,
            int numeroPedido_VM516,
            string dniCliente_VM516,
            string nombreCliente_VM516,
            string apellidoCliente_VM516,
            string cajero_VM516,
            DataTable detalleItems_VM516,
            string ruta_VM516)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A5);
                    page.Margin(25);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(9).FontFamily("Segoe UI"));

                    // Encabezado Institucional y Datos Fiscales
                    page.Header().Column(headerCol =>
                    {
                        headerCol.Item().Row(row =>
                        {
                            row.RelativeItem().Column(col =>
                            {
                                col.Item().Text("VANGUARDIA ARTE")
                                    .FontSize(18)
                                    .Bold()
                                    .FontColor(Colors.Purple.Darken3);

                                col.Item().Text("Cafetería de Galería")
                                    .FontSize(9)
                                    .FontColor(Colors.Grey.Darken1);

                                col.Item().PaddingTop(2).Text("CUIT: 30-71589421-9 | IVA Responsable Inscripto")
                                    .FontSize(7.5f)
                                    .FontColor(Colors.Grey.Medium);
                            });

                            row.ConstantItem(150).AlignRight().Column(col =>
                            {
                                col.Item().Text("TICKET DE CAJA (TIQUE B)")
                                    .FontSize(10)
                                    .Bold()
                                    .FontColor(Colors.Blue.Darken3);

                                col.Item().Text($"PV 0002 - Nro: #{numeroTicket_VM516:D6}")
                                    .FontSize(9)
                                    .Bold()
                                    .FontColor(Colors.Grey.Darken3);

                                col.Item().Text($"Pedido Nro: #{numeroPedido_VM516}")
                                    .FontSize(8.5f)
                                    .Bold()
                                    .FontColor(Colors.Purple.Darken3);

                                col.Item().Text($"Fecha: {fechaHora_VM516:dd/MM/yyyy} | {fechaHora_VM516:HH:mm:ss}")
                                    .FontSize(8)
                                    .FontColor(Colors.Grey.Darken1);
                            });
                        });

                        headerCol.Item().PaddingTop(8).LineHorizontal(2f).LineColor(Colors.Purple.Darken2);
                    });

                    // Contenido Principal
                    page.Content().PaddingVertical(10).Column(col =>
                    {
                        col.Spacing(10);

                        // Tarjeta: Datos del Cliente y Operador
                        col.Item().Background(Colors.Purple.Lighten5).Padding(10).Row(row =>
                        {
                            row.RelativeItem().Column(c =>
                            {
                                c.Spacing(3);
                                c.Item().Text("DATOS DEL CLIENTE").Bold().FontSize(9).FontColor(Colors.Purple.Darken4);
                                c.Item().Text($"• Cliente: {nombreCliente_VM516} {apellidoCliente_VM516}").FontSize(8.5f).Bold();
                                c.Item().Text($"• DNI: {dniCliente_VM516} | Cond. IVA: Consumidor Final").FontSize(8);
                            });

                            row.ConstantItem(145).Column(c =>
                            {
                                c.Spacing(3);
                                c.Item().Text("DATOS DE CAJA").Bold().FontSize(9).FontColor(Colors.Blue.Darken3);
                                c.Item().Text($"• Cajero/a: {cajero_VM516}").FontSize(8);
                                c.Item().Text($"• Pago: {medioPago_VM516}").FontSize(8.5f).Bold();
                            });
                        });

                        // Tabla de Productos Consumidos
                        col.Item().Text("DETALLE DE CONSUMICIÓN").Bold().FontSize(9.5f).FontColor(Colors.Purple.Darken3);

                        col.Item().Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.ConstantColumn(35);  // Cant.
                                columns.RelativeColumn();    // Descripción del Producto
                                columns.ConstantColumn(65);  // P. Unitario
                                columns.ConstantColumn(70);  // Subtotal
                            });

                            table.Header(header =>
                            {
                                header.Cell().Background(Colors.Purple.Darken3).Padding(4).AlignCenter().Text("Cant.").FontColor(Colors.White).Bold().FontSize(8.5f);
                                header.Cell().Background(Colors.Purple.Darken3).Padding(4).Text("Descripción").FontColor(Colors.White).Bold().FontSize(8.5f);
                                header.Cell().Background(Colors.Purple.Darken3).Padding(4).AlignRight().Text("P. Unit.").FontColor(Colors.White).Bold().FontSize(8.5f);
                                header.Cell().Background(Colors.Purple.Darken3).Padding(4).AlignRight().Text("Subtotal").FontColor(Colors.White).Bold().FontSize(8.5f);
                            });

                            if (detalleItems_VM516 != null)
                            {
                                foreach (DataRow item in detalleItems_VM516.Rows)
                                {
                                    table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten3).PaddingVertical(4).AlignCenter().Text(item["Cantidad"].ToString()).FontSize(8.5f);
                                    table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten3).PaddingVertical(4).Text(item["Descripcion"].ToString()).FontSize(8.5f);
                                    table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten3).PaddingVertical(4).AlignRight().Text($"$ {Convert.ToDecimal(item["PrecioUnitario"]):N2}").FontSize(8.5f);
                                    table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten3).PaddingVertical(4).AlignRight().Text($"$ {Convert.ToDecimal(item["Subtotal"]):N2}").Bold().FontSize(8.5f);
                                }
                            }
                        });

                        // Recuadro de Total Abonado
                        col.Item().PaddingTop(5).Background(Colors.Green.Lighten5).Border(1).BorderColor(Colors.Green.Lighten2).Padding(10).Row(row =>
                        {
                            row.RelativeItem().Column(c =>
                            {
                                c.Item().Text("TOTAL ABONADO").Bold().FontSize(10).FontColor(Colors.Green.Darken4);
                                c.Item().Text("Transacción aprobada por Entidad Financiera.").FontSize(7.5f).FontColor(Colors.Grey.Darken2);
                            });

                            row.ConstantItem(130).AlignRight().AlignMiddle().Text($"$ {montoAbonado_VM516:N2}")
                                .FontSize(14)
                                .Bold()
                                .FontColor(Colors.Green.Darken4);
                        });

                        // Aviso para el retiro en barra (ECUN11)
                        col.Item().PaddingTop(6).Background(Colors.Grey.Lighten4).Padding(8).AlignCenter()
                            .Text($"Presente este ticket en la barra con su Nro. de Pedido (#{numeroPedido_VM516}) para retirar su consumición.")
                            .FontSize(8)
                            .Bold()
                            .FontColor(Colors.Purple.Darken3);
                    });

                    // Pie de página
                    page.Footer().Column(f =>
                    {
                        f.Item().LineHorizontal(1).LineColor(Colors.Grey.Lighten2);
                        f.Item().PaddingTop(4).AlignCenter().Text("Vanguardia Arte - Comprobante Oficial de Cafetería | ¡Gracias por su visita!")
                            .FontSize(7.5f)
                            .Italic()
                            .FontColor(Colors.Grey.Medium);
                    });
                });
            }).GeneratePdf(ruta_VM516);
        }
        public void GenerarConstanciaLibreDeudaPDF(string codigoReserva, int idObra, string tituloObra, string dniArtista, string dniResponsable, DateTime fechaRetiro, string ruta)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(40);
                    page.PageColor(Colors.White);

                    // Encabezado
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

                        col.Item().LineHorizontal(1.5f).LineColor(Colors.Purple.Darken3);

                        col.Item().PaddingTop(10).Text("CERTIFICADO DE LIBRE DEUDA Y DESMONTAJE")
                            .FontSize(16)
                            .Bold()
                            .FontColor(Colors.Purple.Darken4);

                        col.Item().Text("Por medio del presente documento, la administración de la galería certifica que la reserva detallada a continuación se encuentra formalmente saldada y que se ha completado de manera exitosa el peritaje de egreso. Se autoriza el retiro definitivo de la pieza de arte.")
                            .FontSize(10)
                            .FontColor(Colors.Grey.Darken3);

                        // Tarjeta de Detalles (Solo DNI del artista)
                        col.Item().Background(Colors.Grey.Lighten4).Padding(15).Column(card =>
                        {
                            card.Spacing(8);
                            card.Item().Text("DETALLES DE LA OPERACIÓN Y PATRIMONIO").Bold().FontSize(12).FontColor(Colors.Purple.Darken3);
                            card.Item().LineHorizontal(1).LineColor(Colors.Grey.Lighten2);
                            card.Item().Text($"• Código de Reserva: {codigoReserva}").FontSize(10).Bold();
                            card.Item().Text($"• Obra Retirada: ID {idObra} - {tituloObra}").FontSize(10).Bold();
                            card.Item().Text($"• DNI del Artista Creador: {dniArtista}").FontSize(10);
                            card.Item().Text($"• DNI del Responsable del Retiro: {dniResponsable}").FontSize(10);
                            card.Item().Text($"• Estado Financiero: SALDADO [Libre Deuda Emitido]").FontSize(10).FontColor(Colors.Green.Darken2);
                        });

                        col.Item().PaddingTop(15).Text("Condiciones de Retiro:")
                            .Bold()
                            .FontSize(10)
                            .FontColor(Colors.Purple.Darken3);

                        col.Item().Text("El firmante o comisionado acredita la recepción en conformidad de la obra y la liberación total de responsabilidades contractuales sobre el espacio de exhibición asignado.")
                            .FontSize(9)
                            .FontColor(Colors.Grey.Darken2);

                        // Firmas
                        col.Item().PaddingTop(40).Row(row =>
                        {
                            row.RelativeItem().Column(firma =>
                            {
                                firma.Item().LineHorizontal(1).LineColor(Colors.Grey.Medium);
                                firma.Item().PaddingTop(5).AlignCenter().Text("Firma Encargado de Sala").FontSize(9).Bold();
                            });

                            row.ConstantItem(50);

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
        public void GenerarReporteInteligenteCafeteriaPDF_VM516(DataTable dtDatos, string ruta_VM516)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            // --- ANÁLISIS DINÁMICO DE DATOS (Inteligencia de Negocio) ---
            string textoAnalisisCafeteria = "No hay registros de consumos disponibles.";
            if (dtDatos != null && dtDatos.Rows.Count > 0)
            {
                // 1. Producto más vendido en cantidad (Volumen)
                DataRow productoVolumen = dtDatos.AsEnumerable().OrderByDescending(r => Convert.ToInt32(r["CantidadTotal"])).First();
                string nombreVolumen = productoVolumen["Descripcion"].ToString();
                int cantVolumen = Convert.ToInt32(productoVolumen["CantidadTotal"]);
                decimal recVolumen = Convert.ToDecimal(productoVolumen["RecaudacionTotal"]);
                decimal precioUnitarioVolumen = cantVolumen > 0 ? recVolumen / cantVolumen : 0;

                // 2. Producto con mayor recaudación total (Margen/Dinero)
                DataRow productoRecaudacion = dtDatos.AsEnumerable().OrderByDescending(r => Convert.ToDecimal(r["RecaudacionTotal"])).First();
                string nombreRec = productoRecaudacion["Descripcion"].ToString();
                decimal recTotalProd = Convert.ToDecimal(productoRecaudacion["RecaudacionTotal"]);

                int totalUnidades = dtDatos.AsEnumerable().Sum(r => Convert.ToInt32(r["CantidadTotal"]));
                decimal recaudacionTotalCafé = dtDatos.AsEnumerable().Sum(r => Convert.ToDecimal(r["RecaudacionTotal"]));

                // 3. Lógica inteligente para definir la recomendación según si el producto líder es económico o costoso
                string estrategiaComercial = "";
                if (precioUnitarioVolumen < 2000m) // Si es un producto económico (ej: medialunas, café básico)
                {
                    estrategiaComercial = $"Al tratarse de un ítem de bajo costo unitario ($ {precioUnitarioVolumen:N2}), funciona como un excelente producto 'gancho' o de alta rotación. " +
                                          $"Acción gerencial recomendada: Implementar combos promocionales cruzados (ej. '{nombreVolumen}' junto a repostería de mayor valor) " +
                                          $"para elevar el ticket promedio por visitante.";
                }
                else // Si es un producto más premium o costoso
                {
                    estrategiaComercial = $"Al ser un producto de mayor valor unitario ($ {precioUnitarioVolumen:N2}), sostiene fuertemente el margen de rentabilidad de la unidad gastronómica. " +
                                          $"Acción gerencial recomendada: Garantizar stock prioritario y estricto control de calidad, asegurando que no existan quiebres de inventario en los horarios pico de las muestras.";
                }

                textoAnalisisCafeteria = $"El punto de venta procesó un total de {totalUnidades} unidades, logrando una recaudación global de $ {recaudacionTotalCafé:N2}. " +
                                         $"El producto con mayor volumen de salida es '{nombreVolumen}' ({cantVolumen} un.), mientras que el ítem que mayor dinero aporta a la caja es '{nombreRec}' ($ {recTotalProd:N2}). " +
                                         estrategiaComercial;
            }

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(40);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(10).FontFamily("Segoe UI"));

                    page.Header().Column(header =>
                    {
                        header.Item().Row(row =>
                        {
                            row.RelativeItem().Column(col =>
                            {
                                col.Item().Text("VANGUARDIA ARTE").FontSize(20).Bold().FontColor(Colors.Purple.Darken3);
                                col.Item().Text("Galería de Arte - Unidad Gastronómica").FontSize(9).FontColor(Colors.Grey.Medium);
                            });

                            row.ConstantItem(180).AlignRight().Column(col =>
                            {
                                col.Item().Text("REPORTE INTELIGENTE").FontSize(11).Bold().FontColor(Colors.Blue.Darken3);
                                col.Item().Text($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}").FontSize(9).FontColor(Colors.Grey.Darken1);
                            });
                        });
                        header.Item().PaddingTop(10).LineHorizontal(1.5f).LineColor(Colors.Purple.Darken3);
                    });

                    page.Content().PaddingVertical(15).Column(col =>
                    {
                        col.Spacing(12);

                        col.Item().Text("Análisis de Consumos y Productos Líderes").FontSize(14).Bold().FontColor(Colors.Purple.Darken4);

                        col.Item().Background(Colors.Purple.Lighten5).Padding(10).Column(c =>
                        {
                            c.Item().Text("PROPÓSITO Y TOMA DE DECISIONES:").Bold().FontSize(9.5f).FontColor(Colors.Purple.Darken3);
                            c.Item().Text("Cruce dinámico de inventario y pedidos para la optimización de stock y anticipación de compras basándose en la demanda real.").FontSize(9).FontColor(Colors.Grey.Darken3);
                        });

                        // Gráfico de barras nativo
                        if (dtDatos != null && dtDatos.Rows.Count > 0)
                        {
                            col.Item().Background(Colors.Grey.Lighten4).Padding(12).Column(grafico =>
                            {
                                grafico.Spacing(6);
                                grafico.Item().Text("📈 ANÁLISIS VISUAL DE UNIDADES VENDIDAS").Bold().FontSize(11).FontColor(Colors.Blue.Darken3);
                                grafico.Item().Text("Representación comparativa del volumen de despacho por ítem gastronómico.").FontSize(8.5f).FontColor(Colors.Grey.Darken2);
                                grafico.Item().PaddingBottom(4).LineHorizontal(1).LineColor(Colors.Grey.Lighten2);

                                decimal maxCantidad = dtDatos.AsEnumerable().Max(r => Convert.ToDecimal(r["CantidadTotal"]));

                                foreach (DataRow row in dtDatos.Rows)
                                {
                                    decimal valor = Convert.ToDecimal(row["CantidadTotal"]);
                                    float proporcion = maxCantidad == 0 ? 0 : (float)(valor / maxCantidad) * 100;
                                    float remanente = 100 - proporcion;

                                    grafico.Item().Row(r =>
                                    {
                                        r.ConstantItem(140).AlignRight().PaddingRight(10).AlignMiddle()
                                           .Text(row["Descripcion"].ToString()).FontSize(8.5f).Bold().FontColor(Colors.Grey.Darken3);

                                        r.RelativeItem().AlignMiddle().Row(barRow =>
                                        {
                                            if (proporcion > 0)
                                                barRow.RelativeItem(proporcion).Height(10).Background(Colors.Purple.Accent2);

                                            if (remanente > 0)
                                                barRow.RelativeItem(remanente).Height(10).Background(Colors.Grey.Lighten3);
                                        });

                                        r.ConstantItem(50).AlignLeft().PaddingLeft(10).AlignMiddle()
                                           .Text($"{valor} un.").FontSize(8).FontColor(Colors.Purple.Darken4).Bold();
                                    });
                                }
                            });
                        }

                        // Tabla de datos estructurados
                        col.Item().PaddingTop(5).Text("Ranking Financiero y Desglose de Ventas").Bold().FontSize(11).FontColor(Colors.Blue.Darken3);

                        col.Item().Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.RelativeColumn();
                                columns.ConstantColumn(90);
                                columns.ConstantColumn(110);
                            });

                            table.Header(header =>
                            {
                                header.Cell().Background(Colors.Purple.Darken3).Padding(5).Text("Descripción del Producto").FontColor(Colors.White).Bold().FontSize(9);
                                header.Cell().Background(Colors.Purple.Darken3).Padding(5).AlignCenter().Text("Cant. Vendida").FontColor(Colors.White).Bold().FontSize(9);
                                header.Cell().Background(Colors.Purple.Darken3).Padding(5).AlignRight().Text("Recaudación ($)").FontColor(Colors.White).Bold().FontSize(9);
                            });

                            if (dtDatos != null)
                            {
                                foreach (DataRow row in dtDatos.Rows)
                                {
                                    table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten3).Padding(5).Text(row["Descripcion"].ToString()).FontSize(9);
                                    table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten3).Padding(5).AlignCenter().Text(row["CantidadTotal"].ToString()).FontSize(9);
                                    table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten3).Padding(5).AlignRight().Text($"$ {Convert.ToDecimal(row["RecaudacionTotal"]):N2}").FontSize(9);
                                }
                            }
                        });

                        // BLOQUE DINÁMICO DE ANÁLISIS GERENCIAL
                        col.Item().PaddingTop(5).Background(Colors.Grey.Lighten4).Padding(12).Column(c =>
                        {
                            c.Spacing(4);
                            c.Item().Text("🔎 INFORME ANALÍTICO").Bold().FontSize(10).FontColor(Colors.Purple.Darken4);
                            c.Item().Text(textoAnalisisCafeteria).FontSize(8.5f).FontColor(Colors.Grey.Darken3);
                        });
                    });

                    page.Footer().AlignCenter().Text(text =>
                    {
                        text.Span("Vanguardia Arte - Módulo Inteligencia de Negocio | Página ").FontSize(8).FontColor(Colors.Grey.Medium);
                        text.CurrentPageNumber().FontSize(8).FontColor(Colors.Grey.Medium);
                    });
                });
            }).GeneratePdf(ruta_VM516);
        }
        public void GenerarReporteInteligenteSalas_VM516(DataTable dtDatos, string ruta_VM516)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            // --- ANÁLISIS DINÁMICO AVANZADO (Cruce de Recaudación y Frecuencia de Reservas) ---
            string textoAnalisisSalas = "No hay registros suficientes para emitir un diagnóstico analítico.";
            if (dtDatos != null && dtDatos.Rows.Count > 0)
            {
                // 1. Sala líder en ingresos económicos (Recaudación)
                DataRow salaMejorRecaudacion = dtDatos.AsEnumerable().OrderByDescending(r => Convert.ToDecimal(r["RecaudacionSalas"])).First();
                string nombreRecTop = salaMejorRecaudacion["NombreSala"].ToString();
                decimal recTop = Convert.ToDecimal(salaMejorRecaudacion["RecaudacionSalas"]);

                // 2. Sala líder en cantidad de reservas / ocupaciones (Frecuencia de uso)
                DataRow salaMayorRotacion = dtDatos.AsEnumerable().OrderByDescending(r => Convert.ToInt32(r["CantidadReservas"])).First();
                string nombreRotTop = salaMayorRotacion["NombreSala"].ToString();
                int reservasTop = Convert.ToInt32(salaMayorRotacion["CantidadReservas"]);

                decimal recaudacionTotalGeneral = dtDatos.AsEnumerable().Sum(r => Convert.ToDecimal(r["RecaudacionSalas"]));
                int totalReservasGeneral = dtDatos.AsEnumerable().Sum(r => Convert.ToInt32(r["CantidadReservas"]));

                // 3. Lógica analítica inteligente combinando precios y frecuencia
                string comparativaLiderazgo = "";
                if (nombreRecTop == nombreRotTop)
                {
                    comparativaLiderazgo = $"El espacio que concentra tanto el mayor volumen financiero ($ {recTop:N2}) como la mayor frecuencia operativa ({reservasTop} reservas) es '{nombreRecTop}', consolidándose indiscutiblemente como el motor principal de la galería.";
                }
                else
                {
                    comparativaLiderazgo = $"Se observa una interesante diversificación operativa: mientras que '{nombreRecTop}' lidera la recaudación económica ($ {recTop:N2}), " +
                                           $"es el espacio '{nombreRotTop}' el que registra mayor rotación de público con {reservasTop} reservas acumuladas.";
                }

                textoAnalisisSalas = $"El sistema consolida un total de {totalReservasGeneral} ocupaciones de espacios y una recaudación global de $ {recaudacionTotalGeneral:N2}. " +
                                     comparativaLiderazgo + " " +
                                     $"Acción gerencial recomendada: Evaluar un incremento de tarifas en los espacios de alta demanda y diseñar estrategias de fidelización o paquetes promocionales para incentivar la ocupación en las salas de menor rotación.";
            }

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(40);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(10).FontFamily("Segoe UI"));

                    page.Header().Column(header =>
                    {
                        header.Item().Row(row =>
                        {
                            row.RelativeItem().Column(col =>
                            {
                                col.Item().Text("VANGUARDIA ARTE").FontSize(20).Bold().FontColor(Colors.Purple.Darken3);
                                col.Item().Text("Galería de Arte - Unidad de Espacios").FontSize(9).FontColor(Colors.Grey.Medium);
                            });

                            row.ConstantItem(180).AlignRight().Column(col =>
                            {
                                col.Item().Text("REPORTE INTELIGENTE").FontSize(11).Bold().FontColor(Colors.Blue.Darken3);
                                col.Item().Text($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}").FontSize(9).FontColor(Colors.Grey.Darken1);
                            });
                        });
                        header.Item().PaddingTop(10).LineHorizontal(1.5f).LineColor(Colors.Purple.Darken3);
                    });

                    page.Content().PaddingVertical(15).Column(col =>
                    {
                        col.Spacing(12);

                        col.Item().Text("Análisis de Ocupación y Rendimiento de Salas").FontSize(14).Bold().FontColor(Colors.Purple.Darken4);

                        col.Item().Background(Colors.Purple.Lighten5).Padding(10).Column(c =>
                        {
                            c.Item().Text("PROPÓSITO Y TOMA DE DECISIONES:").Bold().FontSize(9.5f).FontColor(Colors.Purple.Darken3);
                            c.Item().Text("Cruce dinámico de histórico de reservas y catálogo de salas para evaluar tasas de ocupación y optimizar tarifas.").FontSize(9).FontColor(Colors.Grey.Darken3);
                        });

                        // Gráfico de barras nativo
                        if (dtDatos != null && dtDatos.Rows.Count > 0)
                        {
                            col.Item().Background(Colors.Grey.Lighten4).Padding(12).Column(grafico =>
                            {
                                grafico.Spacing(8);
                                grafico.Item().Text("📈 GRÁFICO DE RENDIMIENTO FINANCIERO").Bold().FontSize(11).FontColor(Colors.Blue.Darken3);
                                grafico.Item().Text("Representación visual del volumen de recaudación por sala de exposición.").FontSize(8.5f).FontColor(Colors.Grey.Darken2);
                                grafico.Item().PaddingBottom(4).LineHorizontal(1).LineColor(Colors.Grey.Lighten2);

                                decimal maxRecaudacion = dtDatos.AsEnumerable().Max(r => Convert.ToDecimal(r["RecaudacionSalas"]));

                                foreach (DataRow row in dtDatos.Rows)
                                {
                                    decimal valor = Convert.ToDecimal(row["RecaudacionSalas"]);
                                    float proporcion = maxRecaudacion == 0 ? 0 : (float)(valor / maxRecaudacion) * 100;
                                    float remanente = 100 - proporcion;

                                    grafico.Item().Row(r =>
                                    {
                                        r.ConstantItem(110).AlignRight().PaddingRight(10).AlignMiddle()
                                           .Text(row["NombreSala"].ToString()).FontSize(8.5f).Bold().FontColor(Colors.Grey.Darken3);

                                        r.RelativeItem().AlignMiddle().Row(barRow =>
                                        {
                                            if (proporcion > 0)
                                                barRow.RelativeItem(proporcion).Height(12).Background(Colors.Purple.Accent1);

                                            if (remanente > 0)
                                                barRow.RelativeItem(remanente).Height(12).Background(Colors.Grey.Lighten3);
                                        });

                                        r.ConstantItem(85).AlignLeft().PaddingLeft(10).AlignMiddle()
                                           .Text($"$ {valor:N2}").FontSize(8).FontColor(Colors.Purple.Darken4).Bold();
                                    });
                                }
                            });
                        }

                        // Tabla de datos estructurados
                        col.Item().PaddingTop(5).Text("Desglose Analítico Detallado").Bold().FontSize(11).FontColor(Colors.Blue.Darken3);

                        col.Item().Table(table =>
                        {
                            table.ColumnsDefinition(columns =>
                            {
                                columns.ConstantColumn(80);
                                columns.RelativeColumn();
                                columns.ConstantColumn(90);
                                columns.ConstantColumn(110);
                            });

                            table.Header(header =>
                            {
                                header.Cell().Background(Colors.Purple.Darken3).Padding(5).Text("Código").FontColor(Colors.White).Bold().FontSize(9);
                                header.Cell().Background(Colors.Purple.Darken3).Padding(5).Text("Sala de Exposición").FontColor(Colors.White).Bold().FontSize(9);
                                header.Cell().Background(Colors.Purple.Darken3).Padding(5).AlignCenter().Text("Ocupaciones").FontColor(Colors.White).Bold().FontSize(9);
                                header.Cell().Background(Colors.Purple.Darken3).Padding(5).AlignRight().Text("Recaudación ($)").FontColor(Colors.White).Bold().FontSize(9);
                            });

                            if (dtDatos != null)
                            {
                                foreach (DataRow row in dtDatos.Rows)
                                {
                                    table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten3).Padding(5).Text(row["CodigoSala"].ToString()).FontSize(9);
                                    table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten3).Padding(5).Text(row["NombreSala"].ToString()).FontSize(9);
                                    table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten3).Padding(5).AlignCenter().Text(row["CantidadReservas"].ToString()).FontSize(9);
                                    table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten3).Padding(5).AlignRight().Text($"$ {Convert.ToDecimal(row["RecaudacionSalas"]):N2}").FontSize(9);
                                }
                            }
                        });

                        // BLOQUE DINÁMICO DE ANÁLISIS GERENCIAL
                        col.Item().PaddingTop(5).Background(Colors.Grey.Lighten4).Padding(12).Column(c =>
                        {
                            c.Spacing(4);
                            c.Item().Text("🔎 INFORME ANALÍTICO").Bold().FontSize(10).FontColor(Colors.Purple.Darken4);
                            c.Item().Text(textoAnalisisSalas).FontSize(8.5f).FontColor(Colors.Grey.Darken3);
                        });
                    });

                    page.Footer().AlignCenter().Text(text =>
                    {
                        text.Span("Vanguardia Arte - Módulo Inteligencia de Negocio | Página ").FontSize(8).FontColor(Colors.Grey.Medium);
                        text.CurrentPageNumber().FontSize(8).FontColor(Colors.Grey.Medium);
                    });
                });
            }).GeneratePdf(ruta_VM516);
        }


    }

}
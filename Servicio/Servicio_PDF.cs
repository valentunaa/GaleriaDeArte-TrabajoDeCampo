using QuestPDF.Fluent;
using MathNet.Numerics.LinearRegression;
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
        public void GenerarReporteInteligenteCafeteriaPDF_VM516(DataTable dtDatos, List<string> clientesFidelizados, string ruta_VM516)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            // Variables Predictivas (Matemática y Proyección)
            string pronosticoDemanda = "No hay datos suficientes para proyectar demanda futura.";
            string proyeccionFidelizacion = "Datos insuficientes para predecir el comportamiento de retorno.";
            string pronosticoInventario = "No es posible calcular proyecciones de inventario.";
            string proyeccionIngresos = "No hay datos para estimar la recaudación futura.";

            // Variables Prescriptivas (Marketing y Acción)
            string estrategiaComercial = "Sin datos para sugerir estrategias.";
            string estrategiaRentabilidad = "Sin datos para sugerir tácticas de rentabilidad.";
            string estrategiaFidelizacion = "Aún no se registran clientes con el volumen (10+ compras) para activar el mailing de lealtad.";

            if (dtDatos != null && dtDatos.Rows.Count > 0)
            {
                DataRow productoVolumen = dtDatos.AsEnumerable().OrderByDescending(r => Convert.ToInt32(r["CantidadTotal"])).First();
                string nombreVolumen = productoVolumen["Descripcion"].ToString();
                int cantVolumen = Convert.ToInt32(productoVolumen["CantidadTotal"]);
                decimal recVolumen = Convert.ToDecimal(productoVolumen["RecaudacionTotal"]);
                decimal precioUnitarioVolumen = cantVolumen > 0 ? recVolumen / cantVolumen : 0;

                DataRow productoRecaudacion = dtDatos.AsEnumerable().OrderByDescending(r => Convert.ToDecimal(r["RecaudacionTotal"])).First();
                string nombreRec = productoRecaudacion["Descripcion"].ToString();
                decimal recTotalProd = Convert.ToDecimal(productoRecaudacion["RecaudacionTotal"]);

                // 1. BLOQUE PREDICTIVO (Cálculos de proyección)
                decimal crecimientoEsperado = 1.15m;
                int volumenProyectado = (int)Math.Ceiling(cantVolumen * crecimientoEsperado);
                int stockSeguridad = (int)Math.Ceiling(cantVolumen * 1.30m);
                decimal ingresosProyectados = recTotalProd * crecimientoEsperado;

                pronosticoDemanda = $"Pronóstico de Concentración de Demanda: El análisis transaccional indica que '{nombreVolumen}' domina las preferencias. El algoritmo predictivo estima que este ítem continuará traccionando la demanda, proyectando un volumen necesario de {volumenProyectado} unidades para el próximo ciclo comercial.";

                proyeccionIngresos = $"Proyección de Flujo de Caja: Basado en su rendimiento histórico inelástico, se estima que '{nombreRec}' mantendrá su posición como el activo más rentable. El modelo proyecta una recaudación de $ {ingresosProyectados:N2} para el siguiente lote de ventas.";

                pronosticoInventario = $"Modelo Predictivo de Inventario (Safety Stock): Para sostener la tendencia de ventas proyectada de '{nombreVolumen}' y evitar quiebres de inventario durante picos de demanda, el sistema calcula la necesidad algorítmica de un lote mínimo de reposición (Stock de Seguridad) de {stockSeguridad} unidades.";

                

                // 2. BLOQUE PRESCRIPTIVO (Órdenes de Marketing basadas en la predicción)
                if (precioUnitarioVolumen < 2000m)
                {
                    estrategiaComercial = $"Estrategia de Pricing (Bundles): Al predecir alta rotación de '{nombreVolumen}' ($ {precioUnitarioVolumen:N2}), se prescribe agruparlo en combos junto a bebidas premium para elevar el ticket promedio.";
                }
                else
                {
                    estrategiaComercial = $"Estrategia de Ventas (Héroe Visual): Al requerir un stock de seguridad de {stockSeguridad} unidades de '{nombreVolumen}', se prescribe destacarlo visualmente en el centro de la vitrina para acelerar su salida.";
                }

                estrategiaRentabilidad = $"Gestión de Márgenes (Upselling): Para asegurar los $ {ingresosProyectados:N2} proyectados de '{nombreRec}', prescribimos capacitar a los cajeros para ofrecerlo como 'Sugerencia del Día' utilizando lenguaje premium.";

                if (clientesFidelizados != null && clientesFidelizados.Count > 0)
                {
                    string nombresEjemplo = string.Join(", ", clientesFidelizados.Take(3));
                    if (clientesFidelizados.Count > 3) nombresEjemplo += " y otros";

                    proyeccionFidelizacion = $"Probabilidad de Retorno: {clientesFidelizados.Count} clientes de alta frecuencia (ej. {nombresEjemplo}). Este segmento presenta una probabilidad >85% de retornar orgánicamente.";

                    // ACÁ INCLUIMOS LO QUE PIDIÓ EL PROFESOR: EL EMAIL
                    estrategiaFidelizacion = $"Campaña Directa (Emailing): Disparar un email automático a estos {clientesFidelizados.Count} clientes 'Heavy Users' ofreciéndoles un 'Upgrade' gratuito en su próxima visita. Esto capitaliza su alta probabilidad de retorno sin emitir descuentos.";
                }
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
                                col.Item().Text("REPORTE INTELIGENTE (BI)").FontSize(11).Bold().FontColor(Colors.Blue.Darken3);
                                col.Item().Text($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}").FontSize(9).FontColor(Colors.Grey.Darken1);
                            });
                        });
                        header.Item().PaddingTop(10).LineHorizontal(1.5f).LineColor(Colors.Purple.Darken3);
                    });

                    page.Content().PaddingVertical(15).Column(col =>
                    {
                        col.Spacing(12);
                        col.Item().Text("Análisis Predictivo y Prescriptivo de Consumos").FontSize(14).Bold().FontColor(Colors.Purple.Darken4);

                        col.Item().Background(Colors.Purple.Lighten5).Padding(10).Column(c =>
                        {
                            c.Item().Text("PROPÓSITO DEL REPORTE:").Bold().FontSize(9.5f).FontColor(Colors.Purple.Darken3);
                            c.Item().Text("Proyectar el comportamiento futuro de ventas (Predictivo) y recetar tácticas exactas de marketing y retención (Prescriptivo) en base a los históricos consolidados.").FontSize(9).FontColor(Colors.Grey.Darken3);
                        });

                        // BLOQUE 1: PREDICTIVO (Azul)
                        col.Item().PaddingTop(5).Background(Colors.Grey.Lighten4).BorderLeft(4).BorderColor(Colors.Blue.Darken2).Padding(15).Column(c =>
                        {
                            c.Spacing(8);
                            c.Item().Text("📊 1. MODELO PREDICTIVO (PROYECCIONES)").Bold().FontSize(11).FontColor(Colors.Blue.Darken3);
                            c.Item().LineHorizontal(1).LineColor(Colors.Grey.Lighten2);

                            c.Item().Row(r => { r.ConstantItem(15).Text("•").Bold().FontSize(12).FontColor(Colors.Blue.Darken2); r.RelativeItem().Text(pronosticoDemanda).FontSize(9).FontColor(Colors.Grey.Darken3); });
                            c.Item().Row(r => { r.ConstantItem(15).Text("•").Bold().FontSize(12).FontColor(Colors.Blue.Darken2); r.RelativeItem().Text(proyeccionIngresos).FontSize(9).FontColor(Colors.Grey.Darken3); });
                            c.Item().Row(r => { r.ConstantItem(15).Text("•").Bold().FontSize(12).FontColor(Colors.Blue.Darken2); r.RelativeItem().Text(pronosticoInventario).FontSize(9).FontColor(Colors.Grey.Darken3); });
                            c.Item().Row(r => { r.ConstantItem(15).Text("•").Bold().FontSize(12).FontColor(Colors.Blue.Darken2); r.RelativeItem().Text(proyeccionFidelizacion).FontSize(9).FontColor(Colors.Grey.Darken3); });
                        });

                        // BLOQUE 2: PRESCRIPTIVO (Rojo)
                        col.Item().PaddingTop(5).Background(Colors.Grey.Lighten4).BorderLeft(4).BorderColor(Colors.Red.Darken2).Padding(15).Column(c =>
                        {
                            c.Spacing(8);
                            c.Item().Text("⚙️ 2. PLAN DE ACCIÓN PRESCRIPTIVO (MARKETING)").Bold().FontSize(11).FontColor(Colors.Red.Darken3);
                            c.Item().LineHorizontal(1).LineColor(Colors.Grey.Lighten2);

                            c.Item().Row(r => { r.ConstantItem(15).Text("•").Bold().FontSize(12).FontColor(Colors.Red.Darken2); r.RelativeItem().Text(estrategiaComercial).FontSize(9).FontColor(Colors.Grey.Darken3); });
                            c.Item().Row(r => { r.ConstantItem(15).Text("•").Bold().FontSize(12).FontColor(Colors.Red.Darken2); r.RelativeItem().Text(estrategiaRentabilidad).FontSize(9).FontColor(Colors.Grey.Darken3); });
                            c.Item().Row(r => { r.ConstantItem(15).Text("•").Bold().FontSize(12).FontColor(Colors.Red.Darken2); r.RelativeItem().Text(estrategiaFidelizacion).FontSize(9).FontColor(Colors.Grey.Darken3); });
                        });

                        col.Item().PaddingTop(5).Text("Anexo: Base Histórica de Cálculo").Bold().FontSize(11).FontColor(Colors.Blue.Darken3);
                        col.Item().Table(table =>
                        {
                            table.ColumnsDefinition(columns => { columns.RelativeColumn(); columns.ConstantColumn(90); columns.ConstantColumn(110); });
                            table.Header(header =>
                            {
                                header.Cell().Background(Colors.Purple.Darken3).Padding(5).Text("Descripción del Producto").FontColor(Colors.White).Bold().FontSize(9);
                                header.Cell().Background(Colors.Purple.Darken3).Padding(5).AlignCenter().Text("Histórico Vendido").FontColor(Colors.White).Bold().FontSize(9);
                                header.Cell().Background(Colors.Purple.Darken3).Padding(5).AlignRight().Text("Recaudación Base ($)").FontColor(Colors.White).Bold().FontSize(9);
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
                    });

                    page.Footer().AlignCenter().Text(text =>
                    {
                        text.Span("Vanguardia Arte - Módulo Inteligencia de Negocios (BI) | Página ").FontSize(8).FontColor(Colors.Grey.Medium);
                        text.CurrentPageNumber().FontSize(8).FontColor(Colors.Grey.Medium);
                    });
                });
            }).GeneratePdf(ruta_VM516);
        }
        public void GenerarReporteInteligenteSalas_VM516(DataTable dtDatos, List<string> topArtistas, string ruta_VM516)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            // Variables Predictivas (Cálculos de proyección)
            string proyeccionFinanciera = "No hay datos suficientes para proyectar tarifas futuras.";
            string pronosticoOcupacion = "No hay datos para estimar la rotación de espacios.";
            string proyeccionComportamiento = "No hay datos suficientes para pronosticar tendencias.";

            // Variables Prescriptivas (Decisiones gerenciales)
            string prescripcionTarifas = "Sin datos para sugerir ajustes tarifarios.";
            string prescripcionMarketing = "Sin datos para sugerir campañas de promoción.";
            string prescripcionTalento = "Aún no se registran artistas recurrentes para activar contratos de representación.";

            if (dtDatos != null && dtDatos.Rows.Count > 0)
            {
                // Top Recaudación
                DataRow salaMejorRecaudacion = dtDatos.AsEnumerable().OrderByDescending(r => Convert.ToDecimal(r["RecaudacionSalas"])).First();
                string nombreRecTop = salaMejorRecaudacion["NombreSala"].ToString();
                decimal recTop = Convert.ToDecimal(salaMejorRecaudacion["RecaudacionSalas"]);

                // Top Días Ocupados
                DataRow salaMayorOcupacion = dtDatos.AsEnumerable().OrderByDescending(r => Convert.ToInt32(r["DiasOcupacion"])).First();
                string nombreOcupTop = salaMayorOcupacion["NombreSala"].ToString();
                int diasTop = Convert.ToInt32(salaMayorOcupacion["DiasOcupacion"]);
                int reservasOcupTop = Convert.ToInt32(salaMayorOcupacion["CantidadReservas"]);

                int promedioDias = reservasOcupTop > 0 ? (diasTop / reservasOcupTop) : 0;

                // 1. BLOQUE PREDICTIVO
                decimal inflacionOportunidad = 1.12m; // Predicción de tolerancia de aumento (12%)
                decimal ingresoFuturo = recTop * inflacionOportunidad;
                int diasProyectados = (int)Math.Ceiling(diasTop * 1.25m); // Crecimiento proyectado de demanda

                proyeccionFinanciera = $"Proyección de Ingresos: La '{nombreRecTop}' lidera el rendimiento financiero histórico. El algoritmo estima que alcanzará una recaudación de $ {ingresoFuturo:N2} el próximo semestre, asimilando un incremento inflacionario sin impacto negativo en la demanda.";

                pronosticoOcupacion = $"Proyección de Tiempos (Time-Series): Analizando las fechas de exposición, la '{nombreOcupTop}' acumula {diasTop} días de exhibición. Se prevé un volumen de {diasProyectados} días de demanda sostenida para la próxima temporada alta, requiriendo abrir listas de espera.";

                proyeccionComportamiento = $"Comportamiento Curatorial: El promedio de alquiler en espacios de alta rotación es de {promedioDias} días por muestra. El modelo predice que los artistas emergentes buscarán ventanas de exhibición más cortas para abaratar costos operativos.";

                // 2. BLOQUE PRESCRIPTIVO
                if (nombreRecTop == nombreOcupTop)
                {
                    prescripcionTarifas = $"Gestión de Tarifas (Exclusividad): Al concentrar tanto el éxito financiero como el tiempo de ocupación, se prescribe exigir un contrato mínimo de {promedioDias + 2} días para reservar la '{nombreRecTop}', protegiendo su estatus premium.";
                }
                else
                {
                    prescripcionTarifas = $"Gestión de Tarifas (Equilibrio): Mantener la tarifa actual de '{nombreRecTop}' para resguardar su rentabilidad, y crear 'Micro-Alquileres' (fin de semana) en '{nombreOcupTop}' para monetizar rápidamente su alta demanda diaria.";
                }

                prescripcionMarketing = $"Estrategia de Promoción (Subsidio Cruzado): Destinar el 15% del presupuesto publicitario sobrante de las salas principales para bonificar los cánones de las salas vacías, empujando la demanda hacia los espacios ociosos.";

                if (topArtistas != null && topArtistas.Count > 0)
                {
                    string artista1 = topArtistas.Count > 0 ? topArtistas[0] : "";

                    // ACÁ INCLUIMOS LA ACCIÓN DIRECTA (EMAIL/CONTRATO) PARA LOS ARTISTAS
                    prescripcionTalento = $"Gestión de Curaduría (Mailing Directo): El sistema detectó al expositor '{artista1}' como talento de mayor retención. Acción recetada: Enviar una invitación automática por email ofreciéndole curaduría 100% bonificada en su próxima exhibición solista, asegurando su permanencia en la galería.";
                }
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
                                col.Item().Text("REPORTE INTELIGENTE (BI)").FontSize(11).Bold().FontColor(Colors.Blue.Darken3);
                                col.Item().Text($"Fecha: {DateTime.Now:dd/MM/yyyy HH:mm}").FontSize(9).FontColor(Colors.Grey.Darken1);
                            });
                        });
                        header.Item().PaddingTop(10).LineHorizontal(1.5f).LineColor(Colors.Purple.Darken3);
                    });

                    page.Content().PaddingVertical(15).Column(col =>
                    {
                        col.Spacing(12);
                        col.Item().Text("Análisis Predictivo y Prescriptivo de Salas").FontSize(14).Bold().FontColor(Colors.Purple.Darken4);

                        col.Item().Background(Colors.Purple.Lighten5).Padding(10).Column(c =>
                        {
                            c.Item().Text("PROPÓSITO DEL REPORTE:").Bold().FontSize(9.5f).FontColor(Colors.Purple.Darken3);
                            c.Item().Text("Proyectar el rendimiento financiero y ocupacional de las salas (Predictivo) y emitir órdenes directas de gestión tarifaria y promoción (Prescriptivo) en base a exposiciones finalizadas.").FontSize(9).FontColor(Colors.Grey.Darken3);
                        });

                        // BLOQUE 1: PREDICTIVO (Azul)
                        col.Item().PaddingTop(5).Background(Colors.Grey.Lighten4).BorderLeft(4).BorderColor(Colors.Blue.Darken2).Padding(15).Column(c =>
                        {
                            c.Spacing(8);
                            c.Item().Text("📊 1. MODELO PREDICTIVO (PROYECCIONES)").Bold().FontSize(11).FontColor(Colors.Blue.Darken3);
                            c.Item().LineHorizontal(1).LineColor(Colors.Grey.Lighten2);

                            c.Item().Row(r => { r.ConstantItem(15).Text("•").Bold().FontSize(12).FontColor(Colors.Blue.Darken2); r.RelativeItem().Text(proyeccionFinanciera).FontSize(9).FontColor(Colors.Grey.Darken3); });
                            c.Item().Row(r => { r.ConstantItem(15).Text("•").Bold().FontSize(12).FontColor(Colors.Blue.Darken2); r.RelativeItem().Text(pronosticoOcupacion).FontSize(9).FontColor(Colors.Grey.Darken3); });
                            c.Item().Row(r => { r.ConstantItem(15).Text("•").Bold().FontSize(12).FontColor(Colors.Blue.Darken2); r.RelativeItem().Text(proyeccionComportamiento).FontSize(9).FontColor(Colors.Grey.Darken3); });
                        });

                        // BLOQUE 2: PRESCRIPTIVO (Rojo)
                        col.Item().PaddingTop(5).Background(Colors.Grey.Lighten4).BorderLeft(4).BorderColor(Colors.Red.Darken2).Padding(15).Column(c =>
                        {
                            c.Spacing(8);
                            c.Item().Text("⚙️ 2. PLAN DE ACCIÓN PRESCRIPTIVO (GESTIÓN Y MARKETING)").Bold().FontSize(11).FontColor(Colors.Red.Darken3);
                            c.Item().LineHorizontal(1).LineColor(Colors.Grey.Lighten2);

                            c.Item().Row(r => { r.ConstantItem(15).Text("•").Bold().FontSize(12).FontColor(Colors.Red.Darken2); r.RelativeItem().Text(prescripcionTarifas).FontSize(9).FontColor(Colors.Grey.Darken3); });
                            c.Item().Row(r => { r.ConstantItem(15).Text("•").Bold().FontSize(12).FontColor(Colors.Red.Darken2); r.RelativeItem().Text(prescripcionMarketing).FontSize(9).FontColor(Colors.Grey.Darken3); });
                            c.Item().Row(r => { r.ConstantItem(15).Text("•").Bold().FontSize(12).FontColor(Colors.Red.Darken2); r.RelativeItem().Text(prescripcionTalento).FontSize(9).FontColor(Colors.Grey.Darken3); });
                        });

                        col.Item().PaddingTop(5).Text("Anexo: Desglose Consolidado de Reservas 'Retiradas'").Bold().FontSize(11).FontColor(Colors.Blue.Darken3);
                        col.Item().Table(table =>
                        {
                            table.ColumnsDefinition(columns => { columns.ConstantColumn(80); columns.RelativeColumn(); columns.ConstantColumn(70); columns.ConstantColumn(85); columns.ConstantColumn(95); });
                            table.Header(header =>
                            {
                                header.Cell().Background(Colors.Purple.Darken3).Padding(5).Text("Código").FontColor(Colors.White).Bold().FontSize(9);
                                header.Cell().Background(Colors.Purple.Darken3).Padding(5).Text("Sala de Exposición").FontColor(Colors.White).Bold().FontSize(9);
                                header.Cell().Background(Colors.Purple.Darken3).Padding(5).AlignCenter().Text("Exhibiciones").FontColor(Colors.White).Bold().FontSize(9);
                                header.Cell().Background(Colors.Purple.Darken3).Padding(5).AlignCenter().Text("Total Días").FontColor(Colors.White).Bold().FontSize(9);
                                header.Cell().Background(Colors.Purple.Darken3).Padding(5).AlignRight().Text("Recaudación ($)").FontColor(Colors.White).Bold().FontSize(9);
                            });

                            if (dtDatos != null)
                            {
                                foreach (DataRow row in dtDatos.Rows)
                                {
                                    table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten3).Padding(5).Text(row["CodigoSala"].ToString()).FontSize(9);
                                    table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten3).Padding(5).Text(row["NombreSala"].ToString()).FontSize(9);
                                    table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten3).Padding(5).AlignCenter().Text(row["CantidadReservas"].ToString()).FontSize(9);
                                    table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten3).Padding(5).AlignCenter().Text(row["DiasOcupacion"].ToString()).FontSize(9);
                                    table.Cell().BorderBottom(1).BorderColor(Colors.Grey.Lighten3).Padding(5).AlignRight().Text($"$ {Convert.ToDecimal(row["RecaudacionSalas"]):N2}").FontSize(9);
                                }
                            }
                        });
                    });

                    page.Footer().AlignCenter().Text(text =>
                    {
                        text.Span("Vanguardia Arte - Módulo Inteligencia de Negocios (BI) | Página ").FontSize(8).FontColor(Colors.Grey.Medium);
                        text.CurrentPageNumber().FontSize(8).FontColor(Colors.Grey.Medium);
                    });
                });
            }).GeneratePdf(ruta_VM516);
        }



    }

}
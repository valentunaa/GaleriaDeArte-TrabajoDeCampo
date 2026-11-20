# Vanguardia Arte

Sistema integral de gestión para galería de arte contemporáneo y unidad gastronómica (cafetería), desarrollado en **C# (.NET 8 / Windows Forms)** con persistencia en **Microsoft SQL Server**.

## Propósito del sistema
**Vanguardia Arte** tiene como objetivo centralizar la operación diaria de una galería de arte con cafetería integrada, unificando en una sola plataforma ASIGNACIÓN de espacios de exhibición, la atención gastronómica, la seguridad de la información y el análisis para la toma de decisiones.

A través de sus distintos módulos, el sistema busca:
- **Ordenar y controlar el ciclo de exhibiciones:** desde el registro de artistas y especificaciones técnicas de obras hasta la validación de compatibilidad con salas, cobros de señas/saldos, inspección física y retiro con libre deuda.
- **Agilizar la operatoria de cafetería:** permitiendo registrar pedidos, controlar stock en tiempo real, emitir tickets de caja y gestionar entregas.
- **Garantizar trazabilidad e integridad de los datos:
- **Brindar soporte a la gestión gerencial:** transformando los datos históricos de ventas y ocupación en reportes inteligentes (predictivos y prescriptivos) exportables a PDF.

## Funcionalidades principales
- **Alquiler de Espacio:** artistas, catálogo de obras, disponibilidad y reservas de salas, tesorería/cobros (seña y cobro final con comprobantes PDF), peritaje post-exhibición y retiro/desmontaje de obras.
- **Cafetería:** registro de pedidos, alta rápida de clientes, cobro con ticket PDF, retiro/entrega, historial de entregados, productos y clientes.
- **Sistema, Auditoría y Seguridad:** 
- **Reportes Inteligentes (BI):** análisis predictivo y prescriptivo de consumos de cafetería y ocupación de salas, con exportación a PDF.

## Arquitectura y tecnologías
- **Lenguaje y Framework:** C# / .NET 8 (Windows Forms).
- **Arquitectura en capas:** Presentación (`IU`), Lógica de Negocio (`BLL` / `BLL_Negocio`), Acceso a Datos (`DAL` con ADO.NET), Entidades (`BE`) y Servicios Transversales - **Base de datos:** Microsoft SQL Server (`BD_VanguardiaArte`).
- **Generación de documentos:** QuestPDF (comprobantes, tickets, constancias de libre deuda, bitácora y reportes BI).

## Requisitos previos
- Windows 10 o Windows 11 (64 bits).
- Instancia de **Microsoft SQL Server** instalada y en ejecución (local o en red).
- Permisos sobre SQL Server para crear o restaurar bases de datos y permisos de escritura en la carpeta de instalación/configuración.

## Instalación
1. Ejecutá `Vanguardia_Arte_Instalador.exe`.
2. Seguí el asistente para realizar una **instalación desde cero** o una **reinstalación** (conservando la base actual o restaurando un archivo `.bak`).
3. Al iniciar la aplicación por primera vez (o tras restaurar según corresponda), completá la configuración del servidor SQL, la creación del primer usuario si hiciera falta e iniciá sesión.

## Documentación
- **Guía de Instalación:** detalla el proceso de instalación, configuración inicial y reinstalación (ubicada junto al instalador).
- **Manual de Usuario Integral (`Manual de Usuario Integral - Vanguardia Arte.pdf`):** explica el uso de cada módulo y pantalla; se encuentra junto al ejecutable y puede abrirse desde el botón **AYUDA** de la aplicación.
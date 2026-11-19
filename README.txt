# Vanguardia Arte

Sistema de gestión integral para galería de arte y unidad de cafetería, desarrollado en C# (Windows Forms) con respaldo en SQL Server.

## Funcionalidades principales
- **Alquiler de Espacio:** artistas, catálogo de obras, disponibilidad y reservas de salas, tesorería/cobros (seña y cobro final con comprobantes PDF), peritaje post-exhibición y retiro/desmontaje de obras.
- **Cafetería:** registro de pedidos, alta rápida de clientes, cobro con ticket PDF, retiro/entrega, historial de entregados, productos y clientes.
- **Sistema, Auditoría y Seguridad:** usuarios, roles y permisos, bitácora de eventos, bitácora de cambios (productos y obras), gestión e idioma de la interfaz, backup/restore (`.bak`) y recálculo de dígitos verificadores.
- **Reportes Inteligentes:** consulta y exportación de reportes en PDF.

## Requisitos previos
- Windows 10 o Windows 11 (64 bits).
- Instancia de **Microsoft SQL Server** instalada y en ejecución (local o en red).
- Permisos sobre SQL Server para crear o restaurar bases de datos y permisos de escritura en la carpeta de instalación/configuración.

## Instalación
1. Ejecutá `VanguardiA_Arte_Instalador.exe`.
2. Seguí el asistente para realizar una **instalación desde cero** o una **reinstalación** (conservando la base actual o restaurando un archivo `.bak`).
3. Al iniciar la aplicación por primera vez (o tras restaurar según corresponda), completá la configuración del servidor SQL, la creación del primer usuario si hiciera falta e iniciá sesión.

## Documentación
- **Guía de Instalación:** detalla el proceso de instalación, configuración inicial y reinstalación (ubicada junto al instalador).
- **Manual de Usuario Integral (`Manual de Usuario Integral - Vanguardia Arte.pdf`):** explica el uso de cada módulo y pantalla; se encuentra junto al ejecutable y puede abrirse desde el botón **AYUDA** de la aplicación.
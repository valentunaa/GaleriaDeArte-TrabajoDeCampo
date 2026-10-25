using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Especificacion_Obra_C_VM516
    {
        public int Id_Cambio_VM516 { get; set; }
        public int Id_Obra_VM516 { get; set; }
        public string DNI_Artista_VM516 { get; set; }
        public string Titulo_Obra_VM516 { get; set; }
        public string Tecnica_VM516 { get; set; }
        public decimal Alto_VM516 { get; set; }
        public decimal Ancho_VM516 { get; set; }
        public decimal Peso_VM516 { get; set; }
        public string Req_Iluminacion_VM516 { get; set; }
        public decimal Valor_Declarado_Mercado_VM516 { get; set; }
        public string Categoria_Seguro_VM516 { get; set; }
        public string Estado_Asignacion_VM516 { get; set; }
        public bool Bit_Lo_Bo_VM516 { get; set; }
        public DateTime Fecha_VM516 { get; set; }
        public bool Activo_VM516 { get; set; }

        public BE_Especificacion_Obra_C_VM516(
            int idCambio, int idObra, string dniArtista, string titulo, string tecnica,
            decimal alto, decimal ancho, decimal peso, string reqIluminacion,
            decimal valorMercado, string categoriaSeguro, string estadoAsignacion,
            bool bitLoBo, DateTime fecha, bool activo)
        {
            Id_Cambio_VM516 = idCambio;
            Id_Obra_VM516 = idObra;
            DNI_Artista_VM516 = dniArtista;
            Titulo_Obra_VM516 = titulo;
            Tecnica_VM516 = tecnica;
            Alto_VM516 = alto;
            Ancho_VM516 = ancho;
            Peso_VM516 = peso;
            Req_Iluminacion_VM516 = reqIluminacion;
            Valor_Declarado_Mercado_VM516 = valorMercado;
            Categoria_Seguro_VM516 = categoriaSeguro;
            Estado_Asignacion_VM516 = estadoAsignacion;
            Bit_Lo_Bo_VM516 = bitLoBo;
            Fecha_VM516 = fecha;
            Activo_VM516 = activo;
        }
    }
}

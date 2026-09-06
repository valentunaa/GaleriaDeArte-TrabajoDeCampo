using Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Especificacion_Obra_VM516 : IVerificable

    {
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
        public string Estado_Asignacion_VM516 { get; set; } = "Pendiente_Asignacion";

        public BE_Especificacion_Obra_VM516() { }

        public BE_Especificacion_Obra_VM516(string dni, string titulo, string tecnica, decimal alto, decimal ancho, decimal peso, string reqIluminacion, decimal valorMercado, string categoriaSeguro)
        {
            DNI_Artista_VM516 = dni;
            Titulo_Obra_VM516 = titulo;
            Tecnica_VM516 = tecnica;
            Alto_VM516 = alto;
            Ancho_VM516 = ancho;
            Peso_VM516 = peso;
            Req_Iluminacion_VM516 = reqIluminacion;
            Valor_Declarado_Mercado_VM516 = valorMercado;
            Categoria_Seguro_VM516 = categoriaSeguro;
            Estado_Asignacion_VM516 = "Pendiente_Asignacion";
        }

        public string ObtenerIdentificadorFila()
        {
            return Id_Obra_VM516.ToString();
        }

        public string ObtenerCadenaParaHash()
        {
            return $"{Id_Obra_VM516}{DNI_Artista_VM516}{Titulo_Obra_VM516}{Tecnica_VM516}{Alto_VM516}{Ancho_VM516}{Peso_VM516}{Req_Iluminacion_VM516}{Valor_Declarado_Mercado_VM516}{Categoria_Seguro_VM516}{Estado_Asignacion_VM516}";
        }
    }
}

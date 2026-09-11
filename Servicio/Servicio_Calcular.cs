using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicio
{
    public class Servicio_Calcular
    {
        private Servicio_Cripto cripto;

        public Servicio_Calcular()
        {
            cripto = new Servicio_Cripto();
        }

        public string CalcularDVH(IVerificable entidad)
        {
            // 1. ObtenerCadena(entidad) según tu diagrama
            string cadena = entidad.ObtenerCadenaParaHash();

            // 2. CalcularHash(cadena) llamando a Servicio_Cripto
            return cripto.CalcularHash(cadena);
        }

        public string CalcularHash(string cadenaNormalizada)
        {
            return cripto.CalcularHash(cadenaNormalizada);
        }
    }
}

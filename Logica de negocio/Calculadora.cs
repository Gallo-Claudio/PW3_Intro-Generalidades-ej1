using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica_de_negocio
{
    public class Calculadora
    {
        /// <summary>
        /// Convierte los parametros del tipo String a Int. Luego los suma
        /// </summary>
        /// <param name="ingreso1"></param>
        /// <param name="ingreso2"></param>
        /// <param name="ingreso3"></param>
        /// <returns></returns>
        public static int Sumar(string ingreso1, string ingreso2, string ingreso3="0")
        {
            int primerValor = int.Parse(ingreso1);
            int segundoValor = int.Parse(ingreso2);
            // Try Parse es el unico que no tira excepcion en caso de no poder realizar la conversión 
            bool valido = int.TryParse(ingreso3, out int tercerValor);
            tercerValor = 10 * primerValor;

            int resultado = primerValor + segundoValor + tercerValor;
            return resultado;
        }
    }
}

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
        /// Sumar
        /// </summary>
        /// <param name="ingreso1"></param>
        /// <param name="ingreso2"></param>
        /// <returns></returns>
        public static int Sumar(string ingreso1, string ingreso2)
        {
            int primerValor = int.Parse(ingreso1);
            int segundoValor = int.Parse(ingreso2);
            int tercerValor = 10 * primerValor;

            int resultado = primerValor + segundoValor;
            return resultado;
        }
    }
}

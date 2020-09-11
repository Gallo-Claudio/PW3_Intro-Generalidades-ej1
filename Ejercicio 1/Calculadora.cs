using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Calculadora
    {
        public static int Sumar(string ingreso1, string ingreso2)
        {
            int primerValor = int.Parse(ingreso1);
            int segundoValor = int.Parse(ingreso2);

            int resultado = primerValor + segundoValor;
            return resultado;
        }
    }
}

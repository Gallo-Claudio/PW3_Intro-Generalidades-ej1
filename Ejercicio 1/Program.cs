using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Calculadora Rudimentaria***");// WriteLine escribe la linea y hace un ENTER (baja una linea)
            Console.Write("Ingrese el primer número a sumar: "); // Write escribe la linea y NO hace enter (se mantiene en la misma linea)
            string primerIngreso = Console.ReadLine();

            Console.Write("Ingrese el segundo número a sumar: ");
            string segundoIngreso = Console.ReadLine();

            int primerValor = int.Parse(primerIngreso); // Casteo la variable string ingresada por consola
            int segundoValor = int.Parse(segundoIngreso);

            Console.WriteLine("El resultado es: ");
            int resultado = primerValor + segundoValor;

            Console.WriteLine(resultado);
            Console.ReadKey(); // Se detiene en este punto gasta que se presione cualquier tecla
        }
    }
}

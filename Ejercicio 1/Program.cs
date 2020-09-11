// Namespaces son como los paquetes de Java
// Son bibliotecas accesibles para poder incluir clases de esos namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Para separar la logica se creo un proyecto de biblioteca 
// Se llevo la logica a ese proyecto. Se puso modificador de acceso "PUBLIC" para poder acceder a la clase
// Se hizo una referencia desde el proyecto "Ejercicio 1" al nuevo proyecto de biblioteca
// Se agrego el using correspondiente a ese proyecto (linea de abajo)
using Logica_de_negocio;  


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

            int resultado = Calculadora.Sumar(primerIngreso, segundoIngreso);

            Console.WriteLine(resultado);
            Console.WriteLine("Presione una tecla para terminar");
            Console.ReadKey(); // Se detiene en este punto gasta que se presione cualquier tecla
        }
    }
}

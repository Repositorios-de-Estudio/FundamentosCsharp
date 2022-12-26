using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leer_datos_de_teclado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Leer datos desde el teclado
             *  Parse: convetir tipos de datos
             */



            Console.WriteLine("SUMA DE DOS NUMEROS");

            Console.WriteLine("Ingrese el primer numero");
            string entrada1 = Console.ReadLine();
            int num1 = int.Parse(entrada1);


            Console.WriteLine("Ingrese el segundo numero");
            string entrada2 = Console.ReadLine();
            int num2 = int.Parse(entrada2);


            int result = num1 + num2;
            Console.WriteLine("Resultado suma: {0}",result );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FomatoCadenas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int manzanas = 10;
            int mangos = 5;
            int fresas = 11;

            string result = string.Format("Hay {0} manzanas, {1} mangos y {2} fresas. ", manzanas, mangos, fresas);

            Console.WriteLine(result);

            Console.WriteLine("Pi: {0:0.0000}", Math.PI);

            // ajustar dato con espacios como un tabulador a la derecha
            Console.WriteLine("{0, 1} {1, 2}",1, 2);
            Console.WriteLine("{0, 3} {1, 4}", 3, 4);
            Console.WriteLine("{0, 5} {1, 6}", 5, 6);
            Console.WriteLine("{0, 7} {1, 8}", 7, 8);
            

            Console.WriteLine("**************************");

            // ajustar dato con espacios como un tabulador a la derecha 
            Console.WriteLine("{0, -1} {1, -2}", 1, 2);
            Console.WriteLine("{0, -3} {1, -4}", 3, 4);
            Console.WriteLine("{0, -5} {1, -6}", 5, 6);
            Console.WriteLine("{0, -7} {1, -8}", 7, 8);

            // formato de texto
            int valor = 9998;

            Console.WriteLine("Numero: {0:N}", valor);
            Console.WriteLine("Cientifico: {0:E}", valor);
            Console.WriteLine("Moneda: {0:C}", valor);
            Console.WriteLine("Porcentaje: {0:P}", valor);
            Console.WriteLine("Hexa: {0:X}", valor);

        }
    }
}

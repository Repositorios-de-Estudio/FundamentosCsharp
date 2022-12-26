using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiposPredefinidos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Tipos enteros
             * int -> system.Int32
             * short -> System.Int16
             * byte -> System.Byte
            * largo -> System.Int64
            */
            int entero = 100; //hasta 32bits
            short sss = 140; //16bits
            byte bbb = 10; // 8bits
            long largo = 1234567890; //64bits

            Console.WriteLine("int: {0}, short: {1}, byte {2}, largo: {3}", entero, sss, bbb, largo);


            /* Tipos flotantes
             * float  -> System.Single
             * double -> System.Double
             * decimal -> System.Decimal
            */
            float fff = 123.5f; // siempre debe ir con f, precion single o de un decimal
            double ddd = 3.14159; // precision doble o double
            decimal dec = 129.99m; // siempre usar m, utlizado para operaciones financieras ideal para calculos

            Console.WriteLine("float: {0}, double: {1}, decinal {2}", fff, ddd, dec);


            /* Otros
             * char -> System.Char
             * bool -> System.Boolean
             */
            char ccc = 'A';
            bool boo = true;


            // Write no hace salto de linea
            Console.Write("*** char: ", ccc);
            Console.WriteLine(" *** bool: ", boo);
        }
    }
}

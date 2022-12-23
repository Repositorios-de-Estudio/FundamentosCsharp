using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tablas_de_multiplicacion_RETO
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * RETO - TABLAS DE MULTIPLICAS
             * 
             * Muestra las tablas de multiplicar de un numero
             * El numero se solicita, entre 1 y 10
             */

            Console.WriteLine("Tabla de multiplicar");
            Console.WriteLine("Ingrese un numerp entre 1 y 10: ");
            int entrada = int.Parse(Console.ReadLine());

            if (entrada >= 1 && entrada <= 10)
            {
                for (int i = 1; i <= 10; i++)
                {

                    int result = entrada * i;
                    Console.WriteLine("{0} X {1} = {2}", i, entrada, result);

                }
            }
            else
            {
                Console.WriteLine("*** El valor no esta entre 1 y 10 ***");
            }

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Sintaxis_Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arreglo = new double[5];
            arreglo[0] = 11.1;
            arreglo[1] = 12.2;
            arreglo[2] = 13.3d;
            arreglo[3] = 14.4d;
            arreglo[4] = 15.5d;

            Console.WriteLine("Primera: "  + arreglo[0]);
            Console.WriteLine("Ultima: " + arreglo[arreglo.Length-1]);
            

            foreach (var item in arreglo)
            {
                Console.WriteLine(item);
            }

            char[] vocales = {'a','e', 'i', 'o', 'u'};

            foreach (var item in vocales)
            {
                Console.WriteLine(item);
            }
        }
    }
}

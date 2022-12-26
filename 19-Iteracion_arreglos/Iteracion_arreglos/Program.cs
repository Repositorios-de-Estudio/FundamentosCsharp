using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iteracion_arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arreglo = new int[5];
            int[] arreglo = { 1, 2, 3, 4, 5};

            // for
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(" for: "+arreglo[i]+ "\n");
            }

            // while
            int k = 0;
            while (k < arreglo.Length)
            {
                Console.WriteLine("while: "+arreglo[k]);
                k++;
            }

            //do while
            int j = 0;
            do
            {
                Console.WriteLine("dp-while: " + arreglo[j]);
                j++;

            } while (j < arreglo.Length);

            // foreach
            foreach (var item in arreglo)
            {
                Console.WriteLine("foreach: "+item);
            }

            Console.WriteLine("###FIN####");
        }
    }
}

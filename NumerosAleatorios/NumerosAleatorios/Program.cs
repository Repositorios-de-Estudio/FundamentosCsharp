using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosAleatorios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random(75679);

            // sin semilla
            //Random ran = new Random();

            // numero entre 1 y 12
            int mes = ran.Next(1, 13);

            // probabilidad entre 0 y 1
            double prob = ran.NextDouble();

            int[] arreglo = new int[5];

            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = ran.Next(0, 99);
            }

            foreach (var item in arreglo)
            {
                Console.WriteLine(item);
            }

        }
    }
}

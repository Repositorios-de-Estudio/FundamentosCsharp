using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerramientasDepuracion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 10, 5, 9, -5, 7 };
            int resultado = SumaElementos(numeros);

            Console.WriteLine("La suma es {0}", resultado);
        }

        static int SumaElementos(int[] arreglo)
        {
            int suma = 0;
            for (int i = 0; i < arreglo.Length; i++)
            {
                suma += arreglo[i];
            }

            return suma;
        }
    }
}

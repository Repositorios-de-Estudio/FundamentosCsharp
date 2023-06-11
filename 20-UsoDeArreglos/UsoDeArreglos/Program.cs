using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoDeArreglos
{
    class Program
    {
        // DESCARGADO DEL CURSO
        static void Main(string[] args)
        {
            Console.Write("Tamaño del arreglo? ");
            int tam = Convert.ToInt32(Console.ReadLine());

            // definir el arreglo
            int[] numeros = new int[tam];

            // leer datos y guardarlos en el arreglo
            for(int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Escribe número en índice {0}: ", i);
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Muestra los datos
            Console.WriteLine("Los datos que ingresaste son:");
            MostrarArreglo(numeros);
        }

        static void MostrarArreglo(int[] arreglo)
        {
            foreach(int num in arreglo)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace clase_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] list = { 11, 34, 1, 5 };
            int[] temp = new int[list.Length]; // creanddo una lista con la misma longitud de list

            // copiar arreglo
            Array.Copy(list, temp, list.Length);

            Console.WriteLine("\n Arreglo original: ");
            MostrarArreglo(list);
            Console.WriteLine("\n Arreglo copiado: ");
            MostrarArreglo(temp);


            //invierte arreglo
            Console.WriteLine("\n Arreglo invertido: ");
            Array.Reverse(temp);
            MostrarArreglo(temp);


            //ordenar arreglo - ascendentemente
            Console.WriteLine("\n Arreglo ordenado: ");
            Array.Sort(temp);
            MostrarArreglo(temp);
        }

        static void MostrarArreglo(int[] list)
        {
            foreach (var item in list)
            {
                Console.Write(" "+item);
            }

            Console.WriteLine("\n");
        }
    }
}

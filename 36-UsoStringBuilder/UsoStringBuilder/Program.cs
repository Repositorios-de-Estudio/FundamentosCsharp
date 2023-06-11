using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoStringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder cadenaBL = new StringBuilder("CADENA de prueba :)");

            Console.WriteLine("Cadena: {0}\n Longitud: {1}\n Capacidad: {2}\n", cadenaBL, cadenaBL.Length, cadenaBL.Capacity);

            cadenaBL.EnsureCapacity(75);

            Console.WriteLine("Cadena: {0}\n Longitud: {1}\n Capacidad: {2}\n", cadenaBL, cadenaBL.Length, cadenaBL.Capacity);

            object[] datos = { "palabra", 1, 0.5, 'c', 8, 100, 1999};

            foreach (var item in datos)
            {
                cadenaBL.Append(item + " ");
            }

            Console.WriteLine(cadenaBL.ToString());
            Console.WriteLine("Longitud: {1}\n Capacidad: {2}\n", cadenaBL, cadenaBL.Length, cadenaBL.Capacity);

            cadenaBL.Insert(0, "Inicio: ");
            Console.WriteLine("Cadena: {0}\n Longitud: {1}\n Capacidad: {2}\n", cadenaBL, cadenaBL.Length, cadenaBL.Capacity);


        }
    }
}

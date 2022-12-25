using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;

namespace RETO_promedio_calificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // RETO  - PROMEDIO CALIFICACIONES
            // Solicite al usuario la cantidad de calificaciones a ingresar
            // despues leer calificaciones y guardarlas,
            // calcular el promedio de las calificaciones
            // mostrar el resultado

            int nn = 0;

            Console.WriteLine(" RETO  - PROMEDIO CALIFICACIONES");

            Console.Write("Ingrese el número de calificaciónes: ");
            nn = Convert.ToInt32(Console.ReadLine());

            int[] lista= new int[nn];

            for (int ii = 0; ii < lista.Length; ii++)
            {
                Console.Write("Ingrese la calificación {0} de {1}: ", ii+1, lista.Length);
                lista[ii] = Int32.Parse(Console.ReadLine());
            }
                      

            //calcular promedio

            double prom = 0.0;
            double acum = 0.0;
            foreach (var item in lista)
            {
                acum+= item;
            }

            prom = acum /lista.Length;

            Console.WriteLine("Cantidad de calificaciones: "+ nn);
            Console.WriteLine("Promedio de calificaciones: "+ prom+"\n");

        }

    }
}

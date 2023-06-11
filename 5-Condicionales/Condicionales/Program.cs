using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Sentencias Condicionales:
             *  simple
             *  compuesto
             * 
             * *sentencias**
             *  if
             *  if - else
             *  if else if - else
             *  switch
             * 
             * Operadores logicos:
             *  && - y logico
             *  || - o logico
             */


            // simple - if
            int num = 10;

            if (num > 5)
            {
                Console.WriteLine("num es mayor que 5");
            }

            // Condicional compuesto - if
            string user = "user1";
            string pass = "password";
            
            if (user == "user1" && pass == "password") 
            {
                Console.WriteLine("Acceso Correcto");
            }


            // if - else
            int edad = 23;
            if (edad >= 18)
            {
                Console.WriteLine("Es mayor de edad");
            }
            else
            {
                Console.WriteLine("Menor de edad");
            }


            //if - else if - else
            int a = 1;
            int b = 6;
            if (a > b)
            {
                Console.WriteLine("A es mayor que B");
            }
            else if (a == b)
            {
                Console.WriteLine("A es igual que B");
            }
            else
            {
                Console.WriteLine("A es menor que B");
            }


            // switch

            string codigo = "A1X";

            switch (codigo)
            {
                case "A1":
                    Console.WriteLine("A1");
                    break;
                case "A2":
                    Console.WriteLine("A2");
                    break;
                case "A3":
                    Console.WriteLine("A3");
                    break;
                default:
                    Console.WriteLine("No encontrado");
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* 1
             * Operadores ARITMETICOS o binarios*
             * Suma, resta +, -
             * Multiplicacion, division, *, /
             * Modulo %
            */
         
            int a = 30;
            int b = 11;

            Console.WriteLine(a + b);
            Console.WriteLine(a * b);
            Console.WriteLine(a % b);

            /* 2
             * Operadores unarios
             * Incremento, decremento ++, --
             * 
             */
            a++;
            Console.WriteLine(a);


            /* 3
             * Operadores de comparacion -> retorna booleano
             * Mayor que, menor que, >, <
             * Mayor o igual que, menor o igual que, >= , <=
             * igual, difernete, ==, !=
             */

            Console.WriteLine(a > b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a == b);


            int num = 19;
            int divisor = 5;
            int resultado = num % divisor;

            Console.WriteLine(resultado);
        }
    }
}

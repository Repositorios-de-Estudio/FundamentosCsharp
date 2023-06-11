using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RETO___estructura_propia_Numero_complejo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            NComplejo n1 = new NComplejo(3,2);
            NComplejo n2 = new NComplejo(5,6);

            Console.WriteLine("Sum: "+n1.Suma(n2));
            Console.WriteLine("Mul: "+n1.Multiplicacion(n2));

            Console.WriteLine("-------------------------------");


            n1 = new NComplejo(3, 4);
            n2 = new NComplejo(-0.5, 2);

            Console.WriteLine("Sum: "+n1.Suma(n2));
            Console.WriteLine("Mul: "+n1.Multiplicacion(n2));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estructuras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(1,2,3);
            Vector v2 = new Vector(4,5,6);

            Console.WriteLine("Modulo v1 = {0}", v1.Modulo());
            Console.WriteLine("Modulo v2 = {0}", v2.Modulo());

            Vector resultado = v1.Suma(v2);
            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(resultado);
        }
    }
}

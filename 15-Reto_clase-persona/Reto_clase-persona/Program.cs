using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reto_clase_persona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Pepito","Paez", -85);
            Persona p2 = new Persona("Rogelio", "Pataquiba", 18);
            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Console.WriteLine(p1.Saludar());
            Console.WriteLine(p2.Saludar());
        }
    }
}

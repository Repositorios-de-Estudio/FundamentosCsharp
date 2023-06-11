using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Persona p1 = new Persona("Fulado", 38);
            p1.Saludar();

            // tostring sobreescrito en persona
            Console.WriteLine(p1.ToString());

            Empleado e1 = new Empleado("Sultado", 29, "Ventas", 4000);
            e1.Saludar();
            e1.Trabajar();

            // tostring sobreescrito en empleado
            Console.WriteLine(e1.ToString());

        }
    }
}

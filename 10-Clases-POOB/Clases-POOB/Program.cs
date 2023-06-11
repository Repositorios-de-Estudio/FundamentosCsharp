using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases_POOB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // crea un objeto de tipo Rectangulo

            Rectangulo rect = new Rectangulo();
            rect.Altura = 10;
            rect.Base = 11;

            int area = rect.CalcularArea();


            Console.WriteLine("Area 1, base {0} x altura {1} = {2} unidades cuadradas", rect.Base, rect.Altura, area);


            // sintaxis de inicializacion

            Rectangulo rect2 = new Rectangulo { Base = 3, Altura = 8 };
            int area2 = rect2.CalcularArea();

            Console.WriteLine("Area 2, base {0} x altura {1} = {2} unidades cuadradas", rect2.Base, rect2.Altura, area2);

        }
    }
}

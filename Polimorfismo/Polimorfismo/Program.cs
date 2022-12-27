using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instanaciado con upcasting
            IFigura f1 = new Circulo { Radio = 5 };
            IFigura f2 = new Triangulo { Base = 10, Altura = 8};
            IFigura f3 = new Rectangulo { Base = 4, Altura = 3};
            IFigura f4 = new Circulo { Radio = 9 };

            // como todas los objetos son a su vez IFgura se pueden almacenar en el arreglo de tipo IFigura
            IFigura[] figuras = { f1, f2, f3, f4 };

            foreach (var figura in figuras)
            {
                // no es posible porque IFigura no implenta esto, se debe hacer un downcasting
                //figura.MostrarDatos();
                Console.WriteLine(figura.CalcularArea());
                
                Console.WriteLine("-----------------");
            }

            //downcasting
            Circulo c = f1 as Circulo;
            Triangulo t = f2 as Triangulo;
            Rectangulo r = f3 as Rectangulo;
            Circulo cc = f4 as Circulo;

            //ahora si se puede usar este metodo
            c.MostrarDatos();
            t.MostrarDatos();
            r.MostrarDatos();
            cc.MostrarDatos();
        }
    }
}

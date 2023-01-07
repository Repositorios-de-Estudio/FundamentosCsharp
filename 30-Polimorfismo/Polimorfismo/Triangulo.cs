using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorfismo
{
    internal class Triangulo : IFigura
    {
        public double Base { get; set; }

        public double Altura { get; set; }
        public double CalcularArea()
        {
            return Base * Altura / 2;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Triangulo: B = {0}, A = {1}", Base, Altura);
        }

    }
}

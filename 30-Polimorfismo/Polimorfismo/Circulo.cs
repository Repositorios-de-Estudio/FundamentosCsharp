using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorfismo
{
    internal class Circulo : IFigura
    {
        
        public double Radio { get; set; }

        public int Id { get; set; }

        public double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Circulo: r = {0}", Radio);
        }
    }
}

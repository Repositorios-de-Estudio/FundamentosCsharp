using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polimorfismo
{
    internal class Rectangulo : IFigura
    {
        public double Base { get; set; }

        public double Altura { get; set; }

        public int Id { get; set; }
        public double CalcularArea()
        {
            return Base * Altura;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Rectangulo: B = {0}, A = {1}", Base, Altura);
        }
    }
    
}

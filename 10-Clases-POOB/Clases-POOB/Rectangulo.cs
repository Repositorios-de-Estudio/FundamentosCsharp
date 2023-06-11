using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases_POOB
{
    internal class Rectangulo
    {
        public int Base { get; set; }
        public int Altura { get; set; }

        public int CalcularArea()
        {
            return Base * Altura;
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposReferenciasVSTiposValor
{
    internal class PuntoRef
    {
        // TIPOS DE REFERENCIA / CLASES

        public int X { get; set; } 
        public int Y { get; set; }

        public PuntoRef(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return string.Format("PuntoRef: {0},{1}", X, Y);
        }
    }
}

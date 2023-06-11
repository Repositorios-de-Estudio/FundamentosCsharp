using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposReferenciasVSTiposValor
{
    internal struct PuntoVal
    {
        // TIPOS DE VALOR / ESTRUCTURAS
        public int X { get; set; }
        public int Y { get; set; }

        // se llama al constructor vacio
        public PuntoVal(int x, int y): this()
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return string.Format("PuntoVal: {0},{1}",X, Y );
        }
    }
}

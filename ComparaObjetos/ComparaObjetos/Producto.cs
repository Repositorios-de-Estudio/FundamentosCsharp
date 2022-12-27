using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComparaObjetos
{
    internal class Producto : IComparable<Producto>
    {
        public string Codigo { get; set; }
        public decimal Precio { get; set; }

        public int CompareTo(Producto other)
        {
            // comprar en base a su precio

            // > 0 es mayor, == 0 son iguales, < -1 es menor

            if (Precio > other.Precio) { return 1; }
            else if (Precio == other.Precio) { return 0; }
            else { return -1;}
        }
    }
}

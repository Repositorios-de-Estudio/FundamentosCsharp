using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComparaObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto p1 = new Producto { Codigo = "A1", Precio = 123 };
            Producto p2 = new Producto { Codigo = "A2", Precio = 34.5m };
            Producto p3 = new Producto { Codigo = "A3", Precio = 99.9m };

            Producto[] productos = new Producto[] { p1, p2,p3 };
            Array.Sort(productos); // aca es usado IComparable que permite hace la comparacion para ordenar

            foreach (var item in productos)
            {
                Console.WriteLine("Codigo: {0}, Precio: {1}", item.Codigo, item.Precio);
            }

        }
    }
}

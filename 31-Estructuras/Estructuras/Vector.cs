using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estructuras
{
    internal struct Vector
    {
        // vector con tres dimensiones
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector(double x, double y, double z): this()
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double Modulo()
        {
            return Math.Sqrt((X * X) + (Y * Y) + (Z * Z));
        }

        public Vector Suma(Vector v2)
        {
            return new Vector(X + v2.X, Y + v2.Y, Z + v2.Z);
        }

        public override string ToString()
        {
            return string.Format("[ {0} , {1} , {2} ]", X, Y, Z);
        }

    }
}

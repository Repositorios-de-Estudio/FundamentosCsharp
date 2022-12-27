using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clase_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona("Algo Poltelo", 55);
            Persona p2 = new Persona("Algo Poltelo", 55);
            Persona p3 = p1;


            //comparacion por referencia, si dos referencias apuntan al mismo objeto
            Console.WriteLine("comparacion por referencia p1 == p2 : {0}", p1==p2); //false, aunque tienes los mismos valores pq son objetos diferentes
            Console.WriteLine("comparacion por referencia p2 == p3 : {0}", p2 == p3); //false
            Console.WriteLine("comparacion por referencia p1 == p3 : {0}", p1 == p3); //true

            Console.WriteLine();

            // comparacion de objetos
            Console.WriteLine("comparacion de objeto p1 equals p2 : {0}", p1.Equals(p2)); //true, diferentes objetos pero con los mismos valores
            Console.WriteLine("comparacion de objeto p2 equals p3 : {0}", p2.Equals(p3)); //true
            Console.WriteLine("comparacion de objeto p1 equals p3 : {0}", p1.Equals(p3)); //true

        }
    }
}

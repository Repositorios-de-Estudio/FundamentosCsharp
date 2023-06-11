using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // RETO
            // SUBCLASE ESTUDIANTE


            /*
             * PROPIEDADES: 
             * PROMEDIO, DOUBLE
             * GRADO, STRING
             * 
             * CONSTRUCTOR:
             * INICIALIZAR TODAS LAS PROPIEDADES
             * 
             * METODOS:
             * ESTUDIAR()
             * IR A CLASE()
             * 
             * SOBREESCRIBIR:
             * SALUDAR()
             * TOSTRING()
             */

            Console.WriteLine("\n CLASE PERSONA \n");

            Persona p1 = new Persona("Fulado", 38);
            p1.Saludar();

            // tostring sobreescrito en persona
            Console.WriteLine(p1.ToString());

            Console.WriteLine("\n CLASE EMPLEADO \n");

            Empleado e1 = new Empleado("Sultado", 29, "Ventas", 4000);
            e1.Saludar();
            e1.Trabajar();

            // tostring sobreescrito en empleado
            Console.WriteLine(e1.ToString());

            Console.WriteLine("\n CLASE ESTUDIANTE \n");

            Estudiante s1 = new Estudiante("Pompilio", 15, 4.99, "11");
            s1.Saludar();
            s1.irAEstudiar();
            s1.irAClase();

            // tostring sobreescrito en estudiante
            Console.WriteLine(s1);

        }
    }
}

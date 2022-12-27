using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases_Abstractas
{
    abstract class Empleado
    {
        public string Nombre { get; set; }
        public string Puesto { get; set;}

        // Propiedad abstracta que debe de ser definida por la subclase
        // esta no va en el constructor
        public abstract decimal Salario { get; }

        public Empleado(string nombre, string puesto) 
        {
            Nombre = nombre;
            Puesto = puesto;
        }

        public void Saludar()
        {
            Console.WriteLine("Hola!! saluda {0}", Nombre);
        }

        // Metodo abstracto que debe de ser implementada por la subclase
        public abstract void Trabajar();
    }
}

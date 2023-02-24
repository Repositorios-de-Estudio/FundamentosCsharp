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
        public string ARL { get; set; }

        // Propiedad abstracta que debe de ser definida por la subclase
        // esta no va en el constructor
        public abstract decimal Salario { get; }

        public Empleado(string nombre, string puesto, string arl)
        {
            Nombre = nombre;
            Puesto = puesto;
            ARL = arl;
        }

        public void Saludar()
        {
            Console.WriteLine("Empleado - Hola!! saluda {0}", Nombre);
        }

        // virtual es para indicar que no tiene implementación en subclase
        // en caso de que la subclase lo implemente esta NO SE EJECUTA
        public virtual void Desayunar()
        {
            Console.WriteLine("Empleado - Esta desayunando...");
        }

        // Metodo abstracto que debe de ser implementada por la subclase
        public abstract void Trabajar();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    internal class Persona
    {
        public string Nombre { get; set; }

        public int Edad { get; set; }

        public Persona()
        {
        }

        public Persona (string nombre, int edad) 
        {
            Nombre= nombre;
            Edad= edad;
        }

        public virtual void Saludar()
        {
            Console.WriteLine("Hola!!! el nombre de la persona es: {0}", Nombre);
        }

        public override string ToString()
        {
            return string.Format("** Persona: {0}, edad: {1} **", Nombre, Edad);
        }

    }
}

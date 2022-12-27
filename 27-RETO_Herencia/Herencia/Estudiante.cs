using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    internal class Estudiante : Persona
    {
        public double Promedio { get; set; }
        public string Grado { get; set; }

        public Estudiante(string nombre, int edad, double promedio, string grado) : base(nombre, edad)
        {
            Promedio = promedio;
            Grado = grado;
        }

        public void irAEstudiar()
        {
            Console.WriteLine("Estudiante {0} va a estudiar arduamente :D...", Nombre);
        }

        public void irAClase() 
        {
            Console.WriteLine("Estudiante {0} va a clase...", Nombre);
        }


        public override void Saludar()
        {
            Console.WriteLine("Estudiante {0} dice Hola!", Nombre);
        }

        public override string ToString()
        {
            return string.Format("** Estudiante: {0}, edad: {1}, Promedio: {2}, Grado {3} **", Nombre, Edad, Promedio, Grado);
        }
    }
}

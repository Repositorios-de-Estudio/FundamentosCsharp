using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    internal class Empleado : Persona
    {
        public string Puesto { get; set; } 

        public decimal Sueldo{ get; set;}

        public Empleado(string nombre, int edad, string puesto, decimal sueldo):base(nombre, edad)
        {
            Puesto= puesto;
            Sueldo= sueldo;
        }


        // este metodo es virtual en Persona
        public override void Saludar()
        {
            Console.WriteLine("Empleado: {0}, puesto: {1}", Nombre, Puesto);
        }

        // metodo propio de empleado
        public void Trabajar()
        {
            Console.WriteLine("{0} esta trabajando...", Nombre);
        }

        // empleado tambien puede sobreescribir otros metodos que fueron sobreescritos en la superclase
        public override string ToString()
        {
            return string.Format("* Empleado: {0}, {1} años, {2}, sueldo: ${3} *", Nombre, Edad, Puesto, Sueldo);
        }
    }
}

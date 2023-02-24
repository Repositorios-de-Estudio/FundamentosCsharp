using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace Clases_Abstractas
{
    internal class EmpleadoXHonorarios : Empleado
    {
        public decimal SueldoBase { get; set; }
        
        // implementacion de propiedad abstract de la clase asbtracta
        public override decimal Salario { get => SueldoBase*0.84m; }

        public EmpleadoXHonorarios(string nombre, string puesto, decimal sueldoBase) : base(nombre, puesto)
        {
            SueldoBase = sueldoBase;
        }


        // implementacion del metodo de la clase abstracta
        public override void Trabajar()
        {
            Console.WriteLine("Trabajando X Honorarios :D...");
        }

        // al existir (new) ya el metodo se debe sobreescribir aca
        public new void Saludar()
        {
            base.Saludar();
            Console.WriteLine("Hola!! saluda {0}", Nombre);
        }

        public override void Desayunar()
        {
            //base.Desayunar();
            Console.WriteLine("Tomando cafe!!");
        }

    }
}

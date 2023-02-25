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
        
        // implementacion de propiedad abstract de la clase base
        public override decimal Salario { get => SueldoBase*0.84m; }

        // la propiedad virtual no se debe implementar

        public EmpleadoXHonorarios(string nombre, string puesto, decimal sueldoBase, string arl) : base(nombre, puesto, arl)
        {
            SueldoBase = sueldoBase;
        }


        // implementacion del metodo de la clase abstracta
        public override void Trabajar()
        {
            Console.WriteLine("Trabajando X Honorarios :D...");
        }

        // al existir el metodo se debe sobreescribir aca con new
        public new void Saludar()
        {
            base.Saludar();
            Console.WriteLine("Hola!! saluda {0}", Nombre);
        }

        // al ser virual en la clase base este metodo nunca se ejecuta, siempre va a imprimir "Empleado - Esta desayunando..."
        public override void Desayunar()
        {
            Console.WriteLine("Tomando cafe!!");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases_Abstractas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmpleadoXHonorarios eH1 = new EmpleadoXHonorarios("Jhon", "Computacion", 4000, "SuperSalud");
            EmpleadoXNomina eN1 = new EmpleadoXNomina("Albon", "Administracion", 4000, "AlohaSalud");

            Console.WriteLine();

            eH1.Trabajar();
            eH1.Saludar();
            eH1.Desayunar();
            Console.WriteLine("Salario de {0} por honborarios: {1}",eH1.Nombre, eH1.Salario);

            Console.WriteLine();

            eN1.Trabajar();
            eN1.Saludar();
            eN1.Desayunar();
            Console.WriteLine("Salario de {0} por nomina: {1}", eN1.Nombre, eN1.Salario);

            Console.WriteLine();

        }
    }
}

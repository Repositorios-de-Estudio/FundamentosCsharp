using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiembrosEstaticos
{
    /// <summary>
    /// Miembros estáticos
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            /* Para acceder a los miembros estáticos se usa solo el nombre de la clase*/
            CuentaBancaria cuenta1 = new CuentaBancaria("001", "John Doe", 100);
            CuentaBancaria cuenta2 = new CuentaBancaria("002", "Jane Doe", 250);

            // al usar un metodo static no se requiere la instancia
            // asigna a todas las cuentas bancarias el Banco "Mi Banco"
            Console.WriteLine("Cambiando el banco a Mi Banco...");
            CuentaBancaria.Banco = "Mi Banco";

            Console.WriteLine(cuenta1);
            Console.WriteLine(cuenta2);

            // asigna a todas las cuentas bancarias el Banco "Otro banco"
            Console.WriteLine("Cambiando el banco a Otro Banco...");
            CuentaBancaria.AsignarBanco("Otro Banco");

            Console.WriteLine(cuenta1);
            Console.WriteLine(cuenta2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Propiedades
{


    // PROYECTO PROPIEDADES DESCARGADO DEL CURSO
    // original en Net Framework 4.0

    /// <summary>
    /// Propiedades
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria cuenta = new CuentaBancaria();

            cuenta.Saldo = -5;
            Console.WriteLine("Saldo después de primera asignación: {0}", cuenta.Saldo);

            cuenta.Saldo = 10;
            Console.WriteLine("Saldo después de segunda asignación: {0}", cuenta.Saldo);

            CuentaBancaria cuenta1 = new CuentaBancaria("001","Terminator", 100);
            CuentaBancaria cuenta2 = new CuentaBancaria("002", "Sarha", 250);

            Console.WriteLine("Deposito cuenta 1");
            cuenta1.Depositar(69.999m);

            Console.WriteLine("Retirp cuenta 2");
            cuenta2.Retirar(19.9999m);


            // al tener el metodo toString es posible invocalor solamente intenando colocar el objeto
            Console.WriteLine(cuenta1);
            Console.WriteLine(cuenta2);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // clase que sea una Cuenta bancaria, 
            // num de cuenta, id usuario, saldo

            // usando constructor con un argumento
            CuentaBancaria cuenta1 = new CuentaBancaria("0000001");
            Console.WriteLine("Cuenta: {0}, Usuario: {1}, Saldo: {2}", 
                cuenta1.Cuenta, cuenta1.Usuario, cuenta1.Saldo);

            // usando constructor con dos argumento - este usa this()
            CuentaBancaria cuenta2 = new CuentaBancaria("0000002", "Pepito Fulano");
            Console.WriteLine("Cuenta: {0}, Usuario: {1}, Saldo: {2}",
                cuenta2.Cuenta, cuenta2.Usuario, cuenta2.Saldo);

            // usando constructor con tres argumentos
            CuentaBancaria cuenta3 = new CuentaBancaria("0000003", "Firulais Rodriguez", 100012313);
            Console.WriteLine("Cuenta: {0}, Usuario: {1}, Saldo: {2}",
                cuenta3.Cuenta, cuenta3.Usuario, cuenta3.Saldo);

        }
    }
}

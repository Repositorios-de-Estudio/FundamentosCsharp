using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructores
{
    internal class CuentaBancaria
    {
        public string Cuenta { get; set; }
        public string Usuario { get; set; } 
        public decimal Saldo { get; set; }

        // pueden haber varios constructores
        // se pueden llamar constructores dentro de otro costructor
        // los constructores no tienen tipo de retorno, a diferencia de los metodos


        public CuentaBancaria(string cuenta)
        {
            Cuenta = cuenta;
        }

        //usando :this(parametro, parametro) busca el constructor que corresponda y lo llama
        public CuentaBancaria(string cuenta, string usuario): this(cuenta)
        {
            Usuario = usuario;
        }

        public CuentaBancaria(string cuenta, string usuario, decimal saldo) 
        { 
            Cuenta = cuenta; 
            Usuario = usuario;
            Saldo = saldo;
        }

        // se puede crear un constructor vacio
        public CuentaBancaria()
        {

        }
    
    }
}

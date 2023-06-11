using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Propiedades
{
    public class CuentaBancaria
    {
        // Auto properties (propiedades automáticas)
        public string NoCuenta { get; set; }
        public string Usuario { get; set; }

        // backing field - _saldo es variable privada solo para calculo del Saldo
        // Se expanden los metodos set y get de Saldo en la declaracion
        private decimal _saldo;

        // Full property (propiedad completa)
        public decimal Saldo
        {
            get { return _saldo; }
            // Evitar que el saldo sea negativo, uso de operador ternario
            set { _saldo = value < 0 ? 0 : value; }
        }

        public void Retirar(decimal cantidad)
        {
            if (cantidad>Saldo)
            {
                Console.WriteLine("Saldo insuficiente");
                return;
                
            }

            Saldo -= cantidad;
        }


        public void Depositar(decimal cantidad)
        {
            Saldo += cantidad;
        }


        public override string ToString()
        {
            return string.Format("noCuenta: {0}, Usuario: {1}, Saldo: {2}", NoCuenta, Usuario, Saldo);
        }


        //codigo extendido para set
        /*
            // Evitar que el saldo sea negativo
            if (value< 0)
            {
                _saldo = 0;
            }
            else
            {
                _saldo = value;
            }
        */

        #region constructores
        public CuentaBancaria(string noCuenta)
        {
            NoCuenta = noCuenta;
        }

        public CuentaBancaria(string noCuenta, string usuario)
            : this(noCuenta)
        {
            Usuario = usuario;
        }

        public CuentaBancaria(string noCuenta, string usuario, decimal saldo)
            : this(noCuenta, usuario)
        {
            Saldo = saldo;
        }

        public CuentaBancaria() { }
        #endregion
    }
}

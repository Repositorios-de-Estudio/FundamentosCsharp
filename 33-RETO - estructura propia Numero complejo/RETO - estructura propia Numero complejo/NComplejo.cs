using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RETO___estructura_propia_Numero_complejo
{
    internal struct NComplejo
    {
        public double Real { get; }
        public double Imaginario { get; }

        public NComplejo(double real, double imaginario): this()
        {
            Real = real;
            Imaginario = imaginario;
        }

        public NComplejo Suma(NComplejo otro)
        {
            return new NComplejo(Real+otro.Real, Imaginario+otro.Imaginario);
        }

        public NComplejo Multiplicacion(NComplejo otro)
        {
            return new NComplejo(Real*otro.Real+Imaginario*otro.Imaginario*-1,Real*otro.Imaginario+Imaginario*otro.Real);
        }

        public override string ToString()
        {
            return string.Format("Num compejo: {0}+{1}i", Real, Imaginario);
        }

    }
}

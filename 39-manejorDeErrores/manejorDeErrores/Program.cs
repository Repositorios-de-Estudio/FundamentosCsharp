using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manejorDeErrores
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
				Console.WriteLine("Ingrese numerador: ");
				int num = int.Parse(Console.ReadLine());

				Console.WriteLine("Ingrese denominador: ");
				int den = int.Parse(Console.ReadLine());

				double result = num / den;

				Console.WriteLine("Resultado: {0}", result);
			}
			catch (FormatException exf)
			{

				Console.WriteLine("Mensaje: " + exf.Message);
			}
			catch (DivideByZeroException exd)
			{
                Console.WriteLine("La division entre 0 no esta definida: " + exd.Message);
            }
        }
    }
}

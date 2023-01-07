using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposReferenciasVSTiposValor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // TIPOS DE VALOR / ESTRUCTURAS

            Console.WriteLine("Tipos de valor \n");

            PuntoVal puntV = new PuntoVal(5, 10);
            PuntoVal otroPuntoV = puntV;

            // puntoV no ha cambiado ya se fue modificada una copia y no afecta al original
            otroPuntoV.X = 100;
            otroPuntoV.Y = 60;

            Console.WriteLine(puntV);
            Console.WriteLine(otroPuntoV);

            Console.WriteLine("\n");

            // TIPOS DE REFERENCIA / CLASES

            Console.WriteLine("Tipos de valor \n");

            PuntoRef puntRef = new PuntoRef(5, 10);
            PuntoRef otroPuntoR = puntRef;

            otroPuntoR.X = 200;
            otroPuntoR.Y = 300;

            Console.WriteLine(puntRef);
            Console.WriteLine(otroPuntoR);

            Console.WriteLine("\n");
        }
    }
}

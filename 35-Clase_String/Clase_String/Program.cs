using System;

namespace Clase_String
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // concatenacion
            Console.WriteLine("Hola" + " " + "Mundo");
            Console.WriteLine(string.Concat("Hola"," ","Mundo"));

            string cadena = "Cadena de prueba :)";
            string otraCadena = " ";

            //tamnaño - no muta la variable
            Console.WriteLine("Tamaño: "+cadena.Length);

            // mayus - minus - no muta la variable
            Console.WriteLine("MAYUSCULAS: " + cadena.ToUpper());
            Console.WriteLine("Minisculas: " + cadena.ToLower());

            //reemplazar - ej: quita espacion es blanco por nada -> quita espacios - no muta
            Console.WriteLine("Reemplazar: "+ cadena.Replace(" ", ""));

            //cadena como arreglo
            Console.WriteLine("Con incices: " + cadena[0] + cadena[2] + cadena[4]);
    
            //substring - subcadena
            Console.WriteLine("Suncadena: (0-9): "+ cadena.Substring(0,10));

            //contiene una cadena dentro
            Console.WriteLine("Contiene ':)': " + cadena.Contains(":)"));

            //cadena empieza con otra cadena
            Console.WriteLine("Cadena empieza con 'CADENA': "+cadena.StartsWith("CADENA"));

            //cadena es nula o vacia?
            Console.WriteLine("Es nula?: " + string.IsNullOrEmpty(otraCadena));

            //cadena es nula o vacia o con caracteres de espacio en blanco?
            Console.WriteLine("Es nula?: " + string.IsNullOrWhiteSpace(otraCadena));

            //indice de una subcadena
            Console.WriteLine("Indice de \"pru\" empieza en: "+cadena.IndexOf("pru"));
            
        }
    }
}

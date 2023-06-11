using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiNamespace
{
    class Clase1
    {
        public void Metodo()
        {
            Console.WriteLine("Mi namespace");
        }
    }
}


namespace OtroNamespace
{
    class Clase1
    {
        public void Metodo()
        {
            Console.WriteLine("Otro namespace");
        }
    }

}
        
namespace NameSpaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CREANDO OBJETOS DE CLASES CONTENIDAS EN OTROS NAMESPACES
            MiNamespace.Clase1 clase1obj = new MiNamespace.Clase1();
            OtroNamespace.Clase1 otroobj = new OtroNamespace.Clase1();

            clase1obj.Metodo();
            otroobj.Metodo();

        }
    }
}

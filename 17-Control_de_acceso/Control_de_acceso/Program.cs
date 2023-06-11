using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using OtroNamespace;

namespace Control_de_acceso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sin user using
            //OtroNamespace.MiClase miClase= new OtroNamespace.MiClase();

            MiClase miClase = new MiClase();
            miClase.MetodoPublic();
            //miClase.MetodoProtected();
            miClase.MetodoInternal();
            //miClase.MetodoPrivate();
        }
    }
}

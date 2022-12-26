using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OtroNamespace
{
    class MiClase
    {

        public void MetodoPublic()
        {
            // puede ser visto desde cualquier clase
            Console.WriteLine("Metodo public");
        }

        protected void MetodoProtected()
        {
            // puede ser visto desde esta clase o cualquier que herede de esta
            Console.WriteLine("Metodo protected");
        }

        internal void MetodoInternal()
        {
            // puede ser visto por cualquier clase dentro del mismo assembly
            Console.WriteLine("Metodo internal");
        }

        private void MetodoPrivate()
        {
            // solo puede ser visto desde la propia clase
            Console.WriteLine("Metodo private");
        }


    }
}

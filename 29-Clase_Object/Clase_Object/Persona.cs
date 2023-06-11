using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clase_Object
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public override bool Equals(object obj)
        {
            /* primero se valida que los objetos sea del mismo tipo */

            if (obj == null) return false;

            // se castea obj como persona
            Persona p = obj as Persona;
            if (p == null) return false;

            /* luego se comprueba que sus propiedades tengan el mismo valor */
            return (Nombre == p.Nombre) && (Edad == p.Edad);
        }

      
      
        public override int GetHashCode()
        {
            //numero primo
            int hash = 104297;

            // se calcula el hash con otro numero primo y se les suma los hash de las propiedades
            hash = (hash * 103919) + Nombre.GetHashCode();
            hash = (hash * 103919) + Edad.GetHashCode();

            return hash;
        }

    }
}

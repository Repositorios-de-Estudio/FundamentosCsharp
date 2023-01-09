using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyetco_final_Agenda_de_contactos.Clases
{


    internal class Contacto : IComparable
    {
        public string Nombre { get; set; } 
        public int Telefono { get; set; }
        public string Correo { get; set; }

        public Contacto(string nombre, int telefono, string correo)
        {
            Nombre = nombre;
            Telefono = telefono;
            Correo = correo;
        }

        public override string ToString()
        {
            return string.Format("Nombre: {0}, Telefono: {1}, Correo:{2}", Nombre, Telefono, Correo);
        }

        public override bool Equals(object obj)
        {           
            if (obj == null) return false;

            Contacto p = obj as Contacto;
            if (p == null) return false;

            return (Nombre == p.Nombre) && (Telefono == p.Telefono) && (Correo== p.Correo);
        }

        public override int GetHashCode()
        {
            int hash = 104297;

            hash = (hash * 103919) + Nombre.GetHashCode();
            hash = (hash * 103919) + Telefono.GetHashCode();
            hash = (hash * 103919) + Correo.GetHashCode();

            return hash;
        }

        // debe ser implementado y ajustado para compara los Nombres 
        // para poder ordenarlos
        public int CompareTo(Object c2)
        {
            Contacto c3 = (Contacto)c2;
            return this.Nombre.CompareTo(c3.Nombre);
        }
    }
}

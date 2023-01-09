using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyetco_final_Agenda_de_contactos.Clases
{

    internal class Agenda
    {
        // la agenda va a contener una lista de maximo 20 contactos
        // se encargara de hacer las operaciones: crear, eliminar ultimo, buscar, ordenar

        private int n = 20; //tamaño de la lista dado por el problema
        private Contacto[] ListaContactos { get; set; }
        private int ListaTamano { get; set; } // tamaño de la cantidad de contactos existen en la lista de contactos
        

        public Agenda()
        {
            ListaContactos = new Contacto[n];
            ListaTamano= 0;
        }
       
        public bool AgregarContacto(string nombre, int telefono, string correo)
        {
            bool rest = false;
            Contacto ccc = new Contacto(nombre, telefono, correo);

            if (Longitud() < 20)
            {
                ListaContactos[ListaTamano] = ccc; //falta hacer validacion de que no exista
                ListaTamano++;
                rest = true;
            }

            return rest;
        }

        public bool OrdenarContactos(string modo)
        {
            bool rest = false;

            if (Longitud() > 1 )
            {
                // asc o desc
                if (modo == "asc")
                {
                    Array.Sort(ListaContactos);

                }
                else
                {
                    Array.Reverse(ListaContactos);
                    Array.Sort(ListaContactos);
                }

                rest = true;

            }

            return rest;

        }

        public Contacto BorrarUltimo()
        {
            Contacto resultado = null;

            if (Longitud() > 0)
            {
                resultado = ListaContactos[Longitud() - 1];
                ListaContactos[Longitud()-1]= null;
                ListaTamano--;
            }

            return resultado;
        }

        public Contacto BuscarPorNombre(Contacto ccc)
        {
       
            Contacto resultado = null;

            if (Longitud() > 0)
            {
                foreach (Contacto item in ListaContactos)
                {
                    if (ccc.Nombre == item.Nombre) { resultado = item; }
                }
            }

            return resultado;
        }

        public int Longitud()
        {
            return ListaTamano;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Capacity = Longitud()+2; // pongo el stringbuilder del mismo tamaño de la cantidad de contactos en la agenda
            result.AppendLine("*** LISTA DE CONTACTOS ***");
            result.AppendLine(string.Format("*** Contactos guardados: {0} ***", Longitud()));

            for (int i = 0; i < Longitud(); i++)
            {
                result.AppendLine(i+1+". "+ ListaContactos[i].ToString()+".");
            }
            
            return result.ToString();
        }
    }
}

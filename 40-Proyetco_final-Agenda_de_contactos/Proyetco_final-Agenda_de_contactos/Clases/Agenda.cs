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

        private int nnn = 20; //tamaño de la lista dado por el problema
        private List<Contacto> ListaContactos { get; set; }
        

        public Agenda()
        {
            ListaContactos = new List<Contacto>();
        }
       
        public bool AgregarContacto(string nombre, int telefono, string correo)
        {
            bool rest = false;
            bool exist = true;
            Contacto ccc = new Contacto(nombre, telefono, correo);

            if (ListaContactos.Count == nnn)
            {
                Console.WriteLine("\n Ha alcanzado el tamaño maximo!");
            }
            else if (ListaContactos.Count < nnn)
            {
                exist = ListaContactos.Exists(x => x.Equals(ccc));

                if (exist)
                {
                    Console.WriteLine("\n Ya existe el contacto!");
                }
                else
                {
                    ListaContactos.Add(ccc);
                    rest = true;
                }

            }

            return rest;
        }

        public bool OrdenarContactos(string modo)
        {
            bool rest = false;

            if (ListaContactos.Count > 1 )
            {
                // asc o desc
                if (modo == "asc")
                {
                    ListaContactos.Sort();

                }
                else
                {
                    ListaContactos.Sort();
                    ListaContactos.Reverse();
                }

                rest = true;

            }

            return rest;

        }

        public Contacto BorrarUltimo()
        {
            Contacto resultado = null;

            if (ListaContactos.Count > 0)
            {
                resultado = ListaContactos[ListaContactos.Count - 1];
                ListaContactos.RemoveAt(ListaContactos.Count-1);
            }
            else
            {
                Console.WriteLine("No existen contactos!");
            }

            return resultado;
        }

        public List<Contacto> BuscarPorNombre(string nombre)
        {

            List<Contacto> resultado = null;

            if (ListaContactos.Count > 0)
            {
                resultado = ListaContactos.FindAll(x => x.Nombre.Contains(nombre));
            }
            else
            {
                Console.WriteLine("No existen contactos con nombre: {0}!", nombre);
            }

            return resultado;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Capacity = ListaContactos.Count+2; // pongo el stringbuilder del mismo tamaño de la cantidad de contactos en la agenda
            result.AppendLine("*** LISTA DE CONTACTOS ***");
            result.AppendLine(string.Format("*** Contactos guardados: {0} ***", ListaContactos.Count));

            for (int i = 0; i < ListaContactos.Count; i++)
            {
                result.AppendLine(i+1+". "+ ListaContactos[i].ToString());
            }
            
            return result.ToString();
        }


    }
}

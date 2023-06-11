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

        private const int _NN = 7; //tamaño de la lista dado por el problema
        private List<Contacto> _ListaContactos { get; set; }
        

        public Agenda()
        {
            _ListaContactos = new List<Contacto>();
        }
       
        public bool AgregarContacto(string nombre, int telefono, string correo)
        {
            bool rest = false;
            bool exist = true;
            Contacto ccc = new Contacto(nombre, telefono, correo);

            if (_ListaContactos.Count >= _NN)
            {
                Console.WriteLine("\nAgenda Llena. Ha alcanzado el tamaño maximo!");
            }
            else
            {
                exist = _ListaContactos.Exists(x => x.Equals(ccc));

                if (exist)
                {
                    Console.WriteLine("\nYa existe el Contacto!");
                }
                else
                {
                    _ListaContactos.Add(ccc);
                    Console.WriteLine("\nSe ha agregado el Contacto!");
                    rest = true;
                }

            }

            return rest;
        }

        public bool OrdenarContactos(string modo)
        {

            bool rest = false;

            if (_ListaContactos.Count > 1 )
            {
                // asc o desc
                if (modo == "asc")
                {
                    _ListaContactos.Sort();

                }
                else
                {
                    _ListaContactos.Sort();
                    _ListaContactos.Reverse();
                }

                rest = true;

            }

            return rest;

        }

        public Contacto BorrarUltimoContacto()
        {
            Contacto resultado = null;

            if (_ListaContactos.Count > 0)
            {
                resultado = _ListaContactos[_ListaContactos.Count - 1];
                _ListaContactos.RemoveAt(_ListaContactos.Count-1);
                Console.WriteLine("\nSe ha eliminado Contacto!: {0}", resultado.Nombre);
            }
            else
            {
                Console.WriteLine("\nNo existen contactos!");
            }

            return resultado;
        }

        public List<Contacto> BuscarContactoPorNombre(string nombre)
        {

            List<Contacto> resultado = null;

            if (_ListaContactos.Count > 0)
            {
                resultado = _ListaContactos.FindAll(x => x.Nombre.Contains(nombre));

                if (resultado.Count == 0){ Console.WriteLine("\nNo existen contactos con nombre: {0}!", nombre); }
            }
            else
            {
                Console.WriteLine("\nNo hay contactos en la Agenda!");
            }

            return resultado;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Capacity = _ListaContactos.Count+2; // pongo el stringbuilder del mismo tamaño de la cantidad de contactos en la agenda
            result.AppendLine("*** LISTA DE CONTACTOS ***");
            result.AppendLine(string.Format("*** Contactos guardados: {0} ***", _ListaContactos.Count));

            for (int i = 0; i < _ListaContactos.Count; i++)
            {
                result.AppendLine(i+1+". "+ _ListaContactos[i].ToString());
            }
            
            return result.ToString();
        }


    }
}

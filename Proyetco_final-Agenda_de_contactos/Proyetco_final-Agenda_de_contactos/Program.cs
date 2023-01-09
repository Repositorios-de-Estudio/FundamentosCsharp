using Proyetco_final_Agenda_de_contactos.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyetco_final_Agenda_de_contactos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * PROYECTO FINAL - AGENDA DE CONTACTOS
             * 
             * App de consola que permita:
             * 1. ver contactos
             *  1.1 orden ascendente por nombre
             *  1.2 orden descendente por nombre
             * 2. agregar contacto
             * 3. borrar ultimo contacto
             * 4. buscar contacto por nombre
             * 5. salir
             * 
             * 
             * Contactos:
             * - nombre
             * - telefono
             * - email
             * 
             * 
             * Consideraciones:
             * - la agenda puede ser una estructura de almacenamiento con tamaño maximo de 20 elementos
             * - será necesario poder comprobar instancias de la clase Contacto (sobreescribir los metodos pertinentes de la clase Object y/o implementar interfaz IComparable
             * - El programa debe tener diseño orientado a objetos (cada clase con un proposito bien definido)
             */


            int op = -1; //opcion del menu
            Menu nuevoMenu = new Menu(); // aca se crean las opciones del menu y su interaccion

            do
            {
                nuevoMenu.MostrarMenu();
                op = int.Parse(Console.ReadLine());
                //nuevoMenu.NavegadorMenu(op);
                //Console.Clear();

            } while (op != 0);



        }
  
    }
}

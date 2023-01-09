using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyetco_final_Agenda_de_contactos.Clases
{
    internal class Menu
    {
        public Menu() 
        {
            // nueva agenda
            Agenda agenda = new Agenda();

            // datos de prueba
            agenda.AgregarContacto("Nombre Prueba1", 1234567, "nombre1@mm.com");
            agenda.AgregarContacto("Nombre Prueba2", 7894561, "nombre2@mm.com");
            agenda.AgregarContacto("Nombre Prueba3", 7418529, "nombre3@mm.com");
            agenda.AgregarContacto("Nombre Prueba4", 9632587, "nombre4@mm.com");
        }

        public void MostrarMenu()
        {
            Console.WriteLine("*** AGENDA DE CONTACTOS 2023 - MSP ***");

            Console.WriteLine("-- Ingrese una opcion: --");
            Console.WriteLine("- 1. Ver Contactos.");
            Console.WriteLine("- 2. Ordenar Contactos (asc).");
            Console.WriteLine("- 3. Ordenar Contactos (des).");
            Console.WriteLine("- 4. Agregar Contacto.");
            Console.WriteLine("- 5. Borrar ultimo contacto.");
            Console.WriteLine("- 6. Buscar Contacto por nombre.");
            Console.WriteLine("- 7. Acerca de..");
            Console.WriteLine("- 0. Salir.");
        }


        public void MenuVerContactos() { }
        public void MenuOrdenarContactos(string modo) { }

        public void MenuAgregarContacto() { }

        public void MenuBorrarUltimoContacto() { }

        public void MenuBuscarContactoNombre() { }

        public void MenuAcercaDe() { }

        public void NingunaOpcion() { }

        public void NavegadorMenu(int opc)
        {
            switch (opc)
            {
                case 1:
                    MenuVerContactos();
                    break;
                case 2:
                    MenuOrdenarContactos("asc");
                    break;
                case 3:
                    MenuOrdenarContactos("desc");
                    break;
                case 4:
                    MenuAgregarContacto();
                    break;
                case 5:
                    MenuBorrarUltimoContacto();
                    break;
                case 6:
                    MenuBuscarContactoNombre();
                    break;
                case 7:
                    MenuAcercaDe();
                    break;
                default:
                    NingunaOpcion();
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Media;
using WMPLib;


namespace Proyetco_final_Agenda_de_contactos.Clases
{
    internal class Menu
    {
        public Agenda agenda { get; set; }
        private WindowsMediaPlayer wply { get; set; }
        public Menu() 
        {
            // nueva agenda
            agenda = new Agenda();

            wply = new WindowsMediaPlayer();
            wply.URL = "D:\\Users\\manue\\Documents\\GitHub\\FundamentosCsharp\\Proyetco_final-Agenda_de_contactos\\Proyetco_final-Agenda_de_contactos\\Media\\Sonidos\\musica-bit-para-videojuego-indie-114696.mp3";
            reproducirSonido(false);

            PoblarAgenda();
        }

        public void MostrarMenu()
        {
            Console.WriteLine("*** AGENDA DE CONTACTOS 2023 - MSP *** \n");

            Console.WriteLine("-- Ingrese una opcion: --");
            Console.WriteLine("- 1. Ver Contactos.");
            Console.WriteLine("- 2. Ordenar Contactos (asc).");
            Console.WriteLine("- 3. Ordenar Contactos (des).");
            Console.WriteLine("- 4. Agregar Contacto.");
            Console.WriteLine("- 5. Borrar ultimo contacto.");
            Console.WriteLine("- 6. Buscar Contacto por nombre.");
            Console.WriteLine("- 7. Acerca de..");
            Console.WriteLine("- 0. Salir.\n");
        }

        public void MenuVerContactos()
        {
            Console.Clear();
            Console.WriteLine(agenda);
            Continuar();
        }
        public void MenuOrdenarContactos(string modo)
        {
            agenda.OrdenarContactos(modo);
            MenuVerContactos();
        }

        public void MenuAgregarContacto()
        {
            string nom = "";
            int tel = -1;
            string cor = "";
            bool result = false;

            Console.Clear();

            Console.WriteLine("-- Agregar Nuevo Contacto --\n");
            Console.WriteLine("-- Nombre: String, Telefono: Int y Correo: String -- \n");

            Console.WriteLine("Ingrese el Nombre: ");
            nom = Console.ReadLine();

            Console.WriteLine("Ingrese el Telefono: ");
            tel = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Correo: ");
            cor = Console.ReadLine();

            result = agenda.AgregarContacto(nom, tel, cor);

            MensajeError(result);

        }

        public void MenuBorrarUltimoContacto()
        {
            Contacto contElim = null;
            bool result = false;
            string opc = "";

            Console.Clear();

            Console.WriteLine("-- Se eliminara el ultimo contacto -- \n");
            Console.WriteLine("¿Esta seguro?: Y / N");
            opc = Console.ReadLine();

            if (opc == "Y" || opc == "y")
            {
                Console.Clear();
                contElim = agenda.BorrarUltimo();
                
            }

            if (contElim != null)
            {
                Console.WriteLine("Fue eliminado el contacto: \n {0}", contElim);  
                result = true;
            }

            MensajeError(result);
        }

        public void MenuBuscarContactoNombre() 
        {
            bool result = false;
            string nombre = "";
            List<Contacto> resultadoL = new List<Contacto>();
            
            Console.Clear();

            Console.WriteLine("-- Busqueda Contacto por Nombre -- \n");
            Console.WriteLine("Ingrese el Nombre para realizar la busqueda: ");
            nombre = Console.ReadLine();

            resultadoL = agenda.BuscarPorNombre(nombre);

            if (resultadoL.Count > 0)
            {
                Console.WriteLine("-- Resultado de la Busqueda --");
                for (int i = 0; i < resultadoL.Count; i++)
                {
                    Console.WriteLine(i + 1 + ". " + resultadoL[i].ToString());
                }
                result = true;
            }

            MensajeError(result);
        }

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
            }
        }

        private void PoblarAgenda()
        {
            // datos de prueba
            agenda.AgregarContacto("Alberto Nuñes", 1234567, "nombre1@mm.com");
            agenda.AgregarContacto("Zulon Tercero", 7894561, "nombre2@mm.com");
            agenda.AgregarContacto("Abel Ariz", 7418529, "nombre3@mm.com");
            agenda.AgregarContacto("Beto Ortiz", 9632587, "nombre4@mm.com");
            agenda.AgregarContacto("Beto Flauta", 9632587, "nombre4@mm.com");
            agenda.AgregarContacto("Diego Beto", 9632587, "nombre4@mm.com");
        }

        public void Continuar()
        {
            Console.WriteLine("<<< Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }

        private void MensajeError(bool result)
        {
            Console.WriteLine();

            if (result)
            {
                Console.WriteLine("Se hizo la operación correctamente!");
            }
            else
            {
                Console.WriteLine("Error: No fue posible realizar la operación!");
            }

            Continuar();
        }

        public void MenuAcercaDe()
        {
            reproducirSonido(true);

            String mensaje =
                "Proyecto: Agenda de Contactos\n" +
                "\n" +
                "Propiedades: Aplicación de Consola - Lenguaje C# - .Net Framework 4.6.1" +
                "\n\n" +
                "Desarrollado por: Sergio Perez (MSP)\n" +
                "Siguiendo el curso en Udemy: Fundamentos de C# para Principiantes\n" +
                "Realizado por Enrique Munguía\n" +
                "Puede encontrar mas proyectos realizado por mi en:\n" +
                "Github: sergioPerez-e" +
                "\n" +
                "Sonido de fondo: Música bit para videojuego indie\n" +
                "Por: FreeGiver - pixabay.com" +
                "\n\n" +
                "Bogota, D.C / Colombia 2023\n\n";

            Console.Clear();
            Console.WriteLine("-- Acerca de --\n");

            EscribirLento(mensaje);

            reproducirSonido(false);
            Continuar();

        }

        private void reproducirSonido(bool reproducir)
        {
            
            if (reproducir)
            {
                wply.controls.play();
            }
            else
            {
                wply.controls.stop();
            }


        }
        private void EscribirLento(string texto)
        {
            int velocidad = 190;

            foreach (var item in texto)
            {
                Console.Write(item);
                Thread.Sleep(velocidad);
            }
        }


    }
}

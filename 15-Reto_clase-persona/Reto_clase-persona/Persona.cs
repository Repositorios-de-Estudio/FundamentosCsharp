using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Reto_clase_persona
{

    /*
     * CREAR UNA CLASE PERSONA
     * NOMBRE
     * APELLIDO
     * EDAD (VALIDAD > 0)
     * 
     * CONSTRUCTORES PARA INICIARLIZAR LAS 3 PROPIEDADES
     * 
     * METODOS
     * SALUDAR: IMPRIME NOMBRE Y APELLIDO
     * TOSTRING: IMPRIME TODAS SUS PROPIEDADES
     * 
     * CREAR DOS OBJETOS PERSONA Y LLAMAR A SALUDAR
     */

    internal class Persona
    {
        private int _edad = 0;
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get { return _edad; } set { _edad = value < 0 ? 0 : value; } }

        public Persona(string nombre)
        {
            Nombre = nombre;
        }

        public Persona(string nombre, string apellido): this(nombre)
        {
            Apellido = apellido;
        }



        public Persona(string nombre, string apellido, int edad) : this(nombre, apellido)
        {           
            Edad = edad;
        }

        public string Saludar()
        {
            return string.Format("Saludos de {0} {1}!!!", Nombre, Apellido);
        }

        public override string ToString()
        {
            return string.Format("Nombre completo: {0} {1}, Edad: {2}", Nombre, Apellido, Edad.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2POO
{
    class Persona
    {
        public Persona()
        {
        }
        //CONSTRUCTOR CON PARAMETRO
        public Persona(string nombre, string apellido, string ci, string direccion, Fecha fechaNacimiento)
        {
            Nombre = nombre;
            Apellido = apellido;
            CI = ci;
            Direccion = direccion;
            FechaNacimiento = fechaNacimiento;
        }
        ////CONSTRUCTOR COPIA 
        //public Persona(Persona persona)
        //{
            
        //}
        //PROPIEDADES
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CI { get; set; }
        public string Direccion { get; set; }

        public Fecha FechaNacimiento;

        //METODOS
        public override string ToString()
        {
            return string.Format("Nombre Completo: {0} {1} - CI: {2} - Dirección: {3} - Fecha de Nacimiento: {4}", Nombre, Apellido, CI, Direccion, FechaNacimiento);
        }

    }
}

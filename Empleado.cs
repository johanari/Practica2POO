using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2POO
{
    class Empleado
    {

        //CONSTRUCTOR POR DEFECTO
        public Empleado()
        {
        }
        //CONSTRUCTOR CON PARAMETRO
        public Empleado(string nombre, string apellido, string ci)
        {
            Nombre = nombre;
            Apellido = apellido;
            CI = ci;
            Sueldo = 2500;
        }
        //CONSTRUCTOR COPIA 
        public Empleado(Empleado empleado)
        {
            Nombre = empleado.Nombre;
            Apellido = empleado.Apellido;
            CI = empleado.CI;
            Sueldo = 2500;
        }
        //PROPIEDADES
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CI { get; set; }
        public static int Sueldo;   //atributo estatico


        public override string ToString()
        {
            return string.Format("Nombre Completo del empleado: {0} {1} CI: {2}",Nombre, Apellido, CI);
        }
    }
}

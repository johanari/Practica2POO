using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////1.-
            ///
            Console.WriteLine("Ingresar Numero de Cuenta: ");
            string numCuenta = Console.ReadLine();
            Console.WriteLine("Ingresar el Nombre del Cliente: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingresar Apellido del Cliente: ");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingresar CI: ");
            string ci = Console.ReadLine();
            Console.WriteLine("Ingresar Saldo: ");
            int saldo = Convert.ToInt32(Console.ReadLine());

            Cuenta cuenta1 = new Cuenta(numCuenta, nombre, apellido, ci, saldo);
            Cuenta cuenta2 = new Cuenta();
            Cuenta cuenta3 = new Cuenta(cuenta1);
            int menu = 0;
            do
            {
                Console.WriteLine("MENU DE OPCIONES");
                Console.WriteLine("1.- Mostrar Cuentas");
                Console.WriteLine("2.- Ingresar Saldo");
                Console.WriteLine("3.- Reintegrar Saldo");
                Console.WriteLine("4.- Transferir Saldo");
                Console.WriteLine("5.- Salir");
                Console.Write("Elegir una opcion: ");
                int opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Cuenta1: {0}, Nombre Completo: {1} {2}, CI: {3}, con Saldo: {4} Bs.", cuenta1.NumCuenta, cuenta1.NombreCliente, cuenta1.ApellidoCliente, cuenta1.CI, cuenta1.SaldoBancario);
                        Console.WriteLine(cuenta2.MostrarCuentas());
                        Console.WriteLine("Cuenta3: {0}, Nombre Completo: {1} {2}, CI: {3}, con Saldo: {4} Bs.", cuenta3.NumCuenta, cuenta3.NombreCliente, cuenta3.ApellidoCliente, cuenta3.CI, cuenta3.SaldoBancario);
                        menu = 1;
                        break;
                    case 2:
                        Console.WriteLine("Ingresar el saldo que desea ingresar a la cuenta: {0}", cuenta1.NumCuenta);
                        int ingresarSaldo = Convert.ToInt32(Console.ReadLine());
                        cuenta1.Ingreso(ingresarSaldo);
                        menu = 2;
                        break;
                    case 3:
                        Console.WriteLine("Ingresar el saldo que desea re integrar a la cuenta: {0}", cuenta1.NumCuenta);
                        int reIntegrarSaldo = Convert.ToInt32(Console.ReadLine());
                        cuenta1.ReIntegro(reIntegrarSaldo);
                        menu = 3;
                        break;
                    case 4:
                        Console.WriteLine("Ingresar el saldo que desea transferir a otra cuenta: ");
                        int transferirSaldo = Convert.ToInt32(Console.ReadLine());
                        cuenta1.Transferencia(cuenta2, transferirSaldo);
                        menu = 4;
                        break;
                    case 5:
                        menu = 0;
                        break;
                }
            } while (menu != 0);




            //////////2.-
            ///
            //Console.Write("Ingresar limite del contador: ");
            //int count = Convert.ToInt32(Console.ReadLine());
            //Contador contador = new Contador(count);

            //int menu = 0;
            //do
            //{
            //    Console.WriteLine("MENU DE OPCIONES");
            //    Console.WriteLine("1.- Incrementar Contador");
            //    Console.WriteLine("2.- Decrementar Contador");
            //    Console.WriteLine("3.- Salir");
            //    Console.Write("Elegir una opcion: ");
            //    int opcion = Convert.ToInt32(Console.ReadLine());

            //    switch (opcion)
            //    {
            //        case 1:
            //            contador.IncrementarContador();
            //            menu = 1;
            //            break;
            //        case 2:
            //            contador.DecrementarContador();
            //            menu = 2;
            //            break;
            //        case 3:
            //            menu = 0;
            //            break;
            //    }
            //} while (menu != 0);





            //////////3.-
            ///
            //Console.WriteLine("Ingresar Nombre del libro: ");
            //string nomLibro= Console.ReadLine();
            //Console.WriteLine("Ingresar Editorial: ");
            //string editorial = Console.ReadLine();
            //Console.WriteLine("Ingresar Genero: ");
            //string genero = Console.ReadLine();
            //Console.WriteLine("Ingresar Autor: ");
            //string autor = Console.ReadLine();
            //Console.WriteLine("Ingresar Edicion: ");          
            //int edicion = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Ingresar Stock: ");
            //int stock = Convert.ToInt32(Console.ReadLine());

            //Libro libro1 = new Libro(nomLibro, editorial, genero, autor, edicion, stock, 0);
            //Libro libro2 = new Libro();
            //Libro libro3 = new Libro(libro1);
            //int menu = 0;
            //do
            //{
            //    Console.WriteLine("MENU DE OPCIONES");
            //    Console.WriteLine("1.- Prestar Libros");
            //    Console.WriteLine("2.- Devolver Libros");
            //    Console.WriteLine("3.- Mostrar Libros");
            //    Console.WriteLine("5.- Salir");
            //    Console.Write("Elegir una opcion: ");
            //    int opcion = Convert.ToInt32(Console.ReadLine());
            //    switch (opcion)
            //    {
            //        case 1:
            //            if (libro1.Prestamo())
            //            {
            //                Console.WriteLine("Se ha prestado el libro: " + libro1.NombreLibro);
            //            }
            //            else
            //            {
            //               Console.WriteLine("No quedan libros de: {0} en el stock ", libro1.NombreLibro + " para prestar");
            //            }
            //            menu = 1;
            //            break;
            //        case 2:
            //            if (libro1.Devolucion())
            //            {
            //               Console.WriteLine("Se ha devuelto el libro: " + libro1.NombreLibro);
            //            }
            //            else
            //            {
            //                Console.WriteLine("No hay libros de: " + libro1.NombreLibro + " prestados");
            //            }
            //            menu = 2;
            //            break;
            //        case 3:
            //            Console.WriteLine(libro1.ToString());
            //            Console.WriteLine("\n" + libro2.ToString());
            //            menu = 3;
            //            break;
            //        case 4:
            //            //Console.WriteLine("Ingresar el saldo que desea transferir a otra cuenta: ");
            //            //int transferirSaldo = Convert.ToInt32(Console.ReadLine());
            //            //cuenta1.Transferencia(cuenta2, transferirSaldo);
            //            menu = 4;
            //            break;
            //        case 5:
            //            menu = 0;
            //            break;
            //    }
            //} while (menu != 0);







            ///////4.-
            ///
            //Console.Write("Ingresar el Numerador 1: ");
            //decimal numerador1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ingresar el Denominador 1: ");
            //decimal denominador1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ingresar el Numerador 2: ");
            //decimal numerador2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ingresar el Denominador 2: ");
            //decimal denominador2 = Convert.ToInt32(Console.ReadLine());

            //Fraccion fraccion = new Fraccion(numerador1, denominador1, numerador2, denominador2);

            //int menu = 0;
            //do
            //{
            //    Console.WriteLine("MENU DE OPCIONES");
            //    Console.WriteLine("1.- Sumar Fracciones");
            //    Console.WriteLine("2.- Restar Fracciones");
            //    Console.WriteLine("3.- Multiplicar Fracciones");
            //    Console.WriteLine("4.- Dividir Fracciones");
            //    Console.WriteLine("5.- Salir");
            //    Console.Write("Elegir una opcion: ");
            //    int opcion = Convert.ToInt32(Console.ReadLine());

            //    switch (opcion)
            //    {
            //        case 1:
            //            fraccion.Sumar();
            //            menu = 1;
            //            break;
            //        case 2:
            //            fraccion.Restar();
            //            menu = 2;
            //            break;
            //        case 3:
            //            fraccion.Multiplicar();
            //            menu = 3;
            //            break;
            //        case 4:
            //            fraccion.Dividir();
            //            menu = 4;
            //            break;
            //        case 5:
            //            menu = 0;
            //            break;
            //    }
            //} while (menu != 0);







            /////////5.-
            ///
            //Console.Write("Ingresar el primer numero Real: ");
            //double real1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ingresar el primer numero Imaginario: ");
            //double imaginario1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ingresar el segundo numero Real: ");
            //double real2 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ingresar el segundo numero Imaginario: ");
            //double imaginario2 = Convert.ToInt32(Console.ReadLine());

            //Complejo complejo1 = new Complejo(real1, imaginario1, real2, imaginario2);

            //int menu = 0;
            //do
            //{
            //    Console.WriteLine("MENU DE OPCIONES");
            //    Console.WriteLine("1.- Sumar Numero Complejos");
            //    Console.WriteLine("2.- Restar Numeros Complejos");
            //    Console.WriteLine("3.- Multiplicar Numeros Complejos");
            //    Console.WriteLine("4.- Dividir Numeros Complejos");
            //    Console.WriteLine("5.- Salir");
            //    Console.Write("Elegir una opcion: ");
            //    int opcion = Convert.ToInt32(Console.ReadLine());

            //    switch (opcion)
            //    {
            //        case 1:
            //            complejo1.Sumar();
            //            menu = 1;
            //            break;
            //        case 2:
            //            complejo1.Restar();
            //            menu = 2;
            //            break;
            //        case 3:
            //            complejo1.Multiplicar();
            //            menu = 3;
            //            break;
            //        case 4:
            //            complejo1.Dividir();
            //            menu = 4;
            //            break;
            //        case 5:
            //            menu = 0;
            //            break;
            //    }
            //} while (menu != 0);



            /////////6.-
            ///
            //Console.Write("Ingresar dia: ");
            //int dia = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ingresar mes: ");
            //int mes = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ingresar año: ");
            //int anio = Convert.ToInt32(Console.ReadLine());

            //Fecha fecha1 = new Fecha(dia, mes, anio);

            //if (fecha1.FechaCorrecta())
            //{
            //    Console.WriteLine("FORMATO FECHA: DD/MM/YYYY");
            //    Console.WriteLine("La fecha es: {0}", fecha1.ToString());
            //    fecha1.diaSiguiente();
            //    Console.WriteLine("\nEl dia siguiente es: {0}", fecha1);
            //}
            //else
            //{
            //    Console.WriteLine("Fecha Incorrecta");
            //}






            //////////7.-
            ///
            //Console.WriteLine("Ingresar el Nombre del Empleado:");
            //string nombre = Console.ReadLine();
            //Console.WriteLine("Ingresar el Apellido del Empleado:");
            //string apellido = Console.ReadLine();
            //Console.WriteLine("Ingresar el CI del Empleado:");
            //string ci = Console.ReadLine();

            //Empleado empleado1 = new Empleado(nombre,apellido,ci);

            //Console.WriteLine(empleado1.ToString() + " Sueldo: " + Empleado.Sueldo + "Bs.");





            /////////////8
            ///
            //Console.WriteLine("Ingresar CI: ");
            //int ci = Convert.ToInt32(Console.ReadLine());
            //NIF nif1 = new NIF(ci);
            //nif1.ToString();
            //Console.WriteLine(nif1);






            ////////Ejercicios Relación de Composición entre clases
            /////////1.-
            ///
            //Console.WriteLine("Ingresar el Nombre:");
            //string nombre = Console.ReadLine();
            //Console.WriteLine("Ingresar el Apellido:");
            //string apellido = Console.ReadLine();
            //Console.WriteLine("Ingresar el CI:");
            //string ci = Console.ReadLine();
            //Console.WriteLine("Ingresar la Dirección:");
            //string direccion = Console.ReadLine();
            //Console.WriteLine("Ingresar Fecha de Nacimiento");
            //Console.Write("Dia: ");
            //int dia = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Mes: ");
            //int mes = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Año: ");
            //int anio = Convert.ToInt32(Console.ReadLine());
            //Fecha fechaNacimiento = new Fecha(dia, mes, anio);
            //Persona persona1 = new Persona(nombre, apellido, ci, direccion, fechaNacimiento);
            //if(fechaNacimiento.FechaCorrecta())
            //{
            //    Console.WriteLine(persona1.ToString());
            //}
            //else
            //{
            //    Console.WriteLine("DATOS INCORRECTOS");
            //}




        }
    }
}

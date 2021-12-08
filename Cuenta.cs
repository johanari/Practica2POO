using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2POO
{
    class Cuenta
    {
        //CONSTRUCTOR POR DEFECTO
        public Cuenta()
        {
            NumCuenta = "SLCBB01-003033299";
            NombreCliente = "Sara";
            ApellidoCliente = "Lopez";
            CI = "4433323 cbba";
            SaldoBancario = 2000;
        }
        //CONSTRUCTOR CON PARÁMETROS
        public Cuenta(string numCuenta, string nombre, string apellido, string ci, int saldo)
        {
            NumCuenta = numCuenta;
            NombreCliente = nombre;
            ApellidoCliente = apellido;
            CI = ci;
            SaldoBancario = saldo;
        }
        //CONSTRUCTOR COPIA 
        public Cuenta(Cuenta cuenta) 
        {
            NumCuenta = cuenta.NumCuenta;
            NombreCliente = cuenta.NombreCliente;
            ApellidoCliente = cuenta.ApellidoCliente;
            CI = cuenta.CI;
            SaldoBancario = cuenta.SaldoBancario;
        }
        //PROPIEDADES
        public string NumCuenta{ get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string CI { get; set; }
        public int SaldoBancario { get; set; }

        //FUNCIONES O METODOS
        public string MostrarCuentas()
        {
            return string.Format("Cuenta2: {0}, Nombre Completo: {1} {2}, CI: {3}, Saldo: {4}", NumCuenta, NombreCliente, ApellidoCliente, CI, SaldoBancario);
        }
        public void Ingreso(int saldoIngresado)
        {
            SaldoBancario = saldoIngresado + SaldoBancario;
            Console.WriteLine("Se ingresó: {0} Bs. a la cuenta: {1}", saldoIngresado,  NumCuenta);
            Console.WriteLine("Saldo Actual: {0} Bs.", SaldoBancario);
        }
        public void ReIntegro(int saldoReIntegrado)
        {
            SaldoBancario = saldoReIntegrado + SaldoBancario;
            Console.WriteLine("Se reintegró: {0} Bs. a la cuenta: {1}", saldoReIntegrado, NumCuenta);
            Console.WriteLine("Saldo Actual: {0} Bs.", SaldoBancario);
        }
        public void Transferencia(Cuenta cuenta2, int saldoTransferido)
        {
            SaldoBancario = SaldoBancario - saldoTransferido;
            Console.WriteLine("Se Tranfirió: {0} Bs. a la cuenta: {1} de la cuenta {2}", saldoTransferido, cuenta2.NumCuenta, NumCuenta);
            cuenta2.SaldoBancario = saldoTransferido + cuenta2.SaldoBancario;
            Console.WriteLine("Saldo Actual: {0} Bs.", SaldoBancario);
        }

    }
}

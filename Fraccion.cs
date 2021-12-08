using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2POO
{
    class Fraccion
    {
        //CONSTRUCTOR
        public Fraccion(decimal numerador1, decimal denominador1, decimal numerador2, decimal denominador2)
        {
            Numerador1 = numerador1;
            Denominador1 = denominador1;
            Numerador2 = numerador2;
            Denominador2 = denominador2;
        }

        //PROPIEDADES
        public decimal Numerador1 { get; set; }
        public decimal Numerador2 { get; set; }
        public decimal Denominador1 { get; set; }
        public decimal Denominador2 { get; set; }

        //METODOS
        static decimal mcd(decimal numerador, decimal denominador)
        {
            if(numerador < denominador)
            {
                return mcd(denominador, numerador);
            }
            else if (denominador == 0)
            {
                return numerador;
            }
            else
            {
                return mcd(denominador, (numerador % denominador));
            }
        }
        public void Sumar()
        {
            if (Denominador1 != 0 && Denominador2 != 0)
            {
                decimal numeradorR, denominadorR;
                numeradorR = (Numerador1 * Denominador2) + (Denominador1 * Numerador2);
                denominadorR = (Denominador1 * Denominador2);
                decimal suma = 0;

                suma = mcd(numeradorR, denominadorR);
                Console.WriteLine("La suma de fracciones: {0}/{1} + {2}/{3} es: {4}/{5}",
                    Numerador1, Denominador1, Numerador2, Denominador2, (numeradorR / suma), (denominadorR / suma));
            }
            else
            {
                Console.WriteLine("NO SE PUEDE DIVIDIR ENTRE 0");
            }
        }
        public void Restar()
        {
            if (Denominador1 != 0 && Denominador2 != 0)
            {
                decimal numeradorR, denominadorR;
                numeradorR = (Numerador1 * Denominador2) - (Denominador1 * Numerador2);
                denominadorR = (Denominador1 * Denominador2);
                decimal resta = 0;

                resta = mcd(numeradorR, denominadorR);
                Console.WriteLine("La resta de fracciones: {0}/{1} - {2}/{3} es: {4}/{5}",
                    Numerador1, Denominador1, Numerador2, Denominador2, (numeradorR / resta), (denominadorR / resta));
            }
            else
            {
                Console.WriteLine("NO SE PUEDE DIVIDIR ENTRE 0");
            }
        }
        public void Multiplicar()
        {
            if (Denominador1 != 0 && Denominador2 != 0)
            {
                decimal numeradorR, denominadorR;
                numeradorR = (Numerador1  * Numerador2);
                denominadorR = (Denominador1 * Denominador2);
                decimal multiplicacion = 0;

                multiplicacion = mcd(numeradorR, denominadorR);
                Console.WriteLine("La multiplicacion de fracciones: {0}/{1} * {2}/{3} es: {4}/{5}",
                    Numerador1, Denominador1, Numerador2, Denominador2, (numeradorR / multiplicacion), (denominadorR / multiplicacion));
            }
            else
            {
                Console.WriteLine("NO SE PUEDE DIVIDIR ENTRE 0");
            }
        }
        public void Dividir()
        {
            if (Denominador1 != 0 && Denominador2 != 0)
            {
                decimal numeradorR, denominadorR;
                numeradorR = (Numerador1 * Denominador2);
                denominadorR = (Denominador1 * Numerador2);
                decimal dividir = 0;

                dividir = mcd(numeradorR, denominadorR);
                Console.WriteLine("La division de fracciones: {0}/{1} / {2}/{3} es: {4}/{5}",
                    Numerador1, Denominador1, Numerador2, Denominador2, (numeradorR / dividir), (denominadorR / dividir));
            }
            else
            {
                Console.WriteLine("NO SE PUEDE DIVIDIR ENTRE 0");
            }
        }
        //public override string ToString()
        //{
        //    return string.Format("Fracciones: {0}/{1} {2}/{3}", Numerador1, Denominador1, Numerador2, Denominador2);
        //}

    }
}

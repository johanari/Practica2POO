using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2POO
{
    class Complejo
    {
        //CONSTRUCTOR
        public Complejo(double real1, double imaginario1, double real2, double imaginario2)
        {
            Real1 = real1;
            Imaginario1 = imaginario1;
            Real2 = real2;
            Imaginario2 = imaginario2;
        }

        //PROPIEDADES
        public double Real1 { get; set; }
        public double Imaginario1 { get; set; }
        public double Real2 { get; set; }
        public double Imaginario2 { get; set; }

        public void Sumar()
        {
              double rreal = ((Real1) + (Real2));
              double rimaginario = ((Imaginario1) + (Imaginario2));
              Console.WriteLine("La suma de: {0} + {1}i + {2} + {3}i = ({4}+{5}) + ({6}+{7})i El resultado es: {8} + {9}i", 
                  Real1, Imaginario1, Real2, Imaginario2, Real1, Real2, Imaginario1, Imaginario2, rreal, rimaginario);
        }
        public void Restar()
        {
            double rreal = ((Real1) - (Real2));
            double rimaginario = ((Imaginario1) - (Imaginario2));
            Console.WriteLine("La resta de: {0} + {1}i - {2} + {3}i = ({4}-{5}) + ({6}-{7})i El resultado es: {8} + {9}i",
                Real1, Imaginario1, Real2, Imaginario2, Real1, Real2, Imaginario1, Imaginario2, rreal, rimaginario);
        }
        public void Multiplicar()
        {
            double rreal1 = ((Real1) * (Real2));
            double rimag1 = (((Imaginario1) * (Imaginario2)));
            double rreal2 = (((Real1) * (Imaginario2)));
            double rimag2 = ((Imaginario1) * (Real2));

            double resulr = ((rreal1) + (-(rimag1)));
            double resuli = ((rreal2) + (rimag2));


            double rreal = ((Real1) + (Real2));
            double rimaginario = ((Imaginario1) + (Imaginario2));
            Console.WriteLine("La multiplicacion de numeros complejos: ({0} + {1}i) * ({2} + {3}i) = " +
                "\nSimplificando: {4}*{5} + {6}*{7}i + {8}*{9}i + {10}*{11}i^2 = " +
                "{12}+{13}i+{14}i-{15}\nEl resultado es: {16} + {17}i",
                Real1, Imaginario1, Real2, Imaginario2, Real1, Real2, Real1, Imaginario2, Imaginario1, Real2, Imaginario1, Imaginario2,
                rreal1, rreal2, rimag2, rimag1, resulr, resuli);
        }
        public void Dividir()
        {


            double numeradorReal = ((Real1 * Real2) + (Imaginario1 * Imaginario2));
            double numeradorImaginario = ((Imaginario1 * Real2) - (Real1 * Imaginario2));
            double denominador = ((Real2) * (Real2)) + ((Imaginario2) * (Imaginario2));



            double resulreal = (numeradorReal) / (denominador);
            double resulimag = (numeradorImaginario) / (denominador);

            //double resulreal = ((Real1 * Real2) + (Imaginario1 * Imaginario2)) / (denominador);
            //double resulimag = ((Imaginario1*Real2) - (Real1 * Imaginario2)) / (denominador);

            Console.WriteLine("La division de numeros complejos de:\n {0}+{1}i\n------ =\n {2}+{3}i\nSimplificando: \n" +
                " {4}+{5}i\n-------- =\n  {6}\n El resultado es: {7} + {8}i",
                Real1, Imaginario1, Real2,Imaginario2, numeradorReal, numeradorImaginario,
                denominador, Math.Round(resulreal, 3), Math.Round(resulimag,3));
        }

    }
}

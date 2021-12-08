using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2POO
{
    class NIF
    {
        //CONSTRUCTOR POR DEFECTO
        public NIF()
        {
        }
        //CONSTRUCTOR CON PARAMETRO
        public NIF(int ci)
        {
            CI = ci;
            Letra = CalcularLetra();
        }
        //CONSTRUCTOR COPIA 
        public NIF(NIF nif)
        {
            CI = nif.CI;
            Letra = CalcularLetra();
        }
        //PROPIEDADES
        public int CI { get; set; }
        public char Letra { get; set; }

        //METODOS
        //Metodo para calcular la letra para el NIF
        public char CalcularLetra()
        {
            //PARA CALCULAR LETRA SE TOMA EN CUENTA LO SIGUIENTE: 
            //0 - A     1 - B    2 - C     3 - D     4 - E     5 – F
            //6 – G     7 – H    8 – I     9 - J    10 – K    11 – L
            //12 – M    13 – N   14 – O    15 – P    16 - Q    17 - R
            //18 - S    19 - T   20 – U    21 – V    22 – W    23 - X
            //24 - Y    25 - Z
            char[] letras = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
            return letras[CI % letras.Length];
        }

        public override string ToString()
        {

            return string.Format("El NIF es: {0} - {1}", CI, Letra);
        }


    }
}

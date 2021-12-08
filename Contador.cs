using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2POO
{
    class Contador
    {
        //CONSTRUCTOR POR DEFECTO
        public Contador()
        {
            Count = 30;
        }
        //CONSTRUCTOR CON PARAMETRO
        public Contador(int cont)
        {
           Count = cont;
        }
        //CONSTRUCTOR COPIA 
        public Contador(Contador contador)
        {
            Count = contador.Count;
        }
        //PROPIEDADES
        public int Count { get; set; }


        public void IncrementarContador()
        {
            for(int i = 1; i <= Count; i++)
            {
                Console.WriteLine(i);
            }
            
        }
        public void DecrementarContador()
        {
            for (int i = Count; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

        }
    }
}

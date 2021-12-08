using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2POO
{
    class Fecha
    {
        ////CONSTRUCTOR POR DEFECTO
        //public Fecha()
        //{
        //}
        //CONSTRUCTOR CON PARAMETRO
        public Fecha(int dia, int mes, int anio)
        {
            Dia = dia;
            Mes = mes;
            Anio = anio;
        }
        //CONSTRUCTOR COPIA 
        public Fecha(Fecha fecha)
        {
            Dia = fecha.Dia;
            Mes = fecha.Mes;
            Anio = fecha.Anio;
        }
        //PROPIEDADES
        public int Dia { get; set; }
        public int Mes  { get; set; }
        public int Anio { get; set; }

        public bool FechaCorrecta()
        {
            bool diaCorrecto = false;
            bool mesCorrecto = false; 
            bool anioCorrecto = false;
            if(Anio > 0)
            {
                if (Mes >= 1 && Mes <= 12)
                {
                    if(Mes == 2)
                    {
                        if (esBisiesto())
                        {
                            if (Dia >= 1 && Dia <= 29)
                            {
                                diaCorrecto = true;
                                Console.WriteLine("La fecha es año bisiesto", Dia, Mes, Anio);
                            }
                            else
                            {
                                diaCorrecto = false;
                                Console.WriteLine("El mes de febrero en año bisiesto cuenta con 29 días");
                            }
                        }
                        else if (Dia >= 1 && Dia <= 28)
                        {
                            diaCorrecto = true;
                        }
                        else
                        {
                            diaCorrecto = false;
                            Console.WriteLine("El mes de febrero cuenta con 28 días");
                        }
                    }
                    else if (Mes == 1 || Mes == 3 || Mes == 5 || Mes == 7 || Mes == 8 || Mes == 10 || Mes == 12)
                    {
                        if (Dia >= 1 && Dia <= 31)
                        {
                            diaCorrecto = true;
                        }
                        else
                        {
                            diaCorrecto = false;
                            Console.WriteLine("Enero, Marzo, Mayo, Julio, Agosto, Octubre y Diciembre cuentan con 31 días");
                        }
                    }
                    else
                    {
                        if (Dia >= 1 && Dia <= 30)
                        {
                            diaCorrecto = true;
                        }
                        else
                        {
                            diaCorrecto = false;
                            Console.WriteLine("Abril, Junio, Septiembre y Noviembre cuentan con 30 días");
                        }
                    }
                    mesCorrecto = true;
                }
                anioCorrecto = true;
            }
            return diaCorrecto && mesCorrecto && anioCorrecto;
        }
        public override string ToString()
        {
            if(Dia < 10)
            {
                if(Mes < 10)
                {
                    return string.Format("0{0}/0{1}/{2}", Dia, Mes, Anio);
                }
                return string.Format("0{0}/{1}/{2}", Dia, Mes, Anio);
            }
            else
            {
                if (Mes < 10)
                {
                    return string.Format("{0}/0{1}/{2}", Dia, Mes, Anio);
                }
                return string.Format("{0}/{1}/{2}", Dia, Mes, Anio);
            }
        }
        public int diaSiguiente()
        {
            return Dia++;
        }
        private bool esBisiesto()
        {
            return (Anio % 4 == 0 && Anio % 100 != 0 || Anio % 400 == 0);
        }
    }
}

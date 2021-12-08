using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2POO
{
    class Libro
    {

        //CONSTRUCTOR POR DEFECTO
        public Libro()
        {
            NombreLibro = "Crónica de una muerte anunciada";
            Editorial = "La Oveja Negra";
            Genero = "Novela";
            Autor = "Gabriel Garcia Marquez";
            Edicion = 1;
            Stock = 85;
            Prestados = 15;
        }
        //CONSTRUCTOR CON PARAMETRO
        public Libro(string libro, string editorial, string genero, string autor, int edicion, int stock, int prestados)
        {
            NombreLibro = libro;
            Editorial = editorial;
            Genero = genero;
            Autor = autor;
            Edicion = edicion;
            Stock = stock;
            Prestados = prestados;
        }
        //CONSTRUCTOR COPIA 
        public Libro(Libro libro)
        {
            NombreLibro = libro.NombreLibro;
            Editorial = libro.Editorial;
            Genero = libro.Genero;
            Autor = libro.Autor;
            Edicion = libro.Edicion;
            Stock = libro.Stock;
            Prestados = libro.Prestados;
        }
        //PROPIEDADES
        public string NombreLibro { get; set; }
        public string Editorial { get; set; }
        public string Genero { get; set; }
        public string Autor { get; set; }
        public int Edicion { get; set; }
        public int Stock { get; set; }
        public int Prestados { get; set; }

        public bool Prestamo()
        {
            bool prestado = false;
            if (Stock > 0)
            {
                Prestados++;
                Stock--;
                prestado = true;
            }
            else
            {
                prestado = false;
            }
            return prestado;
        }
        public bool Devolucion()
        {
            bool devuelto = false;
            if (Prestados == 0)
            {
                devuelto = false;
            }
            else
            {
                Prestados--;
                Stock++;
                devuelto = true;
            }
            return devuelto;
        }
        public override string ToString()
        {
            
            return string.Format("Libro: {0}\nEditorial: {1}\nGenero: {2}\nAutor {3}\nNumero de Edición: {4}\nStock: {5}\nPrestados: {6}", NombreLibro, Editorial, Genero, Autor, Edicion, Stock, Prestados);
        }
    }
}

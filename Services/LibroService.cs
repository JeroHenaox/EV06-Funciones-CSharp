
using System;
using System.Collections.Generic;
using System.Linq;
using EV06_Funciones_CSharp.Models;

namespace EV06_Funciones_CSharp.Services
{
    public class LibroService
    {
        private List<Libro> libros = new List<Libro>();

        // Agregar un libro
        public void AgregarLibro(Libro libro)
        {
            libros.Add(libro);
        }

        // Eliminar un libro por su ID
        public bool EliminarLibro(int id)
        {
            Libro? libro = libros.FirstOrDefault(l => l.Id == id);

            if (libro == null)
            {
                return false;
            }

            return libros.Remove(libro);
        }

        // Obtener todos los libros
        public List<Libro> ObtenerTodos()
        {
            return new List<Libro>(libros);
        }

        // Buscar un libro por ISBN
        public Libro? BuscarPorISBN(string isbn)
        {
            return libros.FirstOrDefault(l =>
                l.ISBN.Equals(isbn, StringComparison.OrdinalIgnoreCase));
        }

        // Buscar libros por título
        public List<Libro> BuscarPorTitulo(string titulo)
        {
            return libros.Where(l =>
                l.Titulo.Contains(titulo, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        // Buscar libros por autor
        public List<Libro> BuscarPorAutor(string autor)
        {
            return libros.Where(l =>
                l.Autor.Contains(autor, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        // Ordenar libros alfabéticamente por título
        public List<Libro> OrdenarPorTitulo()
        {
            return libros.OrderBy(l => l.Titulo).ToList();
        }

        // KPI: total de libros
        public int TotalLibros()
        {
            return libros.Count;
        }

        // KPI: libros disponibles
        public int TotalDisponibles()
        {
            return libros.Count(l => l.Disponible);
        }

        // KPI: libros prestados
        public int TotalPrestados()
        {
            return libros.Count(l => !l.Disponible);
        }
    }
}

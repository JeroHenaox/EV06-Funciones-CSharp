namespace EV06_Funciones_CSharp.Models
{
    public class Libro
    {
        // Propiedades
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;
        public bool Disponible { get; set; } = true;

        // Constructor vacío
        public Libro()
        {
        }

        // Constructor completo
        public Libro(int id, string titulo, string autor, string isbn)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            ISBN = isbn;
            Disponible = true;
        }

        // Muestra un resumen corto del libro
        public string ResumenCorto()
        {
            return $"{Titulo} - {Autor}";
        }

        // Muestra toda la información del libro
        public string DetalleCompleto()
        {
            return $"ID: {Id}\n" +
                   $"Título: {Titulo}\n" +
                   $"Autor: {Autor}\n" +
                   $"ISBN: {ISBN}\n" +
                   $"Disponible: {Disponible}";
        }

        // Representación del libro como texto
        public override string ToString()
        {
            return ResumenCorto();
        }
    }
}
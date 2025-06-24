namespace views;

using models;

public static class LibroView
{
    public static void MostrarLibros(List<Libro> libros)
    {
        if (libros.Count == 0)
        {
            Console.WriteLine("No hay libros disponibles.");
            return;
        }
        Console.WriteLine("Lista de Libros:");
        foreach (var libro in libros)
        {
            MostrarLibro(libro);
        }
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
    }
    private static void MostrarLibro(Libro libro)
    {
        if (libro == null)
        {
            Console.WriteLine("El libro no existe.");
            return;
        }
        Console.WriteLine($"Título: {libro.Titulo}");
        Console.WriteLine($"Autor: {libro.Autor}");
        Console.WriteLine($"ISBN: {libro.ISBN}");
        Console.WriteLine($"Disponible: {(libro.Disponibilidad ? "Sí" : "No")}");
    }

    public static Libro CrearLibro()
    {
        try
        {
            Console.WriteLine("Ingrese el título del libro:");
            string titulo = Console.ReadLine();
            Console.WriteLine("Ingrese el autor del libro:");
            string autor = Console.ReadLine();
            Console.WriteLine("Ingrese el ISBN del libro:");
            string isbn = Console.ReadLine();
            Console.WriteLine("¿Está disponible? (Sí/No):");
            string disponibilidadInput = Console.ReadLine();
            bool disponibilidad = disponibilidadInput?.Trim().ToLower() == "sí" || disponibilidadInput?.Trim().ToLower() == "si";
            return new Libro(titulo, autor, isbn, disponibilidad);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al crear el libro: {ex.Message}");
            throw;
        }
    }
}
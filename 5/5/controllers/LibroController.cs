namespace controllers;

using System.Collections.Generic;
using models;
using views;
public class LibroController
{
    public LibroController() { }

    public void MostrarLibros(List<Libro> libros)
    {
        LibroView.MostrarLibros(libros);
    }

    public Libro CrearLibro()
    {
        try
        {
            return LibroView.CrearLibro();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al crear el libro: {ex.Message}");
            return null;
        }
    }

    
}
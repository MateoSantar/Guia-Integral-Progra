namespace views;

using models;


public static class PrestamoView
{
    public static void MostrarPrestamo(Prestamo prestamo)
    {
        Console.WriteLine("=== Detalles del Préstamo ===");
        Console.WriteLine($"Libro: {prestamo.Libro.Titulo}");
        Console.WriteLine($"Usuario: {prestamo.Usuario.Nombre}");
        Console.WriteLine($"Fecha de Préstamo: {prestamo.FechaPrestamo:dd/MM/yyyy}");
        Console.WriteLine("=============================");
    }

    public static void MostrarListaPrestamos(List<Prestamo> prestamos)
    {
        Console.WriteLine("=== Lista de Préstamos ===");
        foreach (var prestamo in prestamos)
        {
            Console.WriteLine($"Libro: {prestamo.Libro.Titulo} | Usuario: {prestamo.Usuario.Nombre} | Prestado: {prestamo.FechaPrestamo:dd/MM/yyyy}");
        }
        Console.WriteLine("==========================");
    }

    
}
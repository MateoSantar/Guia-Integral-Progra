namespace models;

public class Prestamo
{
    public Libro Libro { get; set; }
    public Usuario Usuario { get; set; }
    public DateTime FechaPrestamo { get; set; }

    public Prestamo(Libro libro, Usuario usuario, DateTime fechaPrestamo)
    {
        Libro = libro;
        Usuario = usuario;
        FechaPrestamo = fechaPrestamo;
    }
    public Prestamo() { }

    public override string ToString()
    {
        return $"Libro: {Libro.Titulo}, Usuario: {Usuario.Nombre}, Fecha de Préstamo: {FechaPrestamo.ToShortDateString()}";
    }
}
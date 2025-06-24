namespace models;

public class Libro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public bool Disponibilidad { get; set; }

    public Libro(string titulo, string autor, string isbn, bool disponibilidad)
    {
        Titulo = titulo;
        Autor = autor;
        ISBN = isbn;
        Disponibilidad = disponibilidad;
    }
    public Libro() { }
    
    public override string ToString()
    {
        return $"Título: {Titulo}, Autor: {Autor}, ISBN: {ISBN}, Disponible: {(Disponibilidad ? "Sí" : "No")}";
    }
}
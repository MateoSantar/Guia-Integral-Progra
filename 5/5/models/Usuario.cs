namespace models;

public class Usuario
{
    public string Nombre { get; set; }
    public string Email { get; set; }

    public Usuario(string nombre, string email)
    {
        Nombre = nombre;
        Email = email;
    }
    public Usuario() { }

    public override string ToString()
    {
        return $"Nombre: {Nombre}, Email: {Email}";
    }
}
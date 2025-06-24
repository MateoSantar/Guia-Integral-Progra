namespace views;

using models;

public static class UsuarioView
{
    public static void MostrarUsuarios(List<Usuario> usuarios)
    {
        if (usuarios.Count == 0)
        {
            Console.WriteLine("No hay usuarios registrados.");
            return;
        }
        Console.WriteLine("Lista de Usuarios:");
        foreach (var usuario in usuarios)
        {
            MostrarUsuario(usuario);
        }
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
    }
    private static void MostrarUsuario(Usuario usuario)
    {
        if (usuario == null)
        {
            Console.WriteLine("El usuario no existe.");
            return;
        }
        Console.WriteLine($"Nombre: {usuario.Nombre}");
        Console.WriteLine($"Correo: {usuario.Email}");
    }
    public static Usuario CrearUsuario()
    {
        try
        {
            Console.WriteLine("Ingrese el nombre del usuario:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el correo del usuario:");
            string email = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentException("El nombre y el correo no pueden estar vacíos.");
            }
            return new Usuario(nombre, email);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al crear el usuario: {ex.Message}");
            throw;
        }
    }
}
namespace controllers;

using views;
using models;

public class UsuarioController
{
    public UsuarioController() { }

    public void MostrarUsuarios(List<Usuario> usuarios)
    {
        UsuarioView.MostrarUsuarios(usuarios);
    }
    public Usuario CrearUsuario()
    {
        try
        {
            return UsuarioView.CrearUsuario();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al crear el usuario: {ex.Message}");
            return null;
        }
    }
}
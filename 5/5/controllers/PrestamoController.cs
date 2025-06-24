namespace controllers;

using models;
using views;
using Newtonsoft.Json;
public class PrestamoController
{
    private List<Prestamo> prestamos;
    private LibroController lc = new LibroController();
    private UsuarioController uc = new UsuarioController();
    public PrestamoController()
    {
        prestamos = GetPrestamos();
    }


    private List<Prestamo> GetPrestamos()
    {
        try
        {
            if (!File.Exists("prestamos.json"))
            {
                File.WriteAllText("prestamos.json", JsonConvert.SerializeObject(new List<Prestamo>(), Formatting.Indented));
                return new List<Prestamo>();
            }
            List<Prestamo> prestamos = JsonConvert.DeserializeObject<List<Prestamo>>(File.ReadAllText("prestamos.json"));
            return prestamos;
        }
        catch (Exception)
        {
            
            throw;
        }

    }

    private void SavePrestamos()
    {
        File.WriteAllText("prestamos.json", JsonConvert.SerializeObject(prestamos, Formatting.Indented));
    }

    public void CrearPrestamo()
    {
        try
        {
            Libro libro = lc.CrearLibro();
            if (libro == null)
            {
                Console.WriteLine("No hay libros disponibles para prestar.");
                return;
            }
            Usuario usuario = uc.CrearUsuario();
            if (usuario == null)
            {
                Console.WriteLine("No se pudo crear el usuario. El préstamo no se puede realizar.");
                return;
            }
            prestamos.Add(new Prestamo(libro, usuario, DateTime.Now));
            SavePrestamos();
            Console.WriteLine("Préstamo creado exitosamente.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al crear el préstamo: {ex.Message}");
            return;
        }
    }
    public void MostrarPrestamos()
    {
        if (prestamos.Count == 0)
        {
            Console.WriteLine("No hay préstamos registrados.");
            return;
        }
        PrestamoView.MostrarListaPrestamos(prestamos);
    }

    public void ModificarPrestamo()
    {
        try
        {
            if (prestamos.Count == 0)
            {
                Console.WriteLine("No hay préstamos registrados para modificar.");
                return;
            }
            Console.WriteLine("Ingrese el índice del préstamo a modificar (0 para cancelar):");
            for (int i = 0; i < prestamos.Count; i++)
            {
                Console.WriteLine($"{i}: Libro: {prestamos[i].Libro.Titulo} | Usuario: {prestamos[i].Usuario.Nombre} | Fecha de Préstamo: {prestamos[i].FechaPrestamo:dd/MM/yyyy}");
            }
            int index = int.Parse(Console.ReadLine() ?? "0");
            if (index < 0 || index >= prestamos.Count)
            {
                Console.WriteLine("Índice inválido. Modificación cancelada.");
                return;
            }
            Prestamo prestamo = prestamos[index];
            prestamo.Libro = lc.CrearLibro();
            if (prestamo.Libro == null)
            {
                Console.WriteLine("No se pudo modificar el libro del préstamo.");
                return;
            }
            prestamo.Usuario = uc.CrearUsuario();
            if (prestamo.Usuario == null)
            {
                Console.WriteLine("No se pudo modificar el usuario del préstamo.");
                return;
            }
            prestamo.FechaPrestamo = DateTime.Now;
            SavePrestamos();
            Console.WriteLine("Préstamo modificado exitosamente.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al modificar el préstamo: {ex.Message}");
            return;
        }
    }

    public void EliminarPrestamo()
    {
        try
        {
            if (prestamos.Count == 0)
            {
                Console.WriteLine("No hay préstamos registrados para eliminar.");
                return;
            }
            Console.WriteLine("Ingrese el índice del préstamo a eliminar (0 para cancelar):");
            for (int i = 0; i < prestamos.Count; i++)
            {
                Console.WriteLine($"{i}: Libro: {prestamos[i].Libro.Titulo} | Usuario: {prestamos[i].Usuario.Nombre} | Fecha de Préstamo: {prestamos[i].FechaPrestamo:dd/MM/yyyy}");
            }
            int index = int.Parse(Console.ReadLine() ?? "0");
            if (index < 0 || index >= prestamos.Count)
            {
                Console.WriteLine("Índice inválido. Eliminación cancelada.");
                return;
            }
            prestamos.RemoveAt(index);
            SavePrestamos();
            Console.WriteLine("Préstamo eliminado exitosamente.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al eliminar el préstamo: {ex.Message}");
            return;
        }
    }

}
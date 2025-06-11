namespace _4;

using classes;
using classes.Repository;
class Program
{
    static void Main(string[] args)
    {
        string opt;
        ProductoRepository repository = new ProductoRepository();
        do
        {
            Console.WriteLine($"Bienvenido al sistema de gestión de productos");
            Console.WriteLine("1. Listar productos");
            Console.WriteLine("2. Agregar producto");
            Console.WriteLine("3. Actualizar producto");
            Console.WriteLine("4. Eliminar producto");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            opt = Console.ReadLine();
            switch (opt)
            {
                case "1":
                    repository.GetAll();
                    break;
                case "2":
                    repository.AddProduct();
                    break;
                case "3":
                    repository.UpdateProduct();
                    break;
                case "4":
                    repository.DeleteProduct();
                    break;
                case "5":
                    Console.WriteLine("Saliendo del sistema...");
                    break;
                default:
                    Console.WriteLine("Opción no válida, intente de nuevo.");
                    break;
            }
            
        } while (opt != "5");
    }
}

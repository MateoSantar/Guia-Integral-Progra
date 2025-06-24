namespace _5;

using controllers;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido al sistema de gestión de biblioteca.");
        PrestamoController prestamoController = new PrestamoController();
        int opcion;
        do
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Crear Préstamo");
            Console.WriteLine("2. Mostrar Préstamos");
            Console.WriteLine("3. Modificar Préstamo");
            Console.WriteLine("4. Eliminar Préstamo");
            Console.WriteLine("5. Salir");
            Console.Write("Opción: ");
            if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 5)
            {
                Console.WriteLine("Opción inválida. Intente nuevamente.");
                continue;
            }
            switch (opcion)
            {
                case 1:
                    prestamoController.CrearPrestamo();
                    break;
                case 2:
                    prestamoController.MostrarPrestamos();
                    break;
                case 3:
                    prestamoController.ModificarPrestamo();
                    break;
                case 4:
                    prestamoController.EliminarPrestamo();
                    break;
                case 5:
                    Console.WriteLine("Saliendo del sistema. ¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                    break;
            }
        } while (opcion != 5);
        Console.WriteLine("Gracias por usar el sistema de gestión de biblioteca.");

    }
}

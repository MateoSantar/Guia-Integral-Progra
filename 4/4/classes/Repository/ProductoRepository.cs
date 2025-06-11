namespace classes.Repository;

using Newtonsoft.Json;
using System.IO;
public class ProductoRepository
{
    private const string FILEPATH = "productos.json";
    private List<Product> productos = new List<Product>();

    public ProductoRepository()
    {
        productos = LoadProducts();
    }
    private List<Product> LoadProducts()
    {
        if (File.Exists(FILEPATH))
        {
            string json = File.ReadAllText(FILEPATH);
            productos = JsonConvert.DeserializeObject<List<Product>>(json) ?? new List<Product>();
        }
        return productos;
    }

    public void GetAll()
    {
        if (productos.Count == 0)
        {
            Console.WriteLine("No hay productos disponibles.");
            return;
        }
        Console.WriteLine("Lista de productos:");
        foreach (var product in productos)
        {
            Console.WriteLine(product);
        }
    }

    public void AddProduct()
    {
        Product product = new Product();
        Console.Write("Ingrese el ID del producto: ");
        product.Id = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Ingrese el nombre del producto: ");
        product.Name = Console.ReadLine() ?? string.Empty;
        Console.Write("Ingrese el precio del producto: ");
        product.Price = decimal.Parse(Console.ReadLine() ?? "0");
        Console.Write("Ingrese el stock del producto: ");
        product.Stock = int.Parse(Console.ReadLine() ?? "0");
        productos.Add(product);
        SaveProducts();
    }

    public void DeleteProduct()
    {
        int id;
        Console.Write("Ingrese el ID del producto a eliminar: ");
        if (!int.TryParse(Console.ReadLine(), out id))
        {
            Console.WriteLine("ID inválido. Por favor, intente de nuevo.");
            return;
        }
        var product = productos.FirstOrDefault(p => p.Id == id);
        if (product != null)
        {
            productos.Remove(product);
            SaveProducts();
        }
    }

    public void UpdateProduct()
    {
        int wantedId;
        Console.Write("Ingrese el ID del producto a actualizar: ");
        if (!int.TryParse(Console.ReadLine(), out wantedId))
        {
            Console.WriteLine("ID inválido. Por favor, intente de nuevo.");
            return;
        }
        var index = productos.FindIndex(p => p.Id == wantedId);
        if (index == -1)
        {
            Console.WriteLine("Producto no encontrado.");
            return;
        }
        Product product = productos[index];
        Console.WriteLine($"Que desea actualizar del producto {product.Name}?");
        Console.WriteLine("1. Nombre");
        Console.WriteLine("2. Precio");
        Console.WriteLine("3. Stock");
        Console.Write("Seleccione una opción: ");
        string option = Console.ReadLine();
        switch (option)
        {
            case "1":
                Console.Write("Ingrese el nuevo nombre: ");
                product.Name = Console.ReadLine() ?? string.Empty;
                break;
            case "2":
                Console.Write("Ingrese el nuevo precio: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal newPrice))
                {
                    product.Price = newPrice;
                }
                else
                {
                    Console.WriteLine("Precio inválido. No se actualizó.");
                }
                break;
            case "3":
                Console.Write("Ingrese el nuevo stock: ");
                if (int.TryParse(Console.ReadLine(), out int newStock))
                {
                    product.Stock = newStock;
                }
                else
                {
                    Console.WriteLine("Stock inválido. No se actualizó.");
                }
                break;
            default:
                Console.WriteLine("Opción no válida.");
                return;
        }
        productos[index] = product;
        SaveProducts();
        
    }

    public void SaveProducts()
    {
        string json = JsonConvert.SerializeObject(productos, Formatting.Indented);
        File.WriteAllText(FILEPATH, json);
    }
}
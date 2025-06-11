namespace classes;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public Product() { }
    public Product(int id, string name, decimal price, int stock)
    {
        Id = id;
        Name = name;
        Price = price;
        Stock = stock;
    }
    
    public override string ToString()
    {
        return $"{Id} - {Name} - {Price:C} - Stock: {Stock}";
    }

}
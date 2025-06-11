using classes;
class Program
{
    static void Main(string[] args)
    {
        Gato g = new Gato("Mittens");
        Perro p = new Perro("Bolt");
        Console.WriteLine($"{g.Presentarse()}");
        Console.WriteLine($"{p.EmitirSonido()}");
        
    }
}

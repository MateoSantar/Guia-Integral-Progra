namespace classes;

public class Animal
{
    public string Nombre { get; set; }
    public Animal(string nombre)
    {
        Nombre = nombre;
    }



    public virtual string EmitirSonido()
    {
        return "Sonido de animal";
    }
}

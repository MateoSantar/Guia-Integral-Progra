namespace classes;

public class Gato : Animal
{
    public Gato(string nombre) : base(nombre)
    {
    }

    public override string EmitirSonido() => "Miau!";

    public string Presentarse() => $"Soy un gato llamado {Nombre} y hago {EmitirSonido()}";
}
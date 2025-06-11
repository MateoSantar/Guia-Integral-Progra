namespace classes;
    public class Perro : Animal
    {
    public Perro(string nombre) : base(nombre)
    {
    }

    public override string EmitirSonido()
        {
            return "Guau!";
        }
    }

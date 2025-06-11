namespace classes;

using interfaces;
using System;


public class FacturaPrinter : IPaperImprimible, IdigitalImprimible
{
    public void ImprimirEnPapel()
    {
        Console.WriteLine("Factura impresa en papel correctamente.");
    }

    public void ImprimirEnDigital()
    {
        Console.WriteLine("Factura impresa en formato digital correctamente.");
    }

}
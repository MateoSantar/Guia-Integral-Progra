using System;
using System.Collections.Generic;
using classes;
namespace IntegralSantarsiero1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ciudadano> ciudadanos = new List<Ciudadano>();

            Console.WriteLine("Bienvenido a mi sistema.");
            string opt = "-1";
            do
            {
                Console.WriteLine("1. Añadir ciudadano");
                Console.WriteLine("2. Mostrar almacenados");
                Console.WriteLine("0. Salir");
                opt = Console.ReadLine();
                switch (opt)
                {
                    case "1":
                        AddCitizen(ciudadanos);
                        break;
                    case "2":
                        if (ciudadanos.Count>0)
                        {
                            ShowCitizens(ciudadanos);
                        }
                        else
                        {
                            Console.WriteLine("No hay ciudadanos guardados.");
                        }
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Opcion erronea");
                        break;
                }
            } while (opt != "0");
        }


        private static void AddCitizen(List<Ciudadano> ciudadanos)
        {
            string keepGoing = "_";
            do
            {
                Console.Clear();
                Console.Write("Ingrese el nombre completo: ");
                string name = Console.ReadLine();
                Console.Write("Ingrese el DNI: ");
                string dni = Console.ReadLine();
                Console.Write("Ingrese la edad: ");
                if (int.TryParse(Console.ReadLine(),out int edad) && name != string.Empty && dni != string.Empty)
                {
                    ciudadanos.Add(new Ciudadano(name, dni, edad));
                    Console.WriteLine("Añadido");
                }
                else
                {
                    Console.WriteLine("Ha ingresado un dato invalido.");
                }
                Console.WriteLine("Desea seguir añadiendo ciudadanos? (y/n)");
                keepGoing = Console.ReadLine();
            } while (keepGoing.ToLower() != "n" );
        }

        private static void ShowCitizens(List<Ciudadano> ciudadanos)
        {
            foreach (Ciudadano c in ciudadanos)
            {
                Console.WriteLine(c);
            }
        }
    }
}

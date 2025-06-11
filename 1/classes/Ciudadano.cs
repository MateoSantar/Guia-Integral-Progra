using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Ciudadano
    {

        private string Name { get; set; }
        private string Dni { get; set; }
        private int Edad { get; set; }
        public Ciudadano(string name, string dni, int edad)
        {
            Name = name;
            Dni = dni;
            Edad = edad;
        }

        public string Saludar() => $"Bienvenido Sr/Sra {Name} | DNI: {Dni}";

        public bool EsMayor() => Edad >= 18;

        public override string ToString() => $"Nombre: {Name} | DNI: {Dni} | Edad: {Edad}";
    }
}

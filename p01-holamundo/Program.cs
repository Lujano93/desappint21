using System;

namespace p01_holamundo
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            DateTime fecha = DateTime.Now;
            Console.WriteLine("Hola Mundo!");
            Console.WriteLine("Dame tu nombre ?");
            nombre = Console.ReadLine();
            Console.WriteLine($"{nombre} bienbenido al c#" );
            Console.WriteLine($"Hoy es {fecha:d} y son las {fecha:t}");
            Console.WriteLine("\nHasta Pronto");
        }
    }
}

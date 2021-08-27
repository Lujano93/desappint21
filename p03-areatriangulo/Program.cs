//Calcular el area de un triangulo
using System;

namespace p03_areatriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            float labase, laaltura, elarea;
            labase = laaltura = elarea =0;
            Console.WriteLine("Calculando el area de un triangulo");
            Console.WriteLine("Dame la base: ");
            labase=float.Parse(Console.ReadLine());
            Console.WriteLine("Dame la Altura: ");
            laaltura=float.Parse(Console.ReadLine());
            elarea=(labase*laaltura) / 2;
            Console.WriteLine($"El area del triangulo es {elarea}");
        }
    }
}

using System;

namespace p07_TablaMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=0, i=0, resultado=0, multiplicando=0, multiplicador=0;;
            Console.WriteLine("Ingrese el valor a multiplicar para la tabla del que ingreses desde 1 al 10: ");
            num = int.Parse(Console.ReadLine());
            for(i=1;i<=10;i++)
            {
                resultado = num*i;
                Console.WriteLine(num+" * "+i+"="+resultado);
            }
            Console.WriteLine("Ingrese lo que se te pide para la siguiente tabla de multiplicar ");
            Console.WriteLine("Ingresa el multiplicando: ");
            multiplicando = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el multiplicador: ");
            multiplicador = int.Parse(Console.ReadLine());
            for(i=1;i<=multiplicador;i++)
            {
                resultado = multiplicando*i;
                Console.WriteLine(multiplicando+" * "+i+"="+resultado);

            }

        }
    }
}

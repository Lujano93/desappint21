﻿using System;

namespace p07_TablaMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=0, i=0, resultado=0;
            Console.WriteLine("Ingrese el valor a multiplicar para la tabla del que ingreses desde 1 al 10: ");
            num = int.Parse(Console.ReadLine());
            for(i=1;i<=10;i++)
            {
                resultado = num*i;
                Console.WriteLine(num+" * "+i+"="+resultado);
            }


        }
    }
}

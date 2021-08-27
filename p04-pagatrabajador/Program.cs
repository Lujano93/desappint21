//Calcula la paga de un trabajador 
using System;

namespace p04_pagatrabajador
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, salida;
            int horas;
            float pago, pagobruto, impuesto, pagoneto;
            const float TASA = 0.3f;

            Console.WriteLine("Calculando la paga del trabajador\n");
            Console.WriteLine("Cual es tu nombre: "); nombre = Console.ReadLine();
            Console.WriteLine("Horas trabajadas:  "); horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Pago por Hora:     "); pago = float.Parse(Console.ReadLine());
        
            pagobruto = horas * pago;
            impuesto = pagobruto * TASA;
            pagoneto = pagobruto - impuesto;

            salida = $"El trabajador {nombre}, trabajo {horas} horas, con un pago de {pago} \n" + 
                     $"Pago bruto: {pagobruto}\n impuesto: {impuesto}\n pagoneto: {pagoneto}";
            
            Console.WriteLine(salida);

        }
    }
}

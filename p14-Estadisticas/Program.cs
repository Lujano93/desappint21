using System;

namespace p14_Estadisticas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double mayor, menor, promedio, varianza, desviacion;
            int n; 
            Console.Write("Cuantos valores deseas procesar: ");
            n = int.Parse(Console.ReadLine());
            double[] v = new double[n];

            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine($"n[{i+1}]= ");
                v[i] = double.Parse(Console.ReadLine());
            }
            mayor = may(v);
            menor = men(v);
            promedio = prom(v);
            varianza = var(v, promedio);
            desviacion = Math.Sqrt(varianza);

            Console.WriteLine($"\nEl Mayor es: {mayor}");
            Console.WriteLine($"\nEl Menor es: {menor}");
            Console.WriteLine($"\nEl Promedio es: {promedio}");
            Console.WriteLine($"\nLa varianza es:  {varianza}");
            Console.WriteLine($"\nLa desviación estandar es:  {desviacion}");
        }

        static double var(double[] v, double p){
            double s=0;
            for (int i = 0; i < v.Length; i++)
                s += Math.Pow(v[i] - p,2);
                return s / v.Length;
        }

        static double prom(double[] v){
            double s=0;
            for (int i = 0; i < v.Length; i++)
                s+=v[i];
                return s / v.Length;
        }

        static double may(double[] v){
            double m= v[0];
            for (int i = 0; i < v.Length; i++)
                if(v[i]>m)
                m = v[i];
                return m;
        }

          static double men(double[] v){
            double m= v[0];
            for (int i = 0; i < v.Length; i++)
                if(v[i]<m)
                m = v[i];
                return m;
        }

    }
}

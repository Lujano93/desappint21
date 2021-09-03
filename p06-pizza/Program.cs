using System;
using static System.Console;
 

namespace p06_pizza
{
    class Program
    {
        static int Main(string[] args)
        {
            char tam, cub;
            string[] ings;

            string tamaño, cubierta;
            string ingredientes="";

            if(args.Length<3){
                Menu();
                return 1;
            }
            //Tamaño de la pizza
            tam = char.Parse(args[0].ToUpper());
            if(tam=='P') tamaño="Pequeña";
            else if(tam =='M') tamaño="Mediana";
            else tamaño="Grande";

            //Ingredientes
            ings = args[1].Split("+");
            foreach (String i in ings)
            {
                switch (char.Parse(i.ToUpper()))
                {
                    
                    case 'E' : ingredientes += "Extraqueso\n"; break;
                    
                    case 'C' : ingredientes += "Champiñones\n"; break;
                    
                    case 'J' : ingredientes += "Jalapeño\n"; break;
                    
                    case 'T' : ingredientes += "Tocino\n"; break;
                    
                    case 'M' : ingredientes += "Jamon\n"; break;
                }
            }

            WriteLine("Tu pizza es de tamaño: {0}", tamaño);
            WriteLine("Tus Ingredientes:\n{0}", ingredientes);
            return 0;

        }
        static void Menu(){
            Clear();
            WriteLine("Tamaños: (P) - Pequeña \n(M) - Mediana \n(G) - GRande");
            WriteLine("Estos son los Ingredientes:\n(C) - Champiñones \n(E) - Extra queso \n(J) - Jalapeño \n(T) - Tocino \n(M) - Jamon");

        }
    }
}

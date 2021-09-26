using System;

namespace examen1
{
    class Program
    {
        static void Main(string[] args)
        {
           //inicializar datos
           Escuela miesc = new Escuela("Universidad Patito SA de CV", "Ing. Juan Perez", "Av. De la Juventud 348");
            miesc.AgregarNodo(new Nodo("Jose Diaz2",DateTime.Parse("1/1/2018"),"1A","Fisica",1200,3));
            miesc.AgregarNodo(new Nodo("Maria Perez",DateTime.Parse("10/2/2016"),"2A","Algebra",3400,2));
            miesc.AgregarNodo(new Nodo("Claudia Sid",DateTime.Parse("1/4/2019"),"4B","Calculo",3800, 0));
            miesc.AgregarNodo(new Nodo("Carlos Lopez",DateTime.Parse("10/3/2016"),"8A","Química",1000,1));
            

            
            //Reporte
            Console.WriteLine(">>Datos Generales de la Escuela: ");
            Console.WriteLine($"Nombre         : {miesc.escuela}");
            Console.WriteLine($"Encargado      : {miesc.encargado}");
            Console.WriteLine($"Domicilio      : {miesc.domicilio}");
            Console.WriteLine($"\nTotal de Maestros :{miesc.nodos.Count}");
            Console.WriteLine("\n>>Datos Generales de los Profesores: \n");
            miesc.nodos.ForEach(n=>Console.WriteLine(n.ToString()));
            Console.WriteLine($"Mayor Salario:  {miesc.Mayor}");
            Console.WriteLine($"Menor Salario:  {miesc.Menor}");

            Console.WriteLine($"\n>>Alumnos por Profesor: ");
            Console.WriteLine($"\n>Nombre: Jose Dias,    Grupo: 1A");

            
            //Alumnos datos inicializarlos
            miesc.AgregarNodoAlumno(new NodoAlumno("Fatima Soto",23,DateTime.Parse("1/1/2019"),"Si","7,7,7",));
            miesc.AgregarNodoAlumno(new NodoAlumno("Damian Diaz",25,DateTime.Parse("1/1/2016"),"No","8,8,8",));
            miesc.AgregarNodoAlumno(new NodoAlumno("Fatima Soto",23,DateTime.Parse("1/1/2018"),"Si","6,6,6",));
                  
            
         }
    }
}

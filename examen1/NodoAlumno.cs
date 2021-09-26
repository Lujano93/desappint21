using System;
namespace examen1
{
  public class Alumno
  {
      public Nodo (string aNombre,int aEdad,DateTime aFechaIng,string aBecado,int aCalifs) =>
            (Nombre,FechaIng,Grupo,Materia,Salario,Alumnos) = (pNombre,pFechaIng,pGrupo,pMateria,pSalario,pAlumnos);

        public string aNombre {get; private set;}
        public int aEdad {get; private set;}
        public  DateTime aFechaIng {get; private set;}
        public string aBecado {get; private set;}
        public string aBecado {get; private set;}
        public int aCalifs {get; private set;}
        public int Antiguedad {
          get{
             return DateTime.Now.Year - FechaIng.Year;
          }
           
        }
        public int promedio{

        }

        public string Mensaje{
            get{
             if(prom>=7)
              string m= Aprobaste;
              else
               m= Reprobaste;

                return m;
            } 
           
        }
        
        public override string ToString() => 
        $"Nombre: {aNombre,-15} Edad: {aEdad,-7} FechaIng: {FechaIng.ToString("dd/mm/yy"),-10} Becado: {aBecado,-4} Califs: {aCalifs,-8} Antiguedad: {Antiguedad.ToString(),-2} Promedio: {aPromedio, -11} Mensaje: {aMensaje,-10}";
  }
}
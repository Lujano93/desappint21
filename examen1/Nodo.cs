  using System;
  namespace examen1
  {
       public class Nodo {

        //public Nodo() => vulnerabilidades = new List<Vulnerabilidad>();

        public Nodo (string pNombre,DateTime pFechaIng,string pGrupo,string pMateria,int pSalario,int pAlumnos) =>
            (Nombre,FechaIng,Grupo,Materia,Salario,Alumnos) = (pNombre,pFechaIng,pGrupo,pMateria,pSalario,pAlumnos);

        public string Nombre {get; private set;}
        public DateTime FechaIng {get; private set;}
        public string Grupo {get; private set;}
        public string Materia {get; private set;}
        public int Salario {get; private set;}
        public int Alumnos {get; private set;}
        public int Antiguedad {
          get{
             return DateTime.Now.Year - FechaIng.Year;
          }
           
        }
        
        //public List<Vulnerabilidad> vulnerabilidades {get; private set;}

        //public void AgregarVulnerabilidad(Vulnerabilidad v) => vulnerabilidades.Add(v);

        public override string ToString() => 
                $"Nombre: {Nombre,-15} FechaIng: {FechaIng.ToString("dd/mm/yy"),-10} Grupo: {Grupo,-4} Materia: {Materia,-8} Salario: {Salario,-6} Alumnos: {Alumnos,-4} Antiguedad: {Antiguedad.ToString(),-2}";
    }
  }
 
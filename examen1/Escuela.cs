using System.Collections.Generic;
namespace examen1
{
    public class Escuela {
     
     public Escuela() => nodos = new List<Nodo>();
    

     public Escuela(string pescuela,string pencargado,string pdomicilio) : this() =>
            (escuela,encargado,domicilio) = (pescuela,pencargado,pdomicilio);
     
     public string escuela {get; private set;}
     public string encargado {get; private set;}
     public string domicilio {get; private set;}
     
     public List<Nodo> nodos {get; private set;}
    
     public int Mayor {
         get {
             int m=nodos[0].Salario;
             foreach (Nodo n in nodos)
                    if(n.Salario>m) m = n.Salario;
             return m;
         }
         
     }
     public int Menor {
         get {
             int m=nodos[0].Salario;
             foreach (Nodo n in nodos)
                    if(n.Salario<m) m = n.Salario;
             return m;
         }
         
     }    
     public void AgregarNodo(Nodo n) => nodos.Add(n);
      
    }

    public class Alumno{
         public Alumno() => nodos1 = new List<NodoAlumno>();
          public List<NodoAlumno> nodos1 {get; private set;}

         public void AgregarNodoAlumno(NodoAlumno n) => nodos1.Add(n);

    }
    
}
     
     
     
     
      /* // public escuela() => nodos = new List<Nodo>();

        public escuela(string pescuela, string pencargado, string pdomicilio) : this() =>
            (escuela,encargado,domicilio) = (pescuela,pencargado,pdomicilio);
         
        public string escuela {get; private set;}
        public string encargado {get; private set;}
        public string domicilio {get; private set;}
       public List<Nodo> nodos {get; private set;}
        public int Mayor {
            get {
                int m=nodos[0].saltos;
                foreach (Nodo n in nodos)
                    if(n.saltos>m) m = n.saltos;
                return m;
            }
        }
        public int Menor {
            get {
                int m=nodos[0].saltos;
                foreach (Nodo n in nodos)
                    if(n.saltos<m) m = n.saltos;
                return m;
            }
        }
        public int TotVuln {
            get {
                int s=0;
                foreach (Nodo n in nodos)
                     s = s + n.vulnerabilidades.Count;
                return s;
            }
        }

    
        public void AgregarNodo(Nodo n) => nodos.Add(n);*/
    



namespace e02_segundoparcial.Modelo{
    public class PeliculaActorRol{
        public int PeliculaId {get; set;}
        public int Actor {get; set;}
        public int RolId {get; set;}
        public string Personaje {get; set;}
        public string Descripcion {get; set;}

        public Actor Actor {get; set;}
        public Rol Rol {get; set;}
        public Pelicula Pelicula {get; set;}
    }
}
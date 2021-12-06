using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace e02_segundoparcial.Modelo{
    public class Actor{
        [key]
        public int Id {get; set;}
        [Required]
        public string Nombre {get; set;}
        public string Notas {get; set;}

        public ICollection<PeliculaActorRol> PeliculaActorRoles {get; set;}
    }
}
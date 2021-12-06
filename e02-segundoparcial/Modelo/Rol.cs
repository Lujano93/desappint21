using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace e02_segundoparcial.Modelo{
    public class Rol{
        [key]
        public int Id {get; set;}
        [Required]
        public string Tipo {get; set;}

        public ICollection<PeliculaActorRol> PeliculaActorRoles {get; set;}
           }
}
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace e02_segundoparcial.Modelo{
    public class Genero{
        [key]
        public int Id {get; set;}
        [Required]
        public string Descripcion {get; set;}     

        public ICollection<Pelicula> Peliculas {get; set;}
    }
}
using System.ComponentModel.DataAnnotations;


namespace e02_segundoparcial.Modelo{
    public class Productor{
        [key]
        public int Id {get; set;}
        [Required]
        public string Nombre {get; set;}
        [EmailAddress]
        public string Correo {get; set;}
        [Url]
         public string SitioWeb {get; set;}
    }
}
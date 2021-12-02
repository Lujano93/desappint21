using System.ComponentModel.DataAnnotations;


namespace e02_segundoparcial.Modelo{
    public class Productor{
        [key]
        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Correo {get; set;}
         public string SitioWeb {get; set;}
    }
}
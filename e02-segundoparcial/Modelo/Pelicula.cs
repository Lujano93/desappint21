using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace e02_segundoparcial.Modelo{
    public class Pelicula{
        [key]
        public int Id {get; set;}
        [Required]
        public string Titulo {get; set;}
        public string Historia {get; set;}
        [DataType(DataType.date)]
         public DateTime FechaEstreno {get; set;}
         public int Duracion {get; set;}
        public int GeneroID {get; set;}
        public int CertificadoID {get; set;}
        public string Notas {get; set;}


        public Icollection<PeliculaActorRol> PeliculaActorRoles {get; set;}
        public Icollection<PeliculaProductor> PeliculaProductores {get; set;}
        public Genero Genero {get; set;}
        public Certificado Certificado {get; set;}
        

    }
}
using System;
using System.ComponentModel.DataAnnotations;

namespace p21_universidadv1.Modelo
{
    public class  oficinaAsignada
    {
        [Key]
        public int instructorid {get; set;}
        public string ubicacion {get; set;}
        
          
    }
}
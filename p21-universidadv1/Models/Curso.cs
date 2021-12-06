using System;
using System.ComponentModel.DataAnnotations;

namespace p21_universidadv1.Modelo
{
    public class  curso
    {
        [Key]
        public int cursoid {get; set;}
        public string titulo {get; set;}
        public int creditos {get; set;}
        public int departamentoid {get; set;}
         
    }
    
}
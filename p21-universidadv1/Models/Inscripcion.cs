using System;
using System.ComponentModel.DataAnnotations;

namespace p21_universidadv1.Modelo
{
    public class  inscripcion
    {
        [Key]
        public int inscripcionid {get; set;}
        public int cursoid {get; set;}
        public int estudianteid {get; set;}
        public int promedio {get; set;}
    }
}
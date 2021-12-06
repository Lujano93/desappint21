using System;
using System.ComponentModel.DataAnnotations;

namespace p21_universidadv1.Modelo
{
    public class Persona {
        [Key]
        public int id {get; set;}
        public string apaterno {get; set;}
        public string amaterno {get; set;}
        public string nombre {get; set;}
        public string nombrecompleto {
            get{
                return $"{apaterno} {amaterno} {nombre}";
            }
        }

    
    }
}
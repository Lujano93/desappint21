using System;
using System.ComponentModel.DataAnnotations;

namespace p21_universidadv1.Modelo
{
    public class  departamento
    {
    [Key] 
    public int departamentoid {get; set;}
    public string nombre {get; set;}
    public decimal presupuesto {get; set;}
    public DateTime fechadeinicio {get; set;}
    public int instructorid {get; set;}

    }
}
using System;
using System.Collections.Generic;

namespace examen1
{
  public class Alumno{

public Alumno(string pnombre, int pedad, DateTime pfechaing, bool pbecado,List<float> pcalifs) => 
(nombre, edad, fechaing, becado, califs) (pnombre, pedad, pfechaing,pbecado,pcalifs);
public string nombre {get; set;} 
public int edad {get; set;} 
public DateTime fechaing {get; set;} 
public bool becado {get; set;} 
public List<float> califs {get; set;}

public float prom {
  get {
    float s=0;
    foreach(var c in califs) S+=c; 
    return s/califs.Count;
  }
}

  public override string ToString() =>
  $"Nombre: {nombre,-12} Edad:6 {edad} FechaIng: {fechaing. ToString("dd/MM/yyy")}" + 
  $"Becado: {(becado?"S1":"No")} Calificaciones: {string. Join (",",califs)}" + 
  $"Prom: {prom} Mensaje: {(promo>=7?"Aprobado":"Reprobado") }";
  }
}
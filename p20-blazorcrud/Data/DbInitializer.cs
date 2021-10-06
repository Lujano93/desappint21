Using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace p20_blazorcrud.Data
{
  public class DbInitilizer
  {
      public static void Iniciaizar(AppDBContext context){
          context.Datebase.EnsureCreated();
          if (context.Employees.Any())
          {
              return;
          }
          var employees = new Employee[]{
              new Employee {EmploeeName="Carlos Castaneda Ramirez",Gender="MAle",City="Zacatecas",Designation="Profesor"},
              new Employee {EmploeeName="Blamca Solis Recendez",Gender="Female",City="Fresnillo",Designation="Profesora"},
              new Employee {EmploeeName="Juan Villa Cisneros",Gender="MAle",City="Zacatecas",Designation="Profesor"},
              new Employee {EmploeeName="Uriel Cortez Vargas",Gender="MAle",City="Guadalupe",Designation="Trabajdor"},
              new Employee {EmploeeName="Ma. Concepcion Lopez",Gender="MAle",City="Jerez",Designation="Intendente"},
          };
          foreach(Employee emp in employees){
              context.Employees.Add(emp);
          }
          context.SaveChanges();
      }
  }  
}
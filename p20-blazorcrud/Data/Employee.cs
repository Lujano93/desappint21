using System.ComponentModel.DataAnnot ations;

namespace p20_blazorcrud.Data
{
    [key]
    public class Employee{
    public int Id {get; set;}
    public string Employee {get; set;}
    public string Gender {get; set;}
    public string City {get; set;}
    public string Designation {get; set;}


    
    }
}
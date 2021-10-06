using System;
Using Microsoft.EntityFrameworkCore;

namespace p20_blazorcrud.Data
{
    public class AppDBContext : DBContext {
        public AppDBContext(DBContextOptions<AppDBContext> options) : base(options){
            public Dbset<Employee> Employees {get; set;}
            
        }
    }




}
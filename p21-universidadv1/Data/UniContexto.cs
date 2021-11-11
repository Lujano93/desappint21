using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using p21_universidadv1.Modelo;

namespace p21_universidadv1.Data
{
    public class UniContexto : DbContexto
    {
        public UniContexto(DbContextOption<UniContexto> opciones) : base(opciones){

        }
        public DbSet<Curso> Cursos {get; set;}
        public DbSet<Departamento> Departamentos {get; set;}
        public DbSet<Estudiante> Estudiantes {get; set;}
        public DbSet<Inscripcion> Incripciones {get; set;}
        public DbSet<Instructor> Instrucores {get; set;}
        public DbSet<OficinaAsignada> OficinaAsignadas {get; set;}
    }
}
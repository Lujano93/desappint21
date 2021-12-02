using Microsoft.EmtityFrameeorkCore;
using e02_segundoparcial.Modelo;

namespace e02_segundoparcial.Data
{
    public class DvdContexto : DbContexto
    {
        public DvdContexto(DbContextoOptions<DvdContexto> opciones)
        : base(opciones) {}

       public DbSet<Actor> Actores {get; set;}
       public DbSet<Certificado> Certificados {get; set;}
       public DbSet<Genero> Generos {get; set;}
       public DbSet<Pelicula> Peliculas {get; set;}
       public DbSet<PeliculaActorRol> PeliculaActorRoles {get; set;}
       public DbSet<PeliculaProductor> PeliculaProductores {get; set;}
       public DbSet<Rol> Roles {get; set;}
       public DbSet<Productor> Productores {get; set;}

       protected override void OnModelCreating(ModelBuilder modelo){
           modelo.Emtity<PeliculaActorRol>().MasKey( k=> new {k.PeliculaId, k.ActorId, k.RolId});
           modelo.Emtity<PeliculaProductor>().MasKey( k=> new {k.ProductorId, k.PeliculaId});

       }
    }
}
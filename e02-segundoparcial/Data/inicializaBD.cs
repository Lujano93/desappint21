using e02_segundoparcial.Modelo;
using System.Linq;
Using System;

namespace e02_segundoparcial.data
{
    public class InicializaBD
    {
        public static void Inicializar(DvdContexto contexto){
            contexto.Database.EsureCreated();
            if (contexto.Peliculas.Any())
            {
                return;
            }
            // Agregar Actores
            var actores = new Actor[] {
                new Actor {Nombre="Pedro Infante"},
                new Actor {Nombre="Cantinflas"},
                new Actor {Nombre="India Maria"},
                new Actor {Nombre="Jorge Negrete"},
                
            };
            foreach (Actor a in actores) contexto.Actores.Add(a);
            contexto.SaveChanges();   
            
            // Agregar Roles
            var roles = new Rol[]{
                new Rol {Tipo="Personaje Principal"},
                new Rol {Tipo="Personaje Secundario"},
                new Rol {Tipo="Personaje Extra"},
                new Rol {Tipo="Personaje Doble de acción"},
                new Rol {Tipo="Personaje canafes"},
            };
            foreach (Rol r in roles) contexto.Roles.Add(r);
            contexto.SaveChanges();

            // Agregar Genero
            var generos = new Genero[]{
                new Genero {Descripcion="Accion"},
                new Genero {Descripcion="Aventura"},
                new Genero {Descripcion="Comedia"},
                new Genero {Descripcion="Drama"},
                new Genero {Descripcion="Terror"},
                new Genero {Descripcion="Ciencia ficcion"},

            };
             foreach (Genero g in generos) contexto.Generos.Add(g);
            contexto.SaveChanges();
            // Agregar certificados
            var certificados = new Certificado[]{
                new Certificado {Descripcion="U"},
                new Certificado {Descripcion="PG"},
                new Certificado {Descripcion="12A"},
                new Certificado {Descripcion="15"},
                new Certificado {Descripcion="18"},
            };
            foreach (Certificado c in certificados) contexto.Certificados.Add(c);
            contexto.SaveChanges();
            // Agregar peliculas
            var Peliculas = new Pelicula[]
            {
                new Pelicula{Tirulo="Macario",Historia="Macario es el perron",FechaEstreno=DateTime,Parse("1/1/1945"),
                Duracion=120, GeneroID=generos.Single(g=>g.Descripcion="Drama").Id,
                CertificadoID=certificados.Single(c=>Descripcion="U").Id}
            };
             foreach (Pelicula p in peliculas) contexto.Peliculas.Add(p);
            contexto.SaveChanges();

            // Agregar pelicula actor rol

            // Agregar pelicula productor
            var productores = new Productor[]{
                new Productor {Nombre="Guillermo del Toro", Correo="memodeltoro@gmail.com", SitioWeb="http://www.deltoro.com.mx"},
                
                new Productor {Nombre="Alfonso cuaron", Correo="cuaron@gmail.com", SitioWeb="http://www.AlfonsoCuaron.com.mx"},
                
                new Productor {Nombre="Diego Luna", Correo="LunaD@gmail.com", SitioWeb="http://www.DiegoLuna.com.mx"},
            };
            foreach (Productor p in productores) contexto.Productores.Add(p);
            contexto.SaveChanges();

        }
    }
}
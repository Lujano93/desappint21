namespace e02_segundoparcial.Modelo{
    public class PeliculaProductor{
        public int ProductorId {get; set;}
        public int PeliculaId {get; set;}

        public Producto Productor {get; set;}
        public Pelicula Pelicula {get; set;}
    }
}
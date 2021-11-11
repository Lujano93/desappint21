using System;

namespace p21_universidadv1.Data
{
    public class InicializaBD
    {
        public static void Inicializar(UniContexto contexto){

            contexto.Database.EnsureCreated();
        }
    }    
}
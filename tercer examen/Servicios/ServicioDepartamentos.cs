using System.Collections.Generic;
using System.Linq;
using p21_universidadv1.Modelo;
using p21_universidadv1.Data;
using Microsoft.EntityFrameworkCore;

namespace p21_universidadv1.Servicio {
    public class ServicioDepartamentos {
        private UniContexto contexto;
        public ServicioDepartamentos(UniContexto uniContexto) => contexto = uniContexto;
        
        public List<Departamento> ObtenerTodo(string cadenabuscar) {
            var _departamentos =       
                contexto.Departamentos
                .Include(i=>i.Instructor);

            var departamentos = from d in _departamentos select d;

            if(!string.IsNullOrEmpty(cadenabuscar)) {
                departamentos = departamentos.Where(d=>d.Nombre.Contains(cadenabuscar));
            }
            return departamentos.ToList();
        
         } 

        public Departamento Obtener(int Id) {
            Departamento departamento = contexto
            .Departamentos.Include(i=>i.Instructor)
            .FirstOrDefault(e=>e.DepartamentoId.Equals(Id));
            return departamento;
        }
        public bool Insertar(Departamento departamento) {
            contexto.Departamentos.Add(departamento);
            contexto.SaveChanges();
            return true;
        }
        public bool Actualizar(Departamento departamento) {
            contexto.Departamentos.Update(departamento);
            contexto.SaveChanges();
            return true;
        }
        public bool Eliminar(Departamento departamento) {
            contexto.Departamentos.Remove(departamento);
            contexto.SaveChanges();
            return true;
        }
    }
}
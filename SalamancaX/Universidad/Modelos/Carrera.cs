using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Modelos
{
    public class Carrera
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Perfil_profesional { get; set; }
        public string Titulo { get; set; }
        public virtual ICollection<Estudiante> Estudiantes { get; set; }
        public virtual ICollection<Asignatura> Asignaturas { get; set; }
        public char Estatus { get; set; }
    }
}

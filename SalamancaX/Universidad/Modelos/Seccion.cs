using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Modelos
{
    public class Seccion
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public virtual Asignatura Asignatura { get; set; }
        public virtual ICollection<Estudiante> Estudiantes { get; set; }
        public char Estatus { get; set; }
    }
}

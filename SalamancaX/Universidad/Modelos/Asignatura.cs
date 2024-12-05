using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Modelos
{
    public class Asignatura
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Unidades_credito { get; set; }
        public int Horas_teoria { get; set; }
        public int Horas_practica { get; set; }
        public int Semestre { get; set; }
        public virtual ICollection<Seccion> Secciones { get; set; }
        public virtual ICollection<Carrera> Carreras { get; set; }
        public char Estatus { get; set; }
    }
}

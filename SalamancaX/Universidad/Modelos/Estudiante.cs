using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad.Modelos
{
    public class Estudiante
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha_nacimiento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public virtual Carrera Carrera { get; set; }
        public virtual ICollection<Seccion> Secciones { get; set; }
        public char Estatus { get; set; }
    }
}

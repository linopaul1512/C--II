using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDebug
{
    public class Guardaparques
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public override string ToString()
        {
            return $"Cédula: {Cedula}\nNombre: {Nombre}\nFecha de Nacimiento: {FechaNacimiento.ToString("dd/MM/yyyy")}\n\n";
        }
    }
}

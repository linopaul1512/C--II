using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas
{
    public class Mascota
    {
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public double Peso { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public override string ToString()
        {
            return $"MASCOTA:\nNombre: {Nombre}\nEspecie: {Especie}\nPeso: {Peso} kg\nFecha de Nacimiento: {FechaNacimiento.ToString("dd/MM/yyy")}\n";
        }
    }
}

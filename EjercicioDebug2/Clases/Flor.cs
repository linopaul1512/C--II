using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDebug2.Clases
{
    public class Flor
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }

        public string Temporada;
        public string Olor { get; set; }

        [System.ComponentModel.DisplayName("# Pétalos")]
        public int CantidadPetalos { get; set; }
    }
}

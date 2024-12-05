using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace EjercicioDebug
{
    public class Parque
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Ubicacion { get; set; }
        public int Telefono { get; set; }
        public Guardaparques guardaparques { get; set; }

        public override string ToString()
        {
            return $"PARQUE\nCódigo: {Codigo}\nNombre: {Nombre}\nUbicación: {Ubicacion}\nTeléfono: {Telefono}\nGuardaparques: {guardaparques}";
        }
    }
}

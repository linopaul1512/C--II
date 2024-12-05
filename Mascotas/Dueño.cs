using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mascotas
{
    public class Dueño
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public int CantidadMaximaMascotas { get; set; }
        public string Telefono { get; set; }
        public List<Mascota> Mascotas { get; set; }

        public string ListarMascotas()
        {
            string lista = "";
            foreach (var mascota in Mascotas)
            {
                lista += $"{mascota}\n";
            }
            return lista;
        }

        public override string ToString()
        {
            return $"D U E Ñ O\nCédula:{Cedula}\nNombre:{Nombre}\n" +
                $"Fecha de Nacimiento: {FechaNacimiento.ToString("dd/MM/yyy")}\nDirección: {Direccion}\n" +
                $"Máximo de Mascotas: {CantidadMaximaMascotas}\nTeléfono: {Telefono}\n\nM A S C O T A S:\n{ListarMascotas()}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace EjercicioDebug2.Clases
{
    public static class FlorRepositorio
    {
        const string FILENAME = "flores.json";

        public static List<Flor> ListarFlores()
        {
            try
            {
                string floresJSON = File.ReadAllText(FILENAME);
                return JsonSerializer.Deserialize<List<Flor>>(floresJSON);
            } catch (FileNotFoundException)
            {
                return new List<Flor>();
            }
        }

        public static void GuardarLista(List<Flor> flores)
        {
            string floresJSON = JsonSerializer.Serialize(flores);
            File.WriteAllText(FILENAME, floresJSON);
        }

        public static void AgregarFlor(Flor flor)
        {
            var lista = ListarFlores();
            lista.Add(flor);
            GuardarLista(lista);
        }

        public static void ModificarFlor(Flor flor)
        {
            var lista = ListarFlores();
            int indice = lista.FindIndex(f => f.Codigo == flor.Codigo);
            lista[indice] = flor;
            GuardarLista(lista);
        }

        public static void EliminarFlor(string codigo)
        {
            var lista = ListarFlores();
            int indice = lista.FindIndex(f => f.Codigo == codigo);
            lista.RemoveAt(indice);
            GuardarLista(lista);
        }

        public static Flor ConsultarFlor(string codigo)
        {
            var lista = ListarFlores();
            int indice = lista.FindIndex(f => f.Codigo == codigo);
            return lista[indice];
        }
    }
}

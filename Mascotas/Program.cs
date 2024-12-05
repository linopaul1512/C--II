using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Mascotas
{
    class Program
    {
        static List<Dueño> Dueños = new List<Dueño>();
        static void Main(string[] args)
        {

            //ImprimirDueños(Dueños);
            /*int numberofownerswith3pets = Dueños.Where(x => x.Mascotas.Count == 3).Count();
            Console.WriteLine("\n Number of owners with 3 pets: " + numberofownerswith3pets);
            Console.ReadKey();


            var petsOver5Kg = Dueños.Where(x => x.Mascotas.Count(n => n.Nombre.StartsWith('J') && n.Peso > 5) != 0);
            List<Mascota> petsOver5Kg_list = new List<Mascota>();
            
            foreach (var pet in petsOver5Kg)
            {
                petsOver5Kg_list.AddRange(pet.Mascotas.Where(m => );
            }
            Console.WriteLine("List of pets weighing more than 5 kilos and whose name begins with J\n");
            foreach (var listX in petsOver5Kg_list)
                Console.WriteLine(listX.ToString());
            Console.ReadKey();

            /*Console.WriteLine("/n First owner  with  BirthDate on 9/10/2009: ");
            var marchowner = Dueños.FirstOrDefault(x => x.FechaNacimiento.ToString("dd/MM/yyyy")== "9/10/2009");
            Console.WriteLine(marchowner.ToString());
            Console.ReadKey();
            Console.WriteLine("/*****************************************");
            Console.WriteLine("/*****************************************");
            var x = petsOver5Kg_list.OrderBy(x => x.Peso).ThenBy(n => n.FechaNacimiento).ToList();
            foreach (var listX in x)
                Console.WriteLine(listX.ToString());
            Console.ReadKey();
            Console.WriteLine("/*****************************************");
            Console.WriteLine("\n Average number of pets owned by minors \n");
            Console.WriteLine("/*****************************************");
            var underageowners = Dueños.Where(x => x.FechaNacimiento.Year < (DateTime.Now.Year - 18));
            List<Mascota> kidspets_list = new();
            foreach (var owner in underageowners)
                kidspets_list.AddRange(owner.Mascotas);
            foreach (var element in kidspets_list)
                Console.WriteLine(element.ToString());
            */
            /*Console.WriteLine("1) All Pets:***************\n");
            PetsPrint(AllPets());
            Console.ReadKey();*/

            /*Console.WriteLine("********************************************************");
            Console.WriteLine("********************************************************");
            Console.WriteLine("2) All owners whose names begin with G:***************\n");
            ImprimirDueños(ownerswhose_NamesBeginWithG());
            Console.ReadKey();*/

            //Cantidad de dueños con un gato o más
            Console.WriteLine("********************************************************");
            Console.WriteLine("********************************************************");
            Console.WriteLine("1) Number of owners with one cat or more: ***************\n");
            Console.WriteLine(Numberownerswithonecatormore());
            Console.ReadKey();

        }

        static List<Dueño> CargarDueños()
        {
            string texto = File.ReadAllText("data.json");
            return JsonSerializer.Deserialize<List<Dueño>>(texto);
        }


        static List<Mascota> AllPets()
        {
            List<Mascota> pets = new();
            foreach (var owner in CargarDueños())
                pets.AddRange(owner.Mascotas);
            return pets;
        }
        static void PetsPrint(List<Mascota> pets)
        {
            foreach (var pet in pets)
                Console.WriteLine(pet.ToString());
        }
        static List<Dueño> ownerswhose_NamesBeginWithG()
        {
            return CargarDueños().Where(d => d.Nombre.StartsWith("G")).ToList();
        }

        static int Numberownerswithonecatormore()
        {
            return CargarDueños().Count(n => n.Mascotas.Count(x => x.Especie == "Gato")!=0);
        }
        /*static List<Mascota> AllPest()
        {
            //PARA RECORRER LAS MASCOTAS DE CADA DUEÑO
            List<Mascota> pets = new();
            foreach (var owner in CargarDueños())            
                pets.AddRange(owner.Mascotas);
            return pets;

            Console.WriteLine("1) All Pets \n");
            ImprimirMascotas(AllPest());
            Console.ReadKey();

        }*/
        static void ImprimirDueños(List<Dueño> dueños)
        {
            foreach (var dueño in dueños)
              Console.WriteLine(dueño);
            
        }
        static void ImprimirMascotas(List<Mascota> mascotas)
        {
            foreach (var mascota in mascotas)
                Console.WriteLine(mascota);

        }
    }
}

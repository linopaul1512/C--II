using System;
using System.Collections.Generic;

namespace EjercicioDebug
{
    class Program
    {
        static List <Parque> parques;

        static void Main(string[] args)
        {
            parques = new List<Parque>();
            Menu();
        }

        static void Menu()
        {
            int resp = 1;
            bool exception = false;
            Console.WriteLine("Welcome to the program!\nWe are going to add parks.");
            do
            {
                Guardaparques guardaparques = new Guardaparques();
                Parque parque = new Parque();
                parque.guardaparques = guardaparques;
                Console.WriteLine("First, the park ranger.\nEnter your ID:");
                guardaparques.Cedula = Console.ReadLine();
                Console.WriteLine("Enter your name:");
                guardaparques.Nombre = Console.ReadLine();

                try
                {
                    Console.WriteLine("Enter your date of birth:\n(Format dd/mm/yyyy)\n");
                    guardaparques.FechaNacimiento = DateTime.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Date format error: " + e);
                    do
                    {
                        Console.WriteLine("Enter your date of birth:\n(Format dd/mm/yyyy)\n");

                        try
                        {
                            guardaparques.FechaNacimiento = DateTime.Parse(Console.ReadLine());
                            exception = false;
                        }
                        catch (Exception eX) { exception = true; }
                    }
                    while (exception);
                }
            

                Console.WriteLine("Now with the park. Enter your code:");
                parque.Codigo = Console.ReadLine();
                Console.WriteLine("Enter your name:");
                parque.Nombre = Console.ReadLine();
                Console.WriteLine("Enter your location:");
                parque.Ubicacion = Console.ReadLine();
                Console.WriteLine("Enter your phone:");
                parque.Telefono = Int32.Parse(Console.ReadLine());
                parques.Add(parque);
                Console.WriteLine("¡Park successfully registered! Do you want to add another one?\n[1] Yes [2] No");
                resp = int.Parse(Console.ReadLine());
            } while (resp ==1);
            ImprimirParques();
        }

        static void ImprimirParques()
        {
            Console.Clear();
            Console.WriteLine("Ready! Now, the parks are:");

            foreach (var parque in parques)
            {
                Console.WriteLine(parque);
                Console.WriteLine("____________________________________________");
            }

            Console.WriteLine("¡See you soon!");
            Console.ReadKey();
        }
    }
}

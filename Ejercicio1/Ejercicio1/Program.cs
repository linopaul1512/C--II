using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x, y;
            Console.WriteLine("Please enter number #1 ");
            x = Console.ReadLine();
            Console.WriteLine("Please enter number #2 ");
            y = Console.ReadLine();
            Console.ReadKey();
            try
            {
                Console.WriteLine("The result of the division is: " +
                    int.Parse(x) / int.Parse(y));

            }

            catch(Exception)
            {
                Console.WriteLine("Cannot be division by 0: ");
                Console.WriteLine("please! try again");
            }
            finally
            {

            }
            Console.ReadKey();

        
        }


        /*static void Main(string[] args)
        {
            try
            {
                List<string> test = new List<string>();
                Console.WriteLine(test[0]);
            }

            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Error: " + e);
            }
        }
         */


        /*static void Main(string[] args)
        {
            try
            {
                int x = 16;
                int y = 0;
                Console.WriteLine(x / y);
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception Controled: " + e);
                Console.ReadLine();
            }*/
        }
}

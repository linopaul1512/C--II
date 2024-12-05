using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Ejercicio_estudiante
{
    internal class Program
    {
        static class Logger
        {
            public static string LogError(Exception exception)
            {
                string message = string.Format("Date: {0}", DateTime.Now.ToString("dd/mm/yyyy hh:mm:ss"));
                message += Environment.NewLine;
                message += "----------------------------------------------------------------------------";
                message += Environment.NewLine;
                message += string.Format("Message: {0}", exception.Message);
                message += Environment.NewLine;
                message += string.Format("StackTrace: {0}", exception.StackTrace);
                string path = AppContext.BaseDirectory + "/error2.log";
                StreamWriter writer = new StreamWriter(path, true);
                writer.WriteLine(message);
                return message;
            }
        }
        class ageOutofRangeException : Exception
        {
            public ageOutofRangeException(int x)
            {
                if (x < 18)
                    throw new ageOutofRangeException("the age cannot be less than 18 years old");
            }
            public ageOutofRangeException(string message) : base(message) { }
            public ageOutofRangeException(string message, Exception inner) : base(message, inner) { }
        }
        class Student
        {
            public string name { get; set; }
            private int _age { get; set; }

            public int age
            {
                get { return _age; }
                /*set { 
                    if (value < 18) throw
                            //new ArgumentOutOfRangeException("the age cannot be less than 18 years old");
                            new ageOutofRangeException("the age cannot be less than 18 years old");
                    _age = value;
                }*/
                set { _age = value; }
            }
            public override string ToString()
            {
                return $"{this.name} with {this.age} age";
            }
        }

        static void Main(string[] args)
        {
            int agex;
            string namex;
            //string path;
            //path = AppContext.BaseDirectory + "/error.log";
            //StreamWriter writer = new StreamWriter(path, true);
            //ageOutofRangeException varx;
            Console.WriteLine("Enter the name of the student: ");
            namex = Console.ReadLine();
            Console.WriteLine("Enter the nage of the student: ");
            agex = int.Parse(Console.ReadLine());

            Student studentx = new Student()
            {
                name = namex,
                age = agex
            };

            try
            {

                ageOutofRangeException varx = new ageOutofRangeException(studentx.age);
                Console.WriteLine(studentx);
                Console.ReadKey();
            }
            catch (ageOutofRangeException e)
            {
                Console.WriteLine("menor of age!!!" + e);
                Logger.LogError(e);
                //writer.WriteLine(e.ToString());
                //writer.Close();
                Console.ReadKey();
            }
        }
    }
}

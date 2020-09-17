using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Nathan Stratford";
            Console.Write("Please enter your full name: ");
            name = Console.ReadLine();

            string location = "Rexburg, ID";

            Console.WriteLine("Please enter your location: ");
            location = Console.ReadLine();

            Console.WriteLine($"Your name is  {name}");
            Console.WriteLine("Your location is " + location);

            var currentDate = DateTime.Now;
            Console.WriteLine("The current date is: " + currentDate.ToShortDateString());

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}

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

            Console.Write("Please enter your location: ");
            location = Console.ReadLine();

            Console.WriteLine($"Your name is  {name}");
            Console.WriteLine("Your location is " + location);

            var currentDate = DateTime.Now;
            Console.WriteLine("The current date is: " + currentDate.ToShortDateString());
           
            var christmas = new DateTime(2020, 12, 25);
            var span = christmas - currentDate;
            var daysToChristmas = span.Days;

            Console.WriteLine("There are " + daysToChristmas + " days left until Christmas!");

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("Please enter width(in meters): ");
            widthString = Console.ReadLine();

            width = double.Parse(widthString);

            Console.Write("Please enter height(in meters: ");

            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");

            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}

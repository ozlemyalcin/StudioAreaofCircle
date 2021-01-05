using System;

namespace StudioAreaOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a radius: ");
            string userInput = Console.ReadLine();
            double radius = double.Parse(userInput);

            double pi = 3.14;

            double areaOfCircle = (pi * radius * radius);

            Console.WriteLine("The area of a circle of radius " + radius + " is: " + areaOfCircle);


        }
    }
}

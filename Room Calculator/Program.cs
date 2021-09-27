using System;

namespace Room_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            do
            {
                done = false;
                Console.WriteLine("Please enter the width of the room in feet.");
                double width = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the length of the room in feet.");
                double length = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the height of the room in feet.");
                double height = double.Parse(Console.ReadLine());

                double perimeter = length * 2 + width * 2;
                double area = length * width;
                double volume = length * width * height;

                double paint = perimeter / 5;
                double carpet = area / 5;

                Console.WriteLine($"For a classroom that is {width} feet wide, {length} ft long, and {height} feet high, it will have a perimeter of {perimeter} feet, an area of {area} sq ft, and a volume of {volume} ft cubed.");
                Console.WriteLine($"You will need {paint} cans of paint, and {carpet} carpet tiles.");

                Console.WriteLine("Would you like to input another room? yes or no");
                string input = Console.ReadLine();

                if (input.ToLower() == "yes"||input.ToLower() == "y")
                {
                    done = true;
                }
                else
                {
                    done = false;
                }

            } while ( done == true);
        }
    }
}

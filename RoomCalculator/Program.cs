using System;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)

        {
            Start:
            Console.WriteLine("Welcome to the Room Calculator");

            Console.WriteLine("Please input a length?");
            string input = Console.ReadLine();
            double length = double.Parse(input);

            Console.WriteLine("Thank you, now input a width");
            string input2 = Console.ReadLine();
            double width = double.Parse(input2);


            double area = length * width;
            double perimeter = 2 * (length) + 2 * (width);

            Console.WriteLine("The Area is:" + area);
            Console.WriteLine("The Perimeter is:" + perimeter);

            double paint = perimeter / 5;
            double carpet = area / 5;

            Console.WriteLine("The amount of paint containers you will need is:" + paint);
            Console.WriteLine("& the amount of carpet squares you will need is:" + carpet);

            Console.WriteLine("Would you like to keep measuring rooms?");

            string userInput = Console.ReadLine();

            if (userInput == "yes")
            {
                Console.WriteLine("Great!");
                goto Start;
            }
            else
            {
                Console.WriteLine("Thank you Goodbye!");
            }
        }
    }
}

using System;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userContinue = true;
            while (userContinue)
            {

                Console.WriteLine("Welcome to the Room Size Calculator!");
                Console.WriteLine("Enter room length: ");
                string userInput = Console.ReadLine();
                decimal length = decimal.Parse(userInput);

                Console.WriteLine("Enter room width: ");
                userInput = Console.ReadLine();
                decimal width = decimal.Parse(userInput);

                Console.WriteLine("Enter room height: ");
                userInput = Console.ReadLine();
                decimal height = decimal.Parse(userInput);
                decimal area = (length * width);
                decimal perimeter = ((length * 2) + (width * 2));
                decimal volume = (length * width * height);

                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);
                Console.WriteLine("Volume: " + volume);

                Console.WriteLine("Continue? y/n");
                string continueInput = Console.ReadLine();
                if (continueInput == "n")
                {
                    userContinue = false;
                    Console.WriteLine("Thank you, enjoy your measurements.");
                }
            }
        }
    }
}

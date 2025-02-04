using System;

namespace BasicCSharp
{
    class Program
    {
        // This is the main method, where the program starts
        static void Main(string[] args)
        {
            // Print a greeting message to the user
            Console.WriteLine("Hello, World!");

            // Declare and initialize some variables
            int number1 = 10;
            int number2 = 5;

            // Perform an addition operation
            int sum = number1 + number2;

            // Print the result of the addition
            Console.WriteLine("Sum of " + number1 + " and " + number2 + " is: " + sum);

            // Take user input
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            // Greet the user with their name
            Console.WriteLine("Hello, " + userName + "! Welcome to the C# world!");

            // Wait for the user to press a key before closing
            Console.ReadKey();
        }
    }
}

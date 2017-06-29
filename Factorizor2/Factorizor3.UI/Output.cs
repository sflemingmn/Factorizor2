using System;
using System.Linq;

namespace Factorizor3.UI
{
    class Output
    {
        public static void Results(int num, int[] factors, bool prime, bool perfect)
        {
            Console.WriteLine($"The factores of {num} are {String.Join(", ", factors)}.");
            Console.WriteLine($"{num} is a prime number - {prime}.");
            Console.WriteLine($"{num} is a perfect number - {perfect}.");
            Console.WriteLine("Press any key to close this screen.");
            Console.ReadLine();
        }

        public static void PromptUserForNumber()
        {
            Console.WriteLine("Please enter a valid number.");
        }

        internal static void InvalidInput()
        {
            Console.WriteLine("That is not a number!");
        }
    }
}
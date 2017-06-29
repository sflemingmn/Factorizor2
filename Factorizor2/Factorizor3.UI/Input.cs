using System;

namespace Factorizor3.UI
{
    internal class Input
    {
        public static int GetNumberFromUser()
        {
            string input;
            int output;

            while (true)
            {
                Output.PromptUserForNumber();
                input = Console.ReadLine();

                if (int.TryParse(input, out output))
                    break;
                Output.InvalidInput();
            }
            return output;
        }
    }
}
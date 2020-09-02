using System;
using Task0Lib;

namespace Task01
{
    public class EventGuide2
    {
        public static void Main()
        {
            do
            {
                var input = new Input();
                input.UserInput += Dialog;
                input.GetUserInput();

                Console.WriteLine("\n\nTo exit press Escape key" +
                    "\nTo continue press any key . . .");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        /// <summary>
        /// Echo dialog with user (method for event in Input class)
        /// </summary>
        private static void Dialog(string message)
        {
            if (message == "q")
                Console.WriteLine("You typed 'q' to quit");
            else
                Console.WriteLine($"You typed: {message}");
        }
    }
}
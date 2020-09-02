using System;

namespace Task0Lib
{
    public class Input
    {
        public void GetUserInput()
        {
            while (true)
            {
                Console.WriteLine("Type any characters or 'q' to quit and press Enter.");
                string input = Console.ReadLine();
                UserInput(input);
                if (input.Trim() == "q")
                    break;
            }
        }

        public delegate void Notify(string input);

        public event Notify UserInput;
    }
}
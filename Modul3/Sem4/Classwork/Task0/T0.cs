using System;
using Task0Lib;

namespace Task0
{
    public class T0
    {
        private static void StartOutputCallBack(string message)
        {
            Console.WriteLine($"StartOutputCallBack - {message}");
        }

        private static void EndOutputCallBack(string message)
        {
            Console.WriteLine($"EndOutputCallBack - {message}");
        }

        public static void Main()
        {
            var publisher = new Publisher();
            do
            {
                Console.Clear();

                publisher.BeginOutput += StartOutputCallBack;
                publisher.EndOutput += EndOutputCallBack;
                publisher.Display("I am subscriber!");
                publisher.BeginOutput -= StartOutputCallBack;
                publisher.EndOutput -= EndOutputCallBack;
                publisher.Display("I am not subscriber");

                Console.WriteLine("\n\nTo exit press Escape key" +
                    "\nTo continue press any key . . .");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
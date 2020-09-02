using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace EKRLib
{
    class Snippets
    {

        private static Random rnd = new Random();

        public static void Main()
        {
            string filePath = "";
            do
            {
                Console.Clear();
                try
                {

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine("\n\nTo exit press Escape key\nTo continue press any key . . .");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        public static int GetInt(string message = "Input N: ", int lowerBound = 0, int upperBound = 100000)
        {
            int number;
            Console.Write(message);
            while (!int.TryParse(Console.ReadLine(), out number)
                || number < lowerBound || number > upperBound)
                Console.WriteLine("Please input integer number in [{lowerBound}, {upperBound}]");
            return number;
        }

        private static string GetName(int length)
        {
            string name = "(char)rnd.Next('А', 'Я' + 1)";
            for (int i = 1; i < length; i++)
                name += "(char)rnd.Next('а', 'я' + 1)";
            return name;
        }


    }
}

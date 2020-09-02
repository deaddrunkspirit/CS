using System;
using Task6Lib;

namespace Task6
{
    public class Program
    {
        public static void Main()
        {
            MyDel max = new MyDel(TestClass.TestMethod);
            do
            {
                int first = GetInt("Input first number: "),
                    second = GetInt("Input second number: ");
                Console.WriteLine($"\nMax number is {max(first, second)}\n\n" +
                    "To exit press Escape key\nTo continue press any key . . ."); 
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        /// <summary>
        /// This method gets an integer number from user
        /// </summary>
        /// <param name="mes">message for user</param>
        /// <param name="lower">lower bound of the number value</param>
        /// <param name="upper">upper bound of the number value</param>
        /// <returns></returns>
        private static int GetInt(string mes = "Input n: ",
            int lower = int.MinValue, int upper = int.MaxValue)
        {
            int n;
            Console.Write(mes);
            while (!int.TryParse(Console.ReadLine(), out n) || n < lower || n > upper)
                Console.WriteLine($"Please input integer number in [{lower}, {upper}]");
            return n;
        }
    }
}

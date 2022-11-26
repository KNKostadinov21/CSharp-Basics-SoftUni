using System;

namespace _07._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int minNumber = int.MaxValue;

            while (input != "Stop")
            {
                int currentNumber = int.Parse(input);
                if (currentNumber < minNumber)
                {
                    minNumber = currentNumber;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{minNumber}");
        }
    }
}
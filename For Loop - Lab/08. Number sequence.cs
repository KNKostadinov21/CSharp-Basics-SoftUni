using System;

namespace _08._Number_sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minNumber = int.MaxValue;
            int maxNumber = int.MinValue;
            int numbers = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers; i++)
            {
                int chosenNumber = int.Parse(Console.ReadLine());
                if(chosenNumber < minNumber)
                {
                    minNumber = chosenNumber;
                }
                if(chosenNumber > maxNumber)
                {
                    maxNumber = chosenNumber;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
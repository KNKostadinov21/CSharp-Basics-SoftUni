using System;

namespace _02._Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumAll = 0;
            int maxNumber = int.MinValue;

            for(int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sumAll += number;
                if(number > maxNumber)
                {
                    maxNumber = number;
                }
            }

            int sumWithoutMaxNumber = sumAll - maxNumber;
            if(maxNumber == sumWithoutMaxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNumber}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxNumber - sumWithoutMaxNumber)}");
            }
        }
    }
}
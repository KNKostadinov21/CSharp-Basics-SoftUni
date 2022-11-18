using System;

namespace _09._Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumFirstNumbers = 0;
            int sumSecondNumbers = 0;
            for (int i = 0; i < n; i++)
            {
                int firstNumbers = int.Parse(Console.ReadLine());
                sumFirstNumbers += firstNumbers;
            }
            for (int j = 0; j < n; j++)
            {
                int secondNumbers = int.Parse(Console.ReadLine());
                sumSecondNumbers += secondNumbers;
            }

            if(sumFirstNumbers == sumSecondNumbers)
            {
                Console.WriteLine($"Yes, sum = {sumFirstNumbers}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sumFirstNumbers - sumSecondNumbers)}");
            }
        }
    }
}
using System;

namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int goalNumber = int.Parse(Console.ReadLine());
            int sumOfAllNumbers = 0;
            
            while(sumOfAllNumbers < goalNumber)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sumOfAllNumbers += currentNumber;
            }

            Console.WriteLine(sumOfAllNumbers);
        }
    }
}
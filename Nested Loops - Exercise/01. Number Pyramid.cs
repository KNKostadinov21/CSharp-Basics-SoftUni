using System;

namespace _01._Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numbersToPrintInRow = 1;
            int currentNumber = 1;

            while(currentNumber <= number)
            {
                for (int i = 0; i < numbersToPrintInRow; i++)
                {
                    Console.Write($"{currentNumber} ");
                    currentNumber++;

                    if (currentNumber > number)
                    {
                        break;
                    }

                }

                Console.WriteLine();
                numbersToPrintInRow++;
            }
        }
    }
}
using System;

namespace _10._Multiply_by_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            while (number >= 0)
            {
                double multipleByTwo = number * 2;
                Console.WriteLine($"Result: {multipleByTwo:F2}");
                number = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Negative number!");
        }
    }
}
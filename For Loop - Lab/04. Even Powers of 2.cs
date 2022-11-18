using System;

namespace _04._Even_Powers_of_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for(int i = 0; i <= number; i += 2)
            {
                Console.WriteLine($"{Math.Pow(2, i)}");
            }
        }
    }
}
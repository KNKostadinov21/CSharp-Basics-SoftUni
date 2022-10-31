using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());
            double Farenheit = degrees * 1.8 + 32;
            Console.WriteLine($"{Farenheit:F2}");
        }
    }
}
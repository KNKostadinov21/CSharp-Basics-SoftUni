using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double Perimeter = 2 * Math.PI * radius;
            double Front = radius * radius * Math.PI;
            Console.WriteLine($"{Front:F2}");
            Console.WriteLine($"{Perimeter:F2}");
        }
    }
}
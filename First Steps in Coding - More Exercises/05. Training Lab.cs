using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());
            height = height * 100;
            weight = weight * 100;
            var h1 = Math.Floor(height / 120);
            var w1 = Math.Floor((weight - 100) / 70);

            var desks = (w1 * h1) - 3;
            Console.WriteLine(desks);
        }
    }
}
using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double points = double.Parse(Console.ReadLine());
            double additionalPoints = 0.0;
            if (points <= 100)
            {
                additionalPoints = 5;
            }
            else if (points > 1000)
            {
                additionalPoints = 0.1 * points;
            }
            else if (points > 100)
            {
                additionalPoints = points * 0.2;
            }
            if (points % 2 == 0)
            {
                additionalPoints += 1;
            }
            else if (points % 10 == 5)
            {
                additionalPoints += 2;
            }
            Console.WriteLine(additionalPoints);
            Console.WriteLine(points + additionalPoints);
        }
    }
}
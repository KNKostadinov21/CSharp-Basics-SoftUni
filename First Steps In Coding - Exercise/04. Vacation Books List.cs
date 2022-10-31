using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int totalTimeForReading = pages / pagesPerHour;
            int neededHours = totalTimeForReading / days;
            Console.WriteLine(neededHours);
        }
    }
}
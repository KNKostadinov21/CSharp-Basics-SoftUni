using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Length = double.Parse(Console.ReadLine());
            double Width = double.Parse(Console.ReadLine());
            double Height = double.Parse(Console.ReadLine());
            double Percentage = double.Parse(Console.ReadLine());
            double Capacity = Length * Width * Height;
            double capacityInLetres = Capacity * 0.001;
            double neededLetres = capacityInLetres * (1 - (Percentage / 100));
            Console.WriteLine(neededLetres);
        }
    }
}
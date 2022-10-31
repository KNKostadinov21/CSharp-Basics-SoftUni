using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chickenMenu = double.Parse(Console.ReadLine());
            double FishMenu = double.Parse(Console.ReadLine());
            double VegetarianMenu = double.Parse(Console.ReadLine());
            double totalSumMenus = (chickenMenu * 10.35) + (FishMenu * 12.4) + (VegetarianMenu * 8.15);
            double sumDesert = totalSumMenus * 0.2;
            double totalSumForAll = totalSumMenus + sumDesert + 2.5;
            Console.WriteLine(totalSumForAll);
        }
    }
}
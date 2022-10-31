using System;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceSkumriqlPerKilogram = double.Parse(Console.ReadLine());
            double priceTsaTsalePerKilogram = double.Parse(Console.ReadLine());
            double palamudKilograms = double.Parse(Console.ReadLine());
            double safridKilograms = double.Parse(Console.ReadLine());
            double clamsKilograms = double.Parse(Console.ReadLine());
            double pricePalamudPerKilogram = priceSkumriqlPerKilogram + priceSkumriqlPerKilogram * 0.6;
            double priceSafridPerKilogram = priceTsaTsalePerKilogram + priceTsaTsalePerKilogram * 0.8;
            double totalSum = (palamudKilograms * pricePalamudPerKilogram) + (clamsKilograms * 7.50) + (safridKilograms * priceSafridPerKilogram);
            Console.WriteLine($"{totalSum:F2}");
        }
    }
}

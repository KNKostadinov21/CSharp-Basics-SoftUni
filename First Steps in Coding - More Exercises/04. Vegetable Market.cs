using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pricePerOneKilogramVegetables = double.Parse(Console.ReadLine());
            double pricePerOneKilogramFruits = double.Parse(Console.ReadLine());
            double kilogramsVegetables = double.Parse(Console.ReadLine());
            double kilogramsFruits = double.Parse(Console.ReadLine());
            double totalPriceVegetagbles = pricePerOneKilogramVegetables * kilogramsVegetables;
            double totalPriceFruits = pricePerOneKilogramFruits * kilogramsFruits;
            double totalPrice = (totalPriceFruits + totalPriceVegetagbles) / 1.94;
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
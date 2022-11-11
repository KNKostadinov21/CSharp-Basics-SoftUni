using System;

namespace _06._Flower_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Magnolias = int.Parse(Console.ReadLine());
            int Hyacinths = int.Parse(Console.ReadLine());
            int Roses = int.Parse(Console.ReadLine());
            int Cacti = int.Parse(Console.ReadLine());
            double pricePresent = double.Parse(Console.ReadLine());
            double earnedSum = (Magnolias * 3.25) + (Hyacinths * 4) + (Roses * 3.50) + (Cacti * 8);
            double taxes = earnedSum * 0.05;
            double totalSum = earnedSum - taxes;
            if(totalSum >= pricePresent)
            {
                Console.WriteLine($"She is left with {Math.Floor(Math.Abs(pricePresent - totalSum))} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(Math.Abs(pricePresent - totalSum))} leva.");
            }
        }
    }
}

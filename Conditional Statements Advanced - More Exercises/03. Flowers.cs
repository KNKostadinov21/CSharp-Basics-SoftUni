using System;

namespace _03._Flowers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemums = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();
            double totalPriceChrysanthemums = 0;
            double totalPriceRoses = 0;
            double totalPriceTulips = 0;

            switch (season)
            {
                case "Spring":
                case "Summer":
                    totalPriceChrysanthemums = chrysanthemums * 2.00;
                    totalPriceRoses = roses * 4.10;
                    totalPriceTulips = tulips * 2.50;
                    break;
                case "Autumn":
                case "Winter":
                    totalPriceChrysanthemums = chrysanthemums * 3.75;
                    totalPriceRoses = roses * 4.50;
                    totalPriceTulips = tulips * 4.15;
                    break;
            }

            double totalPriceAll = totalPriceChrysanthemums + totalPriceRoses + totalPriceTulips;

            if (roses >= 10 && season == "Winter")
            {
                totalPriceAll = totalPriceAll - (totalPriceAll * 0.10);
            }
            else if (tulips > 7 && season == "Spring")
            {
                totalPriceAll = totalPriceAll - (totalPriceAll * 0.05);
            }
            if ((tulips + roses + chrysanthemums) > 20)
            {
                totalPriceAll = totalPriceAll - (totalPriceAll * 0.20);
            }
            if (holiday == "Y")
            {
                totalPriceAll = totalPriceAll + (totalPriceAll * 0.15);
            }

            Console.WriteLine($"{(totalPriceAll + 2):F2}");
        }
    }
}
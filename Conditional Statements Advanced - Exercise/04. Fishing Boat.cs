using System;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishers = int.Parse(Console.ReadLine());
            double price = 0;
            switch (season)
            {
                case "Spring":
                    price = 3000;
                    break;
                case "Summer":
                    price = 4200;
                    break;
                case "Autumn":
                    price = 4200;
                    break;
                case "Winter":
                    price = 2600;
                    break;
            }
            if (fishers <= 6)
            {
                price = price - (price * 0.10);
            }
            else if (fishers >= 7 && fishers <= 11)
            {
                price = price - (price * 0.15);
            }
            else if (fishers > 12)
            {
                price = price - (price * 0.25);
            }
            if (fishers % 2 == 0)
            {
                if (season != "Autumn")
                {
                    price = price - (price * 0.05);
                }
            }
            if(budget >= price)
            {
                Console.WriteLine($"Yes! You have {Math.Abs(budget - price):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(budget - price):F2} leva.");
            }
        }
    }
}
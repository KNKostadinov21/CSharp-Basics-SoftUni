using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceExcursion = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int speakingDolls = int.Parse(Console.ReadLine());
            int plushyBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double totalSum = (puzzles * 2.60) + (speakingDolls * 3) + (plushyBears * 4.1) + (minions * 8.20) + (trucks * 2);
            double totalCount = puzzles + speakingDolls + plushyBears + minions + trucks;
            if (totalCount >= 50)
            {
                totalSum = totalSum - (totalSum * 0.25);
            }
            double rent = totalSum * 0.1;
            double earnings = totalSum - rent;
            if (earnings >= priceExcursion)
            {
                double remainingMoney = totalSum - (rent + priceExcursion);
                Console.WriteLine($"Yes! {remainingMoney:F2} lv left.");
            }
            if (earnings < priceExcursion)
            {
                double neededMoney = priceExcursion - earnings;
                Console.WriteLine($"Not enough money! {neededMoney:F2} lv needed.");
            }
        }

    }
}
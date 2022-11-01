using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double clothesPerOneStatists = double.Parse(Console.ReadLine());
            double sumDecoration = budget * 0.10;
            double sumAllClothes;
            double totalSum;
            if (statists > 150)
            {
                sumAllClothes = (clothesPerOneStatists * statists) - (clothesPerOneStatists * statists * 0.1);
            }
            else
            {
                sumAllClothes = clothesPerOneStatists * statists;
            }
            totalSum = sumDecoration + sumAllClothes;
            if (budget >= totalSum)
            {
                double extraMoney = budget - totalSum;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {extraMoney:F2} leva left.");
            }
            else
            {
                double neededMoney = totalSum - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {neededMoney:F2} leva more.");
            }
        }
    }
}

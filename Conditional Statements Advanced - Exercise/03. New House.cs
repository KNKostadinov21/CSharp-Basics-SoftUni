using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());
            double neededSum = 0;

            switch(flowers)
            {
                case "Roses":
                    neededSum = amount * 5;
                    if(amount > 80)
                    {
                        neededSum = neededSum - (neededSum * 0.10);
                    }
                    break;
                case "Dahlias":
                    neededSum = amount * 3.80;
                    if(amount > 90)
                    {
                        neededSum = neededSum - (neededSum * 0.15);
                    }
                    break;
                case "Tulips":
                    neededSum = amount * 2.80;
                    if(amount > 80)
                    {
                        neededSum = neededSum - (neededSum * 0.15);
                    }
                    break;
                case "Narcissus":
                    neededSum = amount * 3;
                    if(amount < 120)
                    {
                        neededSum = neededSum + (neededSum * 0.15);
                    }
                    break;
                case "Gladiolus":
                    neededSum = amount * 2.50;
                    if(amount < 80)
                    {
                        neededSum = neededSum + (neededSum * 0.20);
                    }
                    break;
            }
            if(budget >= neededSum)
            {
                Console.WriteLine($"Hey, you have a great garden with {amount} {flowers} and {Math.Abs(budget - neededSum):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(budget - neededSum):F2} leva more.");
            }
        }
    }
}
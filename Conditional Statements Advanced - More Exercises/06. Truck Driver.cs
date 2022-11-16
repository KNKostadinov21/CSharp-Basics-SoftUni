using System;

namespace _06._Truck_Driver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            int kilometersPerMonth = int.Parse(Console.ReadLine());
            double earnedSum = 0;

            switch(season)
            {
                case "Spring":
                case "Autumn":
                    if(kilometersPerMonth <= 5000)
                    {
                        earnedSum = (kilometersPerMonth * 0.75) * 4;
                    }
                    else if(kilometersPerMonth > 5000 && kilometersPerMonth <= 10000)
                    {
                        earnedSum = (kilometersPerMonth * 0.95) * 4;
                    }
                    else if(kilometersPerMonth > 10000 && kilometersPerMonth <= 20000)
                    {
                        earnedSum = (kilometersPerMonth * 1.45) * 4;
                    }
                    break;
                case "Summer":
                    if (kilometersPerMonth <= 5000)
                    {
                        earnedSum = (kilometersPerMonth * 0.90) * 4;
                    }
                    else if (kilometersPerMonth > 5000 && kilometersPerMonth <= 10000)
                    {
                        earnedSum = (kilometersPerMonth * 1.10) * 4;
                    }
                    else if (kilometersPerMonth > 10000 && kilometersPerMonth <= 20000)
                    {
                        earnedSum = (kilometersPerMonth * 1.45) * 4;
                    }
                    break;
                case "Winter":
                    if (kilometersPerMonth <= 5000)
                    {
                        earnedSum = (kilometersPerMonth * 1.05) * 4;
                    }
                    else if (kilometersPerMonth > 5000 && kilometersPerMonth <= 10000)
                    {
                        earnedSum = (kilometersPerMonth * 1.25) * 4;
                    }
                    else if (kilometersPerMonth > 10000 && kilometersPerMonth <= 20000)
                    {
                        earnedSum = (kilometersPerMonth * 1.45) * 4;
                    }
                    break;
            }

            earnedSum = earnedSum - (earnedSum * 0.10);
            Console.WriteLine($"{earnedSum:F2}");
        }
    }
}
using System;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double sum = 0;
            string destination = "";
            string type = "";
            if (budget <= 100)
            {
                switch (season)
                {
                    case "summer":
                        sum = budget * 0.30;
                        type = "Camp";
                        destination = "Bulgaria";
                        break;
                    case "winter":
                        sum = budget * 0.70;
                        type = "Hotel";
                        destination = "Bulgaria";
                        break;
                }
            }
            else if (budget <= 1000)
            {
                switch (season)
                {
                    case "summer":
                        sum = budget * 0.40;
                        type = "Camp";
                        destination = "Balkans";
                        break;
                    case "winter":
                        sum = budget * 0.80;
                        type = "Hotel";
                        destination = "Balkans";
                        break;
                }
            }
            else if (budget > 1000)
            {
                switch (season)
                {
                    case "summer":
                    case "winter":
                        sum = budget * 0.90;
                        type = "Hotel";
                        destination = "Europe";
                        break;
                }
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{type} - {sum:F2}");
        }
    }
}
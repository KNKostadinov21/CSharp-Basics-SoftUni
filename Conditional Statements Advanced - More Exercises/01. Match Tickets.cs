using System;

namespace _01._Match_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());
            double priceTransport = 0;
            double neededMoneyForTickets = 0;

            if (people <= 4)
            {
                priceTransport = budget * 0.75;
            }
            else if(people >= 5 && people <= 9)
            {
                priceTransport = budget * 0.60;
            }
            else if(people >= 10 && people <= 24)
            {
                priceTransport = budget * 0.50;
            }
            else if(people >= 25 && people <= 49)
            {
                priceTransport = budget * 0.40;
            }
            else if(people >= 50)
            {
                priceTransport = budget * 0.25;
            }

            switch(category)
            {
                case "VIP":
                    neededMoneyForTickets = people * 499.99;
                    break;
                case "Normal":
                    neededMoneyForTickets = people * 249.99;
                    break;
            }

            if(budget >= neededMoneyForTickets + priceTransport)
            {
                Console.WriteLine($"Yes! You have {budget - (neededMoneyForTickets + priceTransport):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(budget - (neededMoneyForTickets + priceTransport)):F2} leva.");
            }
        }
    }
}
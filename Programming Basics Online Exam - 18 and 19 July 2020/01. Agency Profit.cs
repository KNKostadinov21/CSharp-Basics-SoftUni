using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string companyName = Console.ReadLine();
            int ticketsAdults = int.Parse(Console.ReadLine());
            int ticketsChildren = int.Parse(Console.ReadLine());
            double sumPerOneTicketAdult = double.Parse(Console.ReadLine());
            double taxaObslujvane = double.Parse(Console.ReadLine());
            double sumPerOneTicketChildren = sumPerOneTicketAdult - (sumPerOneTicketAdult * 0.7) + taxaObslujvane;
            double sumPerTicketAdult = sumPerOneTicketAdult + taxaObslujvane;

            double ticketsAdultsSum = ticketsAdults * sumPerTicketAdult;
            double ticketsChildrenSum = ticketsChildren * sumPerOneTicketChildren;

            double totalSum = ticketsChildrenSum + ticketsAdultsSum;
            double agencyEarn = totalSum / 5;

            Console.WriteLine($"The profit of your agency from {companyName} tickets is {agencyEarn:F2} lv.");
        }
    }
}
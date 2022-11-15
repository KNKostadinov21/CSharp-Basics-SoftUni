using System;

namespace _02._Bike_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juniorBikers = int.Parse(Console.ReadLine());
            int seniorBikers = int.Parse(Console.ReadLine());
            string track = Console.ReadLine();
            double juniorTotalPrice = 0;
            double seniorTotalPrice = 0;

            switch (track)
            {
                case "trail":
                    juniorTotalPrice = juniorBikers * 5.50;
                    seniorTotalPrice = seniorBikers * 7;
                    break;
                case "cross-country":
                    if(juniorBikers + seniorBikers >= 50)
                    {
                        juniorTotalPrice = (juniorBikers * 8) - 0.25 * (juniorBikers * 8);
                        seniorTotalPrice = (seniorBikers * 9.50) - 0.25 * (seniorBikers * 9.50);
                    }
                    else
                    {
                        juniorTotalPrice = juniorBikers * 8;
                        seniorTotalPrice = seniorBikers * 9.50;
                    }
                    break;
                case "downhill":
                    juniorTotalPrice = juniorBikers * 12.25;
                    seniorTotalPrice = seniorBikers * 13.75;
                    break;
                case "road":
                    juniorTotalPrice = juniorBikers * 20;
                    seniorTotalPrice = seniorBikers * 21.50;
                    break;
            }

            double totalPrice = juniorTotalPrice + seniorTotalPrice;
            totalPrice = totalPrice - (0.05 * totalPrice);
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
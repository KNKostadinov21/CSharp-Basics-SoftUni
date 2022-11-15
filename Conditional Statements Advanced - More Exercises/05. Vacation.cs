using System;

namespace _05._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string accomodation = "";
            string location = "";
            double price = 0;

            if(budget <= 1000)
            {
                accomodation = "Camp";
            }
            else if(budget > 1000 && budget <= 3000)
            {
                accomodation = "Hut";
            }
            else if(budget > 3000)
            {
                accomodation = "Hotel";
            }

            switch(season)
            {
                case "Summer":
                    location = "Alaska";
                    if(accomodation == "Camp")
                    {
                        price = budget * 0.65;
                    }
                    else if(accomodation == "Hut")
                    {
                        price = budget * 0.80;
                    }
                    else if(accomodation == "Hotel")
                    {
                        price = budget * 0.90;
                    }
                    break;
                case "Winter":
                    location = "Morocco";
                    if (accomodation == "Camp")
                    {
                        price = budget * 0.45;
                    }
                    else if (accomodation == "Hut")
                    {
                        price = budget * 0.60;
                    }
                    else if (accomodation == "Hotel")
                    {
                        price = budget * 0.90;
                    }
                    break;
            }

            Console.WriteLine($"{location} - {accomodation} - {price:F2}");
        }
    }
}
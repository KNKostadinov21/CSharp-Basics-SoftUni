using System;

namespace _04._Car_To_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string classCar = "";
            string typeCar = "";
            double priceCar = 0;
            if(budget <= 100)
            {
                classCar = "Economy class";
            }
            else if(budget > 100 && budget <= 500)
            {
                classCar = "Compact class";
            }
            else if(budget > 500)
            {
                classCar = "Luxury class";
            }


            switch(season)
            {
                case "Summer":
                    typeCar = "Cabrio";
                    if (classCar == "Economy class")
                    {
                        priceCar = budget * 0.35;
                    }
                    else if (classCar == "Compact class")
                    {
                        priceCar = budget * 0.45;
                    }
                    else
                    {
                        priceCar = budget * 0.90;
                        typeCar = "Jeep";
                    }
                    break;
                case "Winter":
                    typeCar = "Jeep";
                    if (classCar == "Economy class")
                    {
                        priceCar = budget * 0.65;
                    }
                    else if (classCar == "Compact class")
                    {
                        priceCar = budget * 0.80;
                    }
                    else
                    {
                        priceCar = budget * 0.90;
                        typeCar = "Jeep";
                    }
                    break;

            }

            Console.WriteLine($"{classCar}");
            Console.WriteLine($"{typeCar} - {priceCar:F2}");
        }
    }
}
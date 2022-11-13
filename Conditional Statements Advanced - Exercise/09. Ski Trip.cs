using System;

namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string mark = Console.ReadLine();
            int nights = days - 1;
            double priceRoomForOnePerson = 18.00;
            double priceApartment = 25.00;
            double pricePresidentApartment = 35.00;
            double neededSum = 0;

            switch(type)
            {
                case "room for one person":
                    if(nights < 10)
                    {
                        neededSum = nights * priceRoomForOnePerson;
                    }
                    else if(nights >= 10 && nights <= 15)
                    {
                        neededSum = nights * priceRoomForOnePerson;
                    }
                    else if(nights > 15)
                    {
                        neededSum = nights * priceRoomForOnePerson;
                    }
                    break;
                case "apartment":
                    if(nights < 10)
                    {
                        neededSum = (nights * priceApartment) - ((nights * priceApartment) * 0.30);
                    }
                    else if (nights >= 10 && nights <= 15)
                    {
                        neededSum = (nights * priceApartment) - ((nights * priceApartment) * 0.35);
                    }
                    else if (nights > 15)
                    {
                        neededSum = (nights * priceApartment) - ((nights * priceApartment) * 0.50);
                    }
                    break;
                case "president apartment":
                    if (nights < 10)
                    {
                        neededSum = (nights * pricePresidentApartment) - ((nights * pricePresidentApartment) * 0.10);
                    }
                    else if (nights >= 10 && nights <= 15)
                    {
                        neededSum = (nights * pricePresidentApartment) - ((nights * pricePresidentApartment) * 0.15);
                    }
                    else if (nights > 15)
                    {
                        neededSum = (nights * pricePresidentApartment) - ((nights * pricePresidentApartment) * 0.20);
                    }
                    break;
            }

            if(mark == "positive")
            {
                neededSum = neededSum + (neededSum * 0.25);
            }

            else
            {
                neededSum = neededSum - (neededSum * 0.1);
            }

            Console.WriteLine($"{neededSum:F2}");
        }
    }
}
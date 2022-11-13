using System;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            double nights = double.Parse(Console.ReadLine());
            double sumPerNightStudio = 0;
            double sumPerNightApartment = 0;
            double sumStudio = 0;
            double sumApartment = 0;

            switch (month)
            {
                case "May":
                case "October":
                    sumPerNightStudio = 50;
                    sumPerNightApartment = 65;
                    sumStudio = nights * sumPerNightStudio;
                    sumApartment = nights * sumPerNightApartment;
                    if (nights > 7 && nights < 14)
                    {
                        sumStudio = sumStudio - (sumStudio * 0.05);
                    }
                    else if(nights > 14)
                    {
                        sumStudio = sumStudio - (sumStudio * 0.30);
                    }
                    break;
                case "June":
                case "September":
                    sumPerNightStudio = 75.20;
                    sumPerNightApartment = 68.70;
                    sumStudio = nights * sumPerNightStudio;
                    sumApartment = nights * sumPerNightApartment;
                    if (nights > 14)
                    {
                        sumStudio = sumStudio - (sumStudio * 0.20);
                    }
                    break;
                case "July":
                case "August":
                    sumPerNightStudio = 76;
                    sumPerNightApartment = 77;
                    sumStudio = nights * sumPerNightStudio;
                    sumApartment = nights * sumPerNightApartment;
                    break;
            }

            if(nights > 14)
            {
                sumApartment = sumApartment - (sumApartment * 0.10);
            }

            Console.WriteLine($"Apartment: {sumApartment:F2} lv.");
            Console.WriteLine($"Studio: {sumStudio:F2} lv.");
        }
    }
}
using System;

namespace _07._School_Camp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string group = Console.ReadLine();
            int numberStudents = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            string sport = "";
            double totalSum = 0;

            if(season == "Winter")
            {
                if(group == "girls" || group == "boys")
                {
                    totalSum = numberStudents * nights * 9.60;
                }
                else
                {
                    totalSum = numberStudents * nights * 10;
                }
                if(group == "girls")
                {
                    sport = "Gymnastics";
                }
                else if(group == "boys")
                {
                    sport = "Judo";
                }
                else
                {
                    sport = "Ski";
                }
            }
            else if(season == "Spring")
            {
                if (group == "girls" || group == "boys")
                {
                    totalSum = numberStudents * nights * 7.20;
                }
                else
                {
                    totalSum = numberStudents * nights * 9.50;
                }
                if (group == "girls")
                {
                    sport = "Athletics";
                }
                else if (group == "boys")
                {
                    sport = "Tennis";
                }
                else
                {
                    sport = "Cycling";
                }
            }
            else if (season == "Summer")
            {
                if (group == "girls" || group == "boys")
                {
                    totalSum = numberStudents * nights * 15;
                }
                else
                {
                    totalSum = numberStudents * nights * 20;
                }
                if (group == "girls")
                {
                    sport = "Volleyball";
                }
                else if (group == "boys")
                {
                    sport = "Football";
                }
                else
                {
                    sport = "Swimming";
                }
            }

            if (numberStudents >= 50)
            {
                totalSum = totalSum - (totalSum * 0.50);
            }
            else if(numberStudents >= 20 && numberStudents < 50)
            {
                totalSum = totalSum - (totalSum * 0.15);
            }
            else if(numberStudents >= 10 && numberStudents < 20)
            {
                totalSum = totalSum - (totalSum * 0.05);
            }

            Console.WriteLine($"{sport} {totalSum:F2} lv.");
        }
    }
}
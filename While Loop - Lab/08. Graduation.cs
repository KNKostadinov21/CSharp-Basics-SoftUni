using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            double currentYear = 1;
            double averageGrade = 0;
            double currentGrade = 0;
            double timesNotPassed = 1;

            while (currentYear <= 12)
            {
                currentGrade = double.Parse(Console.ReadLine());
                averageGrade += currentGrade;

                if (currentGrade >= 4)
                {
                    currentYear++;
                }

                else if (currentGrade < 4)
                {
                    if (timesNotPassed >= 2)
                    {

                        Console.WriteLine($"{name} has been excluded at {currentYear} grade");
                        break;
                    }
                    timesNotPassed++;
                }
            }

            averageGrade = averageGrade / 12;

            if (averageGrade >= 4.00 && timesNotPassed < 2)
            {
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:F2}");
            }
        }
    }
}
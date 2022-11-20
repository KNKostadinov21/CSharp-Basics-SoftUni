using System;

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double pointsFromTheAcademy = double.Parse(Console.ReadLine());
            int numberAppraisers = int.Parse(Console.ReadLine());
            double totalPoints = pointsFromTheAcademy;

            for (int i = 1; i <= numberAppraisers; i++)
            {
                string nameOfTheAppraiser = Console.ReadLine();
                double pointsGiven = double.Parse(Console.ReadLine());
                int index = nameOfTheAppraiser.Length;
                totalPoints += ((index * pointsGiven) / 2);
                if (totalPoints > 1250.5)
                {
                    break;
                }
            }

            if (totalPoints > 1250.5)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {totalPoints:F1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actorName} you need {(1250.5 - totalPoints):F1} more!");
            }
        }
    }
}
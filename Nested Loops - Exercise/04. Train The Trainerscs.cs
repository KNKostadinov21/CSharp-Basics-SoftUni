using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfJudges = int.Parse(Console.ReadLine());
            double presentationsAverageGrade = 0;
            int presentationsCount = 0;
            while(true)
            {
                string command = Console.ReadLine();
                if(command == "Finish")
                {
                    break;
                }

                presentationsCount++;
                double gradesSum = 0;

                for(int i = 0; i < numberOfJudges; i++)
                {
                    gradesSum += double.Parse(Console.ReadLine());
                }

                presentationsAverageGrade += gradesSum / numberOfJudges;
                Console.WriteLine($"{command} - {gradesSum / numberOfJudges:F2}.");
            }

            Console.WriteLine($"Student's final assessment is {presentationsAverageGrade / presentationsCount:F2}.");
        }
    }
}
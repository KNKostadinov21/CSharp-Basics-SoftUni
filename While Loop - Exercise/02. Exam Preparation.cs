using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int notGoodGrade = int.Parse(Console.ReadLine());
            int counterNotGoodGrades = 0;
            int counterTasks = 0;
            double averageGrade = 0;
            double totalGrade = 0;
            string lastTask = "";

            while (counterNotGoodGrades < notGoodGrade)
            {
                string task = Console.ReadLine();

                if (task == "Enough")
                {
                    averageGrade = totalGrade / counterTasks;
                    Console.WriteLine($"Average score: {averageGrade:F2}");
                    Console.WriteLine($"Number of problems: {counterTasks}");
                    Console.WriteLine($"Last problem: {lastTask}");
                    break;
                }
                
                int grade = int.Parse(Console.ReadLine());
                counterTasks += 1;
                totalGrade += grade;
                lastTask = task;

                if (grade <= 4.00)
                {
                    counterNotGoodGrades += 1;
                }

                if (counterNotGoodGrades == notGoodGrade)
                {
                    Console.WriteLine($"You need a break, {counterNotGoodGrades} poor grades.");
                    break;
                }

                          
            }
        }
    }
}
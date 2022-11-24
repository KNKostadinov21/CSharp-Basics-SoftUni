using System;

namespace _04._Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberGrades = int.Parse(Console.ReadLine());
            double resultGrade;
            double percentage5to6 = 0;
            double grade5to6 = 0;
            double percentage4to499 = 0;
            double grade4to499 = 0;
            double percentage3to399 = 0;
            double grade3to399 = 0;
            double percentageUnder3 = 0;
            double gradeUnder3 = 0;
            double averageGrade = 0;

            for(int i = 1; i <= numberGrades; i++)
            {
                resultGrade = double.Parse(Console.ReadLine());
                averageGrade += resultGrade;
                if(resultGrade >= 5)
                {

                    grade5to6 += 1;
                }
                else if(resultGrade <= 4.99 && resultGrade >= 4.00)
                {
                    grade4to499 += 1;
                }
                else if(resultGrade <= 3.99 && resultGrade >= 3.00)
                {
                    grade3to399 += 1;
                }
                else
                {
                    gradeUnder3 += 1;
                }
            }

            percentage5to6 = grade5to6 / numberGrades * 100;
            percentage4to499 = grade4to499 / numberGrades * 100;
            percentage3to399 = grade3to399 / numberGrades * 100;
            percentageUnder3 = gradeUnder3 / numberGrades * 100;
            
            Console.WriteLine($"Top students: {percentage5to6:F2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {percentage4to499:F2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {percentage3to399:F2}%");
            Console.WriteLine($"Fail: {percentageUnder3:F2}%");
            Console.WriteLine($"Average: {(averageGrade / numberGrades):F2}");
        }
    }
}
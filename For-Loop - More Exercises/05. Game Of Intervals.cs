using System;

namespace _05._Game_Of_Intervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            double points = 0;
            int counter = 0;

            double p09 = 0;
            double p1019 = 0;
            double p2029 = 0;
            double p3039 = 0;
            double p4050 = 0;
            double pInvalid = 0;
            double num09 = 0;
            double num1019 = 0;
            double num2029 = 0;
            double num3039 = 0;
            double num4050 = 0;
            double numInvalid = 0;

            for (int i = 1; i <= numbers; i++)
            {
                double number = double.Parse(Console.ReadLine());
                counter += 1;
                if (number >= 0 && number <= 9)
                {
                    num09 += 1;
                    points += 0.2 * number;
                }
                else if (number >= 10 && number <= 19)
                {
                    num1019 += 1;
                    points += 0.3 * number;
                }
                else if (number >= 20 && number <= 29)
                {
                    num2029 += 1;
                    points += 0.4 * number;
                }
                else if (number >= 30 && number <= 39)
                {
                    num3039 += 1;
                    points += 50;
                }
                else if (number >= 40 && number <= 50)
                {
                    num4050 += 1;
                    points += 100;
                }
                else
                {
                    numInvalid += 1;
                    points /= 2;
                }
            }

            p09 = num09 / counter * 100;
            p1019 = num1019 / counter * 100;
            p2029 = num2029 / counter * 100;
            p3039 = num3039 / counter * 100;
            p4050 = num4050 / counter * 100;
            pInvalid = numInvalid / counter * 100;

            Console.WriteLine($"{points:F2}");
            Console.WriteLine($"From 0 to 9: {p09:F2}%");
            Console.WriteLine($"From 10 to 19: {p1019:F2}%");
            Console.WriteLine($"From 20 to 29: {p2029:F2}%");
            Console.WriteLine($"From 30 to 39: {p3039:F2}%");
            Console.WriteLine($"From 40 to 50: {p4050:F2}%");
            Console.WriteLine($"Invalid numbers: {pInvalid:F2}%");
        }
    }
}
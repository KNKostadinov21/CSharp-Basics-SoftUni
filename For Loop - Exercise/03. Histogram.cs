using System;

namespace _03._Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());

            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            int counter4 = 0;
            int counter5 = 0;

            for (int i = 1; i <= numbers; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 200)
                {
                    counter1 += 1;
                }
                else if (number >= 200 && number <= 399)
                {
                    counter2 += 1;
                }
                else if (number >= 400 && number <= 599)
                {
                    counter3 += 1;
                }
                else if (number >= 600 && number <= 799)
                {
                    counter4 += 1;
                }
                else
                {
                    counter5 += 1;
                }
            }

            double p1 = counter1 * 100.0 / numbers;
            double p2 = counter2 * 100.0 / numbers;
            double p3 = counter3 * 100.0 / numbers;
            double p4 = counter4 * 100.0 / numbers;
            double p5 = counter5 * 100.0 / numbers;

            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
            Console.WriteLine($"{p4:F2}%");
            Console.WriteLine($"{p5:F2}%");
        }
    }
}
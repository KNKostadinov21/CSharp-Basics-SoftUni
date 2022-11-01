using System;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine();
            int neededTime = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());

            double lunchTime = breakTime * 0.125;
            double restTime = breakTime * 0.25;

            double neededTimeForEverything = neededTime + lunchTime + restTime;

            if(neededTimeForEverything <= breakTime)
            {
                Console.WriteLine($"You have enough time to watch {filmName} and left with {Math.Ceiling(breakTime - neededTimeForEverything)} minutes free time.");
            }

            else
            {
                Console.WriteLine($"You don't have enough time to watch {filmName}, you need {Math.Abs(Math.Ceiling(neededTimeForEverything - breakTime))} more minutes.");
            }
        }
    }
}

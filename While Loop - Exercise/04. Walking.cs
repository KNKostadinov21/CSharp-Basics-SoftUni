using System;

namespace _04._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isGoingHome = false;
            int totalSteps = 0;

            while (totalSteps < 10000 && !isGoingHome)
            {
                string input = Console.ReadLine();

                if (input == "Going home")
                {
                    input = Console.ReadLine();
                    isGoingHome = true;
                }

                int currentSteps = int.Parse(input);
                totalSteps += currentSteps;
            }

            if (totalSteps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{totalSteps - 10000} steps over the goal!");
            }

            else
            {
                Console.WriteLine($"{10000 - totalSteps} more steps to reach goal.");
            }
        }
    }
}
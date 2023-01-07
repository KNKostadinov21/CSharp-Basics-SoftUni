using System;

namespace _05._Best_Player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bestPlayer = "";
            int bestScore = 0;
            string playerName;

            while ((playerName = Console.ReadLine()) != "END")
            {
                int currentGoals = int.Parse(Console.ReadLine());
                if (currentGoals > bestScore)
                {
                    bestPlayer = playerName;
                    bestScore = currentGoals;
                }

                if (bestScore >= 10)
                {
                    break;
                }
            }

            Console.WriteLine($"{bestPlayer} is the best player!");

            if (bestScore >= 3)
            {
                Console.WriteLine($"He has scored {bestScore} goals and made a hat-trick !!!");
            }

            else
            {
                Console.WriteLine($"He has scored {bestScore} goals.");
            }
        }
    }
}

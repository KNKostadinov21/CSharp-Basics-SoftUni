using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());

            int wPoints = 0;
            int fPoints = 0;
            int sfPoints = 0;
            double wonTournaments = 0;

            for (int i = 1; i <= tournaments; i++)
            {
                string stage = Console.ReadLine();
                    
                if (stage == "W")
                { 
                    wPoints += 2000;
                    wonTournaments++;
                }
                else if(stage == "F")
                {
                    fPoints += 1200;
                }
                else if(stage == "SF")
                {
                    sfPoints += 720;
                }
            }

            int averagePoints = (wPoints + fPoints + sfPoints) / tournaments;
            double percentageWinrate = wonTournaments / tournaments * 100;

            Console.WriteLine($"Final points: {wPoints + fPoints + sfPoints + startingPoints}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{percentageWinrate:F2}%");
        }
    }
}
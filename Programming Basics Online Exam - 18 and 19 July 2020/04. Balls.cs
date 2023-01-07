using System;

namespace _04._Balls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfBalls = int.Parse(Console.ReadLine());
            double totalPoints = 0;
            int counterRedBalls = 0;
            int counterOrangeBalls = 0;
            int counterYellowBalls = 0;
            int counterWhiteBalls = 0;
            int counterOtherBalls = 0;
            int counterDividesFromBlackBalls = 0;

            for (int i = 1; i <= numberOfBalls; i++)
            {
                string colour = Console.ReadLine();

                switch (colour)
                {
                    case "red":
                        totalPoints += 5;
                        counterRedBalls++;
                        break;

                    case "orange":
                        totalPoints += 10;
                        counterOrangeBalls++; 
                        break;

                    case "yellow":
                        totalPoints += 15;
                        counterYellowBalls++;
                        break;

                    case "white":
                        totalPoints += 20;
                        counterWhiteBalls++;
                        break;

                    case "black":
                        totalPoints = Math.Floor(totalPoints / 2);
                        counterDividesFromBlackBalls++;
                        break;

                    default:        
                        counterOtherBalls++;
                        break;
                }
            }

            Console.WriteLine($"Total points: {totalPoints}");
            Console.WriteLine($"Red balls: {counterRedBalls}");
            Console.WriteLine($"Orange balls: {counterOrangeBalls}");
            Console.WriteLine($"Yellow balls: {counterYellowBalls}");
            Console.WriteLine($"White balls: {counterWhiteBalls}");
            Console.WriteLine($"Other colors picked: {counterOtherBalls}");
            Console.WriteLine($"Divides from black balls: {counterDividesFromBlackBalls}"); 
        }
    }
}
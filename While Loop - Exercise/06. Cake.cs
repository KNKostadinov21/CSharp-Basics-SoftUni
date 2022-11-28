using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int countPieces = length * width;

            string pieces;
            while (countPieces >= 0 && (pieces = Console.ReadLine()) != "STOP")
            {
                countPieces -= int.Parse(pieces);
            }

            if (countPieces >= 0)
            {
                Console.WriteLine($"{countPieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {-countPieces} pieces more.");
            }
        }
    }
}
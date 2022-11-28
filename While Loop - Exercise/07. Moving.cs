using System;

namespace _07._Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int heigth = int.Parse(Console.ReadLine());
            int space = width * length * heigth;

            string boxesAsInput;
            while (space >= 0 && (boxesAsInput = Console.ReadLine()) != "Done")
            { 
                int boxes = int.Parse(boxesAsInput);
                space -= boxes;
            }

            if(space >= 0)
            {
                Console.WriteLine($"{space} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(space)} Cubic meters more.");
            }
        }
    }
}
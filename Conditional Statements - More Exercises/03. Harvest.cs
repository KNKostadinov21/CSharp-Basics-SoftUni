using System;

namespace _03._Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int area = int.Parse(Console.ReadLine());
            double grapesPerOneSquareMeter = double.Parse(Console.ReadLine());
            int neededLitresWine = int.Parse(Console.ReadLine());
            int numberWorkers = int.Parse(Console.ReadLine());
            double separatedGrapes = area * 0.40;
            double wine = (separatedGrapes * grapesPerOneSquareMeter) / 2.5;
            if (wine < neededLitresWine)
            {
                double neededWineForExpected = neededLitresWine - wine;
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(neededWineForExpected)} liters wine needed.");
            }
            else if(wine >= neededLitresWine)
            {
                double wineLeft = wine - neededLitresWine;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(wineLeft)} liters left -> {Math.Ceiling(wineLeft / numberWorkers)} liters per person.");
            }
        }
    }
}
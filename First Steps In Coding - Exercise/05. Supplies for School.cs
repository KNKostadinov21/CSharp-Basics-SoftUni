using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double packagePens = double.Parse(Console.ReadLine());
            double packageMarkers = double.Parse(Console.ReadLine());
            double boardCleaner = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());
            double sumPackagePens = packagePens * 5.80;
            double sumPackageMarkers = packageMarkers * 7.20;
            double sumBoardCleaner = boardCleaner * 1.20;
            double totalSum = (sumPackagePens + sumPackageMarkers + sumBoardCleaner) - discount * (sumPackagePens + sumPackageMarkers + sumBoardCleaner) / 100;
            Console.WriteLine(totalSum);
        }
    }
}
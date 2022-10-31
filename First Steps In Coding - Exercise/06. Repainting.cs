using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nylon = double.Parse(Console.ReadLine());
            double dye = double.Parse(Console.ReadLine());
            double thinner = double.Parse(Console.ReadLine());
            double bags = 1;
            double hoursMasters = double.Parse(Console.ReadLine());
            double sumNylon = (nylon + 2) * 1.5;
            double sumDye = (dye + 0.1 * dye) * 14.5;
            double sumThinner = thinner * 5;
            double sumBags = bags * 0.4;
            double sumMaterials = sumNylon + sumDye + sumThinner + sumBags;
            double sumMasters = (sumMaterials * 0.3) * hoursMasters;
            double totalSum = sumMaterials + sumMasters;
            Console.WriteLine(totalSum);
        }
    }
}
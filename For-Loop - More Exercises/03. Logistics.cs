using System;

namespace _03._Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int tons;
            double totalSum = 0;
            int totalTonsVan = 0;
            int totalTonsTruck = 0;
            int totalTonsTrain = 0;
            double totalTons = 0;       

            for(int i = 1; i <= n; i++)
            {
                tons = int.Parse(Console.ReadLine());
                totalTons += tons;
                if(tons <= 3)
                {
                    totalSum += (tons * 200);
                    totalTonsVan += tons;
                }
                else if(tons >= 4 && tons <= 11)
                {
                    totalSum += tons * 175;
                    totalTonsTruck += tons;
                }
                else
                {
                    totalSum += tons * 120;
                    totalTonsTrain += tons;
                }
            }

            Console.WriteLine($"{(totalSum / totalTons):F2}");
            Console.WriteLine($"{((totalTonsVan / totalTons) * 100):F2}%");
            Console.WriteLine($"{((totalTonsTruck / totalTons) * 100):F2}%");
            Console.WriteLine($"{((totalTonsTrain / totalTons) * 100):F2}%");
        }
    }
}
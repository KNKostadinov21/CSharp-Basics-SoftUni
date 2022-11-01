using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videocards = int.Parse(Console.ReadLine());
            int processor = int.Parse(Console.ReadLine());
            int RAMmemory = int.Parse(Console.ReadLine());

            double priceVideocards = 250;
            double sumVideocards = videocards * priceVideocards;

            double priceProcessors = sumVideocards * 0.35;
            double sumProcessors = priceProcessors * processor;
            
            double priceRAMmemory = sumVideocards * 0.1;
            double sumRAMmemories = priceRAMmemory * RAMmemory;

            double neededSum = sumVideocards + sumProcessors + sumRAMmemories;

            if(videocards > processor)
            {
                neededSum -= 0.15 * neededSum;
            }
            if(neededSum <= budget)
            {
                Console.WriteLine($"You have {Math.Abs(neededSum - budget):F2} leva left!");
            }
            else 
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(budget - neededSum):f2} leva more!");
            }
        }
    }
}
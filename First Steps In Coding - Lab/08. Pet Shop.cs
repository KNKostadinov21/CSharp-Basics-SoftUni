using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodDogs = int.Parse(Console.ReadLine());
            int foodCats = int.Parse(Console.ReadLine());
            double costs = foodDogs * 2.5 + foodCats * 4;
            Console.WriteLine($"{costs} lv.");
        }
    }
}
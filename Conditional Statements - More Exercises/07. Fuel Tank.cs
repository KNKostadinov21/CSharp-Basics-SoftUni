using System;

namespace _07._Fuel_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            double fuelLitres = double.Parse(Console.ReadLine());

            if (type == "diesel" || type == "gas" || type == "gasoline")
            {
                if (fuelLitres >= 25)
                {
                    Console.WriteLine($"You have enough {type}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {type}!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
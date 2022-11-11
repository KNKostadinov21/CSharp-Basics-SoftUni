using System;

namespace _05._Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int leftFoodInKilos = int.Parse(Console.ReadLine());
            double foodDog = double.Parse(Console.ReadLine());
            double foodCat = double.Parse(Console.ReadLine());
            double foodTurtle = double.Parse(Console.ReadLine()) / 1000;
            double totalFood = (foodDog * days) + (foodCat * days) + (foodTurtle * days);
            if(totalFood <= leftFoodInKilos)
            {
                Console.WriteLine($"{Math.Floor(Math.Abs(totalFood - leftFoodInKilos))} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(Math.Abs(totalFood - leftFoodInKilos))} more kilos of food are needed.");
            }
        }
    }
}
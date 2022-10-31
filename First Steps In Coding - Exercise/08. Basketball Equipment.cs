using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sumTrainingPerYear = double.Parse(Console.ReadLine());
            double sumBasketballShoes = sumTrainingPerYear - (0.4 * sumTrainingPerYear);
            double sumBasketballClothes = sumBasketballShoes - (0.2 * sumBasketballShoes);
            double sumBasketballBall = 0.25 * sumBasketballClothes;
            double sumBasketballAccessories = 0.2 * sumBasketballBall;
            double totalSum = sumTrainingPerYear + sumBasketballShoes + sumBasketballClothes + sumBasketballBall + sumBasketballAccessories;
            Console.WriteLine(totalSum);
        }
    }
}
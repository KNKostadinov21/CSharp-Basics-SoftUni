using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double size = double.Parse(Console.ReadLine());
            double wholePrice = size * 7.61;
            double discount = 0.18 * wholePrice;
            double finalPrice = wholePrice - discount;
            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
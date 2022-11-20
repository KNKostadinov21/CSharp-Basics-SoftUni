using System;

namespace _02._Add_Bags
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pricePerBagsOver20kg = double.Parse(Console.ReadLine());
            double kgBags = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int numberBags = int.Parse(Console.ReadLine());

            double totalSum = 0;
            
            if (days < 7)
            {
                pricePerBagsOver20kg = pricePerBagsOver20kg + (pricePerBagsOver20kg * 0.40);
            }
            else if (days >= 7 && days <= 30)
            {
                pricePerBagsOver20kg = pricePerBagsOver20kg + (pricePerBagsOver20kg * 0.15);
            }
            else if (days > 30)
            {
                pricePerBagsOver20kg = pricePerBagsOver20kg + (pricePerBagsOver20kg * 0.10);
            }
              
            if(kgBags < 10)
            {
                totalSum = pricePerBagsOver20kg * 0.2;
            }
            else if(kgBags >= 10 && kgBags <= 20)
            {
                totalSum = pricePerBagsOver20kg / 2;
            }
            else if(kgBags > 20)
            {
                totalSum = pricePerBagsOver20kg;
            }
            
            totalSum *= numberBags;
            Console.WriteLine($"The total price of bags is: {totalSum:F2} lv.");
        }
    }
}
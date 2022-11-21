using System;

namespace _01._Back_To_The_Past
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());
            double spendMoney = 0;

            for(int i = 0; i <= (years - 1800); i++)
            {               
                if(i % 2 == 0)
                {
                    spendMoney += 12000;
                }
                else
                {
                    spendMoney = spendMoney + (12000 + (50 * (18 + i)));
                }
            }

            double leftMoney = money - spendMoney;
            if (leftMoney >= 0)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {leftMoney:F2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(leftMoney):F2} dollars to survive.");
            }
        }
    }
}
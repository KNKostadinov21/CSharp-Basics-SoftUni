using System;

namespace _04._Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yearsLily = int.Parse(Console.ReadLine());
            double sumWashingMachine = double.Parse(Console.ReadLine());
            double sumPerOneToy = double.Parse(Console.ReadLine());

            double toys = 0;
            double savedMoney = 0;
            double moneyEarnedFromBirthdays = 10;

            for(int i = 1; i <= yearsLily; i++)
            {
                if (i % 2 == 0)
                {
                    savedMoney += (moneyEarnedFromBirthdays - 1);
                    moneyEarnedFromBirthdays += 10;
                }
                else
                {
                    toys += 1;
                }
            }

            savedMoney += toys * sumPerOneToy;

            if(savedMoney >= sumWashingMachine)
            {
                Console.WriteLine($"Yes! {Math.Abs(savedMoney - sumWashingMachine):F2}");
            }
            else
            {
                Console.WriteLine($"No! {Math.Abs(savedMoney - sumWashingMachine):F2}");
            }
        }
    }
}
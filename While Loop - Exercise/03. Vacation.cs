using System;

namespace _03._Vacation
{
    public class Program
    {
        public static void Main()
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            int counterDays = 0;
            int counterDaysSpending = 0;

            while (money < neededMoney && counterDaysSpending < 5)
            {
                string opportunity = Console.ReadLine();
                double moneyForTheDay = double.Parse(Console.ReadLine());
                counterDays += 1;
                if (opportunity == "spend")
                {
                    counterDaysSpending++;

                    if (money - moneyForTheDay < 0)
                    {
                        money = 0;
                    }
                    else
                    {
                        money -= moneyForTheDay;
                    }
                }
                else if (opportunity == "save")
                {
                    money += moneyForTheDay;
                    counterDaysSpending = 0;
                }
            }

            if (counterDaysSpending == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(counterDays);
            }

            if (money >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {counterDays} days.");
            }
        }
    }
}
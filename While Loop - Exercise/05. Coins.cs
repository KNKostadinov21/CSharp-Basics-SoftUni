using System;

namespace _05._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int counterCoins = 0;
            money = Math.Floor(money * 100);

            while(money > 0)
            {
                if(money >= 200)
                {
                    counterCoins += 1;
                    money -= 200;                   
                }
                else if(money >= 100)
                {
                    counterCoins += 1;
                    money -= 100;
                    
                }
                else if(money >= 50)
                {
                    money -= 50;
                    counterCoins += 1;               
                }
                else if(money >= 20)
                {
                    counterCoins += 1;
                    money -= 20;                   
                }
                else if(money >= 10)
                {
                    counterCoins += 1;
                    money -= 10;     
                }
                else if(money >= 5)
                {
                    counterCoins += 1; 
                    money -= 5;   
                }
                else if(money >= 2)
                {
                    counterCoins += 1;
                    money -= 2;                 
                }
                else
                {
                    counterCoins += 1;
                    money -= 1;               
                }
            }

            Console.WriteLine(counterCoins);
        }
    }
}
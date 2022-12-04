using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for(int i = 1111; i <= 9999; i++)
            {
                int currentNumber = i;
                bool isSpecial = true;

                while(currentNumber > 0)
                {
                    int lastDigit = currentNumber % 10;
                    currentNumber /= 10;
                    
                    if(lastDigit == 0)
                    {
                        isSpecial = false;
                        continue;
                    }
                    if(number % lastDigit != 0)
                    {
                        isSpecial = false;
                        break;
                    }
                }

                if(isSpecial)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
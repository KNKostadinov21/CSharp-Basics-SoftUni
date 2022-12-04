using System;

namespace _03._Sum_Prime_Non_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeSum = 0;
            int nonPrimeSum = 0;

            while(true)
            {
                string command = Console.ReadLine();
                if(command == "stop")
                {
                    break;
                }

                int number = int.Parse(command);

                if(number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }

                bool isPrime = true;

                for(int i = 2; i < number; i++)
                {
                    if(number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if(isPrime)
                {
                    primeSum += number;
                }
                else
                {
                    nonPrimeSum += number;
                }
            }

            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
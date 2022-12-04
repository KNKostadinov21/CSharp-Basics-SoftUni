using System;

namespace _05._Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while(destination != "End")
            {
                double tripPrice = double.Parse(Console.ReadLine());
                double savedMoney = 0;

                while(savedMoney < tripPrice)
                {
                    double payment = double.Parse(Console.ReadLine());
                    savedMoney += payment;
                }

                if(savedMoney >= tripPrice)
                {
                    Console.WriteLine($"Going to {destination}!");
                }

                destination = Console.ReadLine();
            }
        }
    }
}
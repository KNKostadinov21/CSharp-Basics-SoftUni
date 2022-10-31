using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            double months = double.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine());
            double annualInterest = depositSum * interest / 100;
            double interestOneMonth = annualInterest / 12;
            double totalSum = depositSum + months * interestOneMonth;
            Console.WriteLine(totalSum);
        }
    }
}
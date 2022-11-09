using System;

namespace _01._Pipes_In_Pool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int litres = int.Parse(Console.ReadLine());
            int firstPipePerHour = int.Parse(Console.ReadLine());
            int secondPipePerHour = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double firstPipe = firstPipePerHour * hours;
            double secondPipe = secondPipePerHour * hours;
            double total = firstPipe + secondPipe;
            if (total < litres)
            {
                Console.WriteLine($"The pool is {(total / 10):F2}%. Pipe 1: {(firstPipe / total * 100):F2}%. Pipe 2: {(secondPipe / total * 100):F2}%.");
            }
            else
            {
                double litresTwo = total - litres;
                Console.WriteLine($"For {hours:F2} the pool overflows with {litresTwo:F2} litres.");
            }
        }
    }
}
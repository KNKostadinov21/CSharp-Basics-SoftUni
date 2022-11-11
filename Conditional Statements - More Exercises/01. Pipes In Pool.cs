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

            double litresPipeOne = hours * firstPipePerHour;
            double litresPipeTwo = hours * secondPipePerHour;
            double pipesLiters = litresPipeOne + litresPipeTwo;
            double waterHours = hours / pipesLiters;

            if (pipesLiters <= litres)
            {
                double waterPersent = (pipesLiters / litres) * 100;
                double pipe1Persent = (firstPipePerHour * waterHours) * 100;
                double pipe2Persent = (secondPipePerHour * waterHours) * 100;

                Console.WriteLine($"The pools is {waterPersent:F2}% full. Pipe 1: {pipe1Persent:F2}%. Pipe 2: {pipe2Persent:F2}%.");
            }
            else
            {
                double extraWater = pipesLiters - litres;

                Console.WriteLine($"For {hours:F2} hours the pool overflows with {extraWater:F2} liters.");
            }
        }
    }
}
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordSeconds = double.Parse(Console.ReadLine());
            double recordLength = double.Parse(Console.ReadLine());
            double lengthSecondsIvanPerOneMeter = double.Parse(Console.ReadLine());


            double secondsIvanWithoutSlow = recordLength * lengthSecondsIvanPerOneMeter;

            double slowingDistanceSeconds = Math.Floor((recordLength / 15)) * 12.5;
            double resultIvan = slowingDistanceSeconds + secondsIvanWithoutSlow;

            if (resultIvan < recordSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {resultIvan:F2} seconds.");
            }

            else if (resultIvan >= recordSeconds)
            {
                double neededSeconds = resultIvan - recordSeconds;
                Console.WriteLine($"No, he failed! He was {neededSeconds:F2} seconds slower.");
            }
        }
    }
}
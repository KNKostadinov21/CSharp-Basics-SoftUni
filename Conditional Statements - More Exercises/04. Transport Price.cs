using System;

namespace _04._Transport_Price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kilometers = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            double sumTaxi;
            double sumBus = kilometers * 0.09;
            double sumTrain = kilometers * 0.06;
            if(kilometers < 20)
            {
                if(time == "day")
                {
                    sumTaxi = 0.70 + (kilometers * 0.79);
                    Console.WriteLine($"{sumTaxi:F2}");
                }
                else if(time == "night")
                {
                    sumTaxi = 0.70 + (kilometers * 0.90);
                    Console.WriteLine($"{sumTaxi:F2}");
                }
            }
            else if(kilometers >= 20 && kilometers < 100)
            {
                if(time == "day")
                {
                    sumTaxi = 0.70 + (kilometers * 0.79);
                    if(sumTaxi < sumBus)
                    {
                        Console.WriteLine($"{sumTaxi:F2}");
                    }
                    else
                    {
                        Console.WriteLine($"{sumBus:F2}");
                    }
                }
                else if(time == "night")
                {
                    sumTaxi = 0.70 + (kilometers * 0.90);
                    if (sumTaxi < sumBus)
                    {
                        Console.WriteLine($"{sumTaxi:F2}");
                    }
                    else
                    {
                        Console.WriteLine($"{sumBus:F2}");
                    }
                }
            }
            else if(kilometers > 20 && kilometers >= 100)
            {
                if (time == "day")
                {
                    sumTaxi = 0.70 + (kilometers * 0.79);
                    if (sumTaxi < sumBus && sumTaxi < sumTrain)
                    {
                        Console.WriteLine($"{sumTaxi:F2}");
                    }
                    else if(sumBus < sumTaxi && sumBus < sumTrain)
                    {
                        Console.WriteLine($"{sumBus:F2}");
                    }
                    else if(sumTrain < sumTaxi && sumTrain < sumBus)
                    {
                        Console.WriteLine($"{sumTrain:F2}");
                    }
                }
                else if (time == "night")
                {
                    sumTaxi = 0.70 + (kilometers * 0.90);
                    if (sumTaxi < sumBus && sumTaxi < sumTrain)
                    {
                        Console.WriteLine($"{sumTaxi:F2}");
                    }
                    else if (sumBus < sumTaxi && sumBus < sumTrain)
                    {
                        Console.WriteLine($"{sumBus:F2}");
                    }
                    else if (sumTrain < sumTaxi && sumTrain < sumBus)
                    {
                        Console.WriteLine($"{sumTrain:F2}");
                    }
                }
            }
        }
    }
}
using System;

namespace _07._Working_Hours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            if (hours >= 10 && hours <= 18)
            {
                switch (day)
                {
                    case "Monday":
                        Console.WriteLine("open"); break;
                    case "Tuesday":
                        Console.WriteLine("open"); break;
                    case "Wednesday":
                        Console.WriteLine("open"); break;
                    case "Thursday":
                        Console.WriteLine("open"); break;
                    case "Friday":
                        Console.WriteLine("open"); break;
                    case "Saturday":
                        Console.WriteLine("open"); break;
                    default:
                        Console.WriteLine("closed"); break;
                }
            }
            if(day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday" || day == "Saturday")
            {
                if(hours < 10 || hours > 18)
                {
                    Console.WriteLine("closed");
                }
            }
        }
    }
}
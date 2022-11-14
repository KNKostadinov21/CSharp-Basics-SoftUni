using System;

namespace _08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hoursExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hoursArrival = int.Parse(Console.ReadLine());
            int minutesArrival = int.Parse(Console.ReadLine());

            int totalMinutesExam = (hoursExam * 60) + minutesExam;
            int totalMinutesArrival = (hoursArrival * 60) + minutesArrival;

            if (totalMinutesArrival > totalMinutesExam)
            {
                Console.WriteLine("Late");
                int minutesLater = totalMinutesArrival - totalMinutesExam;
                if (minutesLater < 60)
                {
                    Console.WriteLine($"{minutesLater} minutes after the start");
                }
                else
                {
                    int hours = minutesLater / 60;
                    int minutes = minutesLater % 60;
                    Console.WriteLine($"{hours}:{minutes:d2} hours after the start");
                }
            }

            else if(totalMinutesArrival < totalMinutesExam - 30)
            {
                Console.WriteLine("Early");
                int minutesEarlier = totalMinutesExam - totalMinutesArrival;
                if (minutesEarlier < 60)
                {
                    Console.WriteLine($"{minutesEarlier} minutes before the start");
                }
                else
                {
                    int hours = minutesEarlier / 60;
                    int minutes = minutesEarlier % 60;
                    Console.WriteLine($"{hours}:{minutes:d2} hours before the start");
                }
            }

            else
            {
                Console.WriteLine("On time");
                int minutesEarlier = totalMinutesExam - totalMinutesArrival;
                Console.WriteLine($"{minutesEarlier} minutes before the start");
            }
        }
    }
}
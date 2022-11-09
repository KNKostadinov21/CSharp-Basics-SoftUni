using System;

namespace _02._Sleepy_Tom_Cat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int freeDays = int.Parse(Console.ReadLine());
            int minutesPlayingFreeDays = freeDays * 127;
            int minutesPlayingWorkingDays = (365 - freeDays) * 63;
            int minutesPlaying = minutesPlayingFreeDays + minutesPlayingWorkingDays;
            int hoursPlaying = minutesPlaying / 60;
            int minutesPlayingOnly = minutesPlaying - (hoursPlaying * 60);
            if (minutesPlaying > 30000)
            {
                int minutesMore = minutesPlaying - 30000;
                int hoursMorePlaying = minutesMore / 60;
                int minutesMorePlaying = minutesMore - (hoursMorePlaying * 60);
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hoursMorePlaying} hours and {minutesMorePlaying} minutes more for play");
            }
            else
            {
                int minutesLess = 30000 - minutesPlaying;
                int hoursLessPlaying = minutesLess / 60;
                int minutesLessPlaying = minutesLess - (hoursLessPlaying * 60);
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hoursLessPlaying} hours and {minutesLessPlaying} minutes less for play");
            }
        }
    }
}
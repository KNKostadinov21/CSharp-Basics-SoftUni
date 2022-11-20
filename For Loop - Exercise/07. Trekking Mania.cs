using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());

            int Musalla = 0;
            int MontBlanc = 0;
            int Kilimanjaro = 0;
            int K2 = 0;
            int Everest = 0;

            for (int i = 1; i <= groups; i++)
            {
                int people = int.Parse(Console.ReadLine());
                if (people <= 5)
                {
                    Musalla += people;
                }
                else if (people >= 6 && people <= 12)
                {
                    MontBlanc += people;
                }
                else if (people >= 13 && people <= 25)
                {
                    Kilimanjaro += people;
                }
                else if (people >= 26 && people <= 40)
                {
                    K2 += people;
                }
                else if (people >= 41)
                {
                    Everest += people;
                }
            }

            double totalPeople = Musalla + MontBlanc + Kilimanjaro + K2 + Everest;
            double percentageMusalla = Musalla / totalPeople * 100;
            double percentageMontBlanc = MontBlanc / totalPeople * 100;
            double percentageKilimanjaro = Kilimanjaro / totalPeople * 100;
            double percentageK2 = K2 / totalPeople * 100;
            double percentageEverest = Everest / totalPeople * 100;

            Console.WriteLine($"{percentageMusalla:F2}%");
            Console.WriteLine($"{percentageMontBlanc:F2}%");
            Console.WriteLine($"{percentageKilimanjaro:F2}%");
            Console.WriteLine($"{percentageK2:F2}%");
            Console.WriteLine($"{percentageEverest:F2}%");
        }
    }
}
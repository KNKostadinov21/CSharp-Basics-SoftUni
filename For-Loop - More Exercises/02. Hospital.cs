using System;

namespace _02._Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int time = int.Parse(Console.ReadLine());
            int doctors = 7;
            int treatedPatients = 0;
            int untreatedPatients = 0;

            for (int i = 1; i <= time; i++)
            {
                int patients = int.Parse(Console.ReadLine());

                if (i % 3 == 0 && untreatedPatients > treatedPatients)
                {
                    doctors++;
                }

                if(patients <= doctors)
                {
                    treatedPatients += patients;
                }
                else if (patients > doctors)
                {
                    treatedPatients += doctors;
                    untreatedPatients += patients - doctors;
                }
                
            }       
            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        }
    }
}
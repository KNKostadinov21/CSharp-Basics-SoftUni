using System;

namespace _02._Numbers_N_to_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for(int i = number; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
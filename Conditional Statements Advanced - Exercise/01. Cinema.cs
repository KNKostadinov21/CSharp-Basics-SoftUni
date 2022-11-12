using System;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double total = rows * columns;

            switch (type)
            {
                case "Premiere":
                    total = total * 12.00; break;
                case "Normal":
                    total = total * 7.50; break;
                case "Discount":
                    total = total * 5.00; break;
            }

            Console.WriteLine("{0:f2} leva", total);
        }
    }
}
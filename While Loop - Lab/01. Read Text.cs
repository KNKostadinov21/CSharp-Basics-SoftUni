using System;

namespace _01._Read_Text
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            while (text != "Stop")
            {
                if (text == "Stop")
                {
                    break;
                }
                Console.WriteLine(text);
                text = Console.ReadLine();
            }       
        }
    }
}
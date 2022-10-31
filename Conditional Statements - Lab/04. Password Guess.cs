using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string guessPassword = Console.ReadLine();
            string correctPassword = "s3cr3t!P@ssw0rd";
            if (guessPassword == correctPassword)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
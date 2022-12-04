using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startOfInterval = int.Parse(Console.ReadLine());
            int endOfInterval = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int counter = 0;
            bool magicNumberFound = false;

            for(int i = startOfInterval; i <= endOfInterval; i++)
            {
                for(int j = startOfInterval; j <= endOfInterval; j++)
                {
                    counter++;
                    if(i + j == magicNumber)
                    {
                        magicNumberFound = true;
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicNumber})");
                        return;
                    }
                }
            }

            if(!magicNumberFound)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
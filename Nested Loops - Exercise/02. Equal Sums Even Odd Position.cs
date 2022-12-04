using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for(int i = start; i <= end; i++)
            {
                int oddSum = 0;
                int evenSum = 0;
                string numberAsText = i.ToString();
                
                for(int pos = 0; pos < numberAsText.Length; pos++)
                {
                    int numberAtCurrentPosition = int.Parse(numberAsText[pos].ToString());

                    if((pos + 1) % 2 == 0)
                    {
                        evenSum += numberAtCurrentPosition;
                    }
                    else
                    {
                        oddSum += numberAtCurrentPosition;
                    }
                }

                if(oddSum == evenSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
using System;

namespace _05._Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            
            for(int i = 1; i <= numberTabs; i++)
            {
                string sites = Console.ReadLine();
                if(sites == "Facebook")
                {
                    salary -= 150;
                }
                else if(sites == "Instagram")
                {
                    salary -= 100;
                }
                else if(sites == "Reddit")
                {
                    salary -= 50;
                }
                if(salary <= 0)
                {
                    break;
                }
            }

            if(salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary);
            }
        }
    }
}
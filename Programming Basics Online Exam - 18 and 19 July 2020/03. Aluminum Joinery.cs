using System;

namespace _03._Aluminum_Joinery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int joinery = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string delivery = Console.ReadLine();

            double prizePerOneJoinery = 0;
            double neededSum = 0;

            if(joinery <= 10)
            {
                Console.WriteLine("Invalid order");
            }

            else
            {
                switch(type)
                {
                    case "90X130":
                        prizePerOneJoinery = 110.0;
                        if (joinery > 30 && joinery <= 60)
                        {
                            neededSum = (joinery * prizePerOneJoinery) - (joinery * prizePerOneJoinery * 0.05);
                        }
                        else if (joinery > 60)
                        {
                            neededSum = (joinery * prizePerOneJoinery) - (joinery * prizePerOneJoinery * 0.08);
                        }
                        else
                        {
                            neededSum = (joinery * prizePerOneJoinery);
                        }
                        break;

                    case "100X150":
                        prizePerOneJoinery = 140.0;
                        if (joinery > 40 && joinery <= 80)
                        {
                            neededSum = (joinery * prizePerOneJoinery) - (joinery * prizePerOneJoinery * 0.06);
                        }
                        else if (joinery > 80)
                        {
                            neededSum = (joinery * prizePerOneJoinery) - (joinery * prizePerOneJoinery * 0.10);
                        }
                        else
                        {
                            neededSum = (joinery * prizePerOneJoinery);
                        }
                        break;

                    case "130X180":
                        prizePerOneJoinery = 190.0;
                        if (joinery > 20 && joinery <= 50)
                        {
                            neededSum = (joinery * prizePerOneJoinery) - (joinery * prizePerOneJoinery * 0.07);
                        }
                        else if (joinery > 50)
                        {
                            neededSum = (joinery * prizePerOneJoinery) - (joinery * prizePerOneJoinery * 0.12);
                        }
                        else
                        {
                            neededSum = (joinery * prizePerOneJoinery);
                        }
                        break;

                    case "200X300":
                        prizePerOneJoinery = 250.0;
                        if (joinery > 25 && joinery <= 50)
                        {
                            neededSum = (joinery * prizePerOneJoinery) - (joinery * prizePerOneJoinery * 0.09);
                        }
                        else if (joinery > 50)
                        {
                            neededSum = (joinery * prizePerOneJoinery) - (joinery * prizePerOneJoinery * 0.14);
                        }
                        else
                        {
                            neededSum = (joinery * prizePerOneJoinery);
                        }
                        break;
                }

                if(delivery == "With delivery")
                {
                    neededSum += 60;
                }

                if(joinery >= 100)
                {
                    neededSum -= neededSum * 0.04;
                }

                Console.WriteLine($"{neededSum:F2} BGN");
            }
        }
    }
}
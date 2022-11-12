using System;

namespace _08._Fuel_Tank___Part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            string card = Console.ReadLine();
            double priceGasolineOneLiter = 2.22;
            double priceDieselOneLiter = 2.33;
            double priceGasOneLiter = 0.93;
            double totalSum = 0;

            if(card == "Yes")
            {
                
                if (type == "Gas")
                {
                    priceGasOneLiter = 0.85;
                    totalSum = quantity * priceGasOneLiter;
                }

                else if (type == "Gasoline")
                {
                    priceGasolineOneLiter = 2.04;
                    totalSum = quantity * priceGasolineOneLiter;
                }

                else if (type == "Diesel")
                {
                    priceDieselOneLiter = 2.21;
                    totalSum = quantity * priceDieselOneLiter;
                }
            }
            else if(card == "No")
            {
                if (type == "Gas")
                {
                    totalSum = quantity * priceGasOneLiter;
                }

                else if (type == "Gasoline")
                {
                    totalSum = quantity * priceGasolineOneLiter;
                }

                else if (type == "Diesel")
                {
                    totalSum = quantity * priceDieselOneLiter;
                }
            }

            if(quantity >= 20 && quantity <= 25)
            {
                totalSum = totalSum - (totalSum * 0.08);
            }

            else if(quantity > 25)
            {
                totalSum = totalSum - (totalSum * 0.10);
            }

            Console.WriteLine($"{totalSum:F2} lv.");
        }
    }
}
using System;

namespace _02._Summer_Outfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperature = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            string outfit;
            string shoes;

            switch (time)
            {
                case "Morning":
                    if (temperature >= 10 && temperature <= 18)
                    {
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                        Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");
                    }
                    else if (temperature > 18 && temperature <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");
                    }
                    else if (temperature >= 25)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                        Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");
                    }
                    break;
                case "Afternoon":
                    if (temperature >= 10 && temperature <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");
                    }
                    else if (temperature > 18 && temperature <= 24)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                        Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");
                    }
                    else if (temperature >= 25)
                    {
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                        Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");
                    }
                    break;
                case "Evening":
                    if (temperature >= 10 && temperature <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");
                    }
                    else if (temperature > 18 && temperature <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");
                    }
                    else if (temperature >= 25)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");
                    }
                    break;
            }
        }
    }
}
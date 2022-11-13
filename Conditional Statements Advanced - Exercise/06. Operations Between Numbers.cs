using System;

namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double result = 0;
            string evenOrOdd = "";

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (secondNumber == 0)
                    {
                        Console.WriteLine($"Cannot divide {firstNumber} by zero");
                    }
                    else
                    {
                        result = firstNumber / secondNumber;
                    }
                    break;
                case "%":
                    if (secondNumber == 0)
                    {
                        Console.WriteLine($"Cannot divide {firstNumber} by zero");
                    }
                    else
                    {
                        result = firstNumber % secondNumber;
                    }
                    break;
            }

            if (result % 2 == 0)
            {
                evenOrOdd = "even";
            }
            else
            {
                evenOrOdd = "odd";
            }

            if (operation == "/" && secondNumber != 0)
            {
                Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result:F2}");
            }
            else if (operation == "%" && secondNumber != 0)
            {
                Console.WriteLine($"{firstNumber} % {secondNumber} = {result}");
            }
            else if (operation != "/" && operation != "%")
            {
                Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result} - {evenOrOdd}");
            }
        }
    }
}
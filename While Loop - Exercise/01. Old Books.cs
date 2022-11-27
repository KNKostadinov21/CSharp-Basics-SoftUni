using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            string checkedBook = Console.ReadLine();
            int counter = 0;
            bool isBookFounded = false;

            while(checkedBook != "No More Books")
            { 
                if(checkedBook == book)
                {
                    isBookFounded = true;
                    break;
                }

                counter += 1;
                checkedBook = Console.ReadLine();
            }

            if (isBookFounded)
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
            else 
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
        }
    }
}
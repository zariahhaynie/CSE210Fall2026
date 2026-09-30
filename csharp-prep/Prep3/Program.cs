using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber = 13;
        Console.WriteLine("Guess a number 1-50");
        int input = int.Parse(Console.ReadLine());

        while (input != magicNumber)
        {
            if (input > magicNumber)
            {
                Console.WriteLine("That's too high, guess again");
            }
            else
            {
                Console.WriteLine("That's too low, guess again");
            }

            Console.Write("What is your new guess? ");
            input = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("You guessed it!");
    }
}
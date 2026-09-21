using System;

class Program
{
    static void Main(string[] args)
    {
        string score;  
        Console.Write("Please enter your grade score: ");
        score = Console.ReadLine();
        int percentage = int.Parse(score);

        if (percentage > 90)
            Console.WriteLine("You got an A");
        else if (percentage > 80)
            Console.WriteLine("You got a B");
        else if (percentage > 70)
            Console.WriteLine("You got a C");
         else if (percentage > 60)
            Console.WriteLine("You got a D");
        else
            Console.WriteLine("You got an F");

    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction first = new Fraction();
        Fraction second = new Fraction(6);
        Fraction third = new Fraction(6, 7);
    first.SetTop(3);
        first.SetBottom(4);

        Console.WriteLine(first.GetTop());
        Console.WriteLine(first.GetBottom());
        Console.WriteLine(first.GetFractionString());
        Console.WriteLine(first.GetDecimalValue());
        Console.WriteLine(second.GetFractionString());
        Console.WriteLine(second.GetDecimalValue());
        Console.WriteLine(third.GetFractionString());
        Console.WriteLine(third.GetDecimalValue());

        Fraction randomFraction = new Fraction();
        Random random = new Random();

        for (int i = 1; i <= 20; i++)
        {
            int top = random.Next(1, 11);
            int bottom = random.Next(1, 11);

            randomFraction.SetTop(top);
            randomFraction.SetBottom(bottom);

            Console.WriteLine($"Fraction {i}: string: {randomFraction.GetFractionString()} Number: {randomFraction.GetDecimalValue()}");
        }
    }
}
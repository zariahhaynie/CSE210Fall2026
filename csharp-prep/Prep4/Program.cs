using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = 1;
        while (number != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        int sum = 0;
        foreach (int number2 in numbers)
        {
            sum = sum + number2;
        }
        Console.WriteLine("Sum: " + sum);
        float average = (float)sum / numbers.Count;
        Console.WriteLine("Average: " + average);
        int max = numbers[0];
        foreach (int number2 in numbers)
        {
            if (number2 > max)
            {
                max = number2;
            }
        }
        Console.WriteLine("Max: " + max);
    }
}

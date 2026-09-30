// using System;

// internal class Program
// {
//      static void Main(string[] args)
//     //  {
    //       bool done;

    //       do
    //       {
    //            Console.Write("Are we done? (y/n)");
    //            done = Console.ReadLine().ToLower() == "y";
    //       } while (!done);
    //  }
using System;

// class Program
// {
//     static void Main()
//     {
//         for (int i = 0; i <= 100; i+=10)
//         {
//             Console.WriteLine($"{i}-");
//             Console.WriteLine("Hey");
//         }
//     }


// }

// using System;

// class Program
// {
//     static void Main()
//     {
//     List<string> myFriends = ["Bob", "Betty", "Bubba"];
//     myFriends.Add("James");

//     foreach(string name in myFriends)
//         {
//             Console.WriteLine(name);
//         }
//     }
// }

class Program
{
    
    static double AddNumbers(double x, int y)
{
    return x + y;
}
    static void DisplayGreeting(string name)
    {
        Console.WriteLine($"Welcome {name}, pleased to meet you.");
    }
static void Main(string[] args)
{
    DisplayGreeting("Bob");
    double answer = AddNumbers(12.345, 10);
    Console.WriteLine();
    
}
}
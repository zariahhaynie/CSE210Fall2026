using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture myScripture = new Scripture("Moses", 1, 39,
            "Behold this is my work and my glory, to bring to pass the immortality and eternal life of man");

        string input = "";

        while (input != "quit")
        {
            Console.Clear();
            myScripture.ShowScripture();
            if (myScripture.IsCompletelyHidden())
        {
            break;
        }

            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type quit to exit.");
            input = Console.ReadLine();

            if (input != "quit")
            {
                myScripture.HideRandomWords();
            }
        }
    }
}
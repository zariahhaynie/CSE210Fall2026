class BaseActivity
{
    private string _name;
    private string _description;
    private int _duration;

    public BaseActivity(string name, string description)
    {
    _name = name;
    _description = description;
    }

    public void RunCountDownMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        for(int i=seconds; i>= 1; i--)
        {
            Console.Clear();
        Console.Write($"{message} - {i}");
        Thread.Sleep(1000);
        }
    
    Console.CursorVisible = true;
    }
    public void DisplaySpinnerMessage(string message, int seconds)
    {
        Console.CursorVisible = false;
        for (int i = 0; i < seconds; i++)
        {
            Console.Clear();
            Console.Write($"{message}");
            DateTime endTime = DateTime.Now.AddSeconds(1);

            while (DateTime.Now < endTime)
            {
                Console.Write("+");
                Thread.Sleep(200);
                Console.Write("\b");
                Console.Write("-");
                Thread.Sleep(200);
                Console.Write("\b");
            }
        }
    }
    
    public void DisplayStartingMessage()
    {
    Console.Clear();
    Console.WriteLine($"Welcome to the {_name}.");
    Console.WriteLine();
    Console.WriteLine(_description);
    Console.WriteLine();

    Console.Write("How long, in seconds, would you like for your session? ");
    _duration = int.Parse(Console.ReadLine());

    Console.WriteLine();
    RunCountDownMessage("Get ready", 5);
    }

    public void DisplayEndingMessage()
    {
    Console.WriteLine();
    DisplaySpinnerMessage("Well done!", 3);

    Console.Clear();
    Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");

    DisplaySpinnerMessage("Returning to menu", 3);
    List<string> messages = new List<string>()
    {
    "You're doing great!",
    "Good job",
    "You're being so productive",
    "Great work"
    };

Random random = new Random();
Console.WriteLine(messages[random.Next(messages.Count)]);
    }

public int GetDuration()
{
    return _duration;
}

}
class ListingActivity : BaseActivity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private Random _random = new Random();

    public ListingActivity() : base(
        "Listing Activity",
        "This activity will help you reflect by having you list as many things as you can.")
    {}

public void Run()
{
    DisplayStartingMessage();

    Console.Clear();

    string prompt = _prompts[_random.Next(_prompts.Count)];

    Console.WriteLine("Here is your prompt:");
    Console.WriteLine(prompt);
    Console.WriteLine();

    DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

    while (DateTime.Now < endTime)
    {
        string question = _prompts[_random.Next(_prompts.Count)];

        Console.Clear();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine(prompt);
        Console.WriteLine();

        Console.WriteLine(question);
        Console.WriteLine();

        int remaining = (int)Math.Ceiling(
            (endTime - DateTime.Now).TotalSeconds);

        DisplaySpinnerMessage("Thinking...", Math.Min(5, remaining));
    }

    DisplayEndingMessage();
}
}
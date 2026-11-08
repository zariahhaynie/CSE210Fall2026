class ReflectionActivity : BaseActivity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind in the future?"
    };
    private Random _random = new Random();
    public ReflectionActivity() : base(
        "Reflection Activity",
        "This activity will help you reflect on times in your life.")
    {}
    

public void Run()
{
    DisplayStartingMessage();

    Console.Clear();

    string prompt = _prompts[_random.Next(_prompts.Count)];

    Console.WriteLine("Consider the following prompt:");
    Console.WriteLine(prompt);
    Console.WriteLine();

    Console.Write("Press Enter when you're ready...");
    Console.ReadLine();

    DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

    while (DateTime.Now < endTime)
    {
        string question = _questions[_random.Next(_questions.Count)];

        Console.Clear();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine(prompt);
        Console.WriteLine();
        Console.WriteLine(question);
        Console.WriteLine();

        int remaining = (int)Math.Ceiling(
            (endTime - DateTime.Now).TotalSeconds);

        DisplaySpinnerMessage("", Math.Min(5, remaining));
    }

    DisplayEndingMessage();
}
}
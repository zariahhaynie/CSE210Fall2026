using System;

class JournalEntry
{
    public string _date;

    public string _prompt;

    public string _response;

    public void DisplayEntry()
    {
        Console.Write($"{_date} ");
        Console.WriteLine($"{_prompt}");
        Console.WriteLine($"{_response}");
    }

    public void CreateJournalEntry()
    {
        DateTime currentDate = DateTime.Now;
        _date = currentDate.ToShortDateString();

        List<string> prompts = new List<string>()
        {
            "How was your day?",
            "What was the best part of your day?",
            "What's something youre grateful for?",
            "What did you learn today?",
            "Did you do anything fun today?"
        };

        Random random = new Random();
        int index = random.Next(prompts.Count);

        _prompt = prompts[index];

        Console.WriteLine(_prompt);
        _response = Console.ReadLine();
    }
}
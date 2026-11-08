class BreathingActivity : BaseActivity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    { 
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            int remaining = (int)Math.Ceiling((endTime - DateTime.Now).TotalSeconds);
            RunCountDownMessage("Breathe in...", Math.Min(4, remaining));

            remaining = (int)Math.Ceiling((endTime - DateTime.Now).TotalSeconds);

            if (remaining > 0)
            {
                RunCountDownMessage("Breathe out...", Math.Min(6, remaining));
            }
        }

        DisplayEndingMessage();
    }
}



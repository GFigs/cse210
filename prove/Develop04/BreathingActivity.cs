public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _startingMessage = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing";
    }

    public void DoBreathingActivity()
    {
        Console.Clear();
        DisplayWellcomeMessage();
        AskDuration();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner(3);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {

            Console.Write("Breathe in...");
            Countdown(5);
            Console.WriteLine("");
            Console.Write("Breathe out...");
            Countdown(5);
            Console.WriteLine("");
            currentTime = DateTime.Now;
        }
        DisplayEndingMessage();
    }


}
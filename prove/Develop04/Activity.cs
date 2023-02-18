public class Activity
{
    protected string _name;
    protected string _startingMessage;
    protected int _duration;

    public void DisplayWellcomeMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_startingMessage);
        Console.WriteLine();
    }

    public void AskDuration()
    {
        Console.Write("How long, in seconds, would you like for your session?");
        int seconds = int.Parse(Console.ReadLine());
        _duration = seconds;
    }
    public void Spinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            currentTime = DateTime.Now;
        }
    }

    public void Countdown(int seconds)
    {
        int currentSecond = seconds;
        while (currentSecond > 0)
        {
            Console.Write(currentSecond);
            currentSecond--;
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("");
        Console.WriteLine("Well done!!");
        Console.WriteLine();
        Spinner(4);
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}");
        Thread.Sleep(2000);
    }

}

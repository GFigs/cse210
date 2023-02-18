public class ReflectionActivity : Activity
{
    private List<string> _promptsList = new List<string>();
    private List<string> _questionsList = new List<string>();


    public ReflectionActivity()
    {
        _name = "Reflection Activity";
        _startingMessage = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _promptsList.Add("Think of a time when you stood up for someone else.");
        _promptsList.Add("Think of a time when you did something really difficult.");
        _promptsList.Add("Think of a time when you helped someone in need.");
        _promptsList.Add("Think of a time when you did something truly selfless.");
        _questionsList.Add("Why was this experience meaningful to you?");
        _questionsList.Add("Have you ever done anything like this before?");
        _questionsList.Add("How did you get started?");
        _questionsList.Add("How did you feel when it was complete?");
        _questionsList.Add("What made this time different than other times when you were not as successful?");
        _questionsList.Add("What is your favorite thing about this experience?");
        _questionsList.Add("What could you learn from this experience that applies to other situations?");
        _questionsList.Add("What did you learn about yourself through this experience?");
        _questionsList.Add("How can you keep this experience in mind in the future?");
    }

    public string GetRandomPrompt()
    {
        int rndIndex = new Random().Next(0, _promptsList.Count());
        string prompt = _promptsList[rndIndex];
        return prompt;
    }
    public string GetRandomQuestion()
    {
        int rndIndex = new Random().Next(0, _questionsList.Count());
        string question = _questionsList[rndIndex];
        return question;
    }

    public void DoReflectionActivity()
    {
        Console.Clear();
        DisplayWellcomeMessage();
        AskDuration();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        DateTime currentTime = DateTime.Now;
        Console.Clear();
        Console.WriteLine("Get ready...");
        Spinner(3);
        Console.WriteLine("");
        Console.WriteLine("Consider the following prompt");
        Console.WriteLine("");
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("");
        Console.Write("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        Countdown(4);
        Console.Clear();
        while (currentTime < futureTime)
        {
            Console.WriteLine(GetRandomQuestion());
            Spinner(4);
            currentTime = DateTime.Now;
        }
        DisplayEndingMessage();
    }
}
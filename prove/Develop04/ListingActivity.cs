public class ListingActivity : Activity
{
    private List<string> _promptsList = new List<string>();

    public ListingActivity()
    {
        _name = "Listing Activity";
        _startingMessage = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _promptsList.Add("Who are people that you appreciate?");
        _promptsList.Add("What are personal strengths of yours?");
        _promptsList.Add("Who are people that you have helped this week?");
        _promptsList.Add("When have you felt the Holy Ghost this month?");
        _promptsList.Add("Who are some of your personal heroes?");
    }
    public string GetRandomPrompt()
    {
        int rndIndex = new Random().Next(0, _promptsList.Count());
        string prompt = _promptsList[rndIndex];
        return prompt;
    }
    public void DoListingActivity()
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
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine(GetRandomPrompt());
        Console.Write("You may begin in: ");
        Countdown(5);
        int numOfItems = 0;
        while (currentTime < futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            currentTime = DateTime.Now;
            numOfItems++;
        }
        Console.WriteLine($"You listed {numOfItems} items!");
        DisplayEndingMessage();
    }
}
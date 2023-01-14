using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public List<string> _prompts = new List<string>();

    public string GetPrompt()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, this._prompts.Count);
        string randomPrompt = this._prompts[number - 1];

        return randomPrompt;
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine("");
            // Console.WriteLine($"{entry._date}");
            Console.WriteLine($"Prompt: {entry._prompt}");
            Console.WriteLine($"Reponse: {entry._response}");
        }
    }

}
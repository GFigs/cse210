using System;
using System.IO;

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
        foreach (Entry entry in this._entries)
        {
            Console.WriteLine("");
            Console.WriteLine($"{entry._date}");
            Console.WriteLine($"Prompt: {entry._prompt}");
            Console.WriteLine($"Reponse: {entry._response}");
        }
    }

    public void SaveEntries(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in this._entries)
            {
                outputFile.WriteLine($"{entry._prompt}|{entry._date}|{entry._response}");
            }
        }
    }

    public void LoadEntries(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry newEntry = new Entry();
            newEntry._prompt = parts[0];
            newEntry._date = parts[1];
            newEntry._response = parts[2];

            newEntry.AddToEntries(this._entries);
        }
    }
    public void GoodbyeMessage()
    {
        int totalEntries = this._entries.Count();
        int todayEntries = 0;
        DateTime currentTime = DateTime.Now;
        string currentDate = currentTime.ToShortDateString();

        foreach (Entry entry in this._entries)
        {
            if (currentDate == entry._date)
            {
                todayEntries++;
            }

        }

        Console.WriteLine($"Good bye for now. You wrote today {todayEntries} entries. You have a total of {totalEntries}.");
    }

}
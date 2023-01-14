using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        journal._prompts.Add("Who was the mos interesting person I interacted with today?");
        journal._prompts.Add("What was the best part of the my day?");
        journal._prompts.Add("What was the strongest emotion I felt today?");
        journal._prompts.Add("If I had one thing I could do over today, What would that be?");


        int usersChoice = 0;
        Console.WriteLine("Welcome to Journal Program!");

        while (usersChoice != 5)
        {
            usersChoice = DisplayMenu();

            if (usersChoice > 5 || usersChoice < 1)
            {
                Console.WriteLine("Please enter a valid option.");
            }
            else if (usersChoice == 1)
            {
                Entry currenEntry = new Entry();
                currenEntry._prompt = journal.GetPrompt();
                Console.WriteLine(currenEntry._prompt);
                currenEntry._response = Console.ReadLine();
                currenEntry.GetDate();
                currenEntry.AddToEntries(journal._entries);
            }
            else if (usersChoice == 2)
            {
                journal.DisplayEntries();
            }
            else if (usersChoice == 3)
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                journal.LoadEntries(filename);
            }
            else if (usersChoice == 4)
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                journal.SaveEntries(filename);
            }
            else
            {
                Console.WriteLine("Have a nice day");
            }
        }
    }

    static int DisplayMenu()
    {
        Console.WriteLine("");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        int choice = int.Parse(Console.ReadLine());

        return choice;
    }
}
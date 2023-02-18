using System;

class Program
{
    static void Main(string[] args)
    {
        Reference scriptureRefence = new Reference("1 Nephi", "3", "7");
        Scripture scripture = new Scripture(scriptureRefence, "Therefore go, my son, and thou shalt be favored of the Lord, because thou hast not murmured");


        string userInput = "";

        while (userInput != "quit" && scripture.checkWordsLeft() == false)
        {
            scripture.DisplayScripture();
            Console.WriteLine();
            Console.ReadLine();
            scripture.hide_words();
        }

    }
}
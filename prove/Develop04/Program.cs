using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        ListingActivity listingActivity = new ListingActivity();

        int userInput = 0;

        while (userInput != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu:");
            userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    breathingActivity.DoBreathingActivity();
                    break;
                case 2:
                    reflectionActivity.DoReflectionActivity();
                    break;
                case 3:
                    listingActivity.DoListingActivity();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Please enter a valid option");
                    breathingActivity.Spinner(3);
                    break;
            }
        }
    }
}
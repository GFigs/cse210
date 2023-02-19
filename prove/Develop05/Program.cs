using System;

class Program
{
    static void Main(string[] args)
    {
        int score = 0;
        int userInput = 0;
        List<Goal> goalsList = new List<Goal>();
        while (userInput != 6)
        {
            Console.WriteLine($"You have {score} points");
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    Console.WriteLine("The types of goals are: ");
                    Console.WriteLine("  1. Simple Goal");
                    Console.WriteLine("  2. Eternal Goal");
                    Console.WriteLine("  3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    int goalChoice = int.Parse(Console.ReadLine());
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.Write("What is a shot description of it? ");
                    string goalDescription = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int goalPoints = int.Parse(Console.ReadLine());

                    if (goalChoice == 1)
                    {
                        SimpleGoal newGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
                        goalsList.Add(newGoal);
                    }
                    else if (goalChoice == 2)
                    {
                        EternalGoal newGoal = new EternalGoal(goalName, goalDescription, goalPoints);
                        goalsList.Add(newGoal);
                    }
                    else if (goalChoice == 3)
                    {
                        Console.Write("How many times does this goal ned to be accomplished? ");
                        int goalTimesToComplete = int.Parse(Console.ReadLine());
                        Console.Write("What is the bonus for accomplishing it that many times? ");
                        int goalBonusPoints = int.Parse(Console.ReadLine());

                        CheckListGoal newGoal = new CheckListGoal(goalName, goalDescription, goalPoints, goalBonusPoints, goalTimesToComplete);
                        goalsList.Add(newGoal);
                    }
                    break;
                case 2:
                    for (int i = 0; i < goalsList.Count(); i++)
                    {
                        int goalNumber = i + 1;
                        Console.Write($"{goalNumber}. ");
                        goalsList[i].DisplayGoal();
                    }
                    break;
                case 3:
                    Console.Write("What is the filename for the goal file? ");
                    string filename = Console.ReadLine();

                    using (StreamWriter outputFile = new StreamWriter(filename))
                    {
                        outputFile.WriteLine(score);
                        foreach (Goal goal in goalsList)
                        {
                            outputFile.WriteLine(goal.GetStringRepresentation());
                        }
                    }
                    break;
                case 4:
                    Console.Write("What is the filename for the goal file? ");
                    string loadFilename = Console.ReadLine();
                    string[] lines = System.IO.File.ReadAllLines(loadFilename);
                    score = int.Parse(lines[0]);
                    for (int i = 1; i < lines.Count(); i++)
                    {
                        string[] parts = lines[i].Split(":");
                        if (parts[0] == "SimpleGoal")
                        {
                            SimpleGoal newGoal = new SimpleGoal("", "", 0);
                            newGoal.CreateGoal(parts[1]);
                            goalsList.Add(newGoal);
                        }
                        else if (parts[0] == "EternalGoal")
                        {
                            EternalGoal newGoal = new EternalGoal("", "", 0);
                            newGoal.CreateGoal(parts[1]);
                            goalsList.Add(newGoal);
                        }
                        else if (parts[0] == "EternalGoal")
                        {
                            CheckListGoal newGoal = new CheckListGoal("", "", 0, 0, 0);
                            newGoal.CreateGoal(parts[1]);
                            goalsList.Add(newGoal);
                        }
                    }

                    break;
                case 5:
                    for (int i = 0; i < goalsList.Count(); i++)
                    {
                        int goalNumber = i + 1;
                        Console.Write($"{goalNumber}. ");
                        goalsList[i].DisplayGoal();
                    }
                    Console.Write("Wich goal did you accomplish? ");
                    int goalAccomplished = int.Parse(Console.ReadLine()) - 1;
                    int pointsEarned = goalsList[goalAccomplished].RecordEvent();
                    Console.WriteLine($"Contratulations! You have earned {pointsEarned} points!");
                    score = score + pointsEarned;
                    Console.WriteLine("");

                    break;
                default:
                    break;

            }



        }
    }
}
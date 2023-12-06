using System;
using System.ComponentModel.Design.Serialization;
using System.Runtime.CompilerServices;

public class Program
{
    private static List<Goals> _goals = new List<Goals>();
    private static void Main(string[] args)
    {

        while (true)
        {
            int userInput;
            // Console.WriteLine($"You have {_totalPointsEarned} points.");
            // Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Select a choice from the menu:");
            userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoal();
                    break;
                case 3:
                    SaveGoal();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
    private static void CreateGoal()
    {
        
        
        int user;
        Console.WriteLine("The type of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        
        user= int.Parse(Console.ReadLine());
        switch (user)
        {
            case 1:
            _goals.Add(new SimpleGoal());
            break;
            case 2:
            _goals.Add(new EternalGoal());
            break;
            case 3:
            _goals.Add(new ChecklistGoal());
            break;
            default:
            Console.WriteLine("Invalid input");
            break; 
        }
    }
    public static bool GoalsToRecord()
    {
        foreach (Goals goal in _goals)
        {
            if (!goal.GetCompleted()) 
                return true;
        }
        return false;
    }
    public static int GoalCountList()
    {
        int index = 1;
        foreach (Goals goal in _goals)
        {
            if (!goal.GetCompleted())
                Console.WriteLine($"{index++}. {goal.GetName()}");
        }
        return index -1;
    }
    public static Goals GetGoalsToFinish(int indexToDo)
    {
        int index = 1;
        foreach (Goals goal in _goals)
        {
            if (!goal.GetCompleted())
            {
                if (index == indexToDo)
                    return goal;
                index ++;
            }
        }
        return null;
    }
    private static void RecordEvent()
    {
        if (!GoalsToRecord())
        {
            Console.WriteLine("There are no goals");
        }
        int input = 0;
        int maxIndex = -1;
        while (input <= 0 || input > maxIndex)
        {
            Console.WriteLine("The goals availbe to complete are:");
            maxIndex = GoalCountList();
            Console.WriteLine("Which goal did you complete?");
            input = int.Parse(Console.ReadLine());
        }
        Goals theGoalToComplete = GetGoalsToFinish(input);
        System.Diagnostics.Debug.Assert(theGoalToComplete != null);
        theGoalToComplete.Complete();
    }
    private static void ListGoal()
    {
        int score = 0;
        Console.WriteLine("The goals are:");
        foreach (Goals goal in _goals)
        {
            Console.WriteLine(goal.GetCompletedDisplay());
            score += goal.GetPointsEarned();
        }
        Console.WriteLine();
        Console.WriteLine($"You have {score} points");
        Console.WriteLine();
    }
    private static void SaveGoal()
    {
        Console.WriteLine("Enter file:");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
    {
        foreach (Goals goal in _goals)
        {
            writer.WriteLine(goal.GetType().FullName);
            goal.WritetoStreamWriter(writer);
        }
    }
    }
    private static void LoadGoals()
    {
        Console.Write("Enter filename to load from: ");
        string filename = Console.ReadLine();
        _goals.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            while (!reader.EndOfStream)
            {
                string type = reader.ReadLine();
                switch (type)
                {
                    case "GoalTracker.SimpleGoal":
                        _goals.Add(new SimpleGoal(reader));
                    break;
                    case "GoalTracker.ChecklistGoal":
                        _goals.Add(new ChecklistGoal(reader));
                    break;
                    case "GoalTracker.EternalGoal":
                        _goals.Add(new EternalGoal(reader));
                    break;
                    default:
                        Console.WriteLine("Invalid input");
                    break;
                }
            }
        }
    }
}
using System;
public class Goals
{   
    protected int _points;
    protected string _cGoal;
    public Goals(int points)
    {
        _points = points;
    }
    public void GoalChoice(int points)
    {
        int goalChoice = 0;
        while (true)
        {
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            goalChoice = int.Parse(Console.ReadLine());
            switch (goalChoice)
            {
                case 1:
                    Console.Write("What is a short description of it?");
                    // string cGoal = Console.Read();
                    // Console.WriteLine;
                    break;

                case 2:

                    break;

                case 3:

                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;

                
            }
        }
    }
}
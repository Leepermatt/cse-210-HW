using System;

class Program
{
    
    static void Main(string[] args)
    {
        int _points = 0;
        int userInput = 0;
        while (true)
        {
            Console.WriteLine($"You have {_points} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu:");
            userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {   
                case 1:

                    // Goals goals = new (points);
                    // GoalChoice();
                    
                    
                    
                    break;
                case 2:

                    break;
                case 3:
                    string fName = "";
                    Console.WriteLine("What is the file name:");
                    fName = Console.ReadLine();
                    // Compose a string that consists of three lines.
                    string lines = "First line.\r\nSecond line.\r\nThird line.";

                    // Write the string to a file.
                    System.IO.StreamWriter file = new System.IO.StreamWriter(fName);
                    file.WriteLine(lines);

                    file.Close();
                    break;
                case 4:
                    
                    Console.WriteLine("Type file to load.");
                    string sName = Console.ReadLine();
                    // Read entire text file content in one string
                    string text = File.ReadAllText(sName);
                    Console.WriteLine(text);
                    break;
                case 5:

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
}
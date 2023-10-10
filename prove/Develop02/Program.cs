using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {

        Journal journal = new();
        int userInput = 0;

        while (true)
        {
            Console.WriteLine("Welcome to Your Daily Journal!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");


            Console.Write("What would you like to do? ");
            userInput = int.Parse(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    journal.AddEntry();
                    break;
                case 2:
                    journal.DisplayEntries();
                    break;
                case 3:
                    journal.ReadFromFile();
                    break;
                case 4:
                    journal.SaveToFile();
                    break;

                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}

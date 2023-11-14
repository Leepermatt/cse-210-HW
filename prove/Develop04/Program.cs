using System;

class Program
{
    static void Main(string[] args)
    {
        int userInput = 0;
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start breathing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu:");
            userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {   
                case 1:
                    Console.WriteLine ("How Long would (in seconds), would you like to do this for?");
                    int time = int.Parse(Console.ReadLine());
                    Breathing breathing = new(time);
                    breathing.RunBreathingActivity();
                    break;
                case 2:
                    Console.WriteLine ("How Long would (in seconds), would you like to do this for?");
                    int rTime = int.Parse(Console.ReadLine());
                    Reflecting reflecting = new(rTime);
                    reflecting.RunReflectingActifvity();
                    break;
                case 3:
                    Console.WriteLine ("How Long would (in seconds), would you like to do this for?");
                    int lTime = int.Parse(Console.ReadLine());
                    Listing listing = new(lTime);
                    listing.RunListingActivity();          
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
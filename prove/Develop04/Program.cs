using System;

class Program
{
    static void Main(string[] args)
    {
        Mindfulness mindfulness = new ();
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
                    mindfulness.WelcomeMessage();
                    mindfulness.Spinner();
                    mindfulness.CountDown();
                    // Console.Write.Breathing.BreathingWelcome();
                    // mindfulness.BreathingPrompt();
                    mindfulness.WellDone();
                    break;
                case 2:
                    mindfulness.WelcomeMessage();
                    mindfulness.Spinner();
                    // mindfulness.ReflectionList();


                    break;
                case 3:
                    // string Listing.GetListingActivity();
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
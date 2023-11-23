using System;
using System.Net;
public class Listing : Mindfulness
{
    public Listing(int time) : base(time)
    {
        _activity = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area";
    }
    private List<string> response= new(); 
    private List<string> prompts = new()
    {
        "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"
    };
    
    public void GetRandomPrompt()
    {
        Random rnd = new Random();
        string d = prompts[rnd.Next(prompts.Count)];
        Console.WriteLine(d);
    }
    public void RunListingActivity()
    {
        int counter = 0;
        WelcomeMessage();
        Console.WriteLine("List as many responses as you can to the following Prompt:");
        GetRandomPrompt();
        Spinner(5);
        DateTime endTime = DateTime.Now.AddSeconds(_time);
        while (DateTime.Now < endTime)
        {
            string newItem = Console.ReadLine();
            response.Add(newItem);
            counter++;
        }       
        EndMessage();
        SaveToFile();
        Console.WriteLine($"You listed {counter} number of items.");
        Spinner(5);
    }
}
using System;
public class Reflecting : Mindfulness
{
    private string _activity = "Reflecting Activity";
    private string _welcomePrompt = "reflection on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    public void ReflectionList()
    {
        List<string> reflectingList = new List<string>();
        reflectingList.Add("Think of a time when you did something really difficult");
        reflectingList.Add("Think of a time when you stood up for someone else");
        reflectingList.Add("Think of a time when you helped someone in need");
        reflectingList.Add("Think of a time when you did something truly selfless");
        Random rnd = new Random();
        string s = reflectingList[rnd.Next(reflectingList.Count)];
        Console.WriteLine("Consider the following Prompt:");
        Console.WriteLine($"----{s}----");
        // return randomString = reflectingList.PickRandom()
        // reflectingList[Random(reflectingList.Count)];
    }
    public void Followup()
    {
        List<string> followUpList = new List<string>();
        followUpList.Add("Why was this experience meaningful to you?");
        followUpList.Add("Have you ever done anything like this before?");
        followUpList.Add("How did you get started?");
        followUpList.Add("How did you feel when it was complete?");
        followUpList.Add("What made this time different than other times when you were not as successful?");
        followUpList.Add("What is your favorite thing about this experience?");
        followUpList.Add("What could you learn from this experience that applies to other situations?");
        followUpList.Add("What did you learn about yourself through this experience?");
        followUpList.Add("How can you keep this experience in mind in the future?");
        Random rnd = new Random();
        string f = followUpList[rnd.Next(followUpList.Count)];

        Console.WriteLine(f);
    }
    public void Continue()
    {
        Console.WriteLine("When you have something in mind, press enter");
        var Input = Console.ReadLine;
        while (Console.ReadKey().Key != ConsoleKey.Enter)
        {
            Spinner();
        }
    }
    public void Ponder()
    {
        Console.Write ($"Now ponder on each of the following questions as they relate to this experience. You may begin in");
        CountDown();
    }

}
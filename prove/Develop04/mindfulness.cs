using System;
using System.Runtime.InteropServices.Marshalling;
public class Mindfulness
{
    private string _activity;
    
    private string _endingMessage;
    private string _wellDone;
    private int _time;
    private int _timeActivity;
  
    public int GetTime()
    {
        return _time;
    }
    public string WelcomeMessage()
    {
        return $"Welcome to the {_activity}";
        // Console.WriteLine ($"This activity will help you relax by {GetWelcome()} ");
        // Console.WriteLine ("How Long would (in seconds), would you like to do this for?");
        // _time = int.Parse(Console.ReadLine());
        
    }

    private object GetWelcome()
    {
        return $"{_activity}";
    }

    public string WellDone()
    {
        Console.WriteLine("Well done!");
        Spinner();
        return $"You have completed {GetTime()} seconds of {_activity}";
    }
    public void Spinner()
    {
        Console.WriteLine ("Get Ready...");
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        // foreach (string s in animationStrings)
        // {
        //     Console.Write(s);
        //     Thread.Sleep(500);
        //     Console.Write("\b \b");
        // }
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(5);
    int i = 0;
    while (DateTime.Now < endTime)
    {
        string s = animationStrings[i];
        Console.Write(s);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        i++;
        if (i>= animationStrings.Count)
        {
            i = 0;
        }
    }
    }
    public void CountDown()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
            
        }
        Console.Write("Go:");
    }

}
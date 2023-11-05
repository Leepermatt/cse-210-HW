using System;


 public class Breathing : Mindfulness
 {
    private string  _activity = "Breathing Activity";
    private string _welcomePrompt ="walking you through breathing in and out slowly. Clear your mind and focus on your breathing";
    // 
    public string GetWelcome()
    {
        return _welcomePrompt;
    }
    public void SetWelcome(string activity)
    {
        _activity = activity;
    }
    public string GetActivity()
    {
        return _activity;
    }
    public void BreathingPrompt()
    {
            {
        
        List<string> animationStrings = new List<string>();
        animationStrings.Add("Breath in...");
        animationStrings.Add("Breath out...");


        // foreach (string s in animationStrings)
        // {
        //     Console.Write(s);
        //     Thread.Sleep(500);
        //     Console.Write("\b \b");
        // }
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(GetTime());
    int i = 0;
    while (DateTime.Now < endTime)
    {
        string s = animationStrings[i];
        Console.Write(s);
        Thread.Sleep(5000);
        // Console.Write("\b \b");
        i++;
        if (i>= animationStrings.Count)
        {
            i = 0;
        }
    }
    }
        
    }
 }

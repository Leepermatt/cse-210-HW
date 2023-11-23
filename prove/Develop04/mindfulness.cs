using System;
using System.Runtime.InteropServices.Marshalling;
public class Mindfulness
{
    protected string _activity;
    protected string _description;
    protected int _time;
    private List<string> response = new();
    private List<string> animationStrings = new()
    {
        "|", "/", "-", "\\"
    };
    public Mindfulness(int time)
    {
        _time = time;
    }
    public void WelcomeMessage()
    {
        Console.WriteLine($"Welcome to the {_activity}");
        Console.WriteLine(_description);
        Console.WriteLine("Get Ready...");
        Spinner(5);
    }
    public void EndMessage()
    {
        Console.WriteLine("Well done!");
        Spinner(5);
        Console.WriteLine($"You have completed {_time} seconds of {_activity}");
    }
    public void Spinner(int time)
    {
        DateTime endTime = DateTime.Now.AddSeconds(time);
        while (DateTime.Now < endTime)
        {
            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
        }
    }
    public void CountDown(int time)
    {
        for (int i = time; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");  
        }
    }
    public void SaveToFile()
    {
        using (StreamWriter Outputfile = new StreamWriter("activityLog.txt"))
            foreach (string line in response)
            {
                Outputfile.WriteLine(line);                
            }
    }
}
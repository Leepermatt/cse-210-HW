using System;
public class Reflecting : Mindfulness
{
    public Reflecting(int time) : base(time)
    {
        _activity = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
    private List<string> randomprompt = new()
    {
        "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."
    };
    public void RandomPrompt()
    {
        Random rnd = new Random();
        string f = randomprompt[rnd.Next(randomprompt.Count)];
        Console.WriteLine(f);
    }
    private List<string> responseList = new()
    {
        "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"
    };
    public void ResponseList()
    {
        Random rnd = new Random();
        string e = responseList[rnd.Next(responseList.Count)];
        Console.WriteLine(e);
    }
    public void RunReflectingActifvity()
    {
        WelcomeMessage();
        RandomPrompt();
        ResponseList();
        Spinner(10);
        DateTime endTime = DateTime.Now.AddSeconds(_time);
        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
        }
        EndMessage();
    }

    public string GetReflectingActivity()
    {
         return _activity;
    }
    public void SetReflectingActivity(string activity)
    {
        _activity = activity;
    }
}



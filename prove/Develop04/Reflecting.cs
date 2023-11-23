using System;
public class Reflecting : Mindfulness
{
    private List<string> prompts = new()
    {
        "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."
    };
    private List<string> questions = new()
    {
        "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"
    };

    public Reflecting(int time) : base(time)
    {
        _activity = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
    private List<string> response= new();
    public void GetRandomPrompt()
    {
        Random rnd = new Random();
        string f = prompts[rnd.Next(prompts.Count)];
        Console.WriteLine(f);
    }

    public void GetRandomQuestion()
    {
        Random rnd = new Random();
        string e = questions[rnd.Next(questions.Count)];
        Console.WriteLine(e);
    }

    public void RunReflectingActifvity()
    {
        int counter = 0;
        WelcomeMessage();
        Console.WriteLine("Consider the following prompt:");
        GetRandomPrompt();
        Console.WriteLine("When you are ready press enter to continue");
        string go = Console.ReadLine();
        DateTime endTime = DateTime.Now.AddSeconds(_time);
        while (DateTime.Now < endTime)
        {
            GetRandomQuestion();
            counter++;
            string newItem = Console.ReadLine();
            response.Add(newItem);
        }
        EndMessage();
        Console.WriteLine($"You listed {counter} number of items.");
        SaveToFile();
    }
}



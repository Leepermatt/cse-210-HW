public class Entry
{
    public string _prompt;
    //public string Prompt { get{ return _prompt; } set{_prompt = value;} }
    public string _response;
    public string _dateText;
    public string _mood;
    public PromptGenerator promptGenerator;

    public Entry()
    {
        promptGenerator = new PromptGenerator();
    }
    public Entry(string prompt, string response, string date, string mood)
    {
        _prompt = prompt;
        _response = response;
        _dateText = date;
        _mood = mood;
        promptGenerator = new PromptGenerator();
    }

    public void Write()
    {
        _dateText = DateTime.Now.ToShortDateString();
        _prompt = promptGenerator.GenerateRandomPrompt();
        Console.WriteLine($"{_prompt}");
        Console.Write("> ");
        _response = Console.ReadLine();
        Console.WriteLine("What was your mood today?");
        _mood = Console.ReadLine();
    }

    public void Display()
    {
        
        Console.WriteLine($"{_prompt} {_response} {_dateText} {_mood}");
    }

    // public void SetPrompt(string prompt)
    // {
    //     _prompt = prompt;
    // }

    // public string GetPrompt()
    // {
    //     return _prompt;
    // }
}
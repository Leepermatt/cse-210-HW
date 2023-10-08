using System;

public class PromptGenerator {
public List<string> _prompts {get; set;}

    public PromptGenerator() {
        _prompts = new List<string> {
            "Did anything make you happy today?",
            "Write about something you noticed that reminded you of Jesus Christ today:",
            "Write about an experience where you felt the spirit with you today:",
            "Who was the most interesting person you interacted with today?",
            "Write about something that happened for which you are grateful today:",
            "What one thing would you like to change about today?",
                  
        };
    }

    public string GenerateRandomPrompt() {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

}
using System;

public class Journal {
    public string _prompts;
    public string _entry;
    public int _dateText;
    public string _mood;
public List <Journal> _entries;
public PromptGenerator promptGenerator;

    
    public Journal() {
        _entries = new List<Journal>();
        promptGenerator = new PromptGenerator();
    }

    
    public void AddEntry() {
    
        string _prompts = promptGenerator.GenerateRandomPrompt();

        Console.WriteLine($"{_prompts}");
        Console.Write("> ");
        string _entries = Console.ReadLine();
        Console.WriteLine("What was your mood today?");
        string _mood = Console.ReadLine();
        DateTime theCurrentTime = DateTime.Now;
        int _dateText = int.Parse (theCurrentTime.ToShortDateString());

    }

    public void DisplayEntries() {
        foreach (Journal entry in _entries) {
            entry.DisplayEntries();
        }
    }


    public static void SaveToFile(List<Journal>journalEntries)
    {
        List<Journal>_entries = new List<Journal>();
        string fileName = Console.ReadLine();
        Console.WriteLine ("Saving to file....");
        using (StreamWriter Outputfile = new StreamWriter(filename));
        }
            foreach (Journal _entries in journalEntries);
            {
                ouputfile.WriteLine($"{_entries._prompts}~~{_entries.dateText}~~{_entries.Content}~~{entries._mood}");
            }
        }
    }
    public static List<Journal> ReadFromFile();
    {
        List<Journal>_entries = new List<Journal>();
        string fileName = Console.ReadLine();
        Console.WriteLine ("Reading from file....");
        foreach (Journal _entries in journalEntries);
        {
            string[] lines =System.IO.File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split("~~");
                Console.WriteLine(line);

                Journal newJournal = new Journal();
                newJournal._nPrompts = parts[0];
                newJournal.nDate = parts[1];
                newJournal._nEntry = parts[2];
                newJournal.nMood = parts[3];
                Journal.Add(newJournal);
            }

        }

        return _entries;

    }


}
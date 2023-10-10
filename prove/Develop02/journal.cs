using System;

public class Journal
{
    public List<Entry> _entries;


    public Journal()
    {
        _entries = new List<Entry>();
    }


    public void AddEntry()
    {
        Entry entry = new();
        entry.Write();
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }


    public void SaveToFile()
    {
        Console.WriteLine("Enter the file name:");
        string fileName = Console.ReadLine();
        Console.WriteLine("Saving to file....");
        using (StreamWriter Outputfile = new(fileName, true))
        {
            foreach (Entry entry in _entries)
            {
                Outputfile.WriteLine($"{entry._prompt}~~{entry._response}~~{entry._dateText}~~{entry._mood}");
            }
        }
    }


    public void ReadFromFile()
    {
        Console.WriteLine("Enter file name:");
        string fileName = Console.ReadLine();
        Console.WriteLine("Reading from file....");
        string[] lines = File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");
            //Console.WriteLine(line);
            string prompt = parts[0];
            string response = parts[1];
            string date = parts[2];
            string mood = parts[3];
            Entry entry = new Entry(prompt, response, date, mood);
            _entries.Add(entry);
        }
    }
}
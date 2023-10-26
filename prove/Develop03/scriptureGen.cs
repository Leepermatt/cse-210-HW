using System;
public class ScriptureGen
{
    // public List<string> _scriptures = new();
    //public string Prompt { get{ return _p

    // private void randomScripture()
    // {
    //     string[] lines = File.ReadAllLines("scripture.txt");
    //     string[] ranLine = lines.Split('');
    //     foreach (string line in ranLines)
    //     {
    //         string[] parts = line.Split("~~");
    //         //Console.WriteLine(line);
    //         string book = parts[0];
    //         string chapter = parts[1];
    //         string verse = parts[2];
    //         string scripture = parts[3];
    //     }
        public class Scripture
    {
        public string Reference { get; private set; }
        public string Text { get; private set; }
 
        // <summary>
        // Constructs a new scripture with the provided reference and text.
        //
        // Parameters:
        // - reference: The reference of the scripture.
        // - text: The text of the scripture.
        // </summary>
        public Scripture(string reference, string text)
        {
            Reference = reference;
            Text = text;
        }
    }
}
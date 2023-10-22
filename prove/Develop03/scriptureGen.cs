using System;
public class ScriptureGen
{
    public List<string> _scriptures = new();
    //public string Prompt { get{ return _p

    private void randomScripture()
    {
        string[] lines = File.ReadAllLines("scripture.txt");
        string[] ranLine = Random();
        foreach (string line in ranLines)
        {
            string[] parts = line.Split("~~");
            //Console.WriteLine(line);
            string book = parts[0];
            string chapter = parts[1];
            string verse = parts[2];
            string scripture = parts[3];
        }
    
}
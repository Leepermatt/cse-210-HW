using System;
using System.Text;
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList(); 
    }
    public void Display()
    {
        Console.Clear();
        StringBuilder scriptureText = new StringBuilder();
        foreach (Word word in _words)
        {
            scriptureText.Append(word.GetText() + " ");
        }
        Console.WriteLine(_reference.ToString() + "\n" + scriptureText);
    }
    public bool ALLWordsHidden()
    {
        return _words.All(word => word.IsHiddenWord());
    }
    public void HideRandomWord()
    {
        List<Word> unhideWords = _words.Where(word => !word.IsHiddenWord()).ToList();
        Random random = new Random();
        int randomIndex;
        Console.WriteLine("unhide word count:");
        Console.WriteLine(unhideWords.Count);
        randomIndex = random.Next(0, unhideWords.Count - 1);
        Console.WriteLine(randomIndex);
        unhideWords[randomIndex].Hide();
    }
}
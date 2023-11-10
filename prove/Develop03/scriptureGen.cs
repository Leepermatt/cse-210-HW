using System;
public class Reference
{
private string _book;
private int _chapter;
private int _verseStart;
private int _verseEnd;
private string _scripture;
// public Reference(string book, int chapter, int verseStart, int verseEnd, string scripture)
public Reference(string book, int chapter, int verseStart, int verseEnd)
{
    _book = book;
    _chapter = chapter;
    _verseStart = verseStart;
    _verseEnd = verseEnd;
    // _scripture = scripture;
}
public string GetBook()
{
    return _book;
}
public void SetBook(string book)
{
    _book = book;
}
public int GetChapter()
{
    return _chapter;
}
public void SetChapter(int chapter)
{
    _chapter = chapter;
}
public int GetVerseStart()
{
    return _verseStart;
}
public void SetVerseStart(int verseStart)
{
    _verseStart = verseStart;
}   
public int GetVerseEnd()
{
    return _verseEnd;
}
public string GetScripture()
{
    return _scripture;
}
public void SetScripture(string scripture)
{
    _scripture = scripture;
}
    public override string ToString()
    {        
        if (_verseEnd > 0)
        {
            return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verseStart}";
        }      
    }
    //     public void ReadFromFile()
    // {
        
    //     string fileName = "scripture.txt";
    //     string[] lines = File.ReadAllLines(fileName);
    //     foreach (var line in lines)
    //     {
    //         string[] parts = line.Split("~~");
    //         string book = parts[0];
    //         int chapter = int.Parse(parts[1]);
    //         int verseStart = int.Parse(parts[2]);
    //         int verseEnd = int.Parse(parts[3]);
    //         string scripture = parts[4];
    //         Reference _reference = new Reference(book, chapter, verseStart, verseEnd, scripture);
            
    //     }
    // }
}

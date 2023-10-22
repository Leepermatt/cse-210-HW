using System;
public class Word
{    
    static Random rand = new Random();
    private string _words;
    private string _book;
    private string _chaper;
    private string _verse;
    static void HideWord()
    {
    while (true)
       { 
         Console.WriteLine(_words);
         string[] words = _words.Split(' ');
         int numWords = words.Length;
         bool delay = true;

         for(int i = 1; i <= numWords; i++)
         {
            
            int randNum = rand.Next(0, numWords);
            string randWord = words[randNum];

            if (randWord[0] != '_')
            {
               words[randNum] = new string('_', randWord.Length);
               Console.WriteLine(String.Join(" ", words));
               
            }
            else
            {

            } 
    }
}


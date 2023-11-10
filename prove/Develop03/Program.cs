using System;
public class Program
{
    static void Main(string[] args)
    {   
        // Reference _reference = new Reference.SetScripture();
        // _scripture.ReadFromFile()
        // Reference _reference = new Reference.ReadFromFile();
        Reference _reference = new Reference("John", 3, 13, 13);
        Scripture _scripture = new Scripture(_reference,"For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life.");
        _scripture.Display();
        do
        {
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to end the program.");
            string input = Console.ReadLine().ToLower();
            if (input == "quit")
            {
                break;
            }
            else
            {
                _scripture.HideRandomWord();
                _scripture.Display();
                if (_scripture.ALLWordsHidden())
                {
                    Console.WriteLine("All words are hidden.");
                }
            }
        } while (!_scripture.ALLWordsHidden());
    }
}
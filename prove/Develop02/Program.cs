using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        
        List <Journal> journalEntries = new List<Journal> ();

    int userInput = 0;

        
        
        {
        Console.WriteLine("Welcome to Your Daily Journal!");
        }
        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            
            Console.Write("What would you like to do? ");
            int userInput = Console.ReadLine();
            inputNumber = int.Parse(userInput);
            
            
            if (inputNumber = 1)
            {
                
                
                Journal.AddEntry();
            }
                
            else if (inputNumber = 2)
            {
                
                Journal.DisplayEntries();
            }  

            else if (inputNumber = 3)
                {
                Journal.ReadFromFile();
                }

            else if (inputNumber = 4)
                {
                
                Journal.SaveToFile();
                }


        } while (inputNumber !=5);
        
    }



    
}

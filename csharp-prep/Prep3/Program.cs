using System;

class Program
{
    static void Main(string[] args)
    {

        string response;
        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            
            int guessNumber = -1;
            int count = 0;
            
            
                
            
            while (guessNumber != magicNumber) 
            {
                Console.WriteLine("What is your guess for the magic number?");
            
                guessNumber = int.Parse(Console.ReadLine());
                count++;


                if (guessNumber < magicNumber)
                {
                    Console.WriteLine("The Magic number is Higher. Guess again.");
                    
                }
                else if (guessNumber > magicNumber)
                {
                    Console.WriteLine("The Magic number is lower. Guess again.");
                    
                }
                else 
                {
                    Console.WriteLine ($"You guessed the right number! It took you {count} tries.");
                }
            
            }
            Console.Write("Do you want to play again? ");
            response = Console.ReadLine();
        } while (response == "yes");
    }
}
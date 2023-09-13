using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the percent earned in class?");
        string gradeString = Console.ReadLine();
        int gradeNumber = int.Parse(gradeString);
        string letter ="";
        string gradePlus ="";
        int gradeEnd = gradeNumber  % (10);
        if (90 <= gradeNumber)
        {
            letter = "A";
        }

        else if (80 <= gradeNumber)
        {
            letter = "B";
        }

        else if (70 <= gradeNumber)
        {
            letter = "C";
        }

        else if (60 <= gradeNumber)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (gradeNumber >= 95)
        {
            gradePlus ="";
        }
        else if (gradeNumber <60)
        {
            gradePlus ="";
        }
        else if (gradeEnd >= 7)
        {
            gradePlus = "+";
        }
        else if (gradeEnd <= 3)
        {
            gradePlus = "-";
        }
        else
        {
            gradePlus = "";
        }

        Console.WriteLine($"Your grade in the class is {letter}{gradePlus}");

        if (gradeNumber >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Sorry, better luck next time!");
        }

    }
}
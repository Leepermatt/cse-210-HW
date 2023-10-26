using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign1 = new Assignment();
        assign1.SetStudent("Smith");
        assign1.SetTopic("Comp Sci");
        Console.WriteLine(assign1.GetSummary());
        MathAssignment assign2 = new MathAssignment();
        assign2.SetStudent("Bob");
        assign2.SetTopic("math");
        assign2.SetTextbookSection("4a");
        assign2.SetProblems("3-8");
        Console.WriteLine(assign2.GetSummary());
        Console.WriteLine(assign2.GetHomeworkList());
        WritingAssignment assign3 = new WritingAssignment ();
        assign3.SetStudent("Mary Waters");
        assign3.SetTopic("European History");
        assign3.SetTitle("The Causes of World War II");
        Console.WriteLine(assign3.GetWritingInformation());


    }
}
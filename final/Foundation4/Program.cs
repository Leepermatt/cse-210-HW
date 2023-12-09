using System;

class Program
{
    static void Main(string[] args)
    {
        Running run1 = new Running(30, "03 Nov 2022", 20);
        Swimming swim1 = new Swimming(60, "04 Nov 2022", 100);
        Cycling cycle1 = new Cycling(30, "05 Nov 2022", 45);
        Console.WriteLine(run1.GetSummary());
        Console.WriteLine(swim1.GetSummary());
        Console.WriteLine(cycle1.GetSummary());
        
        
    }
}
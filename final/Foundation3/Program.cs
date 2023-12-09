using System;

class Program
{
    static void Main(string[] args)
    {
        // reception
        Reception recep1 = new Reception("Wedding", "Mark and Wendy's", "05 Nov 2022", "12:00 pm", "543 Main street, Lv NV 89101", "mark@gmail.com");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(recep1.GetStandardDetails());
        Console.WriteLine("Short Details:");
        Console.WriteLine(recep1.GetShortDetails());
        Console.WriteLine("Extended Details");
        Console.WriteLine(recep1.GetLongDetails());
        Console.WriteLine();
        // lecture
        Lecture lectur1 = new Lecture("Black Holes", "How do they exist?", "05 Nov 2022", "12:00 pm", "543 Main street, Lv NV 89101", "Mark Rober", 75);
        Console.WriteLine("Standard Details:");
        Console.WriteLine(lectur1.GetStandardDetails());
        Console.WriteLine("Short Details:");
        Console.WriteLine(lectur1.GetShortDetails());
        Console.WriteLine("Extended Details");
        Console.WriteLine(lectur1.GetLongDetails());
        Console.WriteLine();
        // outdoor
        Outdoors out1 = new Outdoors("Book of Mormon", "Build your faith", "05 Nov 2022", "12:00 pm", "543 Main street, Lv NV 89101", "sunny");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(out1.GetStandardDetails());
        Console.WriteLine("Short Details:");
        Console.WriteLine(out1.GetShortDetails());
        Console.WriteLine("Extended Details");
        Console.WriteLine(out1.GetLongDetails());
        Console.WriteLine();

    }
}
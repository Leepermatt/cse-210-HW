using System;

class Program

{
    static void Main(string[] args)
    {
        Fraction fr1 = new Fraction();
        Console.WriteLine(fr1.GetFraction());
        Console.WriteLine(fr1.GetDecimal());

        Fraction fr2 = new Fraction(5);
        Console.WriteLine(fr2.GetFraction());
        Console.WriteLine(fr2.GetDecimal());

        Fraction fr3 = new Fraction(3, 4);
        Console.WriteLine(fr3.GetFraction());
        Console.WriteLine(fr3.GetDecimal());

        Fraction fr4 = new Fraction(1, 3);
        Console.WriteLine(fr4.GetFraction());
        Console.WriteLine(fr4.GetDecimal());
    }
}
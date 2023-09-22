using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int inputNumber =0;
        
;
        do
        {
            Console.Write("Enter a list of numbers, type 0 when finished");
            string userResponse = Console.ReadLine();
            inputNumber = int.Parse(userResponse);
            if (inputNumber != 0);
            numbers.Add(inputNumber);
        } while (inputNumber != 0 );
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

                int maxNumber = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maxNumber)
            {
                
                maxNumber = number;
            }
        }

        Console.WriteLine($"The max is: {maxNumber}");
    }
}
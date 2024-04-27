using System;
using System.Globalization;
using System.Collections.Generic;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        int enterNumber = -1;

        while (enterNumber != 0)
        {
            Console.Write("Enter number: ");
            enterNumber = int.Parse(Console.ReadLine());

            if (enterNumber != 0)
            {
                numbers.Add(enterNumber);
            }
        }

        int sum = 0;
        
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number> max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is {max}");
    }
}
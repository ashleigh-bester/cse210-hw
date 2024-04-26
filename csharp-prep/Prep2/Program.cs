using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string enterPercent = Console.ReadLine();

        int percentage = int.Parse(enterPercent);
        int a = 90;
        int b = 80;
        int c = 70;
        int d = 60;
        string letter = "";

        if (percentage >= a)
        {
            letter = "A";
        }
        else if (percentage >= b)
        {
            letter = "B";
        }
        else if (percentage >= c)
        {
            letter = "C";
        }
        else if (percentage >= d)
        {
            letter = "D";
        }
        else if (percentage < 60)
        {
            letter = "F";
        }
        
        Console.WriteLine($"Your Grade: {letter}");

        if (percentage >= 70)
        {
            Console.WriteLine("Well done! You passed this course!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass this course.");
            Console.WriteLine("Don't stress, try again. Wishing you the best of luck next time!");
        }
    }
}
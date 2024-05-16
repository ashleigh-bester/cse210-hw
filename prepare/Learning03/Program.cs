using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        /* Fraction f1 = new Fraction();
        Console.WriteLine(f1);
        Fraction f2 = new Fraction(6);
        Console.WriteLine(f2);
        Fraction f3 = new Fraction(6, 7);
        Console.WriteLine(f3); */

        /*Fraction f = new Fraction();
        f.SetTop(1);
        f.SetBottom(5);
        Console.WriteLine($"{f.GetTop()}/{f.GetBottom()}");*/

        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine();

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        Console.WriteLine();

        Fraction f3 = new Fraction(3,4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        Console.WriteLine();

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
        Console.WriteLine();
    }
}
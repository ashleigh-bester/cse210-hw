using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Alma", 32, 21, 22);
        Console.WriteLine(reference.GetDisplayText());
        
        /*string text = "21 And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.";
        Scripture scripture = new Scripture(reference, text);
        Console.WriteLine(scripture.GetDisplayText());*/
    }
}
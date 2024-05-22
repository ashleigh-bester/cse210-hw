using System;
using System.Data;
using System.Dynamic;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Alma", 32, 21, 22);
        Console.WriteLine(reference.GetDisplayText());
        
        string text1 = "21 And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.";
        Word verse1 = new Word(text1);
        Console.WriteLine(verse1.GetDisplayText());

        string text2 = "22 And now, behold, I say unto you, and I would that ye should remember, that God is merciful unto all who believe on his name; therefore he desireth, in the first place, that ye should believe, yea, even on his word.";
        Word verse2 = new Word(text2);
        Console.WriteLine(verse2.GetDisplayText());
    }
}
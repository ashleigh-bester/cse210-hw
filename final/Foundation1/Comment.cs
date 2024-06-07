using System;

public class Comment
{
    public string _name;
    public string _text;

    public void DisplayComment()
    {
        Console.WriteLine($"> _{_name}_ '{_text}'");
    }
}
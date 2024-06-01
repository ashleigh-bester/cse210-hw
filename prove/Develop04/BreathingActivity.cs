using System;
using System.Diagnostics.CodeAnalysis;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Write("How long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner();

        for (int i = duration; i > 0; i--)
        {
            Console.WriteLine($"Breath in...");
            ShowCountDown(duration);
            Console.WriteLine($"Breath out...");
            ShowCountDown(duration);
            Console.WriteLine(); 
        }
        /*Console.WriteLine($"Breath in...");
        ShowCountDown(5);
        Console.WriteLine($"Breath out...");
        ShowCountDown(6);
        Console.WriteLine();
        Console.WriteLine($"Breath in...");
        ShowCountDown(7);
        Console.WriteLine($"Breath out...");
        ShowCountDown(8);
        Console.Clear();*/

        DisplayEndingMessage();
        ShowSpinner();
    }
}
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity :)");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        Thread.Sleep(2000);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity ;)");
    }

    public void ShowSpinner()
    {
        //Animation
        List<string> animations = new List<string>();
        animations.Add("|");
        animations.Add("/");
        animations.Add("-");
        animations.Add("\\");
        animations.Add("|");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animations[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("\b \b");

            i++;

            if (i >= animations.Count)
            {
                i = 0;
            }
        }

        Console.Clear();
    }

    public void ShowCountDown(int duration)
    {
        //Console.Clear();
        _duration = duration;

        for (int i = _duration; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("\b \b");
        }
    }
}


//Activity Test
/*Activity activity = new Activity("Test", "Testing the Activity Class", 0);
activity.DisplayStartingMessage();
Console.Write("How long, in seconds, would you like for your session? ");
int duration = int.Parse(Console.ReadLine());
Console.Clear();
Console.WriteLine("Get ready...");
activity.ShowSpinner();
activity.ShowCountDown(duration);
activity.DisplayEndingMessage();
activity.ShowSpinner();*/
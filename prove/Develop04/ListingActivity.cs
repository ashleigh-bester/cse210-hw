using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
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

        Console.WriteLine("List as many responses as you can to the folling prompt:");
        DisplayPrompt();
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);

        /*while (duration != 0)
        {
            GetListFromUser();
        }*/
        GetListFromUser();

        Console.WriteLine();
        DisplayEndingMessage();
        ShowSpinner();
    }

    public string GetRandomPrompt()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

        Random prompt = new Random();
        int index = prompt.Next(_prompts.Count);
        string randomPrompt = _prompts[index];

        return randomPrompt;
    }

    public void DisplayPrompt()
    {

        string randomPrompt = GetRandomPrompt();
        Console.WriteLine($"---{randomPrompt}---");
    }

    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        Console.Write("> ");
        string response = Console.ReadLine();
        responses.Add(response);

        return responses;
    }
}
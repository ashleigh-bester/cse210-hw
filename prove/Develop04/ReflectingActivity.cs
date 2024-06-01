using System;
using System.IO;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
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

        Console.WriteLine("Consider the following prompt:");
        DisplayPrompt();
        Console.WriteLine();
        Console.Write("When you have something in mind, press enter to continue. ");
        Console.ReadLine();
        
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Thread.Sleep(3000);
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);

        DisplayQuestions();
        DisplayQuestions();

        DisplayEndingMessage();
        ShowSpinner();
    }

    public string GetRandomPrompt()
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        Random prompt = new Random();
        int index = prompt.Next(_prompts.Count);
        string randomPrompt = _prompts[index];

        return randomPrompt;
    }

    public string GetRandomQuestion()
    {
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

        Random question = new Random();
        int index = question.Next(_questions.Count);
        string randomQuestion = _questions[index];

        return randomQuestion;
    }

    public void DisplayPrompt()
    {

        string randomPrompt = GetRandomPrompt();
        Console.WriteLine($"---{randomPrompt}---");
    }

    public void DisplayQuestions()
    {
        Console.Clear();
        string randomQuestion = GetRandomQuestion();
        Console.WriteLine($"> {randomQuestion}");
        ShowSpinner();
    }
}
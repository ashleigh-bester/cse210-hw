using System;
using System.IO;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    public PromptGenerator()
    {

    }

    public string GetRandomPrompt()
    {
        _prompts.Add("The high of my day!");
        _prompts.Add("A tender mercy or blessing I've experienced today.");
        _prompts.Add("Something that made me smile/laugh today.");
        _prompts.Add("3 things that I want to improve on.");
        _prompts.Add("What project am I working on that brings me joy?");

        //Console.WriteLine(_prompts);

        Random prompt = new Random();
        int index = prompt.Next(_prompts.Count);
        string randomPrompt = _prompts[index];

        return randomPrompt;
    }
}
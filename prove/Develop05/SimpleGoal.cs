using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

public class SimpleGoal : Goal
{
    private bool _isComplete = false;
    
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }

    public override void RecordEvent()
    {
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetStringRepresentation()
    {
        
        return GetDetailsString();
    }
}
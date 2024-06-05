using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target = 0;

    private int _bonus = 0;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {

    }

    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetDetailsString()
    {
        return "";
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}
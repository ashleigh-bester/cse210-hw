using System;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points = 0;

    public Goal(string name, string descirption, int points)
    {

    }

    public /*abstract*/ virtual void RecordEvent()
    {

    }

    public /*abstract*/ virtual bool IsComplete()
    {
        return true;
    }

    public virtual string GetDetailsString()
    {
        return "";
    }

    public /*abstract*/ virtual string GetStringRepresentation()
    {
        return "";
    }
}
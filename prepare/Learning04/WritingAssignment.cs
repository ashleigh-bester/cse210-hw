using System;

public class WritingAsssignment : Assignment
{
    private string _title;

    public WritingAsssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}
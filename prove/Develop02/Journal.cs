using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public Journal()
    {

    }
    public void AddEntry(string date, string promptText, string entryText)
    {
         _entries.Add(new Entry(date, promptText, entryText));
    }

    public void DisplayAll()
    {
        
    }

    public void SaveToFile(string file)
    {
        string fileName = file;
    }

    public void LoadFromFile(string file)
    {

    }
}
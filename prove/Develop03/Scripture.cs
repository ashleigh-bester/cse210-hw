using System;
using System.Data;
using System.IO;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        text = "";
    }

    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        return $"{_reference} + {_words}";
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }
}
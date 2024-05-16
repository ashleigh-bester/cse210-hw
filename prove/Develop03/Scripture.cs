using System;
using System.Data;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        text = "21 And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.";
    }

    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        return "";
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }
}
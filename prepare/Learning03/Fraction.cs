using System;
using System.ComponentModel.DataAnnotations;

class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
        //Display();
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
        //Display();
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
        //Display();
    }

    /*public void Display()
    {
        Console.WriteLine($"{_top}/{_bottom}");
    }*/

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string fraction = $"{_top}/{_bottom}";

        return fraction;
    }

    public double GetDecimalValue()
    {
        return (double)_top/(double)_bottom;
    }

}
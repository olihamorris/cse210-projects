using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    // Default constructor
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor for whole number (e.g., 5 becomes 5/1)
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor with numerator and denominator
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Returns the fraction in string format (e.g., "3/4")
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Returns the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
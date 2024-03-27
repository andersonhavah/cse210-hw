public class Fraction
{
    // Fraction class attributes
    private int _top;
    private int _bottom;

    // Fraction class contruction with no parameters
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Fraction class contruction with one parameter
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // Fraction class contruction with two parameters
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // A getter or accessor method to get the value of the _top attribute
    public int GetTop()
    {
        return _top;
    }

    // A setter or mutator method to set the value of the _top attribute
    public void SetTop(int top)
    {
        _top = top;
    }

    // A getter or accessor method to get the value of the _bottom attribute
      public int GetBottom()
    {
        return _bottom;
    }

    // A setter or mutator method to set the value of the _bottom attribute
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // This method helps get the fraction string on the form of Eg. 4/6
    public string GetFractionString()
    {
        string fractionString = $"{_top}/{_bottom}";
        return fractionString;
    }

    // This method helps get the decimal value of the decimal value of the fraction
    public double GetDecimalValue()
    {
        double result = (double)_top / (double)_bottom;
        return result;
    }
    
}
using System.Diagnostics.Contracts;

public class Fraction 
 {
//Creating the attributes of the class
    private int _top;
    private int _bottom; 

//Create methods for the class
    //Constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumeber)
    {
        _top = wholeNumeber;
        _bottom = 1;
    }

    public Fraction(int topNum, int bottomNum)
    {
        _top = topNum;
        _bottom = bottomNum;
    }
    
    //No Getters/Setters

    //Methods

    public string GetFractionString()
    {
        string fraction = ($"{_top}/{_bottom}");
        return fraction;

    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
 }
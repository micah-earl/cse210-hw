public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;


    }
    public Fraction(int whole)
    {
        _numerator = whole;
        _denominator = 1;

    }
    public Fraction(int num, int denom)
    {
        _numerator = num;
        _denominator = denom;
    }
    public string getfractionstring()
    {
        string representation = $"{_numerator} / {_denominator}";
        return representation;
    }
    public double getdecimal()
    {
        double value = (double)_numerator / (double)_denominator;
        return value;
    }
    }

    
using System;

public class Speed : IFormattable
{
    protected int knots;
    public Speed() { }
	public Speed(int knots)
	{
        this.knots = knots;
	}

    public int GetKnots()
    {
        return knots;
    }

    public void SetKnots(int knots)
    {
        // Can't be lower than 0, 300 might be a unrealistic upper bound
        if (knots > 300 || knots < 0)
        {
            throw new ArgumentOutOfRangeException("Invalid speed"); 
        }

        this.knots = knots;
    }

    // IFormattable Interface ToString function
    public string ToString(string? format, IFormatProvider? formatProvider)
    {
        if (format == null) { format = "G"; }

        switch (format.ToUpperInvariant())
        {
            case "G":   // Docs state it has to support "G", the general format specifier
            case "KN":
                return this.knots.ToString() + " kn";
            case "MS":
                    return (knots / 1.9438444924406).ToString() + " m/s";   // Divide by constant to convert to m/s
            default:
                throw new FormatException($"The {format} format string is not supported.");
        }
    }
}

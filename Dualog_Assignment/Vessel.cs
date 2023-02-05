using System;
using System.Xml.Linq;


class Vessel : Speed
{
    // Use protected to allow derived classes to set them in their own constructor
    protected string name;
    protected int yearBuilt;
    protected int MaxAge = 20;

    // Default Constructor, assigns variables to prevent non-nullable field warning
    public Vessel() { this.name = "Default"; this.yearBuilt = 0; this.knots = 0; }

    // Constructor
    public Vessel(string Name, int yearBuilt, int knots)
    {
        if (Name == null)
        {
            throw new ArgumentNullException("Invalid name: null");
        }

        // Check current year against max age, covers negative input
        if (DateTime.Now.Year-yearBuilt > this.MaxAge)
        {
            throw new OldShipException("Ship Too Old For Fleet Manager");
        }

        // Check if input is higher than current year
        if(DateTime.Now.Year < yearBuilt)
        {
            throw new ArgumentOutOfRangeException("Invalid build year, higher than current year");
        }

        // Can't be lower than 0, 300 might be a unrealistic upper bound
        if (knots > 300 || knots < 0)
        {
            throw new ArgumentOutOfRangeException("Invalid speed"); 
        }

        this.name = Name;
        this.yearBuilt = yearBuilt;
        this.knots = knots;
    }

    public string GetName()
    { 
        return name; 
    }
    public void SetName(string name)
    {
        if (name == null)
        {
            throw new ArgumentNullException("Invalid name: null");
        }

        this.name = name;
    }

    public int GetYearBuilt()
    {
        return yearBuilt;
    }

    public void SetYearBuilt(int yearBuilt)
    {
        // Check if input is higher than current year
        if (DateTime.Now.Year < yearBuilt)
        {
            throw new ArgumentOutOfRangeException("Invalid build year, higher than current year");
        }

        // Check if input is higher than current year
        if (DateTime.Now.Year < yearBuilt)
        {
            throw new ArgumentOutOfRangeException("Invalid build year, higher than current year");
        }

        this.yearBuilt = yearBuilt;
    }

    // Virtual to allow derived classes to override
    public virtual void GetVesselInfo()
    {
        Console.WriteLine("Vessel Type: " + this.GetType().Name);
        Console.WriteLine("Name: " + this.GetName());
        Console.WriteLine("Year Built: " + this.GetYearBuilt());
    }

    public override string ToString()
    {
        return $"Vessel: {name}";
    }
}

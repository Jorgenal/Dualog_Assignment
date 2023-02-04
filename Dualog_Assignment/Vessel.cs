using System;


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
        // Better way to handle this? Stops terminal error of non-nullable field
        if (Name == null)
        {
            throw new ArgumentNullException("Invalid name: null");
        }

        if (DateTime.Now.Year-yearBuilt > this.MaxAge)
        {
            throw new OldShipException("Ship Too Old For Fleet Manager");
        }

        if(knots > 300 || knots < 0)
        {
            throw new ArgumentOutOfRangeException("Invalid speed"); // Can't be lower than 0, no unrealistic speed
        }

        this.name = Name;
        this.yearBuilt = yearBuilt;
        this.knots = knots;
    }

    public string GetName()
    { 
        return name; 
    }
    public int GetYearBuilt()
    {
        return yearBuilt;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public void SetYearBuilt(int yearBuilt)
    {
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

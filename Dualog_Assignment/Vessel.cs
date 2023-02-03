using System;


class Vessel
{
    // Use protected to allow derived classes to set them in constructor
    protected string name;
    protected int yearBuilt;

    // Default Constructor
    public Vessel() { this.name = "Default"; this.yearBuilt = 0; }

    // Constructor
    public Vessel(string Name, int yearBuilt)
    {
        // Better way to handle this? Stops terminal error of non-nullable field
        if (Name == null)
        {
            this.name = "invalid";
            this.yearBuilt = 0;
            throw new OldShipException("Invalid name/year built");
        }

        if (2023-yearBuilt > 20)
        {
            throw new OldShipException("Ship Too Old For Fleet Manager");
        }

        this.name = Name;
        this.yearBuilt = yearBuilt;
    }

    public string GetName()
    { 
        return name; 
    }
    public int GetYearBuilt()
    {
        return yearBuilt;
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

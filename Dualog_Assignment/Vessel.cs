using System;


class Vessel
{
    // Use protected to allow derived classes to set them in constructor
    protected string name;
    protected string yearBuilt;

    // Default Constructor
    public Vessel() { }

    // Constructor
    public Vessel(string Name, string yearBuilt)
    {
        // Need some better and proper handling here, only init protected fields to stop compiler error atm 
        if (Name == null || yearBuilt == null)
        {
            this.name = "invalid";
            this.yearBuilt = "invalid";
            throw new OldShipException("Invalid name/year built");
        }

        int year = int.Parse(yearBuilt);
        if (2023-year > 20)
        {
            this.name = "invalid";
            this.yearBuilt = "invalid";
            throw new OldShipException("Ship Too Old For Fleet Manager");
        }

        this.name = Name;
        this.yearBuilt = yearBuilt;
    }

    public string GetName()
    { 
        return name; 
    }
    public string GetYearBuilt()
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

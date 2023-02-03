using System;

class Ferry : Vessel
{
    private int passengers;

    public Ferry(string Name, int yearBuilt, int Passengers)
    {
        this.name = Name;
        this.yearBuilt = yearBuilt;
        this.passengers = Passengers;
    }

    public int GetPassengers()
    {
        return this.passengers;
    }

    public override void GetVesselInfo()
    {
        Console.WriteLine("Vessel Type: " + this.GetType().Name);
        Console.WriteLine("Name: " + this.GetName());
        Console.WriteLine("Year Built: " + this.GetYearBuilt());
        Console.WriteLine("Passengers: " + this.GetPassengers());
    }
}

class Tugboat : Vessel
{
    private string maxForce;

    public Tugboat(string Name, int yearBuilt, string maxforce)
    {
        this.name = Name;
        this.yearBuilt = yearBuilt;
        this.maxForce= maxforce;
    }

    public string GetMaxForce() 
    {
        return this.maxForce;
    }

    public override void GetVesselInfo()
    {
        Console.WriteLine("Vessel Type: " + this.GetType().Name);
        Console.WriteLine("Name: " + this.GetName());
        Console.WriteLine("Year Built: " + this.GetYearBuilt());
        Console.WriteLine("Max Force: " + this.GetMaxForce());
    }
}

class Submarine : Vessel
{
    private string maxDepth;

    public Submarine(string Name, int yearBuilt, string maxdepth)
    {
        this.name = Name;
        this.yearBuilt = yearBuilt;
        this.maxDepth= maxdepth;
    }

    public string GetMaxDepth()
    {
        return this.maxDepth;
    }

    public override void GetVesselInfo()
    {
        Console.WriteLine("Vessel Type: " + this.GetType().Name);
        Console.WriteLine("Name: " + this.GetName());
        Console.WriteLine("Year Built: " + this.GetYearBuilt());
        Console.WriteLine("Max Depth: " + this.GetMaxDepth());
    }
}

using System;

class Ferry : Vessel
{
    private int passengers = 20;

    // Call Vessels Constructor class
    public Ferry(string Name, int yearBuilt, int knots) : base(Name, yearBuilt, knots) { }

    public int GetPassengers()
    {
        return this.passengers;
    }

    public int SetPassengers(int passengers)
    {
        this.passengers = passengers;

        return 1;
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
    private string maxForce = "15F";

    // Call Vessels Constructor class
    public Tugboat(string Name, int yearBuilt, int knots) : base(Name, yearBuilt, knots) { }

    public string GetMaxForce() 
    {
        return this.maxForce;
    }

    public int SetMaxForce(string maxforce)
    {
        this.maxForce= maxforce;

        return 1;
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
    private string maxDepth = "20ft";

    // Call Vessels Constructor class
    public Submarine(string Name, int yearBuilt, int knots) : base(Name, yearBuilt, knots) { }

    public string GetMaxDepth()
    {
        return this.maxDepth;
    }

    public int SetMaxDepth(string maxdepth)
    {
        this.maxDepth= maxdepth;

        return 1;
    }

    public override void GetVesselInfo()
    {
        Console.WriteLine("Vessel Type: " + this.GetType().Name);
        Console.WriteLine("Name: " + this.GetName());
        Console.WriteLine("Year Built: " + this.GetYearBuilt());
        Console.WriteLine("Max Depth: " + this.GetMaxDepth());
    }
}

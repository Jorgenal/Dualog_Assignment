using System;

class Ferry : Vessel
{
    private int passengers = 20;

    // Call Vessels Constructor
    public Ferry(string Name, int yearBuilt, int knots) : base(Name, yearBuilt, knots) { }

    public int GetPassengers()
    {
        return this.passengers;
    }

    public int SetPassengers(int passengers)
    {
        if(passengers < 0 || passengers > 10000)
        {
            throw new ArgumentOutOfRangeException("Invalid amount of passengers"); // Not lower than 0, curretn max cruise is 9000
        }

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
    private int maxForce = 15;

    // Call Vessels Constructor
    public Tugboat(string Name, int yearBuilt, int knots) : base(Name, yearBuilt, knots) { }

    public int GetMaxForce() 
    {
        return this.maxForce;
    }

    public int SetMaxForce(int maxforce)
    {
        if (maxforce < 0 || maxforce > 5000) // less than 0 invalid, max is 4680kN, or 477 tonnes-force bollard pull
        {
            throw new ArgumentOutOfRangeException("Invalid force");
        }

        this.maxForce = maxforce;

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
    private int maxDepth = 20;

    // Call Vessels Constructor
    public Submarine(string Name, int yearBuilt, int knots) : base(Name, yearBuilt, knots) { }

    public int GetMaxDepth()
    {
        return this.maxDepth;
    }

    public int SetMaxDepth(int maxdepth)
    {

        if (maxdepth < 0 || maxdepth > 5000) // less than 0 invalid, max is 4265ft (1300 meters)
        {
            throw new ArgumentOutOfRangeException("Invalid Depth");
        }
        this.maxDepth = maxdepth;

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

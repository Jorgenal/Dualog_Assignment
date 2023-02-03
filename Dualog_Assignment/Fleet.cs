using System;

class Ferry : Vessel
{
    private int passengers;

    public Ferry(string Name, int yearBuilt, int knots, int Passengers)
    {

        // Better way to handle this? Stops terminal error of non-nullable field
        if (Name == null)
        {
            this.name = "invalid";
            this.yearBuilt = 0;
            this.knots = 0;
            throw new OldShipException("Invalid name");
        }

        if (2023 - yearBuilt > 20)
        {
            throw new OldShipException("Ship Too Old For Fleet Manager");
        }

        this.name = Name;
        this.yearBuilt = yearBuilt;
        this.passengers = Passengers;
        this.knots = knots;
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

    public Tugboat(string Name, int yearBuilt, int knots, string maxforce)
    {
        // Better way to handle this? Stops terminal error of non-nullable field
        if (Name == null)
        {
            this.name = "invalid";
            this.yearBuilt = 0;
            this.knots = 0;
            throw new OldShipException("Invalid name");
        }

        if (2023 - yearBuilt > 20)
        {
            throw new OldShipException("Ship Too Old For Fleet Manager");
        }

        this.name = Name;
        this.yearBuilt = yearBuilt;
        this.maxForce= maxforce;
        this.knots = knots;
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

    public Submarine(string Name, int yearBuilt, int knots, string maxdepth)
    {
        // Better way to handle this? Stops terminal error of non-nullable field
        if (Name == null)
        {
            this.name = "invalid";
            this.yearBuilt = 0;
            this.maxDepth = maxdepth;
            this.knots = 0;
            throw new OldShipException("Invalid name");
        }

        if (2023 - yearBuilt > 20)
        {
            throw new OldShipException("Ship Too Old For Fleet Manager");
        }

        this.name = Name;
        this.yearBuilt = yearBuilt;
        this.maxDepth= maxdepth;
        this.knots = knots;
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

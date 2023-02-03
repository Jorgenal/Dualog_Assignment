try
{
    Vessel ves = new Vessel("Jotunheim", 1888);
}
catch (OldShipException e)
{
    Console.WriteLine("Error: " + e.Message + "\n");
    
}

Vessel vessel = new Vessel("Jotunheim", 2004);
vessel.GetVesselInfo();
//Console.WriteLine(vessel.ToString());
//Console.WriteLine(vessel.GetYearBuilt());
//Console.WriteLine(vessel.GetName());

Console.WriteLine();

Ferry ferry = new Ferry("Foodo", 2015, 20);
ferry.GetVesselInfo();
//Console.WriteLine(ferry.ToString());
//Console.WriteLine(ferry.GetYearBuilt());
//Console.WriteLine(ferry.GetName());

Console.WriteLine();

Tugboat tugboat = new Tugboat("Tuggy", 2016, "4000F");
tugboat.GetVesselInfo();
//Console.WriteLine(tugboat.ToString());
//Console.WriteLine(tugboat.GetYearBuilt());
//Console.WriteLine(tugboat.GetName());

Console.WriteLine();

Submarine submarine = new Submarine("Subby", 2018, "40m");
submarine.GetVesselInfo();
//Console.WriteLine(submarine.ToString());
//Console.WriteLine(submarine.GetYearBuilt());
//Console.WriteLine(submarine.GetName());


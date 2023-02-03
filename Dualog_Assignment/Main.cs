using System.Collections.ObjectModel;
using System.Globalization;

// Checking for invalid name and too old boat
try
{
    Vessel ves = new Vessel("Jotunheim", 1888, 50);
}
catch (OldShipException e)
{
    Console.WriteLine("Error: " + e.Message + "\n");
}

try
{
    Vessel ves = new Vessel(null, 2020, 500);
}
catch (OldShipException e)
{
    Console.WriteLine("Error: " + e.Message + "\n");
}


// Creating a collection and iterating over it
Ferry ferry = new Ferry("Ferrmeister", 2015, 30, 10);
Tugboat tugboat = new Tugboat("Tuggmeister", 2016, 40, "15F");
Submarine submarine = new Submarine("Subbmeister", 2017, 40, "15ft");

var fleet = new Collection<Vessel>();
fleet.Add(ferry);
fleet.Add(tugboat);
fleet.Add(submarine);
NumberFormatInfo current = NumberFormatInfo.CurrentInfo;

foreach (Vessel v in fleet)
{
    v.GetVesselInfo();
    Console.WriteLine(v.ToString("MS", current));
    Console.WriteLine();
}






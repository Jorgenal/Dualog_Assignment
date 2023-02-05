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
catch (ArgumentNullException e)
{
    Console.WriteLine("Error: " + e.Message + "\n");
}


// Creating a collection and iterating over it
Ferry ferry = new Ferry("Serendipity", 2015, 30);
ferry.SetPassengers(50);
Tugboat tugboat = new Tugboat("Imagination", 2016, 40);
tugboat.SetMaxForce(500);
Submarine submarine = new Submarine("Liberty", 2017, 50);
submarine.SetMaxDepth(800);

Ferry ferry_2 = new Ferry("Wanderlust", 2015, 30);
ferry_2.SetPassengers(200);
Tugboat tugboat_2 = new Tugboat("Gale", 2016, 40);
tugboat_2.SetMaxForce(350);
Submarine submarine_2 = new Submarine("Zephyr", 2017, 50);
submarine_2.SetMaxDepth(300);

var fleet = new Collection<Vessel>();
fleet.Add(ferry);
fleet.Add(tugboat);
fleet.Add(submarine);
fleet.Add(ferry_2);
fleet.Add(tugboat_2);
fleet.Add(submarine_2);
NumberFormatInfo current = NumberFormatInfo.CurrentInfo;    // Needed for IFormattable call

// printing ToString and various others methods to check they are working
foreach (Vessel v in fleet)
{
    Console.WriteLine(v.ToString());
    v.GetVesselInfo();
    Console.WriteLine(v.ToString("KN", current));
    Console.WriteLine(v.ToString("MS", current));
    Console.WriteLine();
}






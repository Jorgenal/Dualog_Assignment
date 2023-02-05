# Dualog_Assignment

## Files
- Main.cs: Simple program to iterate over objects and verify the solution works. 
- UnitTests.cs: Contains all UnitTests for the program. 
- Speed.cs: Implements the speed class with the IFormattable interface
- Vessel.cs: Implements the Vessel class deriving from Speed.
- Fleet.cs: Implements the various fleet classes deriving from Vessel. 
- Exception.cs: Implements a custom OldShip exception. 
- Remarks.md: Contains various remarks about the solution to the task. 

## How to run
For Main.cs:
- dotnet run

For Unit tests: 
- dotnet test

Note: Unit tests might require several nuget packages. 
To run them through Visual Studio 2022, it required:
- Xunit, MSTest.TestAdapter, Microsoft.NET.Test.Sdk, and xunit.runner.visualstudio
# Task 1 Remarks
Each of the fleet classes use the vessel constructor and sets their unique attribute to a default value. The attribute is an integer for all of them,
assumes a standard format for input. Allows for easier parsing and error checking without string to int conversion. 

The unique attributes are all implemented with Get and Set methods that error checks the input to match a decent real world alternative.
Originally overrode the constructor for all of them, but ended up being a lot of duplicate code. Instead decided to use the Vessel constructor and a Set method.
Was unsure if all fleet classes wanted Set methods because of Property vs Field Semantics, but decided to implement them. That is part of the reason for why
the unqiue attributes are implemented as ints. Otherwise, using strings is fine if we assume they can never be changed. 
The same goes for yearBuilt, added a Set method, and implemented as int for easier checking against current year. 

Currently the basic ToString override is only for the Vessel class, not overridden for subclasses as I was unsure if we wanted to change the string to "Classname: name".

GetVesselInfo is currently being overridden in each fleet class to include their unique attribute. Chunk of duplicate code, alternate could be implementing a
GetUniqueAttribute function in Vessel and use it for the GetVesselInfo. 
Would then have to override that as a one-line function for each fleet class, instead of 4-7 lines. 


# Task 2 Remarks
Pondered a bit on "Also remember to add this to the Vessel class", figured the best way to handle it was having Vessel derive the Speed class.

Decided to have knots property as integer so I don't have to double convert strings. This again assumes that we understand knots being used as standard input. 
The IFormattable class handles the conversion to m/s currently, adding a method to return conversion as integer could be useful if a usecase for it. 


# Remarks regarding Verifying solution
Main.cs is currently demonstrating the basic use of the classes. It first tries to create two invalid vessel instances, and then 2 of each fleet class is 
created and added to a collection. The collection is iterated over and calls the required ToString method (which wasn't overriden) and then the GetVesselInfo
to ensure everything works. 

The unit tests should cover almost every single part of the code. A few parts might be missing where the constructor is tested, but not the Set method. 
Decided to sort them based on classes they cover. Mostly troubled by naming convention. 


# Potential Criticsim
I feel like I might have overengineered the task. I implemented a lot of Set methods which probably aren't needed in this context.
This goes for the fleet classes as well. Only Ferry is described to have a public property, meaning it should have Set and 
Get method (if I understood property vs field correctly),whereas Tugboat and Ferry should have private fields. 
Therefore the better semantic might be to just override the constructor instead of having Set methods, but this choice has been explained above. 

A lot of the attributes were changed to int to make some parsing easier, but without the various Set methods, it would probably be fine to only handle the input in
overridden constructors. 
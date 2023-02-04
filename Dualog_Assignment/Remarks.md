# Task 1 Remarks
The current implementation of GetVesselInfo() has to override in each class to add each property. Unsure if possible, but want a better way to handle it,
due to not wanting to copy paste the same 3 lines of code 3 times. 

Decided to change yearBuilt to integer instead of string compared to class provided as inspiration in assignment text,
allows me to not handle string parsing and conversion.

--- All fleet subclasses has their specific property as ints, no need to handle parsing of different inputs. Assume a standard suffix (ft / meters / F, etc)
(Conflicted on whether to keep them ints or use strings, would depend more on practical use case) 

Currently having all the Set methods return 1 on a successful input, otherwise throw an exception if applicable. Alternatively could just return 0 on error. 

Basic ToString method not overridden atm, unsure if it should be to include class name for each fleets subclass.

Should Old ship exception be used to catch null name?



# Task 2 Remarks
Pondered a bit on "Also remember to add this to the Vessel class", figured the best way to handle it was having Vessel derive the Speed class.

Decided to have knots property as integer so I don't have to double convert strings. The IFormattable class handles the conversion to m/s currently,
might want to add a method which can convert and return m/s as integer as well. 


# Remarks regarding Verifying solution
Currently only have a very basic setup testing the OldShipException, and a basic collection to iterate over each object and test the GetVesselInfo method. 

Set up a bunch ofbasic unit tests. 
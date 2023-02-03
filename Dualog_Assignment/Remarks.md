# Task 1 Remarks
The current implementation of GetVesselInfo() has to override in each class to add each property. Unsure if possible, but want a better way to handle it,
due to not wanting to copy paste the same 3 lines of code 3 times. 

Decided to change yearBuilt to integer instead of string compared to class provided as inspiration in assignment text,
allows me to not handle string parsing and conversion.

--- Currently Tugboat and Submarine both have ints as well, might wanna use string so correct suffix can be specified.
(Conflicted on whether to keep fleet specific attribute as int or string) 

Should Old ship exception be used to catch null name?



# Task 2 Remarks
Pondered a bit on "Also remember to add this to the Vessel class", figured the best way to handle it was having Vessel derive the Speed class.

Decided to have knots property as integer so I don't have to double convert strings. The IFormattable class handles the conversion to m/s currently,
might want to add a method which can convert and return m/s as integer as well. 


# Remarks regarding Verifying solution
Currently only have a very basic setup testing the OldShipException, and a basic collection to iterate over each object and test the GetVesselInfo method. 
Possibly add something to use the specific methods to each fleet class, however this can also be covered in UnitTesting. 
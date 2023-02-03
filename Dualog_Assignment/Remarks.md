# Task 1 Remarks
I feel the current implementation of fleet classes could be handled better as the GetVesselInfo class has to be overridden for each class.

Decided to change yearBuilt to integer, no need to handle string conversion. 

Conflicted on whether to keep fleet specific attribute as int or string. 

Should Old ship exception be used to catch null name?



# Task 2 Remarks
Pondered a bit on "Also remember to add this to the Vessel class", figured the best way to handle it was having Vessel derive the Speed class.

Set knots property as int so I don't have to double convert. The IFormattable class handles the print.  
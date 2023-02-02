using System;

public class OldShipException : Exception
{
    public OldShipException() { }

    public OldShipException(string message) : base(message) { }
}

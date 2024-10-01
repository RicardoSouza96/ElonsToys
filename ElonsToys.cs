using System;
using System.Reflection.Metadata.Ecma335;

class RemoteControlCar
{
    private int meters = 0;
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {meters} meters";

    public string BatteryDisplay()
    {
        throw new NotImplementedException("Please implement the RemoteControlCar.BatteryDisplay() method");
    }

    public void Drive()
    {
        throw new NotImplementedException("Please implement the RemoteControlCar.Drive() method");
    }
}

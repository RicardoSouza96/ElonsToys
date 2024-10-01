using System;
using System.Reflection.Metadata.Ecma335;

class RemoteControlCar
{
    private int meters = 0;
    private int battery = 100;
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {meters} meters";

    public string BatteryDisplay() => $"Battery at {battery}%";

    public void Drive()
    {

    }
}

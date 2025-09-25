class RemoteControlCar
{
    private int _distance = 0;
    private int _battery = 100;
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {_distance} meters";
    }

    public string BatteryDisplay()
    {
        if (_battery <= 0) return "Battery empty";
        return $"Battery at {_battery}%";
    }

    public void Drive()
    {
        if (_battery <= 0) return;
        _battery--;
        _distance += 20;
    }
    
}

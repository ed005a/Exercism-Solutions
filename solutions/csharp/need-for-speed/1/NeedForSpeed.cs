class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    public int _speed, _batteryDrain, _distance, _batteryRemaining;
    public RemoteControlCar(int speed, int batteryDrain)
    {
        _speed = speed;
        _batteryDrain = batteryDrain;
        _distance = 0;
        _batteryRemaining = 100;
    }
    public bool BatteryDrained()
    {
        return _batteryRemaining < _batteryDrain;
    }

    public int DistanceDriven()
    {
        return _distance;
    }

    public void Drive()
    {
        if (_batteryRemaining - _batteryDrain < 0) return;
        _distance += _speed;
        _batteryRemaining -= _batteryDrain;
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    // TODO: define the constructor for the 'RaceTrack' class
    private int _distance;
    public RaceTrack(int distance)
    {
       _distance = distance; 
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        return (100 / car._batteryDrain) * car._speed >= _distance;
    }
}

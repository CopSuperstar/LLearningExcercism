class RemoteControlCar
{
    public  int _speed = 5;
    public int _batteryDrain = 2;
    public int _driven;
    public int _capacity;
    public RemoteControlCar(int speed, int batteryDrain)
    {
        _speed = speed;
        _batteryDrain = batteryDrain;
        _capacity = 100;
    }
    public bool BatteryDrained() =>_capacity < _batteryDrain;
    public int DistanceDriven() => _driven;
    public void Drive()
    {
        if (_capacity >=_batteryDrain)
        _driven += _speed;
        _capacity -= _batteryDrain;
    }
    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}class RaceTrack
{int _distance;
    public RaceTrack(int distance)
    {
        _distance =distance;
    }
    public bool TryFinishTrack(RemoteControlCar car) =>((100 / car._batteryDrain) * car._speed) >= _distance;
}

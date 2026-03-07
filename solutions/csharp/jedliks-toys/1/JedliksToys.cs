class RemoteControlCar
{
private int distance = 0;
private int perc = 100;

    public static RemoteControlCar Buy()
    {
        var car = new RemoteControlCar();
        return car;
    }

    public string DistanceDisplay()
    {
        return $"Driven {distance} meters";
       
    }
    
    public string BatteryDisplay()
    {
        perc = Math.Clamp(perc, 0, 100);
        string res = perc == 0? "Battery empty": $"Battery at {perc}%";
       return res;
    }

    public void Drive()
    {
        if(perc > 0)
        {
             distance += 20;
        perc -= 1;
        }
       else {Console.WriteLine("Battery empty");}
    }
}

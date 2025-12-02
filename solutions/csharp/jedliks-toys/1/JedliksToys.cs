public class RemoteControlCar
{
    private int _battery = 100;
    private int _distance = 0;

    // Task 1
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    // Task 2
    public string DistanceDisplay()
    {
        return $"Driven {_distance} meters";
    }

    // Task 3
    public string BatteryDisplay()
    {
        if (_battery == 0)
        {
            return "Battery empty";
        }

        return $"Battery at {_battery}%";
    }

    // Task 4–6
    public void Drive()
    {
        // Don't drive if battery is empty
        if (_battery == 0)
        {
            return;
        }

        _distance += 20;
        _battery -= 1;
    }
}

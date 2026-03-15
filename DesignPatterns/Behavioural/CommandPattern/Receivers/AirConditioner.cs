namespace DesignPatterns.Behavioural.CommandPattern.Receivers;

public class AirConditioner
{
    public int temperature = 22;
    public void On()
    {
        Console.WriteLine("AC On..");
    }

    public void Off()
    {
        Console.WriteLine("AC Off");
    }

    public void SetTemperature(int temp)
    {
        temperature = temp;
        Console.WriteLine($"Current Temperature: {temp}");
    } 
}

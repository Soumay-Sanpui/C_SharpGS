namespace DesignPatterns.Behavioural.CommandPattern;

public class GarageDoor
{
    public void Up() => Console.WriteLine("Garage Door Up..");
    public void Down() => Console.WriteLine("Garage Door Down..");
    public void Stop() => Console.WriteLine("Garage Door Stop..");
    public void LightOn() => Console.WriteLine("Garage Light On..");
    public void LightOff() => Console.WriteLine("Garage Light Off..");
}

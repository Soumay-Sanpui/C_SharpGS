namespace DesignPatterns.Behavioural.CommandPattern.Receivers;

public class Light
{
    public void On() => Console.WriteLine("Lights ON.");
    
    public void Off() => Console.WriteLine("Lights Off.");
}

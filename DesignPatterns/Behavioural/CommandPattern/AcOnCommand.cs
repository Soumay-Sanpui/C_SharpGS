using DesignPatterns.Behavioural.CommandPattern.Receivers;

namespace DesignPatterns.Behavioural.CommandPattern;

public class AcOnCommand(AirConditioner ac): ICommand
{
    readonly AirConditioner airConditioner = ac;
    public void Execute()
    {
        airConditioner.On();
        Console.WriteLine($"AC Temperature: {airConditioner.temperature}");
    }

    public void Undo()
    {
        airConditioner.Off();
        Console.WriteLine("Air Conditioner is Off.");
    }
}

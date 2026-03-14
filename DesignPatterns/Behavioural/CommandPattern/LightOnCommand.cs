using DesignPatterns.Behavioural.CommandPattern.Receivers;

namespace DesignPatterns.Behavioural.CommandPattern;

public class LightOnCommand(Light lht) : ICommand
{
    private readonly Light light = lht;

    public void Execute()
    {
        light.On();
    }
}

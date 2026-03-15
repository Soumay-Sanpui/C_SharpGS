using DesignPatterns.Behavioural.CommandPattern.Receivers;

namespace DesignPatterns.Behavioural.CommandPattern;

public class LightOffCommand(Light light): ICommand
{
    readonly Light lgt = light;

    public void Execute()
    {
        lgt.Off();
    }

    public void Undo()
    {
        lgt.On();
    }
}

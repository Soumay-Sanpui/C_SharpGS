using DesignPatterns.Behavioural.CommandPattern.Receivers;

namespace DesignPatterns.Behavioural.CommandPattern;

public class Pattern
{
    public static void RunCommandExample()
    {
        SimpleRemoteControl simpleRemoteControl = new();
        Light light = new();

        LightOnCommand lightOnCommand = new(light);

        simpleRemoteControl.SetCommand(lightOnCommand);
        simpleRemoteControl.ButtonPressed();
    }
}

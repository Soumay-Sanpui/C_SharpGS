namespace DesignPatterns.Behavioural.CommandPattern;

public class SimpleRemoteControl
{
    ICommand slot;

    public void SetCommand(ICommand command)
    {
        slot = command;
    }

    public void ButtonPressed()
    {
        slot.Execute();
    }
}

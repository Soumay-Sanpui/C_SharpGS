namespace DesignPatterns.Behavioural.CommandPattern.Receivers;

public class SimpleRemoteControl
{
    ICommand[]? OnCommands;
    ICommand[]? OffCommands;

    ICommand? lastCommand;

    public SimpleRemoteControl()
    {
        OnCommands = new ICommand[7];
        OffCommands = new ICommand[7];

        ICommand noCommand = new NoCommand();
        for(int i = 0; i < 7; i++)
        {
            OnCommands[i] = noCommand;
            OffCommands[i] = noCommand;
        }
        lastCommand = noCommand;
    }

    public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
    {
        OnCommands?[slot -1] = onCommand;
        OffCommands?[slot -1] = offCommand;
    }

    public void OnButtonPressed(int slot)
    {
        OnCommands?[slot -1].Execute();
        lastCommand = OnCommands?[slot - 1];
    }

    public void OffButtonPressed(int slot)
    {
        OffCommands?[slot - 1].Execute();
        lastCommand = OffCommands?[slot - 1];
    }

    public void UndoButtonPressed()
    {
        lastCommand?.Undo();
    }
}

namespace DesignPatterns.Behavioural.CommandPattern;

public class NoCommand : ICommand
{
    public void Execute()
    {
        throw new Exception("No Command is assigned to this button yet.");
    }

    public void Undo()
    {
        throw new Exception("Calling Undo without any command.");
    }
}

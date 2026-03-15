using System;

namespace DesignPatterns.Behavioural.CommandPattern;

public class GarageDoorOpenCommand(GarageDoor garageDoor) : ICommand
{
    GarageDoor gd = garageDoor;


    public void Execute()
    {
        gd.Up();
    }

    public void Undo()
    {
        gd.Down();
    }
}

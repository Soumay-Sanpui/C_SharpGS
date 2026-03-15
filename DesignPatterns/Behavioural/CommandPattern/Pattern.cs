using DesignPatterns.Behavioural.CommandPattern.Receivers;

namespace DesignPatterns.Behavioural.CommandPattern;

public class Pattern
{
    public static void RunCommandExample()
    {
        // Invoker
        SimpleRemoteControl simpleRemoteControl = new();

        // Receivers
        Light livingRoomLight = new();
        Light kitchenLight = new();

        GarageDoor garageDoor1 = new();
        GarageDoor garageDoor2 = new();

        Stereo stereo1 = new();
        Stereo stereo2 = new();

        AirConditioner airConditioner = new();

        // Commands
        LightOnCommand lightOnCommandLivingRoom = new(livingRoomLight);
        LightOnCommand lightOnCommandKitchen = new(kitchenLight);

        GarageDoorOpenCommand garageDoorOpen1 = new(garageDoor1);
        GarageDoorOpenCommand garageDoorOpen2 = new(garageDoor2);

        StereoOnWithCDCommand stereoOnWithCDCommand1 = new(stereo1);
        StereoOnWithCDCommand stereoOnWithCDCommand2 = new(stereo2);

        AcOnCommand acOnCommand = new(airConditioner);

        // setting remote
        simpleRemoteControl.SetCommand(1, lightOnCommandKitchen, lightOnCommandKitchen);
        simpleRemoteControl.SetCommand(2, lightOnCommandLivingRoom, lightOnCommandLivingRoom);

        simpleRemoteControl.SetCommand(3, garageDoorOpen1, garageDoorOpen1);
        simpleRemoteControl.SetCommand(4, garageDoorOpen2, garageDoorOpen2);

        simpleRemoteControl.SetCommand(5, stereoOnWithCDCommand1, stereoOnWithCDCommand1);
        simpleRemoteControl.SetCommand(6, stereoOnWithCDCommand2, stereoOnWithCDCommand2);

        simpleRemoteControl.SetCommand(7, acOnCommand, acOnCommand);

        // call
        simpleRemoteControl.OnButtonPressed(1);
        simpleRemoteControl.OnButtonPressed(4);
        simpleRemoteControl.OnButtonPressed(7);

        // undo
        simpleRemoteControl.UndoButtonPressed();
    }
}

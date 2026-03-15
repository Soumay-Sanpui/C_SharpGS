using DesignPatterns.Behavioural.CommandPattern.Receivers;

namespace DesignPatterns.Behavioural.CommandPattern;

public class StereoOnWithCDCommand(Stereo st): ICommand
{
    readonly Stereo stereo = st;

    public void Execute()
    {
        stereo.On();
        stereo.SetCD();
        stereo.SetVolume(30);
    }

    public void Undo()
    {
        stereo.Off();
    }
}

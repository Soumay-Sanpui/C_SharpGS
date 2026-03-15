namespace DesignPatterns.Behavioural.CommandPattern.Receivers;

public class Stereo
{
    public int volume = 0;
    public void On()
    {
        Console.WriteLine("Stereo ON..");
    }
    public void Off()
    {
        Console.WriteLine("Stereo Off..");
    }

    public void SetCD()
    {
        Console.WriteLine("CD Setted...");
    }
    public void SetRadio()
    {
        Console.WriteLine("Radio Setted...");
    }
    public void SetVolume(int val)
    {
        this.volume = val;
        Console.WriteLine($"Volume Setted to {val}");
    }
}

namespace DesignPatterns.Behavioural.ObserverPattern;

class Pattern
{
    /// <summary>
    /// Intent: Notify multiple objects automatically when one object changes.
    /// </summary>
    public static void RunObservableExample()
    {
        var ws = new WeatherStation();
        var wd = new WeatherDisplay();

        ws.Add(wd);

        ws.SetMeasurements(25.3f, 65.0f);
        ws.SetMeasurements(22.8f, 70.2f);

        // optional: display current values on demand
        wd.DisplayData();
    }
}

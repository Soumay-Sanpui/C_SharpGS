namespace DesignPatterns.Behavioural.ObserverPattern;

public class WeatherDisplay : IObserver
{
    private float _temperature;
    private float _humidity;

    public void Update(IObservable observable)
    {
        if (observable is WeatherStation ws)
        {
            Console.WriteLine("Something changed.....");
            _temperature = ws.Temperature;
            _humidity = ws.Humidity;
            DisplayData();
        }
    }

    public void DisplayData()
    {
        Console.WriteLine($"Temperature: {_temperature:F1}°C, Humidity: {_humidity:F1}%");
    }
}


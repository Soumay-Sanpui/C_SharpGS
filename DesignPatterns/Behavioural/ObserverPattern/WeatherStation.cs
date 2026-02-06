using System;
using System.Collections.Generic;

namespace DesignPatterns.Behavioural.ObserverPattern;

public class WeatherStation : IObservable
{
    private readonly List<IObserver> _observers = new();
    public float Temperature { get; private set; } = 20.0f;
    public float Humidity { get; private set; } = 50.0f;

    /*
     * check during Add not during remove. 
    */
    public void Add(IObserver observer)
    {
        if (!_observers.Contains(observer))
            _observers.Add(observer);
    }

    public void Remove(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in _observers.ToArray())
        {
            observer.Update(this);
        }
    }

    public void SetMeasurements(float temperature, float humidity)
    {
        Temperature = temperature;
        Humidity = humidity;
        Notify();
    }

    public void UpdateSensorValues()
    {
        var rnd = new Random();
        SetMeasurements((float)(15 + rnd.NextDouble() * 20), (float)(30 + rnd.NextDouble() * 50));
    }
}

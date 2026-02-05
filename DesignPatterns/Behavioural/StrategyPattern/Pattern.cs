using DesignPatterns.Behavioural.StrategyPattern.ShippingStrategies;

namespace DesignPatterns.Behavioural.StrategyPattern;

public class Pattern
{
    public static void RunExample()
    {
        Console.WriteLine("-----Strategy Pattern-----");
        var order = new Order()
        {
            WeightKg = 5m,
            DistanceKm = 120m,
            Value = 250m
        };

        var calculator = new ShippingCalculator(new FlatRateShipping(10m));
        Console.WriteLine($"Flat rate: {calculator.Calculate(order):c}");

        calculator.SetStrategy(new WeightBasedShipping(2.5m));
        Console.WriteLine($"Weight based: {calculator.Calculate(order):c}");

        calculator.SetStrategy(new ExpressShipping(15m, 0.2m));
        Console.WriteLine($"Express {calculator.Calculate(order):c}");
        Console.WriteLine("=================================================");
    }
}
using DesignPattern.StrategyPattern.ShippingStrategies;

namespace DesignPattern.StrategyPattern;

public class Sp
{
    public static void RunExample()
    {
        System.Console.WriteLine("-----Strategy Pattern-----");
        var order = new Order()
        {
            WeightKg = 5m,
            DistanceKm = 120m,
            Value = 250m
        };

        var calculator = new ShippingCalculator(new FlatRateShipping(10m));
        System.Console.WriteLine($"Flat rate: {calculator.Calculate(order):c}");

        calculator.SetStrategy(new WeightBasedShipping(2.5m));
        System.Console.WriteLine($"Weight based: {calculator.Calculate(order):c}");

        calculator.SetStrategy(new ExpressShipping(15m, 0.2m));
        System.Console.WriteLine($"Express {calculator.Calculate(order):c}");
        System.Console.WriteLine("=================================================");
    }
}
namespace DesignPatterns.Behavioural.StrategyPattern.ShippingStrategies;

public interface IShippingStrategy
{
    decimal CalculateCost(Order order);
}
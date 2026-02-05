namespace DesignPattern.StrategyPattern.ShippingStrategies;

public interface IShippingStrategy
{
    decimal CalculateCost(Order order);
}
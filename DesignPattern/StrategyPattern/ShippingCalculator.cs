using DesignPattern.StrategyPattern.ShippingStrategies;

namespace DesignPattern.StrategyPattern;

public class ShippingCalculator
{
    private IShippingStrategy _strategy;
    public ShippingCalculator(IShippingStrategy strategy) => _strategy = strategy;
    public void SetStrategy(IShippingStrategy strategy) => _strategy = strategy;
    public decimal Calculate(Order order) => _strategy.CalculateCost(order);
}

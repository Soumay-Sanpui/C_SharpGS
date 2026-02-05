namespace DesignPatterns.Behavioural.StrategyPattern.ShippingStrategies;

public class FlatRateShipping : IShippingStrategy
{
    private readonly decimal _rate;
    public FlatRateShipping(decimal rate) => _rate = rate;
    public decimal CalculateCost(Order order) => _rate;
}
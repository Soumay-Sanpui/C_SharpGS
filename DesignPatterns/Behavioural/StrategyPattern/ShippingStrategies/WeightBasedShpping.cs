namespace DesignPatterns.Behavioural.StrategyPattern.ShippingStrategies;

public class WeightBasedShipping : IShippingStrategy
{
    private readonly decimal _perKg;
    public WeightBasedShipping(decimal perKg) => _perKg = perKg;
    public decimal CalculateCost(Order order) => order.WeightKg * _perKg;
}
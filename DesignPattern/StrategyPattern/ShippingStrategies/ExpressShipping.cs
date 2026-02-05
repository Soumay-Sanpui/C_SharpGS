namespace DesignPattern.StrategyPattern.ShippingStrategies;

public class ExpressShipping : IShippingStrategy
{
    private readonly decimal _base;
    private readonly decimal _perKm;
    public ExpressShipping(decimal @base, decimal perKm) { _base = @base; _perKm = perKm; }
    public decimal CalculateCost(Order order) => _base + (order.DistanceKm * _perKm );

}

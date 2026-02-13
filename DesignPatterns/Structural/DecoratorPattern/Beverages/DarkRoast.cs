namespace DesignPatterns.Structural.DecoratorPattern.Beverages;

public class DarkRoast : Beverage
{
    override public decimal Cost()
    {
        return 10.1m;
    }
}

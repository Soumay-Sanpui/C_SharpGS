namespace DesignPatterns.Structural.DecoratorPattern.Beverages;

public class Decaf : Beverage
{
    override public decimal Cost()
    {
        return 11.1m;
    }
}
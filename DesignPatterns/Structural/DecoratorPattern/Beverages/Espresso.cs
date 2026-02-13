namespace DesignPatterns.Structural.DecoratorPattern.Beverages;

public class Espresso : Beverage
{
    public override string Description => "Espresso";
    override public decimal Cost()
    {
        return 13.1m;
    }
}
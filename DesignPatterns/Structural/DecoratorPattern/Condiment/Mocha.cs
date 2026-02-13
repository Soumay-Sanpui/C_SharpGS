namespace DesignPatterns.Structural.DecoratorPattern.Condiment;
using Beverages;

public class Mocha(Beverage beverage) : CondimentDecorator(beverage)
{
    public override string Description => base.Description + "Mocha";

	public override decimal Cost()
	{
		return beverage.Cost() + 0.20m;
	}
}

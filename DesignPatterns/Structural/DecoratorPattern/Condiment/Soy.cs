using System;

namespace DesignPatterns.Structural.DecoratorPattern.Condiment;

public class Soy : CondimentDecorator
{
	public Soy(DesignPatterns.Structural.DecoratorPattern.Beverages.Beverage beverage) : base(beverage)
	{
	}

	public override string Description => beverage.Description + ", Soy";

	public override decimal Cost()
	{
		return beverage.Cost() + 0.15m;
	}
}

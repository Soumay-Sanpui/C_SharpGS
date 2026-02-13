using System;

namespace DesignPatterns.Structural.DecoratorPattern.Condiment;

public class Milk : CondimentDecorator
{
	public Milk(DesignPatterns.Structural.DecoratorPattern.Beverages.Beverage beverage) : base(beverage)
	{
	}

	public override string Description => beverage.Description + ", Milk";

	public override decimal Cost()
	{
		return beverage.Cost() + 0.10m;
	}
}

using System;

namespace DesignPatterns.Structural.DecoratorPattern.Condiment;

public class Whip : CondimentDecorator
{
	public Whip(DesignPatterns.Structural.DecoratorPattern.Beverages.Beverage beverage) : base(beverage)
	{
	}

	public override string Description => beverage.Description + ", Whip";

	public override decimal Cost()
	{
		return beverage.Cost() + 0.10m;
	}
}

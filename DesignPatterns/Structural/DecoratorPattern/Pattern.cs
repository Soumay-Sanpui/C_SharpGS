using DesignPatterns.Structural.DecoratorPattern.Beverages;
using DesignPatterns.Structural.DecoratorPattern.Condiment;

namespace DesignPatterns.Structural.DecoratorPattern;

/// <summary>
/// The Decorator Pattern attaches additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.
/// </summary>
public class Pattern
{
    public static void RunExample()
    {
        Beverage espresso = new Espresso();
        espresso = new Mocha(espresso);
        espresso = new Whip(espresso);

        Console.WriteLine(espresso.Description);
        Console.WriteLine(espresso.Cost());

    }
}

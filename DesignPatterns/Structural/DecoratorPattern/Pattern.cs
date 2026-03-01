using DesignPatterns.Structural.DecoratorPattern.Beverages;
using DesignPatterns.Structural.DecoratorPattern.Condiment;

namespace DesignPatterns.Structural.DecoratorPattern;

/// <summary>
/// The Decorator Pattern attaches additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.
/// it's a combination of DELEGATION + COMPOSITION. (it BEHAVES as a reccursive call chain)
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

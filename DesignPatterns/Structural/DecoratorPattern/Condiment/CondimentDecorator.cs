namespace DesignPatterns.Structural.DecoratorPattern.Condiment;
using DesignPatterns.Structural.DecoratorPattern.Beverages;

/// <summary>
/// Base class for condiment decorators that wrap a <see cref="Beverage"/>.
/// Decorators extend the behaviour of a beverage by adding additional
/// responsibilities such as extra cost or a modified description.
/// </summary>
public abstract class CondimentDecorator : Beverage
{
    /// <summary>
    /// The wrapped beverage instance.
    /// </summary>
    protected Beverage beverage;

    /// <summary>
    /// Initializes a new instance of <see cref="CondimentDecorator"/> that
    /// wraps the specified <paramref name="beverage"/>.
    /// </summary>
    /// <param name="beverage">The beverage to decorate.</param>
    protected CondimentDecorator(Beverage beverage)
    {
        this.beverage = beverage;
    }

    /// <summary>
    /// Gets the description from the wrapped beverage. Concrete decorators
    /// typically append their own label to this description.
    /// </summary>
    public override string Description => beverage.Description;

    /// <summary>
    /// Returns the cost of the wrapped beverage plus the condiment's cost.
    /// Concrete decorators must implement this to add their surcharge.
    /// </summary>
    public override abstract decimal Cost();
}
